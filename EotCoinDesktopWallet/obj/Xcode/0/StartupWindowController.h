// WARNING
// This file has been generated automatically by Visual Studio to
// mirror C# types. Changes in this file made by drag-connecting
// from the UI designer will be synchronized back to C#, but
// more complex manual changes may not transfer correctly.


#import <Foundation/Foundation.h>
#import <AppKit/AppKit.h>


@interface StartupWindowController : NSWindowController {
	NSImageView *_EOTLogo;
}

@property (nonatomic, retain) IBOutlet NSImageView *EOTLogo;

- (IBAction)GenerateNewWalletButtonClick:(id)sender;

- (IBAction)ImportWalletFromSeedButtonClick:(id)sender;

@end
