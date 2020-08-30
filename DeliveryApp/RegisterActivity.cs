using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DeliveryApp
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText txtEmailReg, txtPasswordReg, txtConfirmPwordReg;
        Button btnRegister;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);
            // Create your application here

            txtEmailReg = FindViewById<EditText>(Resource.Id.txtEmailReg);
            txtPasswordReg = FindViewById<EditText>(Resource.Id.txtPwrdReg);
            txtConfirmPwordReg = FindViewById<EditText>(Resource.Id.txtCpwrd);
            btnRegister = FindViewById<Button>(Resource.Id.btnReg);

            btnRegister.Click += BtnRegister_Click;

            //getting data passed
            txtEmailReg.Text = Intent.GetStringExtra("email");
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            
        }
    }
}