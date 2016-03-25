using NUnit.Framework;

using Xamarin.UITest;

namespace SimpleUITestApp.UITests
{
	public class Tests : AbstractSetup
	{

		public Tests(Platform platform) : base(platform)
		{
			this.platform = platform;
		}

		[Test]
		public void EnterText()
		{
			new FirstPage(app, platform)
				.EnterText("Hello World");
			new FirstPage(app, platform)
				.ClickGo();
			new FirstPage(app, platform)
				.WaitForNoActivityIndicator();
		}

		[Test]
		public void EnterTextByID()
		{
			new FirstPage(app, platform)
				.EnterTextByID("I used IDs to Enter this Text!");
			new FirstPage(app, platform)
				.ClickGoByID();
			new FirstPage(app, platform)
				.WaitForNoActivityIndicator();
		}

		[Test]
		public void SelectItemOnListView()
		{
			new FirstPage(app, platform)
				.ClickListViewButton();
			new ListViewPage(app, platform)
				.TapListItemNumber(9);
		}

		[Test]
		public void SelectItemOnListViewByID()
		{
			new FirstPage(app, platform)
				.ClickListViewButtonByID();
			new ListViewPage(app, platform)
				.TapListItemNumber(9);
		}

		[Test]
		public void RotateScreenAndEnterTextByID()
		{
			new FirstPage(app, platform)
				.RotateScreenToLandscape();
			new FirstPage(app, platform)
				.EnterText("The Screen Orientation Is Landscape");
			new FirstPage(app, platform)
				.ClickGoByID();
			new FirstPage(app, platform)
				.WaitForNoActivityIndicator();
			new FirstPage(app, platform)
				.RotateScreenToPortrait();
			new FirstPage(app, platform)
				.EnterText("The Screen Orientation Is Portrait");
			new FirstPage(app, platform)
				.ClickGoByID();
			new FirstPage(app, platform)
				.WaitForNoActivityIndicator();
		}
	}
}

