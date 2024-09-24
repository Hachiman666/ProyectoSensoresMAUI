namespace Proyecto8
{
    public partial class PagGyro : ContentPage
    {
        public PagGyro()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {
            Gyroscope.ReadingChanged += Gyroini_click;
            Gyroscope.Start(SensorSpeed.UI);
        }

        private void btparar(object sender, EventArgs e)
        {
            Gyroscope.ReadingChanged -= Gyroini_click;
            Gyroscope.Stop();
        }

        private void Gyroini_click(object sender, GyroscopeChangedEventArgs e)
        {
            gyrox.Text = e.Reading.AngularVelocity.X.ToString();
            gyroy.Text = e.Reading.AngularVelocity.Y.ToString();
            gyroz.Text = e.Reading.AngularVelocity.Z.ToString();

        }
    }
}