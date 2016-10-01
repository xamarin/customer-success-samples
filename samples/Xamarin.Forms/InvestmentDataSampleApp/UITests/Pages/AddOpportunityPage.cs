using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace InvestmentDataSampleApp.UITests
{
	public class AddOpportunityPage : BasePage
	{
		const int _entryCellXOffset = 200;

		readonly Query TopicEntry;
		readonly Query CompanyEntry;
		readonly Query LeaseAmountEntry;
		readonly Query OwnerEntry;
		readonly Query DBAEntry;

		readonly Query SaveButton;
		readonly Query CancelButton;

		public AddOpportunityPage(IApp app, Platform platform) : base(app, platform)
		{
			TopicEntry = x => x.Marked(AutomationIdConstants.TopicEntry);
			CompanyEntry = x => x.Marked(AutomationIdConstants.CompanyEntry);
			LeaseAmountEntry = x => x.Marked(AutomationIdConstants.LeaseAmountEntry);
			OwnerEntry = x => x.Marked(AutomationIdConstants.OwnerEntry);
			DBAEntry = x => x.Marked(AutomationIdConstants.DBAEntry);

			SaveButton = x => x.Marked(AutomationIdConstants.SaveButton);
			CancelButton = x => x.Marked(AutomationIdConstants.CancelButton);
		}

		public void EnterTopicText(string topicText)
		{
			var topicEntryXCoordinate = app.Query(TopicEntry)[0].Rect.CenterX;
			var topicEntryYCoordinate = app.Query(TopicEntry)[0].Rect.CenterY;

			app.TapCoordinates(topicEntryXCoordinate + _entryCellXOffset, topicEntryYCoordinate);
			app.EnterText(topicText);
			app.DismissKeyboard();
			app.Screenshot($"Entered {topicText} into Topic Entry");
		}

		public void EnterCompanyText(string companyText)
		{
			var companyEntryXCoordinate = app.Query(CompanyEntry)[0].Rect.CenterX;
			var companyEntryYCoordinate = app.Query(CompanyEntry)[0].Rect.CenterY;

			app.TapCoordinates(companyEntryXCoordinate + _entryCellXOffset, companyEntryYCoordinate);
			app.EnterText(companyText);
			app.DismissKeyboard();
			app.Screenshot($"Entered {companyText} into Company Entry");
		}

		public void EnterLeaseAmountText(int leaseText)
		{
			var leaseAmountEntryXCoordinate = app.Query(LeaseAmountEntry)[0].Rect.CenterX;
			var leaseAmountEntryYCoordinate = app.Query(LeaseAmountEntry)[0].Rect.CenterY;

			app.TapCoordinates(leaseAmountEntryXCoordinate + _entryCellXOffset, leaseAmountEntryYCoordinate);
			app.EnterText(leaseText.ToString());
			app.DismissKeyboard();
			app.Screenshot($"Entered {leaseText} into Lease Amount Entry");
		}

		public void EnterOwnerText(string ownerText)
		{
			var ownerEntryXCoordinate = app.Query(OwnerEntry)[0].Rect.CenterX;
			var ownerEntryYCoordinate = app.Query(OwnerEntry)[0].Rect.CenterY;

			app.TapCoordinates(ownerEntryXCoordinate + _entryCellXOffset, ownerEntryYCoordinate);
			app.EnterText(ownerText);
			app.DismissKeyboard();
			app.Screenshot($"Entered {ownerText} into Owner Entry");
		}

		public void EnterDBAText(string dbaText)
		{
			var dbaEntryXCoordinate = app.Query(DBAEntry)[0].Rect.CenterX;
			var dbaEntryYCoordinate = app.Query(DBAEntry)[0].Rect.CenterY;

			app.TapCoordinates(dbaEntryXCoordinate + _entryCellXOffset, dbaEntryYCoordinate);
			app.EnterText(dbaText);
			app.DismissKeyboard();
			app.Screenshot($"Entered {dbaText} into DBA Entry");
		}

		public void PopulateAllFields(string topicText, string companyText, int leaseAmount, string ownerText, string dbaText)
		{
			EnterTopicText(topicText);
			EnterCompanyText(companyText);
			EnterLeaseAmountText(leaseAmount);
			EnterOwnerText(ownerText);
			EnterDBAText(dbaText);
		}

		public void TapSaveButton()
		{
			if (OniOS)
				app.Tap(SaveButton);
			else
				app.Tap(x => x.Marked("Save"));

			app.Screenshot("Tapped Save Button");
		}

		public void TapCancelButton()
		{
			if (OniOS)
				app.Tap(CancelButton);
			else
				app.Tap(x => x.Marked("Cancel"));

			app.Screenshot("Tapped Cancel Button");
		}
	}
}
