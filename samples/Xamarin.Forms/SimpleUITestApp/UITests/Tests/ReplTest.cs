using NUnit.Framework;
using Xamarin.UITest;

namespace SimpleUITestApp.UITests
{
	public class ReplTests : AbstractSetup
	{

		public ReplTests (Platform platform) : base(platform)
		{
		}

		[Ignore ("REPL Tests only for Testing/Developing")]
		[Test]
		public void Repl()
		{
			app.Repl ();

		}
	}
}

