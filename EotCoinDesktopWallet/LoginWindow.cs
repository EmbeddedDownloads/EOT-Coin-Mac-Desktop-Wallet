using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class LoginWindow : NSWindow
    {
        public LoginWindow(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public LoginWindow(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
