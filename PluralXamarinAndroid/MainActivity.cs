using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace PluralXamarinAndroid
{
    [Activity(Label = "PluralXamarinAndroid", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            FindViewById<Button>(Resource.Id.btnHellow).Click += (s, e) => 
            {
                Toast.MakeText(this, "Hey, you touch me, thanks!!", ToastLength.Short).Show();
                
                var intent = new Intent();
                intent.SetClass(this, typeof(DetailActivity));
                StartActivityForResult(intent, 100);
            };
        }
    }
}

