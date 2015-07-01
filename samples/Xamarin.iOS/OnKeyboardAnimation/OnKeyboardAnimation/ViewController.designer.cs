// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace OnKeyboardAnimation
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UITextField FirstNameTextfield { get; set; }

		[Outlet]
		UIKit.UITextField LastNameTextfield { get; set; }

		[Outlet]
		UIKit.UITextField NotesTextfield { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (FirstNameTextfield != null) {
				FirstNameTextfield.Dispose ();
				FirstNameTextfield = null;
			}

			if (LastNameTextfield != null) {
				LastNameTextfield.Dispose ();
				LastNameTextfield = null;
			}

			if (NotesTextfield != null) {
				NotesTextfield.Dispose ();
				NotesTextfield = null;
			}
		}
	}
}
