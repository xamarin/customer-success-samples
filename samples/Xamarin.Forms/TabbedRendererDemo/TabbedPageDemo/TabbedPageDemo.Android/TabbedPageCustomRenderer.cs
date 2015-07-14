using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using TabbedPageDemo.Droid;

using AViewGroup = Android.Views.ViewGroup;
using AndroidView = Android.Views.View;
using Android.Views;
using System.Reflection;

[assembly:ExportRenderer(typeof(TabbedPage),typeof(TabbedPageCustomRenderer))]

namespace TabbedPageDemo.Droid
{
	public class TabbedPageCustomRenderer : TabbedRenderer
	{
		int currentIndex = 0;

		//Create a listener and detector for the gestures
		private readonly GesutreListener _listener;
		private readonly GestureDetector _detector;

		//Create two x points to find out if the swipe was to the left or to the right
		private float x1,x2;

		TabbedPage tabbedPage;

		public TabbedPageCustomRenderer()
		{
			_listener = new GesutreListener();
			_detector = new GestureDetector (_listener);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<TabbedPage> e)
		{
			base.OnElementChanged (e);

			if (e.NewElement != null) {
				tabbedPage = (TabbedPage)e.NewElement;
			}
		}

		protected override void SwitchContent (Page view)
		{
			base.SwitchContent (view);
			//Need to remove and add Touch event to make sure it is effective on the top current page
			ViewGroup.GetChildAt (0).Touch -= HandleGenericMotion;
			//Need to reset the current index in case user touches tab
			currentIndex = Element.Children.IndexOf (view);
			ViewGroup.GetChildAt (0).Touch += HandleGenericMotion;
		}

		public void HandleGenericMotion (object sender, TouchEventArgs e)
		{
			//This assignes the detectors touch event
			_detector.OnTouchEvent (e.Event);

			//We want to test the down and up actions from the TouchEventArgs
			switch (e.Event.Action) {

			//If action is Down, then we set the x1 value and break
			case MotionEventActions.Down:
				x1 = e.Event.GetX ();
				break;
				//If action is Up, then we set the x2 and caluclate whether it was a swipe left or right AND swipe was greater then MinimumSwipeDistance
			case MotionEventActions.Up:
				x2 = e.Event.GetX ();
				float delta = x2 - x1;
				if (Math.Abs (delta) > 100) {
					if (delta > 0) {
						Console.WriteLine ("Swipe to the Right");
						//Check to make sure we aren't at the first view
						if (currentIndex != 0) {
							//Replace the current page with the new page
							currentIndex--;
							tabbedPage.CurrentPage = tabbedPage.Children [currentIndex];
						}

					} else if (delta < 0) {
						Console.WriteLine ("Swipe to the Left");
						//Check to make sure we aren't on the current view
						if (currentIndex != Element.Children.Count - 1) {
							//Replace the current page with the new page
							currentIndex++;
							tabbedPage.CurrentPage = tabbedPage.Children [currentIndex];
						}
					}
				}
				break;
			}
		}
	}
} 