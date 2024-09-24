namespace Proyecto8;
using Xamarin.Essentials;

public partial class PagGPS : ContentPage
{
	public PagGPS()
	{
		InitializeComponent();
	}

    private async void btiniciar(object sender, EventArgs e)
    {
        var location = await Geolocation.GetLastKnownLocationAsync();
        latgps.Text = "Latitud: " + location.Latitude.ToString();
        longps.Text = "Longitud: " + location.Longitude.ToString();
        altgps.Text = "Altitud: " + location.Altitude.ToString();

        var options = new MapLaunchOptions { Name = "Mi ubicación" };
        await location.OpenMapsAsync(options);
    }
}