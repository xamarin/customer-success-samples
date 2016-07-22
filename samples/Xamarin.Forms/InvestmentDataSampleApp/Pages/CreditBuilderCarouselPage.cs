using System;
using Xamarin.Forms;
namespace InvestmentDataSampleApp
{
	public class CreditBuilderCarouselPage : CarouselPage 
	{
		public CreditBuilderCarouselPage()
		{
			Title = "Terms Page";

			var termsPage1 = new TermsPage(1,3);
			var termsPage2 = new TermsPage(2,3);
			var termsPage3 = new TermsPage(3,3);

			Children.Add(termsPage1);
			Children.Add(termsPage2);
			Children.Add(termsPage3);
		}
	}
}

