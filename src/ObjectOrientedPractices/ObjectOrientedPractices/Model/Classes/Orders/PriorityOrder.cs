using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model.Classes.Orders
{
    /// <summary>
    /// Хранит данные о заказе, с указаным предпочитаемой датой и временем доставки.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Вохвращает и задает дату доставки.
        /// </summary>
        public DateTime DeliveryDate { get; set; }

        /// <summary>
        /// Возвращает и задает время доставки.
        /// </summary>
        public string DeliveryTime { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="address">Адрес.</param>
        /// <param name="status">Статус.</param>
        /// <param name="customer">Покупатель.</param>
        /// <param name="discountAmount">Размер скидки.</param>
        /// <param name="deliveryDate">Дата доставки.</param>
        /// <param name="deliveryTime">Время доставки.</param>
        public PriorityOrder(BindingList<Item> items, Address address, OrderStatus status, Customer customer, double discountAmount,
                            DateTime deliveryDate, string deliveryTime) : base(items, address, status, customer, discountAmount)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
