using Xamarin.Forms;

namespace SimpleUITestApp
{
	public static class StyleConstants
	{
		public static Style WhiteTextLabel = new Style(typeof(Label))
		{
			Setters = {
				new Setter {
					Property = Label.TextColorProperty, Value = Color.White
				}
			}
		};

		public static Style UnderlinedEntry = new Style(typeof(Entry))
		{
			Setters = {
				new Setter {
					Property = Entry.BackgroundColorProperty, Value = Color.Transparent
				},
				new Setter{
					Property = Entry.HeightRequestProperty, Value = 40
				},
				new Setter{
					Property = Entry.TextColorProperty, Value = Color.White
				},
				new Setter{
					Property = Entry.PlaceholderColorProperty, Value = Color.White
				}
			}
		};

		public static Style BorderedButton = new Style(typeof(Button))
		{
			Setters = {
				new Setter {
					Property = Button.BorderRadiusProperty, Value = 3
				},
				new Setter{
					Property = Button.TextColorProperty, Value = Color.White
				},
				new Setter{
					Property = Button.BorderColorProperty, Value = Color.White
				},
				new Setter{
					Property = Button.BorderWidthProperty, Value = 1
				}
			}
		};
	}
}

