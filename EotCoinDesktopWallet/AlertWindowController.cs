using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class AlertWindowController : NSWindowController
    {
        public AlertWindowController(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public AlertWindowController(NSCoder coder) : base(coder)
        {
        }

        public AlertWindowController() : base("AlertWindow")
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            AlertImage.Image = NSImage.ImageNamed("alert.png");
        }

        public new AlertWindow Window
        {
            get { return (AlertWindow)base.Window; }
        }
    }
}
