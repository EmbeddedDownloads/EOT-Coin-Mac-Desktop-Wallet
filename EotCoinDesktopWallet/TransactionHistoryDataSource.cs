using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace EotCoinDesktopWallet
{
    public class TransactionHistoryDataSource : NSTableViewDataSource
    {
        #region Public Variables
        public List<TransactionHistory> Transactions = new List<TransactionHistory>();
        #endregion

        #region Constructors
        public TransactionHistoryDataSource()
        {
        }
        #endregion

        #region Override Methods
        public override nint GetRowCount(NSTableView tableView)
        {
            return Transactions.Count;
        }
        #endregion
    }
}
