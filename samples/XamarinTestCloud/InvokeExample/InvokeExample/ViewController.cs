using System;

using UIKit;
using Foundation;
using System.Collections.Generic;

namespace InvokeExample
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.

			PizzaPicker.AccessibilityIdentifier = "PizzaPicker";
			PizzaPicker.Model = new StatusPickerViewModel ();
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

	}


	public class StatusPickerViewModel : UIPickerViewModel
	{
		public override nint GetComponentCount (UIPickerView picker)
		{
			return 1;
		}

		public override nint GetRowsInComponent (UIPickerView pickerView, nint component)
		{
			return 5;

		}

		public override string GetTitle (UIPickerView picker, nint row, nint component)
		{

			return "Component " + row.ToString();
		}

	}



}

