using System;
using FormsUnitTesting.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (DependencyServiceTest_iOS))]

namespace FormsUnitTesting.iOS
{
	public class DependencyServiceTest_iOS : IDependencyServiceTest
	{
		public DependencyServiceTest_iOS() {}

		public int NativeCalculation(int value)
		{
			return value * value;
		}
	}
}