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
            await DisplayAlert("Advertencia", "Verificando datos en el servidor", "Aceptar");

            await Navigation.PushModalAsync(new Dashboard());
        }
    }

}
