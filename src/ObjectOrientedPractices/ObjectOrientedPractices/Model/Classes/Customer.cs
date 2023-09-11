using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator = ObjectOrientedPractices.Services.ValueValidator;

namespace ObjectOrientedPractices.Model.Classes
{
    /// <summary>
    /// Хранит данные о покупателе, его полном имени и адресе.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Идентификатор количества всех объектов данного класса.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает идентификатор предмета.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает и задает полное имя покупателя. Длина строки должна быть меньше 200 символов.
        /// </summary>
        public string FullName
        {
            get { return _fullName; }
            set
            {
                int maxLength = 200;
                Validator.AssertStringOnLength(value, maxLength);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя. Длина строки должна быть меньше 500 символов.
        /// </summary>
        public string Address
        {
            get { return _address; }
            set
            {
                int maxLength = 500;
                Validator.AssertStringOnLength(value, maxLength);
                _address = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Длина строки должна быть меньше 200 символов.</param>
        /// <param name="address">Адрес покупателя. Длина строки должна быть меньше 500 символов.</param>
        public Customer(string fullName, string address)
        {
            _id = _idCounter;
            _idCounter++;
            FullName = fullName;
            Address = address;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> без инициализации.
        /// </summary>
        public Customer()
        {
            _id = _idCounter;
            _idCounter++;
        }
    }
}
