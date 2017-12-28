using System;
namespace EotCoinDesktopWallet
{
    public class TransactionHistory
    {
        #region Computed Propoperties
        public string Date { get; set; } = "";
        public string Amount { get; set; } = "";
        public string Status { get; set; } = "";
        public string SentReceived { get; set; } = "";
        public string Address { get; set; } = "";
        public string TransactionID { get; set; } = "";
        #endregion

        #region Constructors
        public TransactionHistory()
        {
        }

        public TransactionHistory(string date, string amount, string status, string sentreceived, string address, string transactionid)
        {
            this.Date = date;
            this.Amount = amount;
            this.Status = status;
            this.SentReceived = sentreceived;
            this.Address = address;
            this.TransactionID = transactionid;
        }
        #endregion
    }

}
