//
//  ViewController.m
//  Xcode_XamarinUITest_SampleApp
//
//  Created by Brandon Minnick on 11/10/16.
//  Copyright © 2016 Brandon Minnick. All rights reserved.
//

#import "ViewController.h"

@interface ViewController ()
@property (weak, nonatomic) IBOutlet UITextField *MyTextField;
@property (weak, nonatomic) IBOutlet UILabel *MyLabel;
- (IBAction)MyTextFieldEditingChanged:(id)sender;

@end

@implementation ViewController

- (void)viewDidLoad {
    [super viewDidLoad];
    [self setNeedsStatusBarAppearanceUpdate];
    
    _MyTextField.accessibilityIdentifier = @"MyTextField";
    _MyLabel.accessibilityIdentifier = @"MyLabel";
}


- (void)didReceiveMemoryWarning {
    [super didReceiveMemoryWarning];
    // Dispose of any resources that can be recreated.
}


- (IBAction)MyTextFieldEditingChanged:(id)sender {
    _MyLabel.text = _MyTextField.text;
}

- (UIStatusBarStyle)preferredStatusBarStyle
{
    return UIStatusBarStyleLightContent;
}

@end
