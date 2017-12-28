// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace EotCoinDesktopWallet
{
    [Register ("StartupWindowController")]
    partial class StartupWindowController
    {
        [Outlet]
        AppKit.NSImageView EOTLogo { get; set; }

        [Action ("GenerateNewWalletButtonClick:")]
        partial void GenerateNewWalletButtonClick (Foundation.NSObject sender);

        [Action ("ImportWalletFromSeedButtonClick:")]
        partial void ImportWalletFromSeedButtonClick (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (EOTLogo != null) {
                EOTLogo.Dispose ();
                EOTLogo = null;
            }
        }
    }
}
