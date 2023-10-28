using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _08_ListBox
{
    internal class Student : INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            {
                name = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullInfo));
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set 
            { 
                age = value;
                OnPropertyChanged(); 
                OnPropertyChanged(nameof(FullInfo));
            }
        }
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string FullInfo => Name + " " + Age;


        public event PropertyChangedEventHandler? PropertyChanged;

        public override string ToString()
        {
           
            //
            return $"{Name} : {Age}";
        }
    }
}
