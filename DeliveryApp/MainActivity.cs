using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Views;

namespace DeliveryApp
{
    [Activity(Label = "DeliveryApp", Theme = "@style/Theme.AppCompat.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        EditText emailTxt, txtPwd;
        Button btnLogin, btnRegister;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            var theme = Theme;
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            
            SetContentView(Resource.Layout.activity_main);

            emailTxt = FindViewById<EditText>(Resource.Id.txtEmail);
            txtPwd = FindViewById<EditText>(Resource.Id.txtPwrd);
            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnGoToReg);

            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
        }

        private void BtnRegister_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(RegisterActivity));
            intent.PutExtra("email", emailTxt.Text); //passing data
            StartActivity(intent);
        }

        private void BtnLogin_Click(object sender, System.EventArgs e)
        {
            //here i want to pass a static value to the tabs activity.
            var userId = 123;
            //on norms everything should come from the db, but no time

            var intent = new Intent(this, typeof(TabsActivity));
            Intent.PutExtra("user", userId);
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}