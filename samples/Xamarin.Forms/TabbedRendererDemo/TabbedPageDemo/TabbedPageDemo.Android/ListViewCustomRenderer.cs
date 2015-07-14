using System;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

using TabbedPageDemo;
using TabbedPageDemo.Droid;
using Android.Views;

//[assembly:ExportRenderer(typeof(ListView),typeof(ListViewCustomRenderer))]

namespace TabbedPageDemo.Droid
{
	public class ListViewCustomRenderer : ListViewRenderer
	{
		public float x1,x2,y1,y2, counter = 0;

		public float deltaX, deltaY, lastX, lastY = 0;

		public ListViewCustomRenderer()
		{
			this.MotionEventSplittingEnabled = false;
		}

		public override bool OnInterceptTouchEvent (Android.Views.MotionEvent ev)
		{
//			
			switch (ev.Action) {
			case MotionEventActions.Down:
				deltaX = 0;
				deltaY = 0;

				lastX = ev.GetX ();
				lastY = ev.GetY ();

				return false;
				break;
			case MotionEventActions.Move:
				float moveX = ev.GetX ();
				float moveY = ev.GetY ();
		
				deltaX += Math.Abs (moveX - lastX);
				deltaY += Math.Abs (moveY - lastY);

				lastX = moveX;
				lastY = moveY;

				if (deltaX > deltaY) {
					return false;
				}
				break;
			case MotionEventActions.Up:
				if (deltaX > deltaY) {
					return false;
				}
				break;
			}

			var test = base.OnInterceptTouchEvent (ev);

			return test;

//			if (x1 == 0)
//				x1 = ev.GetX ();
//
//			if (ev.Action == Android.Views.MotionEventActions.Move) {
//				Console.WriteLine ("x1 = {0}, x2 = {1}", x1, ev.GetX ());
//				x2 = ev.GetX ();
//				counter = counter + Math.Abs (x2 - x1);
//				Console.WriteLine ("New Counter Value = {0}", counter);
//				x1 = x2;
//			}
//
//			if (counter > 100 && ev.Action == Android.Views.MotionEventActions.Up) {
//				Console.WriteLine (ev.Action);
//				Console.WriteLine ("Reset Counter and Return True");
//				counter = 0;
//			}
//
//			Console.WriteLine (ev.Action);
//			Console.WriteLine ("Get X: {0}", ev.GetX());
//
//			if (counter == 0) {
//				return true;
//			} else {
//				return base.OnInterceptTouchEvent (ev);
//			}
		}
	}
}