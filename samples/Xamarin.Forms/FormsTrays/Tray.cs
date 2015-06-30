using System;

using Xamarin.Forms;

namespace FormsTrays
{
    public class Tray : ContentView
    {
		public Tray(TrayOrientation orientation, double percentOfScreen) {
			if (percentOfScreen > 1 || percentOfScreen < 0)
				throw new Exception ("The percent of screen must be a value between 0 and 1. For example:" +
					"0.8 would be 80% of the screen size");

			Orientation = orientation;
			PercentOfScreen = percentOfScreen;

			if (Orientation == TrayOrientation.Top || Orientation == TrayOrientation.Bottom) {
				HeightRequest = App.ScreenHeight * PercentOfScreen;
				WidthRequest = App.ScreenWidth;
			} else if (Orientation == TrayOrientation.Left || Orientation == TrayOrientation.Right){
				HeightRequest = App.ScreenHeight;
				WidthRequest = App.ScreenWidth * PercentOfScreen;
			}

			IsOpen = false;
		}

        public static readonly BindableProperty OrientationProperty = BindableProperty.Create<Tray, TrayOrientation>(
            x => x.Orientation,
            TrayOrientation.Left,
            BindingMode.OneWay);

        public TrayOrientation Orientation
        {
            get { return (TrayOrientation)this.GetValue(OrientationProperty); }
            set { this.SetValue(OrientationProperty, value); }
        }

		public bool IsOpen { get; set; }
		public double PercentOfScreen { get; set; }
		public uint AnimationLength { get; set; } = 250;

		private double x, y;

        public void Open()
        {
			if (!IsOpen) {
				GetTranslations ();
				this.TranslateTo (x, y, AnimationLength);
				IsOpen = true;
			}

        }

        public void Close()
		{
			if (IsOpen) {
				GetTranslations ();
				this.TranslateTo (-x, -y, AnimationLength);
				IsOpen = false;
			} 
		}

		private void GetTranslations()
		{
			switch (Orientation)
			{
			case TrayOrientation.Left:
				x = App.ScreenWidth * PercentOfScreen;
				y = 0;
				break;
			case TrayOrientation.Right:
				x = - App.ScreenWidth * PercentOfScreen;
				y = 0;
				break;
			case TrayOrientation.Top:
				x = 0;
				y = App.ScreenHeight * PercentOfScreen;
				break;
			case TrayOrientation.Bottom:
				x = 0;
				y = -App.ScreenHeight * PercentOfScreen;
				break;
			}
		}
    }
}