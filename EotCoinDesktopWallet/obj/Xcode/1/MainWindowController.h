// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface MainWindowController : NSWindowController {
	NSTableColumn *_AmountColumn;
	NSTextField *_AmountDollar;
	NSTextField *_BalanceNumberLabel;
	NSTableColumn *_DateColumn;
	NSImageView *_EOTLogoReceive;
	NSImageView *_EOTLogoSend;
	NSImageView *_ExportEOTLogo;
	NSSecureTextField *_ExportPassword;
	NSTextField *_HistoryBalance;
	NSImageView *_HistoryEOTLogo;
	NSTextField *_MinerFeesDollar;
	NSSecureTextField *_PasswordBox;
	NSTextFieldCell *_QRCodeLabel;
	NSTextField *_RandomCharsBox;
	NSTextField *_SendAmount;
	NSTextField *_SendMinerFees;
	NSSecureTextField *_SendPassword;
	NSTextField *_SendToAddress;
	NSTableColumn *_StatusColumn;
	NSTableView *_TransactionTable;
	NSTableHeaderView *_TransactionTableHeader;
	NSTextField *_WalletAddressLabel;
	NSTextField *_WalletBalanceSend;
	NSTextField *_WalletLabel;
    NSTableView *_PasswordVaultTable;
    NSTableColumn *_DescriptionColumn;
    NSTableColumn *_UsernameColumn;
    NSTableColumn *_PasswordColumn;
    NSTableColumn *_AdditionalInfoColumn;
    NSTextView *_PasswordVaultText;
    NSSecureTextField *_PasswordVaultPassword;
}

@property (nonatomic, retain) IBOutlet NSTableColumn *AmountColumn;

@property (nonatomic, retain) IBOutlet NSTextField *AmountDollar;

@property (nonatomic, retain) IBOutlet NSTextField *BalanceNumberLabel;

@property (nonatomic, retain) IBOutlet NSTableColumn *DateColumn;

@property (nonatomic, retain) IBOutlet NSImageView *EOTLogoReceive;

@property (nonatomic, retain) IBOutlet NSImageView *EOTLogoSend;

@property (nonatomic, retain) IBOutlet NSImageView *ExportEOTLogo;

@property (nonatomic, retain) IBOutlet NSSecureTextField *ExportPassword;

@property (nonatomic, retain) IBOutlet NSTextField *HistoryBalance;

@property (nonatomic, retain) IBOutlet NSImageView *HistoryEOTLogo;

@property (nonatomic, retain) IBOutlet NSTextField *MinerFeesDollar;

@property (nonatomic, retain) IBOutlet NSSecureTextField *PasswordBox;

@property (nonatomic, retain) IBOutlet NSTextFieldCell *QRCodeLabel;

@property (nonatomic, retain) IBOutlet NSTextField *RandomCharsBox;

@property (nonatomic, retain) IBOutlet NSTextField *SendAmount;

@property (nonatomic, retain) IBOutlet NSTextField *SendMinerFees;

@property (nonatomic, retain) IBOutlet NSSecureTextField *SendPassword;

@property (nonatomic, retain) IBOutlet NSTextField *SendToAddress;

@property (nonatomic, retain) IBOutlet NSTableColumn *StatusColumn;

@property (nonatomic, retain) IBOutlet NSTableView *TransactionTable;

@property (nonatomic, retain) IBOutlet NSTableHeaderView *TransactionTableHeader;

@property (nonatomic, retain) IBOutlet NSTextField *WalletAddressLabel;

@property (nonatomic, retain) IBOutlet NSTextField *WalletBalanceSend;

@property (nonatomic, retain) IBOutlet NSTextField *WalletLabel;
@property (strong) IBOutlet NSScrollView *PasswordVaultTable;
@property (strong) IBOutlet NSTableColumn *DescriptionColumn;
@property (strong) IBOutlet NSTableColumn *UsernameColumn;
@property (strong) IBOutlet NSTableColumn *PasswordColumn;
@property (strong) IBOutlet NSTableColumn *AdditionalInfoColumn;

@property (strong) IBOutlet NSTextView *PasswordVaultText;
@property (strong) IBOutlet NSSecureTextField *PasswordVaultPassword;

- (IBAction)CopyButtonClick:(id)sender;

- (IBAction)ExportSeedButtonClick:(id)sender;

- (IBAction)GenerateWalletButtonClick:(id)sender;

- (IBAction)RefreshButtonClick:(id)sender;

- (IBAction)RefreshTransactionButtonClick:(id)sender;
- (IBAction)EncryptButtonClick:(id)sender;

- (IBAction)SendEOTButtonClick:(id)sender;
- (IBAction)DecryptButtonClick:(id)sender;

@end
