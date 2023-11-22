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
    public class PointsDiscount : IDiscount, IComparable<PointsDiscount>
    {
        private int points;
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
        public string Info => $"Накопительная - {Points} баллов";
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
        private double CalculateSum(BindingList<Item> items)
        {
            double sum = 0;
            foreach (Item item in items)
            {
                sum += item.Cost;
            }
            return sum;
        }

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

        public PointsDiscount(int points)
        {
            Points = points;
        }
        public PointsDiscount()
        {
            Points = 0;
        }
    }
}
