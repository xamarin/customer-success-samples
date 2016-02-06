using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace MasterDetail_NavigationBarColor_SampleApp
{

	public class MenuListData : List<MenuItem>
	{
		public MenuListData ()
		{
			this.Add (new MenuItem () { 
				Title = "Contracts", 
				IconSource = "contacts.png", 
				TargetType = typeof(ContractsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Leads", 
				IconSource = "leads.png", 
				TargetType = typeof(LeadsPage)
			});

			this.Add (new MenuItem () { 
				Title = "Accounts", 
				IconSource = "accounts.png", 
				TargetType = typeof(AccountsPage)
			});

			this.Add (new MenuItem () {
				Title = "Opportunities",
				IconSource = "opportunities.png",
				TargetType = typeof(OpportunitiesPage)
			});
		}
	}
}