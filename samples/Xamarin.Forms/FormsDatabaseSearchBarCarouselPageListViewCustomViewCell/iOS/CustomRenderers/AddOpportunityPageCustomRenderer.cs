using System.Collections.Generic;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using InvestmentDataSampleApp;
using InvestmentDataSampleApp.iOS;


[assembly: ExportRenderer(typeof(AddOpportunityPage), typeof(AddOpportunityPageCustomRenderer))]
namespace InvestmentDataSampleApp.iOS
{
	public class AddOpportunityPageCustomRenderer : PageRenderer
	{
		public new AddOpportunityPage Element
		{
			get { return (AddOpportunityPage)base.Element; }
		}

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var LeftNavList = new List<UIBarButtonItem>();
			var rightNavList = new List<UIBarButtonItem>();

			var navigationItem = NavigationController.TopViewController.NavigationItem;

			for (var i = 0; i < Element.ToolbarItems.Count; i++)
			{

				var reorder = (Element.ToolbarItems.Count - 1);
				var ItemPriority = Element.ToolbarItems[reorder - i].Priority;

				if (ItemPriority == 1)
				{
					UIBarButtonItem LeftNavItems = navigationItem.RightBarButtonItems[i];
					LeftNavList.Add(LeftNavItems);
				}
				else if (ItemPriority == 0)
				{
					UIBarButtonItem RightNavItems = navigationItem.RightBarButtonItems[i];
					rightNavList.Add(RightNavItems);
				}
			}

			navigationItem.SetLeftBarButtonItems(LeftNavList.ToArray(), false);
			navigationItem.SetRightBarButtonItems(rightNavList.ToArray(), false);

		}
	}
}