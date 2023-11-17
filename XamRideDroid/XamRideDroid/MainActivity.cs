using System;
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using AlertDialog = Android.App.AlertDialog;

namespace XamRideDroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private EditText txtUsuario;
        private EditText txtPassword;
        private Button btnValidateForm;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            txtUsuario = (EditText)FindViewById(Resource.Id.txtUsuario);
            txtPassword = (EditText)FindViewById(Resource.Id.txtPassword);

            btnValidateForm = (Button)FindViewById(Resource.Id.btnValidateForm);

            btnValidateForm!.Click += BtnValidateFormOnClick;
        }

        private void BtnValidateFormOnClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                AlertDialog.Builder alertDialog = new AlertDialog.Builder(this);
                alertDialog.SetTitle("Advertencia");
                alertDialog.SetMessage("Por favor ingrese su nombre de usuario");
                
                alertDialog.SetPositiveButton("Aceptar", (o, args) =>
                {
                    
                });
                
                alertDialog.SetNegativeButton("Cancelar", (o, args) =>
                {
                    
                });
                
                alertDialog.Show();
            }
        }
    }
}