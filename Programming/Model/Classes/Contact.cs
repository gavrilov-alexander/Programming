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
    /// <summary>
    /// Хранит данные о контакте, имя, фамилию и номер. 
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер.
        /// </summary>
        private long _number;

        /// <summary>
        /// Возвращает и задает имя контакта. Должно состоять только из букв.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает фамилию контакта. Должна состоять только из букв.
        /// </summary>
        public string Surname 
        {
            get => _surname;
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта. Должен быть положителен.
        /// </summary>
        public long Number
        {
            get => _number;
            set 
            {
                Validator.AssertOnPositiveValue(value);
                _number = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/> без инициализации.
        /// </summary>
        public Contact()
        {
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно стостоять только из букв.</param>
        /// <param name="surname">Фамилия. Должна стостоять только из букв.</param>
        /// <param name="number">Номер. Должен быть положителен.</param>
        public Contact(string name, string surname, long number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="propertyName">Имя свойства или объекта, которое подлежит проверке.</param>
        /// <exception cref="ArgumentException">Возникает, если проверяемая строка состоит не из букв.</exception>
        private void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string propertyName = "")
        {
            string pattern = @"[A-Z]{1}[a-z]{1,}";
            Regex regex = new Regex(pattern);
            if (!(regex.IsMatch(value)))
            {
                throw new ArgumentException($"Введено некорректное значение в поле {propertyName}");
            }
        }
    }
}
