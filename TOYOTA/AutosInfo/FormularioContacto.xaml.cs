namespace TOYOTA.AutosInfo;
using TOYOTA.Helpers;
using TOYOTA.Models;

public partial class FormularioContacto : ContentPage
{
	public FormularioContacto()
	{
		InitializeComponent();
        
    }

    private async void OnEnviarClicked(object sender, EventArgs e)
    {
        var solicitud = new Solicitud
        {
            Vehiculo = vehiculoPicker.SelectedItem?.ToString(),
            Nombre = nombreEntry.Text,
            Cedula = cedulaEntry.Text,
            Telefono = telefonoEntry.Text,
            Fecha = fechaPicker.Date + horaPicker.Time,
            Comentarios = comentariosEditor.Text
        };

        FirebaseHelper helper = new FirebaseHelper();
        await helper.AddSolicitud(solicitud);

        await DisplayAlert("Éxito", "Tu solicitud ha sido enviada", "OK");
        await Navigation.PopAsync(); // Volver atrás si aplica
    }


}