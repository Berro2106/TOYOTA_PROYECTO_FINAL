using TOYOTA.AutosInfo;

namespace TOYOTA;

public partial class NewCars : ContentPage
{
	public NewCars()
	{
		InitializeComponent();
	}
    private async void OnCorollaButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Corolla());
    }

    private async void OnRAV4ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RAV4());
    }

    private async void OnPradoButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LandCruiserPrado());
    }

    private async void OnHiluxButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Hilux());
    }
}