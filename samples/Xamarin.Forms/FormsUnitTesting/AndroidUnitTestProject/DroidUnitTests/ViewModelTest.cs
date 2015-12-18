using System;
using NUnit.Framework;
using FormsUnitTesting;

namespace AndroidUnitTestProject
{
	[TestFixture]
	public class ViewModelTest : TestingBase
	{
		[TestCase ()]
		public void ViewModelCalculationTest ()
		{
			Console.WriteLine ("Initial Value: 2");
			ViewModel viewModel = new ViewModel ();
			int result = viewModel.GetSquaredValueOfInt (2);
			Console.WriteLine ("Returned Value: {0}", result);
			Assert.AreEqual (result, 4);

		}

		[TestCase ()]
		public void DependencyServiceCalculationTest()
		{
			Console.WriteLine ("Initial Value: 3");
			ViewModel viewModel = new ViewModel ();
			int result = viewModel.GetSquaredValueOfIntDependencyService (3);
			Console.WriteLine ("Returned Value: {0}", result);
			Assert.AreEqual (result, 9);
		}
	}
}

