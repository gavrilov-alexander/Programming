using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractices.Model.Enums;
using System.Reflection.Metadata.Ecma335;
using ObjectOrientedPractices.Model.Interfaces;
using System.Globalization;
using System.ComponentModel;

namespace ObjectOrientedPractices.Model.Classes.Discounts
{
    /// <summary>
    /// Хранит данные о процентной скидке на товары определенной категории, его названии и сумме покупок по данной категории.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Количество процентов скидки.
        /// </summary>
        private int _percents;

        /// <summary>
        /// Сумма покупок.
        /// </summary>
        private double _sum;

        /// <summary>
        /// Возвращает и задает количество процентов. Должно быть в диапозоне от 0 до 10.
        /// </summary>
        public int Percents
        {
            get
            {
                return _percents;
            }
            private set
            {
                int min = 0;
                int max = 10;
                ValueValidator.AssertValueInRange(value, min, max);
                _percents = value;
            }
        }

        /// <summary>
        /// Возвращает и задает категорию товаров, на которую предоставляется скидка.
        /// </summary>
        public Category Category { get; private set; }

        /// <summary>
        /// Возвращает и задает сумму покупок. Должна быть положительна.
        /// </summary>
        public double Sum
        {
            get
            {
                return _sum;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value);
                _sum = value;
            }
        }

        /// <summary>
        /// Возвращает строку, содержащую <see cref="Category"/> и <see cref="Percents"/>.
        /// </summary>
        public string Info => $"Процентная «{Category}» - {Percents}%";

        /// <summary>
        /// Считает возможную сумму скидки.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            return Convert.ToInt32(sum * Percents);
        }

        /// <summary>
        /// Считает возможную сумму скидки, обновляет сумму покупок.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        /// <returns>Сумма скидки.</returns>
        public double Apply(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            Sum += sum;
            return Convert.ToInt32(sum * Percents);
        }

        /// <summary>
        /// Устанавливает новое количество процентов, предостовляемой скидки.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        public void Update(BindingList<Item> items)
        {           
            try
            {
                Percents = Convert.ToInt32(Sum) % 1000;
            }
            catch
            {
                Percents = 10;
            }
        }

        /// <summary>
        /// Считает сумму товаров, которые принадлежат текущей категории.
        /// </summary>
        /// <param name="items">Лист товаров, стоимсоть которого считается.</param>
        /// <returns>Сумму стоимостей товаров.</returns>
        private double CalculateSum(BindingList<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category)
                {
                    sum += item.Cost;
                }
            }
            return sum;
        }

        /// <summary>
        /// Сравнивает текущий объект, с предоставленным по предоставляемой процентой скидке.
        /// </summary>
        /// <param name="other">Объект, с которым сравнивается текущий объект.</param>
        /// <returns>Число, показывающее, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки</returns>
        public int CompareTo(PercentDiscount? other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other is not PercentDiscount)
            {
                return -1;
            }
            if (Percents == other.Percents)
            {
                return 0;
            }
            if (Percents > other.Percents)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="sum">Сумма покупок по категории. Должна быть положительна.</param>
        /// <param name="category">Категория, на котороую предоставляется скидка. Должна принадлежать <see cref="Enums.Category"/></param>
        public PercentDiscount(double sum, Category category)
        {
            Sum = sum;
            Percents = Convert.ToInt32(Sum) / 1000;
            Category = category;
        }
    }
}
