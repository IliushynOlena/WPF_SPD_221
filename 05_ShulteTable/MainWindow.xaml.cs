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

namespace _05_ShulteTable
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] arr = new int[16] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            //shufle
            
            int i = 0;
            foreach (Button btn in grid.Children.OfType<Button>())
            {
                btn.Content = arr[i];
                i++;
            }
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button? button = sender as Button;
            MessageBox.Show(button.Content.ToString());
        }
    }
}
