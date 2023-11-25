using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes.Orders
{
    /// <summary>
    /// Хранит данные о заказе.
    /// </summary>
    public class Order : IEquatable<Order>
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
        /// Дата создания объекта.
        /// </summary>
        private readonly DateTime _dateCreation;

        /// <summary>
        /// Лист типа <see cref="Item"/>, хранящий заказанные товары.
        /// </summary>
        public BindingList<Item> Items;

        /// <summary>
        /// Возвращает и задает статус.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возвращает и задает покупателя, типа <see cref="Classes.Customer"/>.
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Возвращает и задает адрес, типа <see cref="Classes.Address"/>.
        /// </summary>
        public Address Address { get; set; }

        /// <summary>
        /// Возвращает и задает сумму предоставляемой по данному заказу скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Возвращает дату создания.
        /// </summary>
        public DateTime DateCreation
        {
            get { return _dateCreation; }
        }

        /// <summary>
        /// Возвращает статус в виде строки.
        /// </summary>
        public string StatusToString => Status.ToString();

        /// <summary>
        /// Возвращает полное имя покупателя в виде строки.
        /// </summary>
        public string CustomerFullNameToString => Customer.FullName;

        /// <summary>
        /// Возвращает стоимость заказа.
        /// </summary>
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

        /// <summary>
        /// Возвращает итоговую стоимость заказа.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }

        /// <summary>
        /// Возвращает адрес заказа в виде строки.
        /// </summary>
        public string AddressToString => $"{Address.Index}, {Address.Country}, {Address.City}, {Address.Street}, {Address.Building}, {Address.Apartment}";

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="status">Статус.</param>
        /// <param name="customer">Покупатель.</param>
        /// <param name="discountAmount">Размер скидки.</param>
        public Order(BindingList<Item> items, Address address, OrderStatus status, Customer customer, double discountAmount)
        {
            _id = _idCounter;
            _idCounter++;
            _dateCreation = DateTime.Now;
            Items = items;
            Address = address;
            Status = status;
            Customer = customer;
            DiscountAmount = discountAmount;
        }

        /// <summary>
        /// Проверяет, совпадают ли текущий объект с предоставляемым. 
        /// </summary>
        /// <param name="other">Предоставляемы для сравнения объект.</param>
        /// <returns>Логическое значение.</returns>
        public bool Equals(Order? other)
        {
            if (other == null)
            {
                return false;
            }
            if (other is not Order)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if (Items.Count != other.Items.Count)
            {
                return false;
            }
            for (int i = 0; i < Items.Count; i++)
            {
                if (!(Items[i].Equals(other.Items[i])))
                {
                    return false;
                }
            }
            if ((!(Address.Equals(other.Address))) || (Status != other.Status) || (Customer != other.Customer) 
                || (DiscountAmount != other.DiscountAmount))
            {
                return false;
            }
            return true;
        }
    }
}
