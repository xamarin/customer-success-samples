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
			//Always initialize your UITest queries using "x.Marked" and referencing the UI ID
			//In Xamarin.Forms, you set the UI ID by setting the control's "AutomationId"
			//In Xamarin.Android, you set the UI ID by setting the control's "ContentDescription"
			//In Xamarin.iOS, you set the UI ID by setting the control's "AccessibilityIdentifiers"
			GoButtonUsingID = x => x.Marked("MyGoButton");
			EntryFieldUsingID = x => x.Marked("MyEntry");
			LabelFieldUsingID = x => x.Marked("MyLabel");
			ListViewButtonUsingID = x => x.Marked("MyListViewButton");
			ActivityIndicatorUsingID = x => x.Marked("MyActivityIndicator");

			//Below shows the improper way to initalize queries.
			//This code would break if a developer added a third button...
			//...to the screen and placed it above the "Go Button", because...
			//...the Go Button and the ListViewButton Index would change.
			if (OnAndroid)
			{
				GoButton = x => x.Class("AppCompatButton").Index(0);
				EntryField = x => x.Class("EntryEditText");
				ListViewButton = x => x.Class("AppCompatButton").Index(1);
			}
			else if (OniOS)
			{
				GoButton = x => x.Class("UIButton").Index(1);
				EntryField = x => x.Class("UITextField");
				ListViewButton = x => x.Class("UIButton").Index(0);
			}
		}

		public void EnterText(string text)
		{
			app.Tap(EntryField);
			app.ClearText();
			app.ClearText();
			app.EnterText(text);
			app.DismissKeyboard();
			app.Screenshot($"Enter Text, \"{text}\"");
		}

		public void EnterTextByID(string text)
		{
			app.Tap(EntryFieldUsingID);
			app.ClearText();
			app.ClearText();
			app.EnterText(text);
			app.DismissKeyboard();
			app.Screenshot($"Enter Text Using IDs, \"{text}\"");
		}

		public void ClickGo()
		{
			app.Tap(GoButton);
			app.Screenshot("Click Go Button");
		}

		public void ClickGoByID()
		{
			app.Tap(GoButtonUsingID);
			app.Screenshot("Click Go Button Using IDs");
		}

		public void ClickListViewButton()
		{
			app.Tap(ListViewButton);
			app.Screenshot("Click ListView Button");
		}

		public void ClickListViewButtonByID()
		{
			app.Tap(ListViewButtonUsingID);
			app.Screenshot("Click ListView Button Using IDs");
		}

		public void WaitForNoActivityIndicator()
		{
			app.WaitForNoElement(ActivityIndicatorUsingID);
			app.Screenshot("Activity Indicator Stopped Spinning");
		}

		public void RotateScreenToLandscape()
		{
			app.SetOrientationLandscape();
			app.Screenshot("Rotate Device to Landscape");
		}

		public void RotateScreenToPortrait()
		{
			app.SetOrientationPortrait();
			app.Screenshot("Rotate Device to Portrait");
		}

		public string GetEntryFieldText()
		{
			var entryFieldQuery = app.Query(EntryField);
			return entryFieldQuery[0]?.Text;
		}

		public string GetEntryFieldTextByID()
		{
			var entryFieldQuery = app.Query(EntryFieldUsingID);
			return entryFieldQuery[0]?.Text;
		}

		public string GetTitle()
		{
			var titleQuery = app.Query("First Page");
			return titleQuery[0]?.Text;
		}
	}
}

