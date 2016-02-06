using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITestApp.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]

	public class SetupTest
	{
		protected IApp app;
		protected Platform platform;

		public SetupTest (Platform platform)
		{
			this.platform = platform;
		}
		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}
	}
}

