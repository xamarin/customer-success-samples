using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace ElevationExample
{
    [Activity(Label = "ElevationExample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            ActionBar.SetDisplayHomeAsUpEnabled (true);
            ActionBar.SetDisplayShowHomeEnabled (true);
            ActionBar.SetIcon (Android.Resource.Color.Transparent);
        }

    }
}


