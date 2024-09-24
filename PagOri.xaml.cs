using Xamarin.Essentials;
using OrientationSensor = Xamarin.Essentials.OrientationSensor;

namespace Proyecto8
{
    public partial class PagOri : ContentPage
    {
        public PagOri()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {

            OrientationSensor.ReadingChanged += OrientationSensorini_click;
            OrientationSensor.Start(Xamarin.Essentials.SensorSpeed.Default);
        }

        private void btparar(object sender, EventArgs e)
        {
            OrientationSensor.ReadingChanged -= OrientationSensorini_click;
            OrientationSensor.Stop();
        }

        private void OrientationSensorini_click(object sender, Xamarin.Essentials.OrientationSensorChangedEventArgs e)
        {
            orix.Text = e.Reading.Orientation.X.ToString();
            oriy.Text = e.Reading.Orientation.Y.ToString();
            oriz.Text = e.Reading.Orientation.Z.ToString();
            oriw.Text = e.Reading.Orientation.W.ToString();
        }
    }
}