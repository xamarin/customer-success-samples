using System;
using Xamarin.UITest;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace InvestmentDataSampleApp.UITests
{
	public class OpportunitiesPage : BasePage
	{
		readonly Query AddOpportunityButton;
		readonly Query OpportunitySearchBar;

		public OpportunitiesPage(IApp app, Platform platform) : base(app, platform)
		{
			AddOpportunityButton = x => x.Marked(AutomationIdConstants.AddOpportunityButton);
			OpportunitySearchBar = x => x.Marked(AutomationIdConstants.OpportunitySearchBar);
		}

		public void TapAddOpportunityButton()
		{
			if (OniOS)
				app.Tap(AddOpportunityButton);
			else
				app.Tap(x => x.Class("ActionMenuItemView"));
			app.Screenshot("Tapped Add Opportunity Button");
		}

		public void TapOpportunityViewCell(string topic)
		{
			app.ScrollDownTo(topic);
			app.Tap(topic);
			app.Screenshot($"Tapped ${topic} View Cell");
		}

		public void Search(string searchString)
		{
			app.Tap(OpportunitySearchBar);
			app.EnterText(searchString);
			app.DismissKeyboard();
			app.Screenshot($"Entered {searchString} into Search Bar");
		}

		public bool DoesViewCellExist(string topic)
		{
			try
			{
				app.ScrollDownTo(topic);
			}
			catch (Exception e)
			{
				return false;
			}

			return true;
		}
	}
}
