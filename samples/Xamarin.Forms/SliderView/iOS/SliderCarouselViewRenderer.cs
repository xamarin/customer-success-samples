using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using PCL;
using Slider.iOS;

using UIKit;
using System.Threading.Tasks;
using System.Threading;

[assembly:ExportRenderer(typeof(SliderView),typeof(SliderCarouselViewRenderer))]

namespace Slider.iOS
{
	public class SliderCarouselViewRenderer : ViewRenderer
	{
		//Create a holder for the SliderView to be used in the Renderer
		SliderView _sliderView;

		//Start off at the index of 0 in views
		int currentViewIndex = 0;

		//Create a holder for the swipe gesture recognizer
		UISwipeGestureRecognizer rightGesture, leftGesture;

		protected override void OnElementChanged (ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged (e);
			//If the NewElement has been queued up
			if (e.NewElement != null) {
				//Set SliderView Instance
				_sliderView = e.NewElement as SliderView;
				//Make the currentView the same dimensions of the SliderView
				_sliderView.Children [currentViewIndex].HeightRequest = _sliderView.Height;
				_sliderView.Children [currentViewIndex].WidthRequest = _sliderView.Width;
				//This is an optional thing, really depends on how you want to use this SliderView
				_sliderView.Children [currentViewIndex].BackgroundColor = _sliderView.BackgroundColor;
			}

			//Create the gesture that brings the view in from the right side
			rightGesture = new UISwipeGestureRecognizer (swipe => {
				Console.WriteLine("Swipe Left");
				//Check to make sure we aren't on the current view
				if (_sliderView.Children.Count > currentViewIndex + 1 ) {
					//Add one to the index
					currentViewIndex++;

					_sliderView.CurrentView = _sliderView.Children [currentViewIndex];
					_sliderView.CurrentView.HeightRequest = _sliderView.Height;
					_sliderView.CurrentView.WidthRequest = _sliderView.Width;
					_sliderView.CurrentView.BackgroundColor = _sliderView.BackgroundColor;

					//Translate the CurrentView onto the ViewScreen
					TranslateToCurrentView ("Left");
				}
			}) {
				Direction = UISwipeGestureRecognizerDirection.Left
			};

			//Create the gesture that brings the view in from the left side
			leftGesture = new UISwipeGestureRecognizer (swipe => {
				//Check to make sure we aren't at the first view
				if (currentViewIndex != 0) {
					//Drop the index one
					currentViewIndex--;

					//Set the new CurrentView
					_sliderView.CurrentView = _sliderView.Children [currentViewIndex];
					//Set the size of the CurrentView to the size of the SliderView
					_sliderView.CurrentView.HeightRequest = _sliderView.Height;
					_sliderView.CurrentView.WidthRequest = _sliderView.Width;
					//This is an optional thing, really depends on how you want to use this SliderView
					_sliderView.CurrentView.BackgroundColor = _sliderView.BackgroundColor;

					//Translate the CurrentView onto the ViewScreen
					TranslateToCurrentView ("Right");
				}
			}) {
				Direction = UISwipeGestureRecognizerDirection.Right
			};

			//Add the Gesture Recognizers to the SliderView
			AddGestureRecognizer (rightGesture);
			AddGestureRecognizer (leftGesture);
		}

		protected override void Dispose (bool disposing)
		{
			//Remove the Gesture Recognizers and dispose of them
			RemoveGestureRecognizer (rightGesture);
			RemoveGestureRecognizer (leftGesture);
			leftGesture.Dispose ();
			rightGesture.Dispose ();
		}

		public async void TranslateToCurrentView(string direction)
		{
			//Create the initial layout for Translation property
			Rectangle initialLayoutRect = new Rectangle (
				0,
				0,
				_sliderView.Width, 
				_sliderView.Height
			);

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
				if (dot.StyleId == currentViewIndex.ToString ())
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
				await _sliderView.CurrentView.TranslateTo (_sliderView.ParentView.Width , 0, _sliderView.TransitionLength);
				//Remove the old view from the back of the ViewScreen
				_sliderView.ViewScreen.Children.Remove (_sliderView.Children [currentViewIndex + 1]);
			
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
				await _sliderView.CurrentView.TranslateTo (-_sliderView.ParentView.Width , 0, _sliderView.TransitionLength);
				//Remove the old view from the back of the ViewScreen
				_sliderView.ViewScreen.Children.Remove (_sliderView.Children [currentViewIndex - 1]);

				break;
			}
		}
//		You would want to use what is below if you are trying to implement the MinimumSwipeDistance on iOS side
//		I didn't want to do this because I don't think the length in swipe matters this much.
//		I did it for Android because it was so easy ;)
//
//		void panGesture(UIPanGestureRecognizer gestureRecognizer) {
//			if (gestureRecognizer.State == UIGestureRecognizerState.Began) {
//				startLocation = gestureRecognizer.TranslationInView (view)
//			} else if (gestureRecognizer.State == UIGestureRecognizerState.Ended) {
//				PointF stopLocation = gestureRecognizer.TranslationInView (view);
//				float dX = stopLocation.X - startLocation.X;
//				float dY = stopLocation.Y - startLocation.Y;
//				float distance = Math.Sqrt(dX * dX + dY * dY);
//				System.Console.WriteLine("Distance: {0}", distance);
//			}
//		}
	}
}