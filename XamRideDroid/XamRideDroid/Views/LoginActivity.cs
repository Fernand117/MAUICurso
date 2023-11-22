using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace XamRideDroid.Views
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {
        private EditText txtUsuario;
        private EditText txtPassword;
        private Button   btnLogin;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login_activity);
            SupportActionBar.Hide();

            txtUsuario  = (EditText)FindViewById(Resource.Id.txtUsuario);
            txtPassword = (EditText)FindViewById(Resource.Id.txtPassword);
            btnLogin = (Button)FindViewById(Resource.Id.btnValidateForm);
            
            btnLogin.Click += BtnLoginOnClick;
        }

        private void BtnLoginOnClick(object sender, EventArgs e)
        {
            Console.WriteLine("Dentro del botón del login");
        }
    }
}