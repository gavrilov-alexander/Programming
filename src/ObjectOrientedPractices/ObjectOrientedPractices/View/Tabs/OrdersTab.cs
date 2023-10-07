using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        private BindingList<Order> _orders;
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }
        private BindingList<Customer> _customers;
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        public OrdersTab()
        {
            InitializeComponent();
            Orders = new BindingList<Order>();
            FillOrdersDataGridView();
            FillOrderStatusComboBox();
        }
        private void UpdateOrders()
        {
            Orders.Clear();
            foreach (Customer customer in Customers)
            {
                foreach (Order order in customer.Orders)
                {
                    Orders.Add(order);
                }
            }
        }
        private void FillOrderStatusComboBox()
        {
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatuses)
            {
                StatusComboBox.Items.Add(status);
            }
        }
        public void RefreshData()
        {
            UpdateOrders();
            FillOrdersDataGridView();
        }
        private void FillOrdersDataGridView()
        {
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = Orders;
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null)
            {
                return;
            }
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            Order currentOrder = Orders[index];
            IdTextBox.Text = currentOrder.Id.ToString();
            DataTextBox.Text = currentOrder.DateCreation.ToString();
            StatusComboBox.SelectedItem = currentOrder.Status;
            AddressControl1.Address = currentOrder.Address;
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = currentOrder.Items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
            ItemsListBox.SelectedIndex = -1;
            AmountLabel.Text = currentOrder.Amount.ToString();
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddressControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null)
            {
                return;
            }
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            Order currentOrder = Orders[index];
            if (currentOrder.Status != (OrderStatus)StatusComboBox.SelectedItem)
            {
                currentOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                FillOrdersDataGridView();
            }
        }
    }
}
