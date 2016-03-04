using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITestApp.UITests
{
	public class Tests : SetupTest
	{

		public Tests (Platform platform) : base (platform)
		{
			this.platform = platform;
		}

		[Test]
		public void EnterText ()
		{
			new FirstPage (app, platform)
				.EnterText ("Hello World");
			new FirstPage (app, platform)
				.ClickGo ();
			new FirstPage (app, platform)
				.WaitForNoActivityIndicator ();
		}

		[Test]
		public void EnterTextByID ()
		{
			new FirstPage (app, platform)
				.EnterTextByID ("I used IDs to Enter this Text!");
			new FirstPage (app, platform)
				.ClickGoByID ();
			new FirstPage (app, platform)
				.WaitForNoActivityIndicator ();
		}

		[Test]
		public void SelectItemOnListView ()
		{
			new FirstPage (app, platform)
				.ClickListViewButton ();
			new ListViewPage (app, platform)
				.TapListItemNumber (9);
		}

		[Test]
		public void SelectItemOnListViewByID ()
		{
			new FirstPage (app, platform)
				.ClickListViewButtonByID ();
			new ListViewPage (app, platform)
				.TapListItemNumber (9);
		}
	}
}

