// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ForceAppliedSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel LabelForce { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (LabelForce != null) {
				LabelForce.Dispose ();
				LabelForce = null;
			}
		}
	}
}
