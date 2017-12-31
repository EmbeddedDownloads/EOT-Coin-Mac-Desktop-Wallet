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
    [Register ("MainWindowController")]
    partial class MainWindowController
    {
        [Outlet]
        AppKit.NSTableColumn AdditionalInfoColumn { get; set; }

        [Outlet]
        AppKit.NSTableColumn AmountColumn { get; set; }

        [Outlet]
        AppKit.NSTextField AmountDollar { get; set; }

        [Outlet]
        AppKit.NSTextField BalanceNumberLabel { get; set; }

        [Outlet]
        AppKit.NSButton CryptoDocDecryptButton { get; set; }

        [Outlet]
        AppKit.NSButton CryptoDocEncryptButton { get; set; }

        [Outlet]
        AppKit.NSSecureTextField CryptoDocPassword { get; set; }

        [Outlet]
        AppKit.NSTabViewItem CryptoDocTabView { get; set; }

        [Outlet]
        AppKit.NSTableColumn DateColumn { get; set; }

        [Outlet]
        AppKit.NSButton DeleteEnctrypted { get; set; }

        [Outlet]
        AppKit.NSButton DeleteOriginal { get; set; }

        [Outlet]
        AppKit.NSTableColumn DescriptionColumn { get; set; }

        [Outlet]
        AppKit.NSImageView EOTLogoReceive { get; set; }

        [Outlet]
        AppKit.NSImageView EOTLogoSend { get; set; }

        [Outlet]
        AppKit.NSImageView ExportEOTLogo { get; set; }

        [Outlet]
        AppKit.NSSecureTextField ExportPassword { get; set; }

        [Outlet]
        AppKit.NSTextField HistoryBalance { get; set; }

        [Outlet]
        AppKit.NSImageView HistoryEOTLogo { get; set; }

        [Outlet]
        AppKit.NSTextField MinerFeesDollar { get; set; }

        [Outlet]
        AppKit.NSSecureTextField PasswordBox { get; set; }

        [Outlet]
        AppKit.NSTableColumn PasswordColumn { get; set; }

        [Outlet]
        AppKit.NSSecureTextField PasswordVaultPassword { get; set; }

        [Outlet]
        AppKit.NSScrollView PasswordVaultTable { get; set; }

        [Outlet]
        AppKit.NSTextView PasswordVaultText { get; set; }

        [Outlet]
        AppKit.NSTextFieldCell QRCodeLabel { get; set; }

        [Outlet]
        AppKit.NSTextField RandomCharsBox { get; set; }

        [Outlet]
        AppKit.NSTextField SendAmount { get; set; }

        [Outlet]
        AppKit.NSTextField SendMinerFees { get; set; }

        [Outlet]
        AppKit.NSSecureTextField SendPassword { get; set; }

        [Outlet]
        AppKit.NSTextField SendToAddress { get; set; }

        [Outlet]
        AppKit.NSTableColumn StatusColumn { get; set; }

        [Outlet]
        AppKit.NSTableView TransactionTable { get; set; }

        [Outlet]
        AppKit.NSTableHeaderView TransactionTableHeader { get; set; }

        [Outlet]
        AppKit.NSTableColumn UsernameColumn { get; set; }

        [Outlet]
        AppKit.NSTextField WalletAddressLabel { get; set; }

        [Outlet]
        AppKit.NSTextField WalletBalanceSend { get; set; }

        [Outlet]
        AppKit.NSTextField WalletLabel { get; set; }

        [Action ("CopyButtonClick:")]
        partial void CopyButtonClick (Foundation.NSObject sender);

        [Action ("CryptoDocDecryptButtonClick:")]
        partial void CryptoDocDecryptButtonClick (Foundation.NSObject sender);

        [Action ("CryptoDocOpenButtonClick:")]
        partial void CryptoDocOpenButtonClick (Foundation.NSObject sender);

        [Action ("DecryptButtonClick:")]
        partial void DecryptButtonClick (Foundation.NSObject sender);

        [Action ("EncryptButtonClick:")]
        partial void EncryptButtonClick (Foundation.NSObject sender);

        [Action ("ExportSeedButtonClick:")]
        partial void ExportSeedButtonClick (Foundation.NSObject sender);

        [Action ("GenerateWalletButtonClick:")]
        partial void GenerateWalletButtonClick (Foundation.NSObject sender);

        [Action ("RefreshButtonClick:")]
        partial void RefreshButtonClick (Foundation.NSObject sender);

        [Action ("RefreshTransactionButtonClick:")]
        partial void RefreshTransactionButtonClick (Foundation.NSObject sender);

        [Action ("SendEOTButtonClick:")]
        partial void SendEOTButtonClick (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (AdditionalInfoColumn != null) {
                AdditionalInfoColumn.Dispose ();
                AdditionalInfoColumn = null;
            }

            if (AmountColumn != null) {
                AmountColumn.Dispose ();
                AmountColumn = null;
            }

            if (AmountDollar != null) {
                AmountDollar.Dispose ();
                AmountDollar = null;
            }

            if (BalanceNumberLabel != null) {
                BalanceNumberLabel.Dispose ();
                BalanceNumberLabel = null;
            }

            if (CryptoDocDecryptButton != null) {
                CryptoDocDecryptButton.Dispose ();
                CryptoDocDecryptButton = null;
            }

            if (CryptoDocEncryptButton != null) {
                CryptoDocEncryptButton.Dispose ();
                CryptoDocEncryptButton = null;
            }

            if (CryptoDocPassword != null) {
                CryptoDocPassword.Dispose ();
                CryptoDocPassword = null;
            }

            if (CryptoDocTabView != null) {
                CryptoDocTabView.Dispose ();
                CryptoDocTabView = null;
            }

            if (DateColumn != null) {
                DateColumn.Dispose ();
                DateColumn = null;
            }

            if (DescriptionColumn != null) {
                DescriptionColumn.Dispose ();
                DescriptionColumn = null;
            }

            if (EOTLogoReceive != null) {
                EOTLogoReceive.Dispose ();
                EOTLogoReceive = null;
            }

            if (EOTLogoSend != null) {
                EOTLogoSend.Dispose ();
                EOTLogoSend = null;
            }

            if (ExportEOTLogo != null) {
                ExportEOTLogo.Dispose ();
                ExportEOTLogo = null;
            }

            if (ExportPassword != null) {
                ExportPassword.Dispose ();
                ExportPassword = null;
            }

            if (HistoryBalance != null) {
                HistoryBalance.Dispose ();
                HistoryBalance = null;
            }

            if (HistoryEOTLogo != null) {
                HistoryEOTLogo.Dispose ();
                HistoryEOTLogo = null;
            }

            if (MinerFeesDollar != null) {
                MinerFeesDollar.Dispose ();
                MinerFeesDollar = null;
            }

            if (PasswordBox != null) {
                PasswordBox.Dispose ();
                PasswordBox = null;
            }

            if (PasswordColumn != null) {
                PasswordColumn.Dispose ();
                PasswordColumn = null;
            }

            if (PasswordVaultPassword != null) {
                PasswordVaultPassword.Dispose ();
                PasswordVaultPassword = null;
            }

            if (PasswordVaultTable != null) {
                PasswordVaultTable.Dispose ();
                PasswordVaultTable = null;
            }

            if (PasswordVaultText != null) {
                PasswordVaultText.Dispose ();
                PasswordVaultText = null;
            }

            if (QRCodeLabel != null) {
                QRCodeLabel.Dispose ();
                QRCodeLabel = null;
            }

            if (RandomCharsBox != null) {
                RandomCharsBox.Dispose ();
                RandomCharsBox = null;
            }

            if (SendAmount != null) {
                SendAmount.Dispose ();
                SendAmount = null;
            }

            if (SendMinerFees != null) {
                SendMinerFees.Dispose ();
                SendMinerFees = null;
            }

            if (SendPassword != null) {
                SendPassword.Dispose ();
                SendPassword = null;
            }

            if (SendToAddress != null) {
                SendToAddress.Dispose ();
                SendToAddress = null;
            }

            if (StatusColumn != null) {
                StatusColumn.Dispose ();
                StatusColumn = null;
            }

            if (TransactionTable != null) {
                TransactionTable.Dispose ();
                TransactionTable = null;
            }

            if (TransactionTableHeader != null) {
                TransactionTableHeader.Dispose ();
                TransactionTableHeader = null;
            }

            if (UsernameColumn != null) {
                UsernameColumn.Dispose ();
                UsernameColumn = null;
            }

            if (WalletAddressLabel != null) {
                WalletAddressLabel.Dispose ();
                WalletAddressLabel = null;
            }

            if (WalletBalanceSend != null) {
                WalletBalanceSend.Dispose ();
                WalletBalanceSend = null;
            }

            if (WalletLabel != null) {
                WalletLabel.Dispose ();
                WalletLabel = null;
            }

            if (DeleteEnctrypted != null) {
                DeleteEnctrypted.Dispose ();
                DeleteEnctrypted = null;
            }

            if (DeleteOriginal != null) {
                DeleteOriginal.Dispose ();
                DeleteOriginal = null;
            }
        }
    }
}
