using System;

using Xamarin.Forms;

namespace SimpleUITestApp
{
	public static class Extensions
	{
		public const string BaseUrl = "http://simplueuitestapp.minnick.com/session/";

		public static AppLinkEntry CreateAppLink(string title, string description, string id, string iconName = "")
		{
			var url = $"{BaseUrl}{id}";

			var entry = new AppLinkEntry
			{
				Title = title,
				Description = description,
				AppLinkUri = new Uri(url, UriKind.RelativeOrAbsolute),
				IsLinkActive = true
			};

			if (iconName != "" && Device.OS == TargetPlatform.iOS)
				entry.Thumbnail = ImageSource.FromFile(iconName);

			entry.KeyValues.Add("contentType", "Session");
			entry.KeyValues.Add("appName", "SimpleUITestApp");
			entry.KeyValues.Add("companyName", "Minnick");

			return entry;
		}
	}
}

