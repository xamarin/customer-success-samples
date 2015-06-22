using System;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using PCL;
using Slider.Droid;

using Android.Views;
using AndroidView = Android.Views.View;

[assembly:ExportRenderer(typeof(SliderView),typeof(SliderViewRenderer))]

namespace Slider.Droid
{
	public class SliderViewRenderer : ViewRenderer <SliderView,AndroidView>, GestureDetector.IOnGestureListener
	{
		//Create a listener and detector for the gestures
		private readonly GestureDetector _detector;

		//Create two x points to find out if the swipe was to the left or to the right
		private float _lastOnDownX;

		//Create a holder for the SliderView to be used in the Renderer
		SliderView _sliderView;

		public SliderViewRenderer ()
		{
			//Contruct the listener and detector
			_detector = new GestureDetector (Forms.Context, this);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<SliderView> e)
		{
			base.OnElementChanged (e);

			//Assign the Touch event of the SliderView
			if (e.OldElement == null) {
				_sliderView = (PCL.SliderView)e.NewElement;
				_sliderView.AddDotLayoutToViewScreen ();
				_sliderView.IsInitialized = true;

			}
		}

		public override bool OnInterceptTouchEvent (MotionEvent ev)
		{
			ViewConfiguration vc = ViewConfiguration.Get(Forms.Context);
			int mSlop = vc.ScaledTouchSlop;           
			switch (ev.ActionMasked)
			{               

			case MotionEventActions.Move:                   
				float deltaX = ev.RawX - _lastOnDownX;
				if (Math.Abs (deltaX) > mSlop) {
					return true;
				} else {
					return false;
				}
			case MotionEventActions.Down:
				_lastOnDownX = ev.GetX();
				return false;
			}
			return false;
		}

		public override bool OnTouchEvent(MotionEvent e)
		{
			return _detector.OnTouchEvent(e);
		}

		public bool OnFling(MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		{
			Console.WriteLine("Renderer: Fling");

			if (_lastOnDownX - e2.GetX() > _sliderView.MinimumSwipeDistance)
			{
				// right to left swipe                
				Console.WriteLine("right to left swipe");
				HandleRightToLeftSwipeAsync();
				return true;

			}
			if (e2.GetX() - _lastOnDownX > _sliderView.MinimumSwipeDistance)
			{
				// left to right swipe
				Console.WriteLine(" left to right swipe");
				HandleLeftToRightSwipeAsync ();
				return true;

			}
			return false;
		}

		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			//Call the garbage collection to make sure the BitMaps are cleaned up
			GC.Collect ();
		}

		async Task HandleLeftToRightSwipeAsync()
		{
			if (_sliderView.CurrentViewInt != 0) {
				//Drop the index one
				_sliderView.CurrentViewInt--;
				//Set the new CurrentView
				_sliderView.CurrentView = _sliderView.Children [_sliderView.CurrentViewInt];
				//Now add and wait for the view to translate in. Important to use await so the view is translated prior to removing the old view
				bool loading = await TranslateToCurrentViewAsync ("Right");

				_sliderView.ViewScreen.Children.Remove (_sliderView.Children [_sliderView.CurrentViewInt + 1]);
			}
		}

		async Task HandleRightToLeftSwipeAsync()
		{
			if (_sliderView.Children.Count > _sliderView.CurrentViewInt + 1) {
				//Add one to the index
				_sliderView.CurrentViewInt++;
				//Set the new CurrentView
				_sliderView.CurrentView = _sliderView.Children [_sliderView.CurrentViewInt];
				//Now add and wait for the view to translate in. Important to use await so the view is translated prior to removing the old view
				bool loading = await TranslateToCurrentViewAsync("Left");

				_sliderView.ViewScreen.Children.Remove (_sliderView.Children [_sliderView.CurrentViewInt - 1]);

			}
		}

		public async Task<bool> TranslateToCurrentViewAsync(string direction)
		{
			Console.WriteLine ("Enter Translate Async");
			//Create the initial layout for Translation property
			Rectangle initialLayoutRect = new Rectangle (
				0,
				0,
				_sliderView.Width, 
				_sliderView.Height
			);
			//This is pretty much a dumby variable to allow us to use async/await
			//It could be utilized for errors if you want to build this out more
			bool error = false;

			//Depending on the swiping direction...
			switch (direction) {
			case "Right":
				//Set the X value of the new CurrentView. 
				//SliderView was designed to take up the entire width of the page so the layout will be off screen to the left
				initialLayoutRect.X = -_sliderView.ParentView.Width;

				_sliderView.RemoveDotLayoutFromViewScreen ();
				//Add the CurrentView to the ViewScreen, but it is still off screen
				_sliderView.ViewScreen.Children.Add (_sliderView.CurrentView, initialLayoutRect);
				//Add the dotLayout after the current view to make sure it is visible
				_sliderView.RefreshDotOpacity ();
				_sliderView.AddDotLayoutToViewScreen ();

				//Translate the currentview into ViewScreen. CurrentView is now on screen
				error = await _sliderView.CurrentView.TranslateTo (_sliderView.ParentView.Width, 0, _sliderView.TransitionLength);
				break;
			case "Left":
				//Set the X value of the new CurrentView. 
                                                                                                                   				//SliderView was designed to take up the entire width of the page so the layout will be off screen to the right
				initialLayoutRect.X = _sliderView.ParentView.Width;

				_sliderView.RemoveDotLayoutFromViewScreen ();
				//Add the CurrentView to the ViewScreen, but it is still off screen
				_sliderView.ViewScreen.Children.Add (_sliderView.CurrentView, initialLayoutRect);
				//Add the dotLayout after the current view to make sure it is visible
				_sliderView.RefreshDotOpacity ();
				_sliderView.AddDotLayoutToViewScreen ();

				//Translate the currentview into ViewScreen. CurrentView is now on screen
				error = await _sliderView.CurrentView.TranslateTo (-_sliderView.ParentView.Width, 0, _sliderView.TransitionLength);
				break;
			}

			return error;
		}

		public void OnLongPress(MotionEvent e){}

		public bool OnScroll(MotionEvent e1, MotionEvent e2, float distanceX, float distanceY)
		{
			return false;
		}

		public void OnShowPress(MotionEvent e){}
		public bool OnSingleTapUp(MotionEvent e)
		{
			return false;
		}
		public bool OnDown(MotionEvent e)
		{
			return true;
		}
	}
}