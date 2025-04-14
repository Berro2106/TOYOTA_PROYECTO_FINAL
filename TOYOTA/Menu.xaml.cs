using Microsoft.Maui.Controls;
using TOYOTA.Views;

namespace TOYOTA
{
    public partial class Menu : ContentPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private async void OnNewCarsButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewCars());
        }
        private async void OnAyudaButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ayuda());
        }
        private async void OnVerSolicitudesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new VerSolicitudesPage());
        }
    }
}