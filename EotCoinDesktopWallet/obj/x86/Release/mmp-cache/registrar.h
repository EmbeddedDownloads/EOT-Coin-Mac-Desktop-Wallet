#pragma clang diagnostic ignored "-Wdeprecated-declarations"
#pragma clang diagnostic ignored "-Wtypedef-redefinition"
#pragma clang diagnostic ignored "-Wobjc-designated-initializers"
#include <stdarg.h>
#include <objc/objc.h>
#include <objc/runtime.h>
#include <objc/message.h>
#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>
#import <CloudKit/CloudKit.h>
#import <CoreGraphics/CoreGraphics.h>

@class Foundation_InternalNSNotificationHandler;
@class __monomac_internal_ActionDispatcher;
@class __MonoMac_NSActionDispatcher;
@class __Xamarin_NSTimerActionDispatcher;
@class __MonoMac_NSAsyncActionDispatcher;
@class Foundation_NSUrlSessionHandler_WrappedNSInputStream;
@class __NSObject_Disposer;
@class __NSGestureRecognizerToken;
@class __NSClickGestureRecognizer;
@class __NSGestureRecognizerParameterlessToken;
@class __NSGestureRecognizerParametrizedToken;
@class __NSMagnificationGestureRecognizer;
@class AppKit_NSTableView__NSTableViewDelegate;
@class __NSPanGestureRecognizer;
@class __NSPressGestureRecognizer;
@class __NSRotationGestureRecognizer;
@class AppKit_NSTextField__NSTextFieldDelegate;
@class Foundation_NSUrlSessionHandler_NSUrlSessionHandlerDelegate;
@class OpenTK_Platform_MacOS_MonoMacGameView;
@class MainWindow;
@class MainWindowController;
@class AppDelegate;
@class EotCoinDesktopWallet_Setup;
@class EotCoinDesktopWallet_TransactionHistoryDataSource;
@class EotCoinDesktopWallet_TransactionHistoryDelegate;
@class LoginWindow;
@class LoginWindowController;
@class GenerateNewWallet;
@class GenerateNewWalletController;
@class AlertWindow;
@class AlertWindowController;
@class ImportPrivateKey;
@class ImportPrivateKeyController;
@class StartupWindow;
@class StartupWindowController;

@interface __NSGestureRecognizerToken : NSObject {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface __NSGestureRecognizerParameterlessToken : __NSGestureRecognizerToken {
}
	-(void) target;
@end

@interface __NSGestureRecognizerParametrizedToken : __NSGestureRecognizerToken {
}
	-(void) target:(NSGestureRecognizer *)p0;
@end

@interface OpenTK_Platform_MacOS_MonoMacGameView : NSView {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) drawRect:(CGRect)p0;
	-(void) lockFocus;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithFrame:(CGRect)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface MainWindow : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface MainWindowController : NSWindowController {
}
	@property (nonatomic, assign) NSTableColumn * AmountColumn;
	@property (nonatomic, assign) NSTextField * AmountDollar;
	@property (nonatomic, assign) NSTextField * BalanceNumberLabel;
	@property (nonatomic, assign) NSTableColumn * DateColumn;
	@property (nonatomic, assign) NSImageView * EOTLogoReceive;
	@property (nonatomic, assign) NSImageView * EOTLogoSend;
	@property (nonatomic, assign) NSImageView * ExportEOTLogo;
	@property (nonatomic, assign) NSSecureTextField * ExportPassword;
	@property (nonatomic, assign) NSTextField * HistoryBalance;
	@property (nonatomic, assign) NSImageView * HistoryEOTLogo;
	@property (nonatomic, assign) NSTextField * MinerFeesDollar;
	@property (nonatomic, assign) NSSecureTextField * PasswordBox;
	@property (nonatomic, assign) NSTextFieldCell * QRCodeLabel;
	@property (nonatomic, assign) NSTextField * RandomCharsBox;
	@property (nonatomic, assign) NSTextField * SendAmount;
	@property (nonatomic, assign) NSTextField * SendMinerFees;
	@property (nonatomic, assign) NSSecureTextField * SendPassword;
	@property (nonatomic, assign) NSTextField * SendToAddress;
	@property (nonatomic, assign) NSTableColumn * StatusColumn;
	@property (nonatomic, assign) NSTableView * TransactionTable;
	@property (nonatomic, assign) NSTableHeaderView * TransactionTableHeader;
	@property (nonatomic, assign) NSTextField * WalletAddressLabel;
	@property (nonatomic, assign) NSTextField * WalletBalanceSend;
	@property (nonatomic, assign) NSTextField * WalletLabel;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSTableColumn *) AmountColumn;
	-(void) setAmountColumn:(NSTableColumn *)p0;
	-(NSTextField *) AmountDollar;
	-(void) setAmountDollar:(NSTextField *)p0;
	-(NSTextField *) BalanceNumberLabel;
	-(void) setBalanceNumberLabel:(NSTextField *)p0;
	-(NSTableColumn *) DateColumn;
	-(void) setDateColumn:(NSTableColumn *)p0;
	-(NSImageView *) EOTLogoReceive;
	-(void) setEOTLogoReceive:(NSImageView *)p0;
	-(NSImageView *) EOTLogoSend;
	-(void) setEOTLogoSend:(NSImageView *)p0;
	-(NSImageView *) ExportEOTLogo;
	-(void) setExportEOTLogo:(NSImageView *)p0;
	-(NSSecureTextField *) ExportPassword;
	-(void) setExportPassword:(NSSecureTextField *)p0;
	-(NSTextField *) HistoryBalance;
	-(void) setHistoryBalance:(NSTextField *)p0;
	-(NSImageView *) HistoryEOTLogo;
	-(void) setHistoryEOTLogo:(NSImageView *)p0;
	-(NSTextField *) MinerFeesDollar;
	-(void) setMinerFeesDollar:(NSTextField *)p0;
	-(NSSecureTextField *) PasswordBox;
	-(void) setPasswordBox:(NSSecureTextField *)p0;
	-(NSTextFieldCell *) QRCodeLabel;
	-(void) setQRCodeLabel:(NSTextFieldCell *)p0;
	-(NSTextField *) RandomCharsBox;
	-(void) setRandomCharsBox:(NSTextField *)p0;
	-(NSTextField *) SendAmount;
	-(void) setSendAmount:(NSTextField *)p0;
	-(NSTextField *) SendMinerFees;
	-(void) setSendMinerFees:(NSTextField *)p0;
	-(NSSecureTextField *) SendPassword;
	-(void) setSendPassword:(NSSecureTextField *)p0;
	-(NSTextField *) SendToAddress;
	-(void) setSendToAddress:(NSTextField *)p0;
	-(NSTableColumn *) StatusColumn;
	-(void) setStatusColumn:(NSTableColumn *)p0;
	-(NSTableView *) TransactionTable;
	-(void) setTransactionTable:(NSTableView *)p0;
	-(NSTableHeaderView *) TransactionTableHeader;
	-(void) setTransactionTableHeader:(NSTableHeaderView *)p0;
	-(NSTextField *) WalletAddressLabel;
	-(void) setWalletAddressLabel:(NSTextField *)p0;
	-(NSTextField *) WalletBalanceSend;
	-(void) setWalletBalanceSend:(NSTextField *)p0;
	-(NSTextField *) WalletLabel;
	-(void) setWalletLabel:(NSTextField *)p0;
	-(void) awakeFromNib;
	-(void) ExportSeedButtonClick:(NSObject *)p0;
	-(void) GenerateWalletButtonClick:(NSObject *)p0;
	-(void) RefreshButtonClick:(NSObject *)p0;
	-(void) RefreshTransactionButtonClick:(NSObject *)p0;
	-(void) SendEOTButtonClick:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface AppDelegate : NSObject<NSApplicationDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) applicationDidFinishLaunching:(NSNotification *)p0;
	-(void) applicationWillTerminate:(NSNotification *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface EotCoinDesktopWallet_Setup : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface EotCoinDesktopWallet_TransactionHistoryDataSource : NSObject<NSTableViewDataSource> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSInteger) numberOfRowsInTableView:(NSTableView *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) init;
@end

@interface EotCoinDesktopWallet_TransactionHistoryDelegate : NSObject<NSTableViewDelegate> {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSView *) tableView:(NSTableView *)p0 viewForTableColumn:(NSTableColumn *)p1 row:(NSInteger)p2;
	-(BOOL) conformsToProtocol:(void *)p0;
@end

@interface LoginWindow : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface LoginWindowController : NSWindowController {
}
	@property (nonatomic, assign) NSImageView * LogoImage;
	@property (nonatomic, assign) NSTextField * PasswordIncorrect;
	@property (nonatomic, assign) NSSecureTextField * PasswordTextField;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSImageView *) LogoImage;
	-(void) setLogoImage:(NSImageView *)p0;
	-(NSTextField *) PasswordIncorrect;
	-(void) setPasswordIncorrect:(NSTextField *)p0;
	-(NSSecureTextField *) PasswordTextField;
	-(void) setPasswordTextField:(NSSecureTextField *)p0;
	-(void) awakeFromNib;
	-(void) LoginButtonClick:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface GenerateNewWallet : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface GenerateNewWalletController : NSWindowController {
}
	@property (nonatomic, assign) NSTextField * CharactersLeft;
	@property (nonatomic, assign) NSImageCell * LogoImage;
	@property (nonatomic, assign) NSSecureTextField * PasswordField;
	@property (nonatomic, assign) NSTextField * RandomCharsField;
	@property (nonatomic, assign) NSSecureTextField * RepeatPasswordField;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSTextField *) CharactersLeft;
	-(void) setCharactersLeft:(NSTextField *)p0;
	-(NSImageCell *) LogoImage;
	-(void) setLogoImage:(NSImageCell *)p0;
	-(NSSecureTextField *) PasswordField;
	-(void) setPasswordField:(NSSecureTextField *)p0;
	-(NSTextField *) RandomCharsField;
	-(void) setRandomCharsField:(NSTextField *)p0;
	-(NSSecureTextField *) RepeatPasswordField;
	-(void) setRepeatPasswordField:(NSSecureTextField *)p0;
	-(void) awakeFromNib;
	-(void) GenerateWalletClick:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface AlertWindow : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface AlertWindowController : NSWindowController {
}
	@property (nonatomic, assign) NSImageView * AlertImage;
	@property (nonatomic, assign) NSTextField * AlertLabel;
	@property (nonatomic, assign) NSButton * CloseButtonClick;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSImageView *) AlertImage;
	-(void) setAlertImage:(NSImageView *)p0;
	-(NSTextField *) AlertLabel;
	-(void) setAlertLabel:(NSTextField *)p0;
	-(NSButton *) CloseButtonClick;
	-(void) setCloseButtonClick:(NSButton *)p0;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface ImportPrivateKey : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface ImportPrivateKeyController : NSWindowController {
}
	@property (nonatomic, assign) NSImageView * EOTLogoPrivateKey;
	@property (nonatomic, assign) NSSecureTextField * ImportPassword;
	@property (nonatomic, assign) NSTextField * PrivateKeyTextBox;
	@property (nonatomic, assign) NSTextField * PublicKeyImport;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSImageView *) EOTLogoPrivateKey;
	-(void) setEOTLogoPrivateKey:(NSImageView *)p0;
	-(NSSecureTextField *) ImportPassword;
	-(void) setImportPassword:(NSSecureTextField *)p0;
	-(NSTextField *) PrivateKeyTextBox;
	-(void) setPrivateKeyTextBox:(NSTextField *)p0;
	-(NSTextField *) PublicKeyImport;
	-(void) setPublicKeyImport:(NSTextField *)p0;
	-(void) awakeFromNib;
	-(void) ImportPrivateKeyButtonClick:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end

@interface StartupWindow : NSWindow {
}
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(void) awakeFromNib;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
@end

@interface StartupWindowController : NSWindowController {
}
	@property (nonatomic, assign) NSImageView * EOTLogo;
	-(void) release;
	-(id) retain;
	-(int) xamarinGetGCHandle;
	-(void) xamarinSetGCHandle: (int) gchandle;
	-(NSImageView *) EOTLogo;
	-(void) setEOTLogo:(NSImageView *)p0;
	-(void) awakeFromNib;
	-(void) GenerateNewWalletButtonClick:(NSObject *)p0;
	-(void) ImportWalletFromSeedButtonClick:(NSObject *)p0;
	-(BOOL) conformsToProtocol:(void *)p0;
	-(id) initWithCoder:(NSCoder *)p0;
	-(id) init;
@end


