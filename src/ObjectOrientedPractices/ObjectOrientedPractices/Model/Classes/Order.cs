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

        //private readonly Data dataCreation

        public BindingList<Item> Items;

        public OrderStatus OrderStatus;

        public int Id { get { return _id; } }

        public Address Address;

        public Order(BindingList<Item> items, Address address, OrderStatus orderStatus)
        {
            _id = _idCounter;
            _idCounter++;
            Items = items;
            Address = address;
            OrderStatus = orderStatus;
        }

    }
}
