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

namespace _07_ListControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //INotifyCollectionChanged
        ObservableCollection<Person> persons = null;
        public MainWindow()
        {
            InitializeComponent();
            comboBox.Items.Clear();
            persons = new ObservableCollection<Person>()
            {
                new Person(){ Name=  "Bogdan", Lastname="Ivanchuk", Birthdate = new DateTime(1990,5,6)},
                new Person(){ Name=  "Victoria", Lastname="Oliunuk", Birthdate = new DateTime(2005,12,2)},
                new Person(){ Name=  "Oksana", Lastname="Petruk", Birthdate = new DateTime(2003,8,12)},
                new Person(){ Name=  "Mukola", Lastname="Popchuk", Birthdate = new DateTime(1999,7,17)}
            };

            //foreach (var item in persons)
            //{
            //    comboBox.Items.Add(item);
            //}
           
            comboBox.ItemsSource = persons;
            //comboBox.DisplayMemberPath = "FullName";
            comboBox.DisplayMemberPath = nameof(Person.FullName);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var newPerson = new Person() { Name = "New name", Lastname = "New lastname",
                Birthdate = new DateTime(2000, 2, 2) };


            persons.Add(newPerson);
            MessageBox.Show(persons.Count.ToString());
            //comboBox.Items.Add(newPerson);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(comboBox.SelectedIndex != -1)
                persons.RemoveAt(comboBox.SelectedIndex);   
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            persons.Clear();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox.SelectedItem != null)
                MessageBox.Show(comboBox.SelectedItem.ToString());
        }
    }
}
