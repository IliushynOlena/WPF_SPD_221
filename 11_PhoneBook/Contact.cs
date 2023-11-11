using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _11_PhoneBook
{
    public class Contact: INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                //OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }

        private string surname;
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
               // OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public int Age { get; set; }//25
        public string Phone { get; set; }//address
        public bool IsMale { get; set; }//true

        public string FullName => $"{Name}  {Surname}";

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Contact Clone()
        {
            Contact copy = (Contact)this.MemberwiseClone();
            copy.Name = (string)this.Name.Clone();
            copy.Surname = (string)this.Surname.Clone();
            copy.Phone = (string)this.Phone.Clone();
            return copy;
        }
        public override string ToString()
        {
            return $"{Name}  {Surname}";
        }
    }
}
