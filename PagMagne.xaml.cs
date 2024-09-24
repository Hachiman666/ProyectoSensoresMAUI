namespace Proyecto8
{
    public partial class PagMagne : ContentPage
    {
        public PagMagne()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {

            Magnetometer.ReadingChanged += Magnetometerini_click;
            Magnetometer.Start(SensorSpeed.Default);
        }

        private void btparar(object sender, EventArgs e)
        {
            Magnetometer.ReadingChanged -= Magnetometerini_click;
            Magnetometer.Stop();
        }

        private void Magnetometerini_click(object sender, MagnetometerChangedEventArgs e)
        {
            magx.Text = e.Reading.MagneticField.X.ToString();
            magy.Text = e.Reading.MagneticField.Y.ToString();
            magz.Text = e.Reading.MagneticField.Z.ToString();
        }
    }
}