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
	public class SliderViewRenderer : ViewRenderer <SliderView,AndroidView>
	{
		//Create a listener and detector for the gestures
		private readonly GesutreListener _listener;
		private readonly GestureDetector _detector;

		//Create two x points to find out if the swipe was to the left or to the right
		private float x1,x2;

		//Create a holder for the SliderView to be used in the Renderer
		SliderView _sliderView;

		//Start off at the index of 0 in views
		int currentViewIndex = 0;

		public SliderViewRenderer ()
		{
			//Contruct the listener and detector
			_listener = new GesutreListener();
			_detector = new GestureDetector (_listener);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<SliderView> e)
		{
			base.OnElementChanged (e);

			//Assign the Touch event of the SliderView
			if (e.OldElement == null) {
				this.Touch += HandleGenericMotion;
				//set instance of the current SliderView
				_sliderView = (PCL.SliderView)e.NewElement;
			}
		}

		protected override void Dispose (bool disposing)
		{
			//If CurrentView is a Layout, then we need to remove the Touch event
			if (_sliderView.CurrentView is Layout) {
				//This viewgroup contains the ViewScreen that we need to get at child 0
				ViewGroup view = (ViewGroup)this.ViewGroup.GetChildAt (0);
				//view contains the Layout that is in the ViewScreen at child 0
				Android.Views.View currentLayout = (ViewGroup)view.GetChildAt (0);
				//Remove touch event
				currentLayout.Touch -= HandleGenericMotion;
			}
			//When disposing, remove the gesture detector
			Touch -= HandleGenericMotion;
			//Call the garbage collection to make sure the BitMaps are cleaned up
			GC.Collect ();
            base.Dispose(disposing);
        }

		async void HandleGenericMotion (object sender, TouchEventArgs e)
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
				if (Math.Abs (delta) > _sliderView.MinimumSwipeDistance) {
					if (delta > 0) {
						Console.WriteLine ("Swipe to the Right");
						//Check to make sure we aren't at the first view
						if (currentViewIndex != 0) {
							//Drop the index one
							currentViewIndex--;
							//Set the new CurrentView
							_sliderView.CurrentView = _sliderView.Children [currentViewIndex];
							//Now add and wait for the view to translate in. Important to use await so the view is translated prior to removing the old view
							bool loading = await TranslateToCurrentViewAsync ("Right");

							//If the view is a layout, we need to remove the touch even
							if (_sliderView.Children [currentViewIndex + 1] is Layout) {
								//This viewgroup contains the ViewScreen that we need to get at child 0
								ViewGroup view = (ViewGroup)this.ViewGroup.GetChildAt (0);
								//view contains the Layout that is in the ViewScreen at child 0
								Android.Views.View currentLayout = (ViewGroup)view.GetChildAt (0);
								//Remove touch event
								currentLayout.Touch -= HandleGenericMotion;
							}
							//Remove the old view from the back of the ViewScreen
							_sliderView.ViewScreen.Children.Remove (_sliderView.Children [currentViewIndex + 1]);
						}
					} else if (delta < 0) {
						Console.WriteLine ("Swipe to the Left");
						//Check to make sure we aren't on the current view
						if (_sliderView.Children.Count > currentViewIndex + 1) {
							//Add one to the index
							currentViewIndex++;
							//Set the new CurrentView
							_sliderView.CurrentView = _sliderView.Children [currentViewIndex];
							//Now add and wait for the view to translate in. Important to use await so the view is translated prior to removing the old view
							bool loading = await TranslateToCurrentViewAsync("Left");

							//If the view is a layout, we need to remove the touch even so there are no memory leaks
							if (_sliderView.Children [currentViewIndex - 1] is Layout) {
								//This viewgroup contains the ViewScreen that we need to get at child 0
								ViewGroup view = (ViewGroup)this.ViewGroup.GetChildAt (0);
								//view contains the Layout that is in the ViewScreen at child 0
								Android.Views.View currentLayout = (ViewGroup)view.GetChildAt (0);
								//Remove touch event
								currentLayout.Touch -= HandleGenericMotion;
							}
							//Remove the old view from the back of the ViewScreen
							_sliderView.ViewScreen.Children.Remove (_sliderView.Children [currentViewIndex - 1]);
						}
					}
				}
				break;
			}
		}

		public async Task<bool> TranslateToCurrentViewAsync(string direction)
		{
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

			//Calculate the rectangle that will be used for the new dot layout
			Rectangle dotRect = new Rectangle (
				x: _sliderView.ViewScreen.Width / 2 - (_sliderView.DotStack.Children.Count * 15) / 2,
				y: _sliderView.ViewScreen.Height - 15,
				width: _sliderView.DotStack.Children.Count * 15,
				height: 10
			);

			//Remove and update the dot Layout
			_sliderView.ViewScreen.Children.Remove (_sliderView.DotStack);
			_sliderView.UpdateDots ();

			//Make sure the opacity is 0.5 for all of the dots and 1 for the current view
			foreach (Button dot in _sliderView.DotStack.Children) {
				dot.Opacity = 0.5;
				if(dot.StyleId == currentViewIndex.ToString())
					dot.Opacity = 1;
			}

			//Depending on the swiping direction...
			switch (direction) {
			case "Right":
				//Set the X value of the new CurrentView. 
				//SliderView was designed to take up the entire width of the page so the layout will be off screen to the left
				initialLayoutRect.X = -_sliderView.ParentView.Width;

				//Add the CurrentView to the ViewScreen, but it is still off screen
				_sliderView.ViewScreen.Children.Add (_sliderView.CurrentView, initialLayoutRect);
				//Add the dotLayout after the current view to make sure it is visible
				_sliderView.ViewScreen.Children.Add (_sliderView.DotStack, dotRect);

				//Translate the currentview into ViewScreen. CurrentView is now on screen
				error = await _sliderView.CurrentView.TranslateTo (_sliderView.ParentView.Width, 0, _sliderView.TransitionLength);
				break;
			case "Left":
				//Set the X value of the new CurrentView. 
				//SliderView was designed to take up the entire width of the page so the layout will be off screen to the right
				initialLayoutRect.X = _sliderView.ParentView.Width;

				//Add the CurrentView to the ViewScreen, but it is still off screen
				_sliderView.ViewScreen.Children.Add (_sliderView.CurrentView, initialLayoutRect);
				//Add the dotLayout after the current view to make sure it is visible
				_sliderView.ViewScreen.Children.Add (_sliderView.DotStack, dotRect);

				//Translate the currentview into ViewScreen. CurrentView is now on screen
				error = await _sliderView.CurrentView.TranslateTo (-_sliderView.ParentView.Width , 0, _sliderView.TransitionLength);
				break;
			}

			//If the CurrentView is a Layout, we need to add the same Touch event to this
			//We need to do this because the Layout covers up the Touch even on the ViewScreen
			//Don't worry, we also remove this event handler if the old currentView is a Layout so there is no memory leaks
			if (_sliderView.CurrentView is Layout) {
				ViewGroup view = (ViewGroup)this.ViewGroup.GetChildAt (0);
				Android.Views.View currentLayout = (ViewGroup)view.GetChildAt (1);
				currentLayout.Touch += HandleGenericMotion;
			}

			return error;
		}
	}
}