using System;
using System.ComponentModel;

using Xamarin.Forms;

namespace RecertificationApplicaiton
{
	public class TimerViewModel : INotifyPropertyChanged
	{
		public TimerViewModel ()
		{
			timer = 0;
			questionCount = 0;
			time = "";
			numberOfQuestions = "";
		}

		string numberOfQuestions;
		public string NumberOfQuestions { 
			get { return numberOfQuestions; }
			set {
				if (numberOfQuestions == value)
					return;
				numberOfQuestions = value;
				OnPropertyChanged ("NumberOfQuestions");
			}
		}

		string time;
		public string Time { 
			get { return time; }
			set {
				if (time == value)
					return;
				time = value;
				OnPropertyChanged ("time");
			}
		}

		int timer;
		public string Timer {
			get { 
				var hours = Math.Floor ((double)(timer / 60 / 60));
				var minutes = Math.Floor(timer / 60 - (hours * 60));
				var seconds = Math.Floor (timer - (hours * 60 * 60) - (minutes * 60));

				return "Total Time \nHours: " + hours + "\nMinutes: " + minutes + "\nSeconds: " + seconds; 
			}
		}

		int questionCount;
		public string QuestionCount {
			get { return "Current Question: " + questionCount; }
		}

		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged(string propertyName = null)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
			{
				PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		double questions;
		double totalTime;

		public void StartTimer()
		{
			var minutes = TimeSpan.FromSeconds (1); 

			totalTime = Convert.ToDouble (time) * 60;
			questions = Convert.ToDouble (numberOfQuestions);

			Device.StartTimer (minutes, () => {
				timer++;
				OnPropertyChanged("Timer");
				CheckQuestionCount();

				if(timer == (totalTime))
					return false;

				return true;
			});
		}

		void CheckQuestionCount()
		{
			var denominator = (totalTime / questions);
			var newCount = Math.Floor ((double)(timer / denominator));
			if (newCount != questionCount) {
				questionCount = (int)newCount;
				OnPropertyChanged("QuestionCount");
			}
		}
	}
}