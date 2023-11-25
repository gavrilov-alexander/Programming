using ObjectOrientedPractices.Model.Interfaces;
using ObjectOrientedPractices.Model.Classes.Discounts;
using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="DiscountsTab"/>.
    /// </summary>
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Скидка класса, реализующая <see cref="IDiscount"/>.
        /// </summary>
        public IDiscount Discount { get; set; }

        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        public BindingList<Item> Items { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="DiscountsTab"/>.
        /// </summary>
        public DiscountsTab()
        {

            InitializeComponent();
        }

        /// <summary>
        /// Отображает предоставляему скидку в DiscountAmountLabel.
        /// </summary>
        private void CalculateButton_Click(object sender, EventArgs e)
        {

            DiscountAmountLabel.Text = Discount.Calculate(Items).ToString();
        }

        /// <summary>
        /// Отображает предоставляему скидку в DiscountAmountLabel.
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            DiscountAmountLabel.Text = Discount.Apply(Items).ToString();
        }

        /// <summary>
        /// Принимает текущую скидку к списку товаров.
        /// </summary>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Discount.Update(Items);
            InfoLabel.Text = Discount.Info;
        }

        /// <summary>
        /// Случайно генерирует список товаров из 10 элементов, а так же случайно генерирует скидку типа <see cref="PointsDiscount"/>.
        /// </summary>
        private void PointsDiscountButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int points = random.Next(100000, 150000);
            Discount = new PointsDiscount(points);
            Items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                Items.Add(ItemFactory.GenerateItem());
            }
            InfoLabel.Text = Discount.Info;
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.Cost;
            }
            ProductsAmountLabel.Text = sum.ToString();
        }

        /// <summary>
        /// Случайно генерирует список товаров из 10 элементов, а так же случайно генерирует скидку типа <see cref="PercentDiscount"/>.
        /// </summary>
        private void PercentDiscountButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            double sumBought = random.Next(1000, 10001);
            Items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                Items.Add(ItemFactory.GenerateItem());
            }
            Discount = new PercentDiscount(sumBought, Items[0].Category);
            InfoLabel.Text = Discount.Info;
            double sum = 0;
            foreach (var item in Items)
            {
                sum += item.Cost;
            }
            ProductsAmountLabel.Text = sum.ToString();
        }
    }
}
