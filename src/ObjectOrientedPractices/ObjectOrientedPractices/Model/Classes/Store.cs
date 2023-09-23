using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    public class Store
    {
        private BindingList<Item> _items = new BindingList<Item>();
        private BindingList<Customer> _customers = new BindingList<Customer>();

        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public Store()
        {
        }
    }
}
