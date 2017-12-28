using System;

using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class GenerateNewWallet : NSWindow
    {
        public GenerateNewWallet(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public GenerateNewWallet(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
