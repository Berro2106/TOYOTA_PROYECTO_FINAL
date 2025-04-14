namespace TOYOTA.AutosInfo;

public partial class RAV4 : ContentPage
{
	public RAV4()
	{
		InitializeComponent();
	}

    private async void OnSolicitarInformacionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioContacto());
    }
}