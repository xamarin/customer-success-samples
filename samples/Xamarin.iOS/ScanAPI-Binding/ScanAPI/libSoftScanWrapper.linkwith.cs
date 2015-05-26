using System;
using ObjCRuntime;

[assembly: LinkWith ("libSoftScanWrapper.a", LinkTarget.ArmV7 | LinkTarget.Simulator64 | LinkTarget.ArmV7s | LinkTarget.Arm64 | LinkTarget.Simulator, Frameworks = "AudioToolbox AVFoundation CoreGraphics SystemConfiguration QuartzCore CoreImage MultipeerConnectivity Security CFNetwork UIKit Foundation ExternalAccessory", LinkerFlags = "", IsCxx = true, SmartLink = true, ForceLoad = true)]