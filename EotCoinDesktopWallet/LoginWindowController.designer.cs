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
    [Register ("LoginWindowController")]
    partial class LoginWindowController
    {
        [Outlet]
        AppKit.NSImageView LogoImage { get; set; }

        [Outlet]
        AppKit.NSTextField PasswordIncorrect { get; set; }

        [Outlet]
        AppKit.NSSecureTextField PasswordTextField { get; set; }

        [Action ("LoginButtonClick:")]
        partial void LoginButtonClick (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (PasswordTextField != null) {
                PasswordTextField.Dispose ();
                PasswordTextField = null;
            }

            if (LogoImage != null) {
                LogoImage.Dispose ();
                LogoImage = null;
            }

            if (PasswordIncorrect != null) {
                PasswordIncorrect.Dispose ();
                PasswordIncorrect = null;
            }
        }
    }
}
