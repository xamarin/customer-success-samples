using System;
using NUnit.Framework;
using Xamarin.Forms;

namespace AndroidUnitTestProject
{
	public class TestingBase
	{
		[SetUp]
		public void Init ()
		{
			Forms.Init(MainActivity._activity,MainActivity._bundle);

		}
	}
}

