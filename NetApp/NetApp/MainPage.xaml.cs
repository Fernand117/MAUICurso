using NetApp.Views;

namespace NetApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnLogin_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                await DisplayAlert("Advertencia", "Ingrese un nombre de usuario", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                await DisplayAlert("Advertencia", "Ingrese su contraseña", "Aceptar");
                return;
            }

            await Navigation.PushModalAsync(new Dashboard());
        }
    }
}
