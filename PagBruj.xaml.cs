namespace Proyecto8
{
    public partial class PagBruj : ContentPage
    {
        public PagBruj()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {
            Compass.ReadingChanged += Compassini_click;
            Compass.Start(SensorSpeed.UI, applyLowPassFilter: true);
        }

        private void btparar(object sender, EventArgs e)
        {
            Compass.ReadingChanged -= Compassini_click;
            Compass.Stop();
        }

        private void Compassini_click(object sender, CompassChangedEventArgs e)
        {
            ang.Text = e.Reading.HeadingMagneticNorth.ToString();
        }
    }
}