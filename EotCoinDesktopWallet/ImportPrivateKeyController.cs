using System;
using System.Collections.Generic;
using NBitcoin;
using Foundation;
using AppKit;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EotCoinDesktopWallet
{
    public partial class ImportPrivateKeyController : NSWindowController
    {
        MainWindowController mainWindowController;

        public ImportPrivateKeyController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public ImportPrivateKeyController(NSCoder coder) : base(coder)
        {
        }

        public ImportPrivateKeyController() : base("ImportPrivateKey")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            EOTLogoPrivateKey.Image = NSImage.ImageNamed("EOT-3.png");
        }

        partial void ImportPrivateKeyButtonClick(Foundation.NSObject sender)
        {

            if (PrivateKeyTextBox.StringValue != " " && PrivateKeyTextBox.StringValue != "" && PrivateKeyTextBox.StringValue != null)
            {
                if (ImportPassword.StringValue != " " && ImportPassword.StringValue != "" && ImportPassword.StringValue != null)
                {
                    import();
                }
                else
                {
                    var alert = new NSAlert()
                    {
                        AlertStyle = NSAlertStyle.Informational,
                        InformativeText = "Please enter a password",
                        MessageText = "EOT Coin Wallet",
                    };
                    alert.RunModal();

                  //  System.Windows.Forms.MessageBox.Show("Please enter a password");
                }
            }
            else
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Please enter your wallet seed",
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();
                //System.Windows.Forms.MessageBox.Show("Please enter your wallet seed");
            }

        }


        public void import()
        {
            try
            {
                string seed = PrivateKeyTextBox.StringValue;
                string password = ImportPassword.StringValue;

                List<string> keyPair = Utilities.getKeyPair(seed);
                string eotPrivateKey = keyPair.ElementAt(0);
                string eotAddress = keyPair.ElementAt(1);
                Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
                string file1 = @"wallet.eot";
                string file2 = @"Address.txt";

                if (File.Exists(file1) && File.Exists(file2))
                {
                    File.Delete(file1);
                    File.Delete(file2);
                }

                Utilities.FileEncrypt(seed, password);
                Utilities.printWalletToFile(eotWallet);

                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Wallet imported successfully!",
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();

                mainWindowController = new MainWindowController();
                mainWindowController.Window.MakeKeyAndOrderFront(this);
                this.Close();
            }
            catch (Exception ex)
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Import failed: " + ex.Message,
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();

               // System.Windows.Forms.MessageBox.Show("Import failed: " + ex.Message);
            }
        }
        public new ImportPrivateKey Window
        {
            get { return (ImportPrivateKey)base.Window; }
        }
    }
}
