using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class StartupWindow : NSWindow
    {
        public StartupWindow(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public StartupWindow(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
