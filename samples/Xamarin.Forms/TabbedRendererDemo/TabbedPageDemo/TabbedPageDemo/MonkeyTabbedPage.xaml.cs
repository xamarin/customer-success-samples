using System;
using Xamarin.Forms;

namespace TabbedPageDemo
{
    public partial class MonkeyTabbedPage
    {
        public MonkeyTabbedPage()
        {
            InitializeComponent();

            this.ItemsSource = MonkeyDataModel.All;
        }
    }
}
