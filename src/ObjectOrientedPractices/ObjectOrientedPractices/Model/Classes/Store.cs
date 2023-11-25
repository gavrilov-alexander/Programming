using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    /// <summary>
    /// Хранит данные о списке товаров и о списке покупателей.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/> без инициализации.
        /// </summary>
        public Store()
        {
        }
    }
}
