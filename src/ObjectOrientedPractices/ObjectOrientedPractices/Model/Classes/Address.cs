using ObjectOrientedPractices.Model.Classes.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validator = ObjectOrientedPractices.Services.ValueValidator;

namespace ObjectOrientedPractices.Model.Classes
{
    /// <summary>
    /// Хранит данные об адресе.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Событие, которое вызывается при каждом изменении полей объекта.
        /// </summary>
        public event EventHandler AddressChanged;

        /// <summary>
        /// Индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Строение.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает индекс. Должен быть шестизначным.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                int min = 100000;
                int max = 999999;
                Validator.AssertValueInRange(value, min, max);
                if (_index != value)
                {
                    _index = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну. Должна быть длиной до 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                int maxLength = 50;
                Validator.AssertStringOnLength(value, maxLength);
                if (_country != value)
                {
                    _country = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает город. Должн быть длиной до 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                int maxLength = 50;
                Validator.AssertStringOnLength(value, maxLength);
                if (_city != value)
                {
                    _city = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает улицу. Должна быть длиной до 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                int maxLength = 100;
                Validator.AssertStringOnLength(value, maxLength);
                if (_street != value)
                {
                    _street = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает строение. Должно быть длиной до 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                int maxLength = 10;
                Validator.AssertStringOnLength(value, maxLength);
                if (_building != value)
                {
                    _building = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры. Должн быть длиной до 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                int maxLength = 10;
                Validator.AssertStringOnLength(value, maxLength);
                if (_apartment != value)
                {
                    _apartment = value;
                    AddressChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Индекс. Должен быть шестизначным.</param>
        /// <param name="country">Страна. Длиной до 50 символов</param>
        /// <param name="city">Город. Длиной до 50 символов</param>
        /// <param name="street">Улица. Длиной до 100 символов</param>
        /// <param name="building">Строение. Длиной до 10 символов</param>
        /// <param name="apartment">Номер квартиры. Длиной до 10 символов</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/> без инициализации.
        /// </summary>
        public Address()
        {
        }

        /// <summary>
        /// Клонирует текущий объект.
        /// </summary>
        /// <returns>Новый объект, с теми же значениями полей.</returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Проверяет, совпадают ли текущий объект с предоставляемым. 
        /// </summary>
        /// <param name="other">Предоставляемы для сравнения объект.</param>
        /// <returns>Логическое значение.</returns>
        public bool Equals(Address? other)
        {
            if (other == null)
            {
                return false;
            }
            if (other is not Address)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if ((Index != other.Index) || (Country != other.Country) || (City != other.City) || (Street != other.Street) 
                || (Building != other.Building) || (Apartment != other.Apartment))
            {
                return false;
            }
            return true;
        }
    }
}
