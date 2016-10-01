using System;

using NUnit.Framework;

using Xamarin.UITest;

namespace InvestmentDataSampleApp.UITests
{
	public abstract class TestSetUp
	{
		protected IApp App;
		protected Platform Platform;

		protected OpportunitiesPage OpportunitiesPage;
		protected AddOpportunityPage AddOpportunityPage;
		protected TermsPage TermsPage;

		protected TestSetUp(Platform platform)
		{
			Platform = platform;
		}

		[SetUp]
		public virtual void TestSetup()
		{
			App = AppInitializer.StartApp(Platform);

			OpportunitiesPage = new OpportunitiesPage(App, Platform);
			AddOpportunityPage = new AddOpportunityPage(App, Platform);
			TermsPage = new TermsPage(App, Platform);
		}
	}

}
