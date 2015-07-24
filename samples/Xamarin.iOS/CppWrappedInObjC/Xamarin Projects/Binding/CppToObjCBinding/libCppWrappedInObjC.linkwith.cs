using System;
using ObjCRuntime;

[assembly: LinkWith ("libCppWrappedInObjC.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator64 | LinkTarget.Arm64, Frameworks = "Foundation", IsCxx = true, SmartLink = true, ForceLoad = true)]