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
    public partial class CartsTab : UserControl
    {
        public event EventHandler OrdersChanged;
        public BindingList<Item> Items;
        public BindingList<Customer> Customers;
        public BindingList<Order> Orders;
        private Customer _currentCustomer;
        public CartsTab()
        {
            InitializeComponent();
            FillItemsListBox();
            FillCustomersComboBox();
        }
        public void RefreshData(object sender, EventArgs e)
        {
            FillItemsListBox();
            FillCustomersComboBox();
        }
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Items;
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        private void FillCustomersComboBox()
        {
            CustomersComboBox.DataSource = null;
            CustomersComboBox.DataSource = Customers;
            CustomersComboBox.DisplayMember = null;
            CustomersComboBox.DisplayMember = nameof(Customer.FullName);
        }
        private void FillDiscountsCheckedListBox()
        {
            DiscountsCheckedListBox.DataSource = null;
            DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
            DiscountsCheckedListBox.DisplayMember = null;
            DiscountsCheckedListBox.DisplayMember = nameof(IDiscount.Info);
        }
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
        private void UpdateCartListBox()
        {
            CartListBox.DataSource = null;
            CartListBox.DataSource = _currentCustomer.Cart.Items;
            CartListBox.DisplayMember = null;
            CartListBox.DisplayMember = nameof(Item.Name);
        }
        private void CustomersComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

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

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            RefreshAmountLabel();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null || CustomersComboBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Cart.Items.Clear();
            RefreshAmountLabel();
        }

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
        private void DiscountsCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            UpdateCheckedDiscountsAmount();
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCheckedDiscountsAmount();
        }
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
