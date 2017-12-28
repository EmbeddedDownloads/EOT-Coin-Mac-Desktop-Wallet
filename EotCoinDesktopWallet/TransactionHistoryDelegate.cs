using System;
using AppKit;
using CoreGraphics;
using Foundation;
using System.Collections;
using System.Collections.Generic;

namespace EotCoinDesktopWallet
{
    public class TransactionHistoryDelegate : NSTableViewDelegate
    {
        #region Constants 
        private const string CellIdentifier = "ProdCell";
        #endregion

        #region Private Variables
        private TransactionHistoryDataSource DataSource;
        #endregion

        #region Constructors
        public TransactionHistoryDelegate(TransactionHistoryDataSource datasource)
        {
            this.DataSource = datasource;
        }
        #endregion

        #region Override Methods
        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            // This pattern allows you reuse existing views when they are no-longer in use.
            // If the returned view is null, you instance up a new view
            // If a non-null view is returned, you modify it enough to reflect the new data
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            // Setup view based on the column selected
            switch (tableColumn.Title)
            {
                case "Date":
                    view.StringValue = DataSource.Transactions[(int)row].Date;
                    break;
                case "Amount":
                    view.StringValue = DataSource.Transactions[(int)row].Amount;
                    break;
                case "Status":
                    view.StringValue = DataSource.Transactions[(int)row].Status;
                    break;
                case "Sent/Received":
                    view.StringValue = DataSource.Transactions[(int)row].SentReceived;
                    break;
                case "Address":
                    view.StringValue = DataSource.Transactions[(int)row].Address;
                    break;
                case "TransactionID":
                    view.StringValue = DataSource.Transactions[(int)row].TransactionID;
                    break;
            }

            return view;
        }
        #endregion
    }
}
