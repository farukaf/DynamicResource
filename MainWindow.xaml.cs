using System;
using System.Threading;
using System.Windows;
using System.Windows.Media;

namespace DynamicResource
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["ColorA"] = RandomColor();
            Application.Current.Resources["ColorB"] = RandomColor();
        }

        private SolidColorBrush RandomColor()
        {
            //Poor random use but works on this
            Random rnd = new Random(DateTime.Now.Millisecond);
            Color col = new Color();

            col.A = 255;
            col.R = (byte)rnd.Next(0, 255);
            Thread.Sleep(1);
            rnd = new Random(DateTime.Now.Millisecond);
            col.G = (byte)rnd.Next(0, 255);
            Thread.Sleep(1);
            rnd = new Random(DateTime.Now.Millisecond);
            col.B = (byte)rnd.Next(0, 255);

            SolidColorBrush ret = new SolidColorBrush(col);

            return ret;
        }
    }
}
