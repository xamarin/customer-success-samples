using System;

using Xamarin.Forms;

namespace RecertificationApplicaiton
{
	public class LandingPage : ContentPage
	{
		public LandingPage ()
		{
			var viewModel = new TimerViewModel ();
			BindingContext = viewModel;

			Entry numberOfQuestions = new Entry { Placeholder = "Enter number of questions" };
			Entry timeForTest = new Entry { Placeholder = "Enter the total time of the test (minutes)" };

			Label timer = new Label { Text = "Total Time: " };
			Label questionCount = new Label { Text = "Current Question: " };
			Button start = new Button { Text = "Start Test" };

			numberOfQuestions.SetBinding (Entry.TextProperty, "NumberOfQuestions");
			timeForTest.SetBinding (Entry.TextProperty, "Time");
			timer.SetBinding (Label.TextProperty, "Timer");
			questionCount.SetBinding (Label.TextProperty, "QuestionCount");

			start.Clicked += (object sender, EventArgs e) => {
				if(numberOfQuestions.Text == null || timeForTest == null){
					DisplayAlert("Error","You must enter the number of questions and total time of test.","OK");
					return;
				}
			
				start.IsEnabled = false;
				numberOfQuestions.IsEnabled = false;
				timeForTest.IsEnabled = false;
				viewModel.StartTimer();
			};

			Content = new StackLayout {
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					numberOfQuestions,
					timeForTest,
					timer,
					questionCount,
					start
				}
			};
		}
	}
}