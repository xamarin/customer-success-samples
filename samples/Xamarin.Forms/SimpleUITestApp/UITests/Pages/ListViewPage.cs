using System;

using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SimpleUITestApp.UITests
{
	public class ListViewPage : BasePage
	{
		public ListViewPage(IApp app, Platform platform) : base (app, platform)
		{
		}

		public void TapListItemNumber(int ListItemNumber)
		{
			app.ScrollDownTo (ListItemNumber.ToString ());
			app.Tap (x => x.Marked (ListItemNumber.ToString ()));
			app.WaitForElement ("OK");
			app.Tap ("OK");
		}
	}
}

