using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit.Framework;
using System.Linq;
using System.Threading;

namespace SliderTests
{
	public class CrossPlatformTests
	{
		protected IApp app;

		[SetUp]
		public virtual void SetUp()
		{
			Assert.Ignore ("This class requires a platform-specific bootstrapper to override the `SetUp` method");
		}
	
		/// <summary>
		/// This test checks the value of a Label, presses a Button, then checks the Label text again
		/// </summary>
		[Test ()]
		public void TestCase ()
		{
			app.Screenshot ("Startup");
			app.WaitForThenTap (x => x.Text ("Click"),"Navigate to SliderView Page");
			Thread.Sleep (500);

			var screen = app.Query (x => x.All ())[0];
			app.Screenshot ("First view presented");

			var rightX = (float)(screen.Rect.Width * 0.9);
			var leftX = (float)(screen.Rect.Width * 0.1);
			var swipeY = (float)(screen.Rect.CenterY);


			app.SwipeRight (leftX, rightX, swipeY, "Tried swiping to the right, should not change view");

			app.SwipeLeft (rightX, leftX, swipeY, "Swipe to second view");
			app.SwipeLeft (rightX, leftX, swipeY, "Swipe to third view");
			app.SwipeLeft (rightX, leftX, swipeY, "Swipe to fourth view");
			app.SwipeLeft (rightX, leftX, swipeY, "Swipe to fifth view");
			app.SwipeLeft (rightX, leftX, swipeY, "Tried swiping to the left, should not change view");

			app.SwipeRight (leftX, rightX, swipeY, "Swipe to fourth view");
			app.SwipeRight (leftX, rightX, swipeY, "Swipe to third view");
			app.SwipeRight (leftX, rightX, swipeY, "Swipe to second view");
			app.SwipeRight (leftX, rightX, swipeY, "Swipe to first view");

			app.Back ();
			app.Screenshot ("Back to landing page, memory should be released");
			app.WaitForThenTap (x => x.Text ("Click"),"Navigate to SliderView Page");

			app.Back ();
			app.Screenshot ("Back to landing page, memory should be released");
			app.WaitForThenTap (x => x.Text ("Click"),"Navigate to SliderView Page");

			app.Back ();
			app.Screenshot ("Back to landing page, memory should be released");
			app.WaitForThenTap (x => x.Text ("Click"),"Navigate to SliderView Page");
		}
	}
}