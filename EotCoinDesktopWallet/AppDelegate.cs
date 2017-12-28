using AppKit;
using Foundation;
using System.IO;
using System.Security.AccessControl;

namespace EotCoinDesktopWallet
{
    [Register("AppDelegate")]
    public class AppDelegate : NSApplicationDelegate
    {
       // MainWindowController mainWindowController;
        LoginWindowController loginWindowController;
        StartupWindowController startupWindowController;

        public AppDelegate()
        {
        }

        public override void DidFinishLaunching(NSNotification notification)
        {

            string filename = "wallet.eot";
          //  Console.WriteLine(filename);


            string path = "/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/" + filename;

            if (!Directory.Exists("/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/"))
            {
                // Directory.SetAccessControl("~/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/", directorySecurity:);
                Directory.CreateDirectory("/Users/Shared/Library/Application Support/com.eotwallet.Eot-Coin-Wallet/");
            }

            if (File.Exists(path)) //if set up already 
            {
                loginWindowController = new LoginWindowController();
                loginWindowController.Window.MakeKeyAndOrderFront(this);
            }
            else
            {
                // generateWalletController = new GenerateNewWalletController();
                // generateWalletController.Window.MakeKeyAndOrderFront(this);
                startupWindowController = new StartupWindowController();
                startupWindowController.Window.MakeKeyAndOrderFront(this);
            }

            //mainWindowController = new MainWindowController();
            //mainWindowController.Window.MakeKeyAndOrderFront(this);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
