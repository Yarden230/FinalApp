using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace FinalApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView tvToSignIn, tvToSignUp;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.activity_main);
            //SetContentView(Resource.Layout.activity_main);


            //InitilizeViews();
        }

        //private void InitilizeViews()
        //{
        //    tvToSignIn = FindViewById<TextView>(Resource.Id.tvToLogIn);
        //    tvToSignUp = FindViewById<TextView>(Resource.Id.tvToSignUp);

        //    tvToSignIn.Click += (s, a) => { StartActivity(typeof(LogInActivity)); };
        //    tvToSignUp.Click += (s, a) => { StartActivity(typeof(SignUpActivity)); };
        //}

        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}