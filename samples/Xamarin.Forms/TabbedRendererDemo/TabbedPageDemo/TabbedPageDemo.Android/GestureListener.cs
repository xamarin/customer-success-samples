using System;

using Android.Views;

namespace TabbedPageDemo.Droid
{
	public class GesutreListener : GestureDetector.SimpleOnGestureListener
	{
		public override bool OnFling (MotionEvent e1, MotionEvent e2, float velocityX, float velocityY)
		{
			return base.OnFling (e1, e2, velocityX, velocityY);
		}
	}
}