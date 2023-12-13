namespace ExampleApp
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_OnClicked(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new InnerPage());
        }
    }

}
