using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    public class Order
    {
        /// <summary>
        /// Идентификатор количества всех объектов данного класса.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        private readonly DateTime _dateCreation;

        public BindingList<Item> Items;

        public OrderStatus Status;
        public Customer Customer;
        public Address Address;



        public int Id { get { return _id; } }

        
        public DateTime DateCreation
        {
            get { return _dateCreation; }
        }


        public string StatusToString
        {
            get
            {
                return Status.ToString();
            }
        }
        public string CustomerFullNameToString
        {
            get
            {
                return Customer.FullName;
            }
        }
        public double Amount
        {
            get
            {
                double amount = 0;
                foreach (var item in Items)
                {
                    amount += item.Cost;
                }
                return amount;
            }
        }
        public string AddressToString
        {
            get
            {
                return $"{Address.Index}, {Address.Country}, {Address.City}, {Address.Street}, {Address.Building}, {Address.Apartment}";
            }
        }


        public Order(BindingList<Item> items, Address address, OrderStatus status, Customer customer)
        {
            _id = _idCounter;
            _idCounter++;
            _dateCreation = DateTime.Now;
            Items = items;
            Address = address;
            Status = status;
            Customer = customer;
        }
    }
}
