using System;
using Xamarin.Forms;
using System.Linq;

namespace MasterDetail_NavigationBarColor_SampleApp
{
	public class RootPage : MasterDetailPage
	{
		MenuPage menuPage;

		public RootPage ()
		{
			menuPage = new MenuPage ();

			menuPage.Menu.ItemSelected += (sender, e) => NavigateTo (e.SelectedItem as MenuItem);

			Master = menuPage;
			Detail = new NavigationPage (new ContractsPage ()) {
				BarBackgroundColor = Color.Aqua	
			};
		}

		void NavigateTo (MenuItem menu)
		{
			if (menu == null)
				return;
			
			Page displayPage = (Page)Activator.CreateInstance (menu.TargetType);

			if (displayPage is ContractsPage) {
				Detail = new NavigationPage (displayPage) {
					BarBackgroundColor = Color.Aqua
				};
			} else if (displayPage is OpportunitiesPage)
				Detail = new NavigationPage (displayPage) {
					BarBackgroundColor = Color.Pink
				};
			else {
				Detail = new NavigationPage (displayPage) {
					BarBackgroundColor = Color.Fuchsia
				};
			}

			menuPage.Menu.SelectedItem = null;
			IsPresented = false;
		}
	}
}