using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace TabbedPageDemo
{
    public partial class MonkeyTabbedPage
    {
        public MonkeyTabbedPage()
        {
            InitializeComponent();

//            this.ItemsSource = MonkeyDataModel.All;

			ListView1.ItemsSource = new List<string>() { "List item 1 on tab 1", "List item 2 on tab 1", "List item 3 on tab 1", 
				"List item 1 on tab 1", "List item 2 on tab 1", "List item 3 on tab 1", 
				"List item 1 on tab 1", "List item 2 on tab 1", "List item 3 on tab 1", 
				"List item 1 on tab 1", "List item 2 on tab 1", "List item 3 on tab 1", 
				"List item 1 on tab 1", "List item 2 on tab 1", "List item 3 on tab 1", 
			};
			ListView2.ItemsSource = new List<string>() { "List item 1 on tab 2", "List item 2 on tab 2", "List item 3 on tab 2" };
			ListView3.ItemsSource = new List<string>() { "List item 1 on tab 3", "List item 2 on tab 3", "List item 3 on tab 3" };
        }
    }
}
