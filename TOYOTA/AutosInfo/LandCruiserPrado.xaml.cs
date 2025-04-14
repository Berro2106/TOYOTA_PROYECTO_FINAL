namespace TOYOTA.AutosInfo;

public partial class LandCruiserPrado : ContentPage
{
	public LandCruiserPrado()
	{
		InitializeComponent();
	}

    private async void OnSolicitarInformacionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioContacto());
    }
}