using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Programming.Model.Classes
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private long _number;

        public string Name
        { 
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        public string Surname 
        { 
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        public long Number
        {
            get { return _number; }
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _number = value;
            }
        }

        public Contact()
        {
        }

        public Contact(string name, string surname, long number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        private void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string propertyName = "")
        {
            string pattern = @"[A-Z]{1}[a-z]{1,}";
            Regex regex = new Regex(pattern);
            if (!(regex.IsMatch(value)))
            {
                throw new ArgumentException($"Введено некоректное значение в поле {propertyName}");
            }
        }
    }
}
