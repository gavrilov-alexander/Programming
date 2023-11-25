using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.Model.Classes.Orders;
using ObjectOrientedPractices.Model.Enums;
using ObjectOrientedPractices.Model.Interfaces;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="CartsTab"/>.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Событие, вызываемое при каждом создании заказа.
        /// </summary>
        public event EventHandler OrdersChanged;

        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        public BindingList<Item> Items;

        /// <summary>
        /// Коллекция элементов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers;

        /// <summary>
        /// Коллекция элементов класса <see cref="Order"/>.
        /// </summary>
        public BindingList<Order> Orders;

        /// <summary>
        /// Выбранный в CustomersComboBox элемент.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает объект типа <see cref="CartsTab"/>.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
            FillItemsListBox();
            FillCustomersComboBox();
        }

        /// <summary>
        /// Заполняет данными ItemsListBox и CustomersComboBox.
        /// </summary>
        public void RefreshData(object sender, EventArgs e)
        {
            FillItemsListBox();
            FillCustomersComboBox();
        }

        /// <summary>
        /// Заполняет ItemsListBox данными из Items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Заполняет CustomersComboBox данными из Customers.
        /// </summary>
        private void FillCustomersComboBox()
        {
            CustomersComboBox.DataSource = null;
            CustomersComboBox.DataSource = Customers;
            CustomersComboBox.DisplayMember = null;
            CustomersComboBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Заполняет DiscountsCheckedListBox данными из _currentCustomer.Discounts.
        /// </summary>
        private void FillDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
            DiscountsCheckedListBox.DisplayMember = null;
            DiscountsCheckedListBox.DisplayMember = nameof(IDiscount.Info);
        }

        /// <summary>
        /// Обновляет значения в AmountLabel и TotalLabel.
        /// </summary>
        private void RefreshAmountLabel()
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            AmountLabel.Text = _currentCustomer.Cart.Amount.ToString();
            DiscountsAmountLabel.Text = "0";
            TotalLabel.Text = _currentCustomer.Cart.Amount.ToString();
            UpdateCheckedDiscountsAmount();
        }

        /// <summary>
        /// Заполяет CartListBox данными из _currentCustomer.Cart.Items.
        /// </summary>
        private void UpdateCartListBox()
        {
            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
            CartListBox.DisplayMember = null;
            CartListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Контролирует изменения в CustomersComboBox.
        /// </summary>
        private void CustomersComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Заполняет список товаров в корзине и список скидок при изменении выбора покупателя.
        /// </summary>
        private void CustomersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.Items.Count == 0 || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer = Customers[CustomersComboBox.SelectedIndex];
            UpdateCartListBox();
            FillDiscountsCheckedListBox();
        }

        /// <summary>
        /// Добавляет в _currentCustomer.Cart.Items выбранный в ItemsListBox элемент.
        /// </summary>
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Cart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            RefreshAmountLabel();
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Удаляет из _currentCustomer.Cart.Items выбранный в CartListBox элемент.
        /// </summary>
        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            RefreshAmountLabel();
        }

        /// <summary>
        /// Удаляет из _currentCustomer.Cart.Items все элементы.
        /// </summary>
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Cart.Items.Clear();
            RefreshAmountLabel();
        }

        /// <summary>
        /// Добавляет в _currentCustomer.Orders сформированный заказ.
        /// </summary>
        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex == -1 || _currentCustomer == null || _currentCustomer.Cart.Items.Count == 0)
            {
                return;
            }
            double discountAmount = 0;
            foreach (IDiscount discount in DiscountsCheckedListBox.CheckedItems)
            {
                discountAmount += discount.Apply(_currentCustomer.Cart.Items);
            }
            foreach (IDiscount discount in _currentCustomer.Discounts)
            {
                discount.Update(_currentCustomer.Cart.Items);
            }
            if (_currentCustomer.IsPriority)
            {
                PriorityOrder order = new PriorityOrder(_currentCustomer.Cart.Items, _currentCustomer.Address, OrderStatus.New,
                                                        _currentCustomer, discountAmount, DateTime.Now, "9:00 - 11:00");
                _currentCustomer.Orders.Add(order);
            }
            else
            {
                Order order = new Order(_currentCustomer.Cart.Items, _currentCustomer.Address, OrderStatus.New, _currentCustomer, discountAmount);
                _currentCustomer.Orders.Add(order);
            }
            _currentCustomer.Cart.Items = new BindingList<Item>();
            UpdateCartListBox();
            RefreshAmountLabel();
            FillDiscountsCheckedListBox();
            OrdersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обновляет значение в DiscountsAmountLabel и TotalLabel.
        /// </summary>
        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateCheckedDiscountsAmount();
        }

        /// <summary>
        /// Обновляет значение в DiscountsAmountLabel и TotalLabel.
        /// </summary>
        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckedDiscountsAmount();
        }

        /// <summary>
        /// Обновляет значение в DiscountsAmountLabel и TotalLabel.
        /// </summary>
        private void UpdateCheckedDiscountsAmount()
        {
            if (CustomersComboBox.SelectedIndex == -1 || _currentCustomer == null)
            {
                return;
            }
            double discountAmount = 0;
            foreach (IDiscount discount in DiscountsCheckedListBox.CheckedItems)
            {
                discountAmount += discount.Calculate(_currentCustomer.Cart.Items);
            }
            DiscountsAmountLabel.Text = discountAmount.ToString();
            TotalLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
        }
    }
}
