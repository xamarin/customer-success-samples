using System;

using Xamarin.Forms;

namespace InvestmentDataSampleApp
{
	public class App : Application
	{
		static OpportunityModelDatabase database;

		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new OpportunitiesPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
		public static OpportunityModelDatabase Database
		{
			get
			{
				if (database == null)
				{
					database = new OpportunityModelDatabase();
				}
				return database;
			}
		}
	}
}

