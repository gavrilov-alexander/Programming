using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private Cart _cart;

        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        public Address Address;

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
        public Cart Cart
        {
            get { return _cart; }
            private set
            {
                _cart = value;
            }
        }

        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя. Длина строки должна быть меньше 500 символов.
        /// </summary>
        /*public Address Address
        {
            get { return _address; }
            set
            {
                int maxLength = 500;
                Validator.AssertStringOnLength(value, maxLength);
                _address = value;
            }
        }*/

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Длина строки должна быть меньше 200 символов.</param>
        /// <param name="address">Адрес покупателя. Длина строки должна быть меньше 500 символов.</param>
        public Customer(string fullName, Address address)
        {
            _id = _idCounter;
            _idCounter++;
            FullName = fullName;
            Address = address;
            Cart= new Cart();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/> без инициализации.
        /// </summary>
        public Customer()
        {
            _id = _idCounter;
            _idCounter++;
            Address = new Address();
            Cart= new Cart();
        }
    }
}
