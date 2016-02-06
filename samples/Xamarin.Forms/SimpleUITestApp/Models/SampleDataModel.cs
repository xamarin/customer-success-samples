using System;
using System.Dynamic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections;

namespace SimpleUITestApp
{

	public class SampleDataModel : INotifyPropertyChanged
	{
		public int Number { get; set; }

		public event PropertyChangedEventHandler PropertyChanged = delegate {};

		public SampleDataModel ()
		{
			
		}

		public SampleDataModel (int number)
		{
			Number = number;
		}

		void RaisePropertyChanged ([CallerMemberName] string propertyName = "")
		{
			PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
		}

		public override string ToString ()
		{
			return Number.ToString ();
		}
	}

	public static class SampleDataModelFactory
	{
		public static ObservableCollection<SampleDataModel> GetSampleData ()
		{
			var sampleData = new ObservableCollection<SampleDataModel> ();

			for (int i = 0; i < 10; i++) {
				var thisObject = new SampleDataModel ();

				thisObject.Number = i;

				sampleData.Add (thisObject);
			}

			return sampleData;
		}
	}
}

