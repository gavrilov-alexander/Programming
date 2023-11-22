using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    public class Cart : ICloneable
    {
        private BindingList<Item> _items;


        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }
                double sum = 0.0;
                foreach (Item item in Items)
                {
                    sum += item.Cost;
                }
                return sum;
            }
        }
        public Cart()
        {
            Items = new BindingList<Item>();
        }
        public Cart(BindingList<Item> items)
        {
            Items = items;
        }

        public object Clone()
        {
            return new Cart(new BindingList<Item>(Items));
        }
    }
}
