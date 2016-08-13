using Xamarin.Forms;

using Entry_UITest.ViewModels;

namespace Entry_UITest.Pages
{
    class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = new MainViewModel();

            BackgroundColor = Color.FromHex("2980b9");

            var emailKeyboardEntry = new Entry
            {
                Placeholder = "Enter Text Here",
                PlaceholderColor = Color.FromHex("749FA8"),
                Keyboard = Keyboard.Email,
                AutomationId = AutomationIdConstants.EntryAutomationID,
                TextColor = Color.FromHex("2C7797"),
                BackgroundColor = Color.FromHex("91E2F4")
            };
            emailKeyboardEntry.SetBinding(Entry.TextProperty, "EmailKeyboardEntryText");

            var textLabel = new Label
            {
                TextColor = Color.White,
                AutomationId = AutomationIdConstants.LabelAutomationID,
            };
            textLabel.SetBinding(Label.TextProperty, "TextLabelText");

            Padding = new Thickness(30, Device.OnPlatform(20, 0, 0), 30, 5);

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                Children =
                {
                    emailKeyboardEntry,
                    textLabel
                }
            };
        }
    }
}
