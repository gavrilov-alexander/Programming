using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model.Interfaces;
using ObjectOrientedPractices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractices.Model.Classes.Discounts
{
    /// <summary>
    /// Хранит данные о накопительной скидке на товары и сумме накопленных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        /// <summary>
        /// Количество накопленных баллов.
        /// </summary>
        private int points;

        /// <summary>
        /// Возвращает и задает количество накопленных баллов. Должно быть положительно.
        /// </summary>
        public int Points
        {
            get
            {
                return points;
            }
            private set
            {
                ValueValidator.AssertOnPositiveValue(value);
                points = value;
            }
        }

        /// <summary>
        /// Возвращает строку, содержащую <see cref="Points"/>.
        /// </summary>
        public string Info => $"Накопительная - {Points} баллов";

        /// <summary>
        /// Считает возможную сумму скидки.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        /// <returns>Сумма скидки.</returns>
        public double Calculate(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            if ((sum * 0.3) > Points)
            {
                return Points;
            }
            else
            {
                return Convert.ToInt32(sum * 0.3);
            }
        }

        /// <summary>
        /// Считает возможную сумму скидки, списывает накопленные баллы баллы.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        /// <returns>Сумма скидки.</returns>
        public double Apply(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            if ((sum * 0.3) > Points)
            {
                Points -= Points;
                return Points;
            }
            else
            {  
                Points -= Convert.ToInt32(sum * 0.3);
                return Convert.ToInt32(sum * 0.3);
            }
        }

        /// <summary>
        /// Устанавливает новое количество баллов.
        /// </summary>
        /// <param name="items">Лист товаров, на который предоставляется скидка.</param>
        public void Update(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            if ((sum * 0.1) % 1 == 0)
            {
                Points += Convert.ToInt32(sum * 0.1);
            }
            else
            {
                Points += Convert.ToInt32(sum * 0.1) + 1;
            }
        }

        /// <summary>
        /// Считает сумму товаров.
        /// </summary>
        /// <param name="items">Лист товаров, стоимсоть которого считается.</param>
        /// <returns>Сумму стоимостей товаров.</returns>
        private double CalculateSum(BindingList<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }
            return sum;
        }

        /// <summary>
        /// Сравнивает текущий объект, с предоставленным по количеству накопленных баллов.
        /// </summary>
        /// <param name="other">Объект, с которым сравнивается текущий объект.</param>
        /// <returns>Число, показывающее, расположен ли данный экземпляр перед, после или на той же позиции в порядке сортировки</returns>
        public int CompareTo(PointsDiscount? other)
        {
            if (other == null)
            {
                return 1;
            }
            if (other is not PointsDiscount)
            {
                return -1;
            }
            if (Points == other.Points)
            {
                return 0;
            }
            if (Points > other.Points)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="points">Количество накопленных баллов. Должно быть положительно.</param>
        public PointsDiscount(int points)
        {
            Points = points;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="PointsDiscount"/> с предустановленным количеством баллов 0.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }
    }
}
