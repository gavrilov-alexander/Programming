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
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="PriorityOrdersTab"/>.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Элемент класса <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _order;

        /// <summary>
        /// Возвращает и задает элемент класса <see cref="PriorityOrder"/>.
        /// </summary>
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

        /// <summary>
        /// Коллекция элементов типа <see cref="string"/>, используемая для выбора времени доставки.
        /// </summary>
        private BindingList<string> _deliverytimes = new BindingList<string>() { "9:00 - 11:00", "11:00 - 13:00",
                                                        "13:00 - 15:00", "15:00 - 17:00", "17:00 - 19:00", "19:00 - 21:00" };

        /// <summary>
        /// Создает объект типа <see cref="PriorityOrdersTab"/>.
        /// </summary>
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
        /// Заполняет DeliveryTimeComboBox данными из _deliverytimes.
        /// </summary>
        private void FillOrderDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.DataSource = _deliverytimes;
        }

        /// <summary>
        /// Заполняет IdTextBox, DataTextBox, StatusComboBox, ItemsListBox,
        /// AmountLabel, DeliveryTimeComboBox значениями из Order.
        /// </summary>
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
        /// Добавляет в Order.Items случайно сгенерированный в <see cref="ItemFactory"/> объект.
        /// </summary>
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Order.Items.Add(ItemFactory.GenerateItem());
            ItemsListBox.SelectedIndex = Order.Items.Count - 1;
        }

        /// <summary>
        /// Удаляет из Order.Items выбранный в ItemsListBox элемент.
        /// </summary>
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

        /// <summary>
        /// Добавляет в Order случайно сгенерированный заказ.
        /// </summary>
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

        /// <summary>
        /// Записывает в Order.Status значение из StatusComboBox.
        /// </summary>
        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Записывает в Order.Status значение из DeliveryTimeComboBox.
        /// </summary>
        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.DeliveryTime = (string)DeliveryTimeComboBox.SelectedItem;
        }
    }
}
