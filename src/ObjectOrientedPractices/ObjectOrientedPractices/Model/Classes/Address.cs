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
    public class Address : ICloneable, IEquatable<Address>
    {
        private int _index;
        private string _country;
        private string _city;
        private string _street;
        private string _building;
        private string _apartment;

        public int Index
        {
            get { return _index; }
            set
            {
                int min = 100000;
                int max = 999999;
                Validator.AssertValueInRange(value, min, max);
                _index = value;
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                int maxLength = 50;
                Validator.AssertStringOnLength(value, maxLength);
                _country = value;
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                int maxLength = 50;
                Validator.AssertStringOnLength(value, maxLength);
                _city = value;
            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                int maxLength = 100;
                Validator.AssertStringOnLength(value, maxLength);
                _street = value;
            }
        }
        public string Building
        {
            get { return _building; }
            set
            {
                int maxLength = 10;
                Validator.AssertStringOnLength(value, maxLength);
                _building = value;
            }
        }
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                int maxLength = 10;
                Validator.AssertStringOnLength(value, maxLength);
                _apartment = value;
            }
        }

        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address()
        {
        }

        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

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
