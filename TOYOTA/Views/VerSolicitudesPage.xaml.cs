using TOYOTA.Helpers;
using TOYOTA.Models;

namespace TOYOTA.Views
{
    public partial class VerSolicitudesPage : ContentPage
    {
        
        private FirebaseHelper helper = new FirebaseHelper();

        public VerSolicitudesPage()
        {
            InitializeComponent();
            CargarSolicitudes();
        }

        private async void CargarSolicitudes()
        {
            var solicitudes = await helper.GetAllSolicitudes();
            SolicitudesListView.ItemsSource = solicitudes;
        }
    }
}