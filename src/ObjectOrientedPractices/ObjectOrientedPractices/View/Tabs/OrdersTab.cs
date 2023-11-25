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
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="OrdersTab"/>.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Order"/>.
        /// </summary>
        private BindingList<Order> _orders;

        /// <summary>
        /// Возвращает и задает коллекцию элементов класса <see cref="Order"/>.
        /// </summary>
        public BindingList<Order> Orders
        {
            get { return _orders; }
            set { _orders = value; }
        }

        /// <summary>
        /// Выбранный в OrdersDataGridView элемент класса <see cref="Order"/>.
        /// </summary>
        private Order _currentOrder;

        /// <summary>
        /// Выбранный в OrdersDataGridView элемент класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _currentPriorityOrder;

        /// <summary>
        /// Коллекция элементов класса <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задает коллекцию элементов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Коллекция элементов типа <see cref="string"/>, используемая для выбора времени доставки.
        /// </summary>
        private BindingList<string> _deliverytimes = new BindingList<string>() { "9:00 - 11:00", 
                                    "11:00 - 13:00", "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        /// <summary>
        /// Создает объект типа <see cref="OrdersTab"/>.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
            Orders = new BindingList<Order>();
            FillOrdersDataGridView();
            FillOrderStatusComboBox();
            FillOrderDeliveryTimeComboBox();
            PriorityOptionsGroupBox.Visible = false;
        }

        /// <summary>
        /// Формирует коллекцию Orders.
        /// </summary>
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

        /// <summary>
        /// Заполняет StatusComboBox элементами перечисления <see cref="OrderStatus"/>.
        /// </summary>
        private void FillOrderStatusComboBox()
        {
            var orderStatuses = Enum.GetValues(typeof(OrderStatus));
            foreach (var status in orderStatuses)
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Заполняет данными Orders и OrdersDataGridView.
        /// </summary>
        public void RefreshData(object sender, EventArgs e)
        {
            UpdateOrders();
            FillOrdersDataGridView();
        }

        /// <summary>
        /// Заполняет OrdersDataGridView данными из Orders.
        /// </summary>
        private void FillOrdersDataGridView()
        {
            OrdersDataGridView.DataSource = null;
            OrdersDataGridView.DataSource = Orders;
        }

        /// <summary>
        /// Заполняет DeliveryTimeComboBox данными из _deliverytimes.
        /// </summary>
        private void FillOrderDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.DataSource = _deliverytimes;
        }

        /// <summary>
        /// Заполняет данными IdTextBox, DataTextBox, AddressControl1, ItemsListBox, AmountLabel, TotalLabel из выбранного в OrdersDataGridView элемента.
        /// </summary>
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

        /// <summary>
        /// Контролирует изменение IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует изменение DataTextBox.
        /// </summary>
        private void DataTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует изменение AddressControl1.
        /// </summary>
        private void AddressControl1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует изменение ItemsListBox.
        /// </summary>
        private void ItemsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Записывает в _currentOrder.Status значение из StatusComboBox.
        /// </summary>
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

        /// <summary>
        /// Записывает в _currentPriorityOrder.Status значение из DeliveryTimeComboBox.
        /// </summary>
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
