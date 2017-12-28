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
    [Register ("GenerateNewWalletController")]
    partial class GenerateNewWalletController
    {
        [Outlet]
        AppKit.NSTextField CharactersLeft { get; set; }

        [Outlet]
        AppKit.NSImageCell LogoImage { get; set; }

        [Outlet]
        AppKit.NSSecureTextField PasswordField { get; set; }

        [Outlet]
        AppKit.NSTextField RandomCharsField { get; set; }

        [Outlet]
        AppKit.NSSecureTextField RepeatPasswordField { get; set; }

        [Action ("CharacterTyped:")]
        partial void CharacterTyped (AppKit.NSTextField sender);

        [Action ("GenerateWalletClick:")]
        partial void GenerateWalletClick (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (CharactersLeft != null) {
                CharactersLeft.Dispose ();
                CharactersLeft = null;
            }

            if (LogoImage != null) {
                LogoImage.Dispose ();
                LogoImage = null;
            }

            if (PasswordField != null) {
                PasswordField.Dispose ();
                PasswordField = null;
            }

            if (RandomCharsField != null) {
                RandomCharsField.Dispose ();
                RandomCharsField = null;
            }

            if (RepeatPasswordField != null) {
                RepeatPasswordField.Dispose ();
                RepeatPasswordField = null;
            }
        }
    }
}
