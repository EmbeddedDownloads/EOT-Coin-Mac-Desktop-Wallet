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
    [Register ("ImportPrivateKeyController")]
    partial class ImportPrivateKeyController
    {
        [Outlet]
        AppKit.NSImageView EOTLogoPrivateKey { get; set; }

        [Outlet]
        AppKit.NSSecureTextField ImportPassword { get; set; }

        [Outlet]
        AppKit.NSTextField PrivateKeyTextBox { get; set; }

        [Outlet]
        AppKit.NSTextField PublicKeyImport { get; set; }

        [Action ("ImportPrivateKeyButtonClick:")]
        partial void ImportPrivateKeyButtonClick (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (PrivateKeyTextBox != null) {
                PrivateKeyTextBox.Dispose ();
                PrivateKeyTextBox = null;
            }

            if (EOTLogoPrivateKey != null) {
                EOTLogoPrivateKey.Dispose ();
                EOTLogoPrivateKey = null;
            }

            if (PublicKeyImport != null) {
                PublicKeyImport.Dispose ();
                PublicKeyImport = null;
            }

            if (ImportPassword != null) {
                ImportPassword.Dispose ();
                ImportPassword = null;
            }
        }
    }
}
