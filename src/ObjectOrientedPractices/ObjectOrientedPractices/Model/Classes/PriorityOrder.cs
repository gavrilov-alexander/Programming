using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.Model.Classes
{
    public class PriorityOrder : Order
    {
        public DateTime DeliveryDate { get; set; }
        public string DeliveryTime { get; set; }

        public PriorityOrder(BindingList<Item> items, Address address, OrderStatus status, Customer customer, 
                            DateTime deliveryDate, string deliveryTime) : base(items, address, status, customer)
        {
            DeliveryDate = deliveryDate;
            DeliveryTime = deliveryTime;
        }
    }
}
