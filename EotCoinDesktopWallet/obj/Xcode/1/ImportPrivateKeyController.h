// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface ImportPrivateKeyController : NSWindowController {
	NSImageView *_EOTLogoPrivateKey;
	NSSecureTextField *_ImportPassword;
	NSTextField *_PrivateKeyTextBox;
	NSTextField *_PublicKeyImport;
}

@property (nonatomic, retain) IBOutlet NSImageView *EOTLogoPrivateKey;

@property (nonatomic, retain) IBOutlet NSSecureTextField *ImportPassword;

@property (nonatomic, retain) IBOutlet NSTextField *PrivateKeyTextBox;

@property (nonatomic, retain) IBOutlet NSTextField *PublicKeyImport;

- (IBAction)ImportPrivateKeyButtonClick:(id)sender;

@end
