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
using ObjectOrientedPractices.Model.Classes.Orders;
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
        private Order _currentOrder;
        private PriorityOrder _currentPriorityOrder;
        private BindingList<Customer> _customers;
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        private BindingList<string> _deliverytimes = new BindingList<string>() { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };
        public OrdersTab()
        {
            InitializeComponent();
            Orders = new BindingList<Order>();
            FillOrdersDataGridView();
            FillOrderStatusComboBox();
            FillOrderDeliveryTimeComboBox();
            PriorityOptionsGroupBox.Visible = false;
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
        public void RefreshData(object sender, EventArgs e)
        {
            UpdateOrders();
            FillOrdersDataGridView();
        }
        private void FillOrdersDataGridView()
        {
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = Orders;
        }
        private void FillOrderDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.DataSource = _deliverytimes;
        }
        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null)
            {
                PriorityOptionsGroupBox.Visible = false;
                return;
            }
            int index = OrdersDataGridView.CurrentCell.RowIndex;
            _currentOrder = Orders[index];
            if (_currentOrder is PriorityOrder _currentPriorityOrder)
            {
                PriorityOptionsGroupBox.Visible = true;
                DeliveryTimeComboBox.SelectedItem = _currentPriorityOrder.DeliveryTime;
            }
            else
            {
                PriorityOptionsGroupBox.Visible = false;
            }
            IdTextBox.Text = _currentOrder.Id.ToString();
            DataTextBox.Text = _currentOrder.DateCreation.ToString();
            StatusComboBox.SelectedItem = _currentOrder.Status;
            AddressControl1.Address = _currentOrder.Address;
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _currentOrder.Items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
            ItemsListBox.SelectedIndex = -1;
            AmountLabel.Text = _currentOrder.Amount.ToString();
            TotalLabel.Text = _currentOrder.Total.ToString();
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
            if (_currentOrder.Status != (OrderStatus)StatusComboBox.SelectedItem)
            {
                _currentOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
                FillOrdersDataGridView();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.CurrentCell == null)
            {
                return;
            }
            if (_currentPriorityOrder == null)
            {
                return;
            }
            _currentPriorityOrder.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
