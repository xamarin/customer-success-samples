using System;

using Xamarin.Forms;

namespace FormsUnitTesting
{
	public class ViewModel 
	{
		public ViewModel ()
		{
		}

		public int GetSquaredValueOfInt (int number)
		{
			return number * number;
		}

		public int GetSquaredValueOfIntDependencyService(int number)
		{
			return DependencyService.Get<IDependencyServiceTest> ().NativeCalculation (number);
		}
	}
}