using System;

using Xamarin.Forms;

namespace MyLoginUI.Views
{
	public enum Borders
	{
		None,
		Thin
	}

	public class StyledButton : Button
	{
		public StyledButton(Borders border, double opacity = 0)
		{
			BackgroundColor = Color.Transparent;
			TextColor = Color.White;
			FontSize = 18;
			Opacity = opacity;
			FontFamily = Device.OnPlatform(
				iOS: "AppleSDGothicNeo-Light",
				Android: "Droid Sans Mono",
				WinPhone: "Comic Sans MS"
			);

			switch (border)
			{
				case Borders.None:
					break;
				case Borders.Thin:
					BorderRadius = 3;
					BorderColor = Color.White;
					BorderWidth = 1;
					break;
			}
		}
	}
}