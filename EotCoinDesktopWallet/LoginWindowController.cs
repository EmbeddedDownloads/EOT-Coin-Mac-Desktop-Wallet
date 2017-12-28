using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class LoginWindowController : NSWindowController
    {

        MainWindowController mainWindowController;

        public LoginWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public LoginWindowController(NSCoder coder) : base(coder)
        {
        }

        public LoginWindowController() : base("LoginWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            LogoImage.Image = NSImage.ImageNamed("EOT-3.png");
        }

        partial void LoginButtonClick(Foundation.NSObject sender)
        {

            try
            {
                string password = PasswordTextField.StringValue;

                string seed = Utilities.FileDecrypt("/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/wallet.eot", password);
                string txtAddress = "";
                string filename = "Address.txt";
                string path = "/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/" + filename;
                if (File.Exists(path))
                {
                    txtAddress = File.ReadLines(path).First();
                }
                else
                {
                   // System.Windows.Forms.MessageBox.Show("Address.txt does not exist!");
                }

                //generate address using seed
                List<string> keyPair = Utilities.getKeyPair(seed);
                string eotPrivateKey = keyPair.ElementAt(0);
                string eotAddress = keyPair.ElementAt(1);
                Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);

                //if address matches address.txt, go to dashboard
                if (txtAddress == eotWallet.eotAddress)
                {
                    mainWindowController = new MainWindowController();
                    mainWindowController.Window.MakeKeyAndOrderFront(this);
                    this.Close();
                   // EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
                   // dashboardform.Show();
                   // this.Hide();
                }
                else
                {
                    //System.Windows.Forms.MessageBox.Show("Incorrect password, please try again!");
                    PasswordIncorrect.Hidden = false;
                }
            }
            catch (Exception ex)
            {
                //System.Windows.Forms.MessageBox.Show("Login failed: " + ex.Message);
            }

        }

        public new LoginWindow Window
        {
            get { return (LoginWindow)base.Window; }
        }
    }
}