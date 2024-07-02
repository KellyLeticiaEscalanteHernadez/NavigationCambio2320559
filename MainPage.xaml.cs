namespace NavigationCambio2320559
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Cambio_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cambio());
        }

        private void Dino_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Dinosaurio());
        }

        private void Gas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Gas());
        }

        private void Superficie_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Superficie());
        }

        private void Acerca_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Acerca());
        }
    }

}
