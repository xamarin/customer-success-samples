using System;

using Xamarin.Forms;

namespace StyledAlertDialogs 
{
	public class RootPage : ContentPage
	{
		Button button;

		public RootPage ()
		{
			button = new Button {
				Text = "Click Me"
			};

			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					button
				}
			};
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing ();

			button.Clicked += Button_Clicked;
		}

		void Button_Clicked (object sender, EventArgs e)
		{
			AlertArguments arg = new AlertArguments { 
				Title = "Title",
				Message = "Everything is customized!!",
				Accept = "Ok",
				Cancel = "Cancel"
			};

			MessagingCenter.Send (this, "DisplayAlert",arg);
		}			
	}
}