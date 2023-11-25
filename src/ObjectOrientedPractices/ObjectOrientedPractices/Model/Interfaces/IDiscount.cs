using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using ObjectOrientedPractices.Model.Classes;

namespace ObjectOrientedPractices.Model.Interfaces
{
    /// <summary>
    /// Хранит данные об интерфейсе скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Возвращает информация.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Считает сумму скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки</returns>
        double Calculate(BindingList<Item> items);

        /// <summary>
        /// Считает и принимает скидку.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Сумма скидки</returns>
        double Apply(BindingList<Item> items);

        /// <summary>
        /// Обновляет данные о скидке.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(BindingList<Item> items);
    }
}
