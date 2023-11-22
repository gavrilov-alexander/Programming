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
    public class PercentDiscount : IDiscount
    {
        private int _percents;
        private double _sum;
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
        public Category Category { get; private set; }
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
        public string Info => $"Процентная «{Category}» - {Percents}%";
        public double Calculate(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            return Convert.ToInt32(sum * Percents);
        }

        public double Apply(BindingList<Item> items)
        {
            double sum = CalculateSum(items);
            Sum += sum;
            return Convert.ToInt32(sum * Percents);
        }
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
        public PercentDiscount(double sum, Category category)
        {
            Sum = sum;
            Percents = Convert.ToInt32(Sum) / 1000;
            Category = category;
        }
    }
}
