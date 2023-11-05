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

namespace _10_DataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel ViewModel = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
           
            //Binding
           //this.DataContext = ViewModel;

        }
    }
    public class ViewModel
    {
        public User User1 { get; set; }
        public User User2 { get; set; }
        public ViewModel()
        {
            User1 = new User() { Name = "Bob", Email = "bob@gmail.com" };
            User2 = new User() { Name = "Tom", Email = "tom@gmail.com" };

        }

    }
}
