using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

using Xamarin.Forms;

namespace PCL
{
	public class SliderView : ContentView
	{
		View _currentView;
		StackLayout dotLayout;
		double _height, _width;
		int dotCount = 1;

		public SliderView (View rootview, double height, double width) 
		{
			CurrentViewInt = 0;
			IsInitialized = false;
			//Set the height and width to be used throughout the SLiderView
			_height = height;
			_width = width;

			//Set the current view to the view that was initialized
			_currentView = rootview;

			//Create the ObservableCollection for the Children property
			Children = new ObservableCollection<View> ();
			Children.Insert (0, _currentView);

			//Create the ViewScreen that will schol the current layout.
			ViewScreen = new AbsoluteLayout {
				HeightRequest = _height,
				WidthRequest = _width,
			};

			//Create a StackLayout for the little white dots that will be at the boom of the slider
			dotLayout = new StackLayout {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.Center,
				Orientation = StackOrientation.Horizontal,
			};

			//Make one button and add it to the dotLayout
			Button whiteDot = new Button {
				BorderRadius = 5,
				HeightRequest = 10,
				WidthRequest = 10,
				StyleId = 0.ToString(),
				BackgroundColor = Color.White
			};
			dotLayout.Children.Add (whiteDot);

			//Add ObservableCollection CollectionChanged event to update the little white dots as children are added and removed
			Children.CollectionChanged += Children_CollectionChanged;

			//Layout the current view to the ViewScreen
			ViewScreen.Children.Add (_currentView, new Rectangle (0, 0, width, height));

			//Set the content of the ContentView to the ViewScreen	
			Content = ViewScreen;
		}

		private int _currentViewIndex;
		public int CurrentViewInt {
			get {
				return _currentViewIndex;
			}
			set {
				_currentViewIndex = value;
			}
		}

		void Children_CollectionChanged (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (ViewScreen.Children.Contains (DotStack))
				ViewScreen.Children.Remove (DotStack);

			UpdateDots (Children.Count - DotStack.Children.Count);

			if (IsInitialized)
				AddDotLayoutToViewScreen ();
		}

		//This property only work on Android. iOS does not have this property to swipe
		//If you want this property to work on iOS, you need to implement a UIPanGestureRecognizer to get the swipe lengths
		//See the SliderViewRenderer on the iOS side to panGesture. It is commented out, but shows the idea of how to get the swipe distances
		public int MinimumSwipeDistance {
			get;
			set;
		}

		public AbsoluteLayout ViewScreen {
			get;
			set;
		}

		public ObservableCollection<View> Children {
			get;
			set;
		}

		public View CurrentView {
			get;
			set;
		}

		public StackLayout DotStack {
			get {
				return dotLayout;
			}
		}

		public bool IsInitialized {get;set;} = false;

		public uint TransitionLength {
			get;
			set;
		}

		public void RefreshDotOpacity() {
			foreach (Button dot in DotStack.Children) {
				dot.Opacity = 0.5;
			}
			DotStack.Children [CurrentViewInt].Opacity = 1;
		}

		public void AddDotLayoutToViewScreen() {
			if(!ViewScreen.Children.Contains(DotStack)){
				Rectangle dotRect = new Rectangle (
					x: _width / 2 - (DotStack.Children.Count * 15) / 2,
					y: _height - 15,
					width: DotStack.Children.Count * 15,
					height: 10
				);
				ViewScreen.Children.Add (DotStack, dotRect);
			}
		}

		public void RemoveDotLayoutFromViewScreen() {
			if (ViewScreen.Children.Contains (DotStack)) {
				ViewScreen.Children.Remove (DotStack);
			}
		}

		public void UpdateDots(int dotsToAdd)
		{
			//If we don't need to add any dots, stop doing this!!!!
			if (dotsToAdd == 0)
				return;

			if (dotsToAdd > 0) {
				for (var i = 0; i < dotsToAdd; i++) {
					dotLayout.Children.Add (
						new Button {
							BorderRadius = 5,
							HeightRequest = 10,
							WidthRequest = 10,
							StyleId = (dotCount).ToString (),
							BackgroundColor = Color.White,
							Opacity = 0.5,
						});
					dotCount++;
				}
			} else if (dotsToAdd < 0) {
				for (var i = 0; i < Math.Abs(dotsToAdd); i++) {
					dotLayout.Children.RemoveAt (dotLayout.Children.Count - 1);
					dotCount--;
				}
			}
		}
	}
}