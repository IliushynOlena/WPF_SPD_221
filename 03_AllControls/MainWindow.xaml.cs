using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _03_AllControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += Timer_Tick;
            //this.WindowStyle = WindowStyle.None;
           
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            //if(progressBar.Value == progressBar.Maximum)
            //    progressBar.Value = progressBar.Minimum;  
            //else
            //    progressBar.Value++;
        }
        private void Button_ClickStart(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }
        private void Button_Click_Stop(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            this.Opacity = slider.Value / 100;//0...1
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("File opened!!!");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
