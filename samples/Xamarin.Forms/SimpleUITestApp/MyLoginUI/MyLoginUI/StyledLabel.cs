using Xamarin.Forms;

namespace MyLoginUI
{
	public class StyledLabel : Label
	{
		public StyledLabel()
		{
			TextColor = Color.White;
			FontFamily = Device.OnPlatform(
				iOS: "AppleSDGothicNeo-Light",
				Android: "Droid Sans Mono",
				WinPhone: "Comic Sans MS");
			FontSize = 14;
		}
	}
}

