using System;
using System.Collections.Generic;
using Foundation;
using AppKit;

namespace EotCoinDesktopWallet
{
    public partial class ImportPrivateKey : NSWindow
    {
        public ImportPrivateKey(IntPtr handle) : base(handle)
        {
        }

        [Export("initWithCoder:")]
        public ImportPrivateKey(NSCoder coder) : base(coder)
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }
    }
}
