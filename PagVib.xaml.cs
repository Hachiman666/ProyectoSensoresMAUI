namespace Proyecto8
{
    public partial class PagVib : ContentPage
    {
        private int shakeCount = 0;
        public PagVib()
        {
            InitializeComponent();
        }

        private void btiniciar(object sender, EventArgs e)
        {
            Accelerometer.ShakeDetected += Vibini_click;
            Accelerometer.Start(SensorSpeed.UI);
            vibra.Text = "Agitalo :o";
        }

        private void btparar(object sender, EventArgs e)
        {
            Accelerometer.ReadingChanged -= Vibini_click;
            Accelerometer.Stop();
            vibra.Text = "Stop, Presiona iniciar para seguir con el contador";
        }

        private void Vibini_click(object sender, EventArgs e)
        {
            shakeCount++;
            MainThread.InvokeOnMainThreadAsync(() =>
            {
                vibra.Text = "El dispositivo ha vibrado " + shakeCount + " veces";
            });
        }
    }
}