using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_PhoneBook
{
    public class Contact//: INotifyPropertyChanged
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public bool IsMale { get; set; }
        public override string ToString()
        {
            return $"{Name}  {Surname}";
        }
    }
}
