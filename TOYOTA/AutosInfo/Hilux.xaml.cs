namespace TOYOTA.AutosInfo;

public partial class Hilux : ContentPage
{
	public Hilux()
	{
		InitializeComponent();
	}

    private async void OnSolicitarInformacionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioContacto());
    }
}