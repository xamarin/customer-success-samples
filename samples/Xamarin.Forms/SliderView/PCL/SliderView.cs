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

			Rectangle dotRect = new Rectangle (
				x: _width/2 - (15)/2,
				y: _height - 15,
				width: 15,
				height: 10
			);

			//Layout the current view to the ViewScreen
			ViewScreen.Children.Add (_currentView, new Rectangle (0, 0, width, height));
			//Layout the dotLayout to the ViewScreen. This must be done AFTER the current view is added so the dots are on the top level
			ViewScreen.Children.Add (dotLayout, dotRect);

			//Set the content of the ContentView to the ViewScreen	
			Content = ViewScreen;
		}

		void Children_CollectionChanged (object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			UpdateDots ();
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

		public uint TransitionLength {
			get;
			set;
		}

		public void UpdateDots()
		{
			//Calculate how many dots need to be addded. This should always be 1 or -1
			var dotsToAdd = Children.Count - dotCount;

			//If we don't need to add any dots, stop doing this!!!!
			if (dotsToAdd == 0)
				return;

			//Depending on whether we need to add or subtract a dot
			switch (dotsToAdd.ToString()){
			//Add a dot
			case "1":
				Button whiteDot = new Button {
					BorderRadius = 5,
					HeightRequest = 10,
					WidthRequest = 10,
					StyleId = (dotCount).ToString (),
					BackgroundColor = Color.White,
					Opacity = 0.5,
				};
				dotLayout.Children.Add (whiteDot);
				dotCount++;
				break;
			//Remove a dot
			case "-1":
				dotLayout.Children.RemoveAt (dotLayout.Children.Count - 1);
				dotCount--;
				break;
			}

			//Remove and add the dotLayout to recalculate how it should be laid out
			Rectangle dotRect = new Rectangle (
				x: _width/2 - (dotCount * 15)/2,
				y: _height - 15,
				width: dotCount * 15,
				height: 10
			);
			ViewScreen.Children.Remove (dotLayout);
			ViewScreen.Children.Add (dotLayout, dotRect);
		}
	}
}