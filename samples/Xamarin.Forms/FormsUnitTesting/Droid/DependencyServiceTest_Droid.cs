using System;
using FormsUnitTesting.Droid;

[assembly: Xamarin.Forms.Dependency (typeof (DependencyServiceTest_Droid))]

namespace FormsUnitTesting.Droid
{
	public class DependencyServiceTest_Droid : IDependencyServiceTest
	{
		public DependencyServiceTest_Droid ()
		{
		}

		public int NativeCalculation(int value)
		{
			return value * value;
		}
	}
}