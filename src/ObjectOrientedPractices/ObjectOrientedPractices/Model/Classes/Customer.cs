using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Classes.Discounts;
using ObjectOrientedPractices.Model.Classes.Orders;
using ObjectOrientedPractices.Model.Interfaces;
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
        /// Корзина.
        /// </summary>
        private Cart _cart;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Order> _orders = new BindingList<Order>();

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        public Address Address;

        /// <summary>
        /// Список скидок.
        /// </summary>
        public BindingList<IDiscount> Discounts {  get; set; }

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
        /// Возвращает и задает корзину товаров.
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            private set
            {
                _cart = value;
            }
        }

        /// <summary>
        /// Возвращает и задает список заказов.
        /// </summary>
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Возвращает и задает указатель приоритетности покупателя.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">Полное имя покупателя. Длина строки должна быть меньше 200 символов.</param>
        /// <param name="address">Адрес покупателя. Длина строки должна быть меньше 500 символов.</param>
        /// <param name="isPriority">Указатель приоритетности.</param>
        /// <param name="discounts">Список скидок.</param>
        public Customer(string fullName, Address address, bool isPriority, BindingList<IDiscount> discounts)
        {
            _id = _idCounter;
            _idCounter++;
            FullName = fullName;
            Address = address;
            Cart= new Cart();
            IsPriority = isPriority;
            Discounts = discounts;
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
            IsPriority = false;
            Discounts = new BindingList<IDiscount> { new PointsDiscount() };
        }
    }
}
