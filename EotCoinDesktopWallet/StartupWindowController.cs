using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class StartupWindowController : NSWindowController
    {
        GenerateNewWalletController generateWalletController;
        ImportPrivateKeyController importPrivateKeyController;

        public StartupWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public StartupWindowController(NSCoder coder) : base(coder)
        {
        }

        public StartupWindowController() : base("StartupWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            EOTLogo.Image = NSImage.ImageNamed("EOT-3.png");
        }
        partial void GenerateNewWalletButtonClick(Foundation.NSObject sender)
        {
            generateWalletController = new GenerateNewWalletController();
            generateWalletController.Window.MakeKeyAndOrderFront(this);
            this.Close();

        }

        partial void ImportWalletFromSeedButtonClick(Foundation.NSObject sender)
        {
            importPrivateKeyController = new ImportPrivateKeyController();
            importPrivateKeyController.Window.MakeKeyAndOrderFront(this);
            this.Close();
        }

        public new StartupWindow Window
        {
            get { return (StartupWindow)base.Window; }
        }
    }
}
