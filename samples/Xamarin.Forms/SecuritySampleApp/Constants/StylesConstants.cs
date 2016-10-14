using Xamarin.Forms;

namespace SecuritySampleApp
{
	//This class creates Styles Constants to be reused in the app
	public static class StylesConstants
	{
		public static Style LabelStyle = new Style(typeof(Label))
		{
			Setters = {
				new Setter { Property = Label.HorizontalOptionsProperty, Value = LayoutOptions.Center},
				new Setter { Property = Label.BackgroundColorProperty, Value = Color.Transparent}
			}
		};
		public static Style ButtonStyle = new Style(typeof(Label))
		{
			Setters = {
				new Setter { Property = Button.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
				new Setter { Property = Button.BackgroundColorProperty, Value = Color.Transparent}
			}
		};
		public static Style ImageStyle = new Style(typeof(Label))
		{
			Setters = {
				new Setter { Property = Button.BackgroundColorProperty, Value = Color.Transparent}
			}
		};
		public static Style StackLayoutStyle = new Style(typeof(Label))
		{
			Setters = {
				new Setter { Property = StackLayout.HorizontalOptionsProperty, Value = LayoutOptions.CenterAndExpand},
				new Setter { Property = StackLayout.VerticalOptionsProperty, Value = LayoutOptions.CenterAndExpand}
			}
		};
	}
}

