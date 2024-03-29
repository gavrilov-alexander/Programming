﻿using ObjectOrientedPractices.Services;
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
using ObjectOrientedPractices.Services;
using ObjectOrientedPractices.View.Controls;
using ObjectOrientedPractices.Model.Interfaces;
using ObjectOrientedPractices.View.Forms;
using ObjectOrientedPractices.Model.Classes.Discounts;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="CustomersTab"/>.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        //// <summary>
        /// Событие, вызываемое при каждом изменении покупателей.
        /// </summary>
        public event EventHandler CustomersChanged;

        /// <summary>
        /// Коллекция элементов класса <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

        /// <summary>
        /// Возвращает и задает коллекция элементов класса <see cref="Customer"/>.
        /// </summary>
        public BindingList<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Выбранный в CustomersListBox элемент.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создаваемый объект класса <see cref="Customer"/>.
        /// </summary>
        private Customer _newCustomer = new Customer();

        /// <summary>
        /// Количество случайно генерируемых элементов коллекции _customers по нажатию кнопки AddListButton.
        /// </summary>
        public const int DesualtSize = 10;



        /// <summary>
        /// Создает объект типа <see cref="CustomersTab"/>
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
            _currentCustomer = _newCustomer;
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FillCustomersListBox();
            AddressControl1.Address = _currentCustomer.Address;
            DiscountsListBox.DisplayMember = nameof(IDiscount.Info);
            DiscountsListBox.DataSource = _currentCustomer.Discounts;
        }

        /// <summary>
        /// Заполняет CustomersListBox элементами коллекции Customers.
        /// </summary>
        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = Customers;
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Удаляет данные из IdTextBox, FullNameTextBox, AddressTextBox, PriorityCheckBox.
        /// </summary>
        private void ClearCurrentCustomer()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            PriorityCheckBox.Checked = false;
        }

        /// <summary>
        /// Обновляет данные, отображаемые в CustomersListBox.
        /// </summary>
        private void UpdateCustomersListBoxDisplayMember()
        {
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Заполняет IdTextBox, FullNameTextBox, AddressTextBox, PriorityCheckBox, DiscountsListBox значениями выбранного в CustomersListBox элемента.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || Customers.Count == 0)
            {
                _currentCustomer = _newCustomer;
                AddressControl1.Address = _currentCustomer.Address;
                ClearCurrentCustomer();
                IdTextBox.Text = _newCustomer.Id.ToString();
                PriorityCheckBox.Checked = _newCustomer.IsPriority;
                DiscountsListBox.DataSource = _newCustomer.Discounts;
                DiscountsListBox.SelectedIndex = -1;
                ApplyButton.Visible = true;
                return;
            }
            ApplyButton.Visible = false;
            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            AddressControl1.Address = _currentCustomer.Address;
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.DataSource = _currentCustomer.Discounts;
            DiscountsListBox.SelectedIndex = -1;
            _currentCustomer.Address.AddressChanged += delegate { CustomersChanged?.Invoke(this, EventArgs.Empty); };
        }

        /// <summary>
        /// Выбирает активным для заполнения элемент _newCustomer.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem == null || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в _customers случайно сгенерированные элементы класса <see cref="Customer"/>.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DesualtSize; i++)
            {
                _currentCustomer = null;
                _currentCustomer = CustomerFactory.GenerateCustomer();
                Customers.Add(_currentCustomer);
            }
            _currentCustomer = null;
            FillCustomersListBox();
            CustomersListBox.SelectedIndex = -1;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Удаляет из _customers выбранный в CustomersListBox элемент.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || CustomersListBox.SelectedItem == null)
            {
                return;
            }
            Customers.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Добавляет в Customers заполненный значениям элемент _newCustomer.
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.BackColor == Color.Pink
                || FullNameTextBox.Text == ""
                || _currentCustomer != _newCustomer)
            {
                return;
            }
            _currentCustomer = null;
            Customers.Add(_newCustomer);
            _newCustomer = new Customer();
            FillCustomersListBox();
            CustomersListBox.SelectedIndex = -1;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Контролирует изменение IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Записывает в _currentCustomer значение из FullNameTextBox.
        /// </summary>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentCustomer == null)
                {
                    return;
                }
                FullNameTextBox.BackColor = Color.White;
                if (_currentCustomer.FullName == FullNameTextBox.Text)
                {
                    return;
                }
                _currentCustomer.FullName = FullNameTextBox.Text;
                CustomersChanged?.Invoke(this, EventArgs.Empty);
                if (!(_currentCustomer == _newCustomer))
                {
                    UpdateCustomersListBoxDisplayMember();
                }
            }
            catch
            {
                FullNameTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Контролирует фокусировку CustomersListBox.
        /// </summary>
        private void CustomersListBox_Leave(object sender, EventArgs e)
        {
            UpdateCustomersListBoxDisplayMember();
        }

        /// <summary>
        /// Записывает в _currentCustomer значение из PriorityCheckBox.
        /// </summary>
        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (_currentCustomer == null)
            {
                return;
            }
            if (_currentCustomer.IsPriority == PriorityCheckBox.Checked)
            {
                return;
            }
            _currentCustomer.IsPriority = PriorityCheckBox.Checked;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Вызывает форму класса <see cref="AddDiscountForm"/>.
        /// </summary>
        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            DialogResult result = addDiscountForm.ShowDialog();
            if (DialogResult.OK == result)
            {
                PercentDiscount newDiscount = new PercentDiscount(0, addDiscountForm.Category);
                _currentCustomer.Discounts.Add(newDiscount);
                DiscountsListBox.SelectedItem = newDiscount;
                CustomersChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Удаляет из _currentCustomer.Discounts выбранный в DiscountsListBox элемент.
        /// </summary>
        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == -1 || DiscountsListBox.SelectedIndex == 0)
            {
                return;
            }
            _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
