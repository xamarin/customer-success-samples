using System;
using Android.Widget;
using Android.Util;
using Android.Media.Audiofx;
using Android.Content;
using Android.Views.InputMethods;
using Android.Runtime;

namespace DoneButtonInEditView
{
	public class MultiLineTextWithDoneButton : EditText
	{
		public MultiLineTextWithDoneButton (Context context) : base (context)
		{
		}

		public MultiLineTextWithDoneButton (Context context, IAttributeSet attrs) : base (context, attrs)
		{
			
		}

		public MultiLineTextWithDoneButton (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public MultiLineTextWithDoneButton (Context context, IAttributeSet attrs, int defStyle) : base (context, attrs, defStyle)
		{

		}

		public override Android.Views.InputMethods.IInputConnection OnCreateInputConnection (Android.Views.InputMethods.EditorInfo outAttrs)
		{
			IInputConnection conn = base.OnCreateInputConnection (outAttrs);
			outAttrs.ImeOptions &= ~(ImeFlags.NoEnterAction);
			return conn;
		}
	}
}

