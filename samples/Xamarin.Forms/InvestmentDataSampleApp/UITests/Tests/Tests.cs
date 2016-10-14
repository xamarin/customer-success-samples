using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading.Tasks;

namespace InvestmentDataSampleApp.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests : BaseTest
	{
		public Tests(Platform platform) : base(platform)
		{
		}

		[Test]
		public void SmokeTest()
		{
			App.Screenshot("First screen.");
		}

		[TestCase("715022 / Investment Data Corp")]
		[Test]
		public void ViewOpportunity(string opportunityTopic)
		{
			//Arrange
			var title = "Terms Page";

			//Act
			OpportunitiesPage.TapOpportunityViewCell(opportunityTopic);
			TermsPage.WaitForTermsPageToAppear();

			//Assert
			Assert.IsTrue(TermsPage.GetTitle().Equals(title));
		}

		[TestCase("715022 / Investment Data Corp")]
		[Test]
		public async void DeleteOpportunity(string opportunityTopic)
		{
			//Arrange

			//Act
			OpportunitiesPage.DeleteViewCell(opportunityTopic);
			await Task.Delay(1000);

			//Assert
			Assert.IsFalse(OpportunitiesPage.DoesViewCellExist(opportunityTopic));
		}

		[Test]
		public void AddNewOpportunityEmptyFields()
		{
			//Arrange

			//Act
			OpportunitiesPage.TapAddOpportunityButton();

			AddOpportunityPage.TapSaveButton();

			//Assert
			Assert.IsTrue(App.Query("OK").Length > 0);
		}

		[Test]
		public void AddNewOpportunity()
		{
			//Arrange
			var topicText = "Test Topic";
			var companyText = "Test Company";
			var leaseAmount = 123456789;
			var ownerText = "Test Owner";
			var dbaText = "Test DBA";

			//Act
			OpportunitiesPage.TapAddOpportunityButton();

			AddOpportunityPage.PopulateAllFields(topicText, companyText, leaseAmount, ownerText, dbaText);
			AddOpportunityPage.TapSaveButton();

			OpportunitiesPage.TapOpportunityViewCell(topicText);

			TermsPage.WaitForTermsPageToAppear();

			//Assert
			Assert.IsTrue(TermsPage.GetTitle().Equals("Terms Page"));
		}

		[Test]
		public void CancelAddNewOpportunity()
		{
			//Arrange
			var topicText = "Test Topic";
			var companyText = "Test Company";
			var leaseAmount = 123456789;
			var ownerText = "Test Owner";
			var dbaText = "Test DBA";

			//Act
			OpportunitiesPage.TapAddOpportunityButton();

			AddOpportunityPage.PopulateAllFields(topicText, companyText, leaseAmount, ownerText, dbaText);
			AddOpportunityPage.TapCancelButton();

			//Assert
			Assert.IsFalse(OpportunitiesPage.DoesViewCellExist(topicText));
		}
	}
}

