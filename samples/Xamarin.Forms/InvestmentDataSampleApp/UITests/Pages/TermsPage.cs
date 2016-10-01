using Xamarin.UITest;
using Xamarin.UITest.Queries;

using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace InvestmentDataSampleApp.UITests
{
	public class TermsPage : BasePage
	{
		readonly Query PageNumberLabel;

		public TermsPage(IApp app, Platform platform) : base(app,platform)
		{
			PageNumberLabel = x => x.Marked(AutomationIdConstants.PageNumberLabel);
		}

		public void WaitForTermsPageToAppear()
		{
			app.WaitForElement(PageNumberLabel);
		}

		public string GetTitle()
		{
			var title = "Terms Page";
			AppResult[] titleQuery;

			app.WaitForElement(title);

			if (OniOS)
				titleQuery = app.Query(x => x.Class("UILabel").Marked(title));
			else
				titleQuery = app.Query(x => x.Class("TextView").Marked(title));

			return titleQuery[0]?.Text;
		}
	}
}
