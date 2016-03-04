using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;


namespace InvokeExample.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp.iOS.StartApp ();
		}

		[Test]
		public void ViewIsDisplayed ()
		{
			// Example of Invoking selectRow in the native UIPickerView to set the value to the 4th row (0-based array)
			var invokingHere = app.Query(e => e.Id("PizzaPicker").Index(0).Invoke("selectRow", 3 , "inComponent", 3, "animated", true));

		}
			

	}
}


