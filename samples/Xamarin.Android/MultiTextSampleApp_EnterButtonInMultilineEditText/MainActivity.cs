using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views.InputMethods;
using Android.Text;

namespace DoneButtonInEditView
{
	[Activity (Label = "MultipleEntrySample", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//ImeAction.Next will forward the user to the following text box when they click Enter
			EditText numerictext = FindViewById<EditText> (Resource.Id.editText1);
			numerictext.ImeOptions = ImeAction.Next;
			numerictext.SetSingleLine ();

			//The MultiLineTextWithDoneButton class extends EditText and always shows a "Done" button in place
			// of the carriage return. SetHorizonalScrolling causes the user input to appear on the next line
			// once it runs out of space on it's current line. This allows for the user to input mulitple lines 
			// of text, and still close the keyboard by hitting enter

			MultiLineTextWithDoneButton text = FindViewById<MultiLineTextWithDoneButton> (Resource.Id.editText2);
			text.InputType = InputTypes.TextFlagMultiLine;
			text.ImeOptions = ImeAction.Done;
			text.SetMaxLines (3);
			text.SetHorizontallyScrolling (false);
		}
	}
}


