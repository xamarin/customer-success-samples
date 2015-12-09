using System;
using Xamarin.Forms;
using FormsImageTapGesture;
using Xamarin.Forms.Platform.Android;
using FormsImageTapGesture.Droid;
using Android.Widget;
using Android.Views;

[assembly: ExportRenderer(typeof(CustomImage), typeof(CustomImageRenderer))]
namespace FormsImageTapGesture.Droid
{
	public class CustomImageRenderer : ImageRenderer, 
		// Gesture Recognizer methods
		Android.Views.GestureDetector.IOnGestureListener, 
		// Touch handling methods
		Android.Views.View.IOnTouchListener
	{
		#region properties & fields
		// ---------------------------------------------------------------------------
		//
		// PROPERTIES & FIELDS
		//
		// ---------------------------------------------------------------------------

		//
		// The Xamarin.Forms control (not native)
		//
		private CustomImage formsElement;

		//
		// Android ImageView (native implementation of Xamarin.Forms control)
		//
		private ImageView nativeElement;

		//
		// Gesture detector
		//
		private GestureDetector _gestureDetector;
		#endregion

		#region methods
		// ---------------------------------------------------------------------------
		//
		// METHODS
		//
		// ---------------------------------------------------------------------------

		//
		// Use this method to customize the native control as desired
		//
		protected override void OnElementChanged(ElementChangedEventArgs<Image> e) {
			base.OnElementChanged (e);
			if (e.NewElement != null) {
				// Grab the Xamarin.Forms element from the incoming event
				formsElement = e.NewElement as CustomImage;
				// Grab the native implementation of the Xamarin.Forms element from the incoming event
				nativeElement = Control as ImageView;
				// Use this object to handle the touch events coming from the native elemtn
				nativeElement.SetOnTouchListener (this);
				// Create a gesture detector, and use this object to handle its events
				_gestureDetector = new GestureDetector (this);
			}
		}
		#endregion

		#region IOnTouchListener methods
		// --------------------------------------------------------------------------
		//
		// IOnTouchListener METHODS
		//
		// --------------------------------------------------------------------------

		//
		// Handle touch events. In this case, just pass them through to the gesture
		// detector so that it can determine when a tap has happened.
		//
		public bool OnTouch (Android.Views.View v, MotionEvent e) {
			_gestureDetector.OnTouchEvent (e);
			return true;
		}
		#endregion

		#region IOnGestureListener methods
		// --------------------------------------------------------------------------
		//
		// IOnGestureListener METHODS
		//
		// --------------------------------------------------------------------------

		//
		// When a single tap up has been detected, tell the Xamarin.Forms control
		// to dispatch its tap event.
		//
		public bool OnSingleTapUp (MotionEvent e) { 
			formsElement.OnTapEvent((int)e.GetX(), (int)e.GetY());
			return true; 
		}

		//
		// Not really using the rest of these methods.
		//
		public bool OnDown (MotionEvent e) { return true; }
		public bool OnFling (MotionEvent e1, MotionEvent e2, float velocityX, float velocityY) { return false; }
		public void OnLongPress (MotionEvent e) { }
		public bool OnScroll (MotionEvent e1, MotionEvent e2, float distanceX, float distanceY) { return false; }
		public void OnShowPress (MotionEvent e){ } 
		#endregion
	}
}

