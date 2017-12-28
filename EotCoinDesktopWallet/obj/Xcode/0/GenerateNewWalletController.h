// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface GenerateNewWalletController : NSWindowController {
	NSTextField *_CharactersLeft;
	NSImageCell *_LogoImage;
	NSSecureTextField *_PasswordField;
	NSTextField *_RandomCharsField;
	NSSecureTextField *_RepeatPasswordField;
}

@property (nonatomic, retain) IBOutlet NSTextField *CharactersLeft;

@property (nonatomic, retain) IBOutlet NSImageCell *LogoImage;

@property (nonatomic, retain) IBOutlet NSSecureTextField *PasswordField;

@property (nonatomic, retain) IBOutlet NSTextField *RandomCharsField;

@property (nonatomic, retain) IBOutlet NSSecureTextField *RepeatPasswordField;

- (IBAction)CharacterTyped:(NSTextField *)sender;

- (IBAction)GenerateWalletClick:(id)sender;

@end
