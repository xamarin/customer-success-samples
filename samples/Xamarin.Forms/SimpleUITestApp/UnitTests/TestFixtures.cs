using System;
using System.Collections.ObjectModel;

using NUnit.Framework;

using SimpleUITestApp;

namespace SimpleUITestApp.UnitTests
{
	[TestFixture]
	public class TestFixtures
	{
		[Test]
		public void Pass ()
		{
			// Arrange
			int zero = 0;
			int one = 1;
			int two = 2;

			// Act
			SampleDataModel firstDataModel = new SampleDataModel (0);
			SampleDataModel fifthDataModel = new SampleDataModel (4);
			SampleDataModel tenthDataModel = new SampleDataModel (9);

			ObservableCollection<SampleDataModel> dataCollection = new ObservableCollection<SampleDataModel> ();
			dataCollection.Add (firstDataModel);
			dataCollection.Add (fifthDataModel);
			dataCollection.Add (tenthDataModel);

			// Assert
			Assert.AreEqual (zero, dataCollection.IndexOf (firstDataModel));
			Assert.AreEqual (one, dataCollection.IndexOf (fifthDataModel));
			Assert.AreEqual (two, dataCollection.IndexOf (tenthDataModel));
		}

		[Test]
		public void Fail ()
		{
			// Arrange
			int zero = 0;
			int one = 1;
			int two = 2;

			// Act
			SampleDataModel firstDataModel = new SampleDataModel (0);
			SampleDataModel fifthDataModel = new SampleDataModel (4);
			SampleDataModel tenthDataModel = new SampleDataModel (9);

			ObservableCollection<SampleDataModel> dataCollection = new ObservableCollection<SampleDataModel> ();
			dataCollection.Add (firstDataModel);
			dataCollection.Add (fifthDataModel);
			dataCollection.Add (tenthDataModel);

			// Assert
			Assert.AreEqual (two, dataCollection.IndexOf (firstDataModel));
			Assert.AreEqual (zero, dataCollection.IndexOf (fifthDataModel));
			Assert.AreEqual (one, dataCollection.IndexOf (tenthDataModel));
		}

		[Test]
		[Ignore ("another time")]
		public void Ignore ()
		{
			Assert.True (false);
		}
	}
}
