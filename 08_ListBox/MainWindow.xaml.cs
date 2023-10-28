using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace _08_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //INotifyCollectionChanged
        ObservableCollection<Student> students = null;
        public MainWindow()
        {
            InitializeComponent();
            students = new ObservableCollection<Student>()
            {
                new Student(){ Name = "Bob", Age = 23},
                new Student(){ Name = "Tom", Age = 12},
                new Student(){ Name = "Jack", Age = 5},
                new Student(){ Name = "Will", Age = 35}
            };
            listBox.Items.Clear();
            listBox.ItemsSource = students;
            listBox.DisplayMemberPath = nameof(Student.FullInfo);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            students.Add(new Student() { Name= "Bill", Age = 57 });
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
                students.Remove( (listBox.SelectedItem as Student)!);
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                Student select = (listBox.SelectedItem as Student)!;
                select.Name = "New name";
                select.Age++;
            }
        }
    }
}
