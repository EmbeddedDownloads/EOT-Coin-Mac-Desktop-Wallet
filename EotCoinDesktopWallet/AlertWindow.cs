using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class AlertWindow : NSWindow
    {
        public AlertWindow(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public AlertWindow(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
