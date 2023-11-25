using ObjectOrientedPractices.Model.Classes;
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
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.Model.Classes.Orders;

namespace ObjectOrientedPractices.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {
        private PriorityOrder _order;
        public PriorityOrder Order
        {
            get
            {
                return _order;
            }
            set
            {
                _order = value;
            }
        }
        private BindingList<string> _deliverytimes = new BindingList<string>() { "9:00 - 11:00", "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        public PriorityOrdersTab()
        {
            InitializeComponent();
            BindingList<Item> items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(ItemFactory.GenerateItem());
            }
            Customer customer = CustomerFactory.GenerateCustomer();
            Order = new PriorityOrder(items, customer.Address, OrderStatus.New, customer, 0, DateTime.Now, _deliverytimes[0]);
            FillOrderStatusComboBox();
            FillOrderDeliveryTimeComboBox();
            FillOrderData();
        }
        private void FillOrderStatusComboBox()
        {
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatuses)
            {
                StatusComboBox.Items.Add(status);
            }
        }
        private void FillOrderDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.DataSource = _deliverytimes;
        }
        private void FillOrderData()
        {
            IdTextBox.Text = Order.Id.ToString();
            DataTextBox.Text = Order.DateCreation.ToString();
            StatusComboBox.SelectedItem = Order.Status;
            AddressControl1.Address = Order.Address;
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = Order.Items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
            ItemsListBox.SelectedIndex = -1;
            AmountLabel.Text = Order.Amount.ToString();
            DeliveryTimeComboBox.SelectedItem = Order.DeliveryTime;
        }

        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Order.Items.Add(ItemFactory.GenerateItem());
            ItemsListBox.SelectedIndex = Order.Items.Count - 1;
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            int index = ItemsListBox.SelectedIndex;
            Order.Items.Remove(Order.Items[ItemsListBox.SelectedIndex]);
            if (Order.Items.Count > index)
            {
                ItemsListBox.SelectedIndex = index;
            }
            else
            {
                ItemsListBox.SelectedIndex = Order.Items.Count - 1;
            }
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            BindingList<Item> items = new BindingList<Item>();
            for (int i = 0; i < 10; i++)
            {
                items.Add(ItemFactory.GenerateItem());
            }
            Customer customer = CustomerFactory.GenerateCustomer();
            Order = new PriorityOrder(items, customer.Address, OrderStatus.New, customer, 0, DateTime.Now, _deliverytimes[0]);
            FillOrderData();
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
