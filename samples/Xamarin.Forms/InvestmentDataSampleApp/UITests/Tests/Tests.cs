using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace InvestmentDataSampleApp.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests : TestSetUp
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

			AddOpportunityPage.PopulateAllFields(topicText,companyText,leaseAmount,ownerText,dbaText);
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

