using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using TabbedPageDemo.iOS;

using UIKit;

[assembly:ExportRenderer(typeof(TabbedPage),typeof(TabbedPageCustomRenderer))]

namespace TabbedPageDemo.iOS
{
	public class TabbedPageCustomRenderer : TabbedRenderer
	{
		UITabBarController tabbedController;
		UISwipeGestureRecognizer rightGesture, leftGesture;
		bool isInitialized = false;

		protected override void OnElementChanged (VisualElementChangedEventArgs e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				tabbedController = (UITabBarController)ViewController;
			}

			if (!isInitialized) {

				rightGesture = new UISwipeGestureRecognizer (swipe => {
					//Check to make sure we aren't at the last view
					Console.WriteLine ("Swipe Left");
					if(this.SelectedIndex != ViewControllers.Length - 1)
						tabbedController.SelectedViewController = ViewControllers [this.SelectedIndex + 1];
				}) {
					Direction = UISwipeGestureRecognizerDirection.Left
				};

				leftGesture = new UISwipeGestureRecognizer (swipe => {
					//Check to make sure we aren't at the first view
					Console.WriteLine ("Swipe Right");
					if(this.SelectedIndex != 0)
						tabbedController.SelectedViewController = ViewControllers [this.SelectedIndex - 1];
				}) {
					Direction = UISwipeGestureRecognizerDirection.Right
				};

				View.AddGestureRecognizer (rightGesture);
				View.AddGestureRecognizer (leftGesture);

				isInitialized = true;
			}
		}
	}
}