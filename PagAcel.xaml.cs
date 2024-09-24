namespace Proyecto8
{
    public partial class PagAcel : ContentPage
    {
        public PagAcel()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {
            Accelerometer.ReadingChanged += Acelini_click;
            Accelerometer.Start(SensorSpeed.UI);
        }

        private void btparar(object sender, EventArgs e)
        {
            Accelerometer.ReadingChanged -= Acelini_click;
            Accelerometer.Stop();
        }

        private void Acelini_click(object sender, AccelerometerChangedEventArgs e)
        {
            acelx.Text = e.Reading.Acceleration.X.ToString();
            acely.Text = e.Reading.Acceleration.Y.ToString();
            acelz.Text = e.Reading.Acceleration.Z.ToString();

        }
    }
}