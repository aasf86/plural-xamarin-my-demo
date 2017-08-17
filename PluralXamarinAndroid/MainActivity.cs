using Android.App;
using Android.Widget;
using Android.OS;

namespace PluralXamarinAndroid
{
    [Activity(Label = "PluralXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.btnHellow).Click += (s, e) => 
            {
                Toast.MakeText(this, "Hey, you touch me, thanks!!", ToastLength.Short).Show();
            };
        }
    }
}

