using System;

namespace _07_ListControls
{
    internal class Person
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }

        public string FullName => Name + " " + Lastname;
        public override string ToString()
        {
            return $"Name : {Name}.\nSurname {Lastname} .\nBirthday {Birthdate.ToShortDateString()}";
        }

    }
}
