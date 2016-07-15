using System;

using MyLoginUI.iOS.Renderers;

namespace MyLoginUI.iOS
{
	public class LoginUIExtension
	{
		public static void Init()
		{
			new StyledEntryRenderer ();
		}
	}
}