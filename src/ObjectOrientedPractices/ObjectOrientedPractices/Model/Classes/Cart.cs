using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes
{
    /// <summary>
    /// Хранит данные о корзине.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Возвращает и задает список товаров.
        /// </summary>
        public BindingList<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Возвращает стоимость товаров.
        /// </summary>
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

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/> без инициализации.
        /// </summary>
        public Cart()
        {
            Items = new BindingList<Item>();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список товаров</param>
        public Cart(BindingList<Item> items)
        {
            Items = items;
        }

        /// <summary>
        /// Клонирует текущий объект.
        /// </summary>
        /// <returns>Новый объект, с тем же списком товаров.</returns>
        public object Clone()
        {
            return new Cart(new BindingList<Item>(Items));
        }
    }
}
