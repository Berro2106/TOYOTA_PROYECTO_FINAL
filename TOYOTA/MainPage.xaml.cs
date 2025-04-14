namespace TOYOTA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BtnIr.Clicked += BtnIr_Clicked;

        }

        private void BtnIr_Clicked(object? sender, EventArgs e)
        {
            if ((usr.Text == "PEPE") && (pwd.Text == "123"))
            {
                if (this.Parent is NavigationPage navigationPage)
                {
                    navigationPage.PushAsync(new Menu());
                }
                else if (this.Parent is ShellContent shellContent)
                {
                    shellContent.Navigation.PushAsync(new Menu());
                }
                usr.Text = "";
                pwd.Text = "";
            }
        }
    }
}
