namespace Proyecto8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Btfirma(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Firma());
        }

        private async void BtpagAce(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagAcel());
        }

        private async void BtpagGyro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagGyro());
        }

        private async void BtpagBruj(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagBruj());
        }

        private async void BtpagMag(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagMagne());
        }

        private async void BtpagOri(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagOri());
        }

        private async void BtpagVib(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagVib());
        }

        private async void BtpagGPS(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PagGPS());
        }
    }

}
