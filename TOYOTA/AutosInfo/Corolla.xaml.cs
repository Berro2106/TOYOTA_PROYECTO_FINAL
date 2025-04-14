namespace TOYOTA.AutosInfo;

public partial class Corolla : ContentPage
{
	public Corolla()
	{
		InitializeComponent();
		
	}
    private async void OnSolicitarInformacionClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormularioContacto());
    }


}