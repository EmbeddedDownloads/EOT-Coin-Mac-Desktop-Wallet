using System;
using System.Collections.Generic;
using Foundation;
using AppKit;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EotCoinDesktopWallet
{
    public partial class GenerateNewWalletController : NSWindowController
    {

        MainWindowController mainWindowController;

        public GenerateNewWalletController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public GenerateNewWalletController(NSCoder coder) : base(coder)
        {
        }

        public GenerateNewWalletController() : base("GenerateNewWallet")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            LogoImage.Image = NSImage.ImageNamed("EOT-3.png");
            RandomCharsField.Changed += (sender, e) => {
                int numberofchars = 120 - RandomCharsField.StringValue.Count(); 
                CharactersLeft.StringValue = numberofchars.ToString();
           };
           // RandomCharsField.Changed += (sender, e)
            //NumberField.EditingEnded += (sender, e) => {
            //    FeedbackLabel.StringValue = string.Format("Number: {0}", NumberField.IntValue);
            //};
        }


        partial void GenerateWalletClick(Foundation.NSObject sender)
        {

            if (RandomCharsField.StringValue.Length < 120)
            {
                var alert = new NSAlert()
                {
                    AlertStyle = NSAlertStyle.Informational,
                    InformativeText = "Please ensure that you have typed 120 random characters!",
                    MessageText = "EOT Coin Wallet",
                };
                alert.RunModal();
            }
            else
            {

                string Password = PasswordField.StringValue;
                string RepeatPassword = RepeatPasswordField.StringValue;
                if (Password == "")
                {
                    var alert = new NSAlert()
                    {
                        AlertStyle = NSAlertStyle.Informational,
                        InformativeText = "Password Field is empty! Please enter a password!",
                        MessageText = "EOT Coin Wallet",
                    };
                    alert.RunModal();
                }
                else if (Password == RepeatPassword)
                {
                    string inputString = RandomCharsField.StringValue;

                    Random rnd = new Random();
                    string seed = Utilities.generateSeed(inputString, rnd);

                    List<string> keyPair = Utilities.getKeyPair(seed);
                    string eotPrivateKey = keyPair.ElementAt(0);
                    string eotAddress = keyPair.ElementAt(1);

                    Wallet eotWallet = new Wallet(eotPrivateKey, eotAddress, seed);
                    Utilities.FileEncrypt(seed, Password);
                    Utilities.printWalletToFile(eotWallet);

                    mainWindowController = new MainWindowController();
                    mainWindowController.Window.MakeKeyAndOrderFront(this);
                    this.Close();
                }
                else
                {
                    var alert = new NSAlert()
                    {
                        AlertStyle = NSAlertStyle.Informational,
                        InformativeText = "Passwords Do not Match! Please ensure that your passwords match!",
                        MessageText = "EOT Coin Wallet",
                    };
                    alert.RunModal();
                }

            }

           // WalletLabel.StringValue = eotWallet.eotAddress;
            //ClickedLabel.StringValue = Utilities.FileDecrypt("wallet.eot", Password);
            //EOTCoinWalletDashboard dashboardform = new EOTCoinWalletDashboard();
            //dashboardform.Show();
            //  this.Hide();
            //}

        }



        public new GenerateNewWallet Window
        {
            get { return (GenerateNewWallet)base.Window; }
        }
    }
}
