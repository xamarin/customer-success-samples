using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace SimpleUITestApp.UITests
{
	public class ReplTests : SetupTest
	{

		public ReplTests (Platform platform) : base(platform)
		{
		}

		[Ignore]
		[Test]
		public void Repl()
		{
			app.Repl ();
		}
	}
}

