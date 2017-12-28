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
	[Register ("AlertWindowController")]
	partial class AlertWindowController
	{
		[Outlet]
		AppKit.NSImageView AlertImage { get; set; }

		[Outlet]
		AppKit.NSTextField AlertLabel { get; set; }

		[Outlet]
		AppKit.NSButton CloseButtonClick { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (CloseButtonClick != null) {
				CloseButtonClick.Dispose ();
				CloseButtonClick = null;
			}

			if (AlertLabel != null) {
				AlertLabel.Dispose ();
				AlertLabel = null;
			}

			if (AlertImage != null) {
				AlertImage.Dispose ();
				AlertImage = null;
			}
		}
	}
}
