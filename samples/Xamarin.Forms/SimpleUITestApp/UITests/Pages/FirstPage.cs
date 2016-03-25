using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace SimpleUITestApp.UITests
{
	public class FirstPage : BasePage
	{
		protected readonly Query GoButton;
		protected readonly Query EntryField;
		protected readonly Query LabelField;
		protected readonly Query ListViewButton;

		protected readonly Query GoButtonUsingID;
		protected readonly Query EntryFieldUsingID;
		protected readonly Query LabelFieldUsingID;
		protected readonly Query ListViewButtonUsingID;
		protected readonly Query ActivityIndicatorUsingID;

		public FirstPage(IApp app, Platform platform) : base(app, platform)
		{
			GoButtonUsingID = x => x.Marked("MyGoButton");
			EntryFieldUsingID = x => x.Marked("MyEntry");
			LabelFieldUsingID = x => x.Marked("MyLabel");
			ListViewButtonUsingID = x => x.Marked("MyListViewButton");
			ActivityIndicatorUsingID = x => x.Marked("MyActivityIndicator");

			if (OnAndroid)
			{
				GoButton = x => x.Class("Button").Index(0);
				EntryField = x => x.Class("EntryEditText");
				ListViewButton = x => x.Class("Button").Index(1);
			}
			if (OniOS)
			{
				GoButton = x => x.Class("UIButton").Index(0);
				EntryField = x => x.Class("UITextField");
				ListViewButton = x => x.Class("UIButton").Index(1);
			}
		}

		public void EnterText(string text)
		{
			app.Tap(EntryField);
			app.ClearText();
			app.ClearText();
			app.EnterText(text);
		}

		public void ClickGo()
		{
			app.Tap(GoButton);
		}

		public void EnterTextByID(string text)
		{
			app.Tap(EntryFieldUsingID);
			app.ClearText();
			app.ClearText();
			app.EnterText(text);
		}

		public void ClickGoByID()
		{
			app.Tap(GoButtonUsingID);
		}

		public void ClickListViewButton()
		{
			app.Tap(ListViewButton);
		}

		public void ClickListViewButtonByID()
		{
			app.Tap(ListViewButtonUsingID);
		}

		public void WaitForNoActivityIndicator()
		{
			app.WaitForNoElement(ActivityIndicatorUsingID);
		}

		public void RotateScreenToLandscape()
		{
			app.SetOrientationLandscape();
		}

		public void RotateScreenToPortrait()
		{
			app.SetOrientationPortrait();
		}
	}
}

