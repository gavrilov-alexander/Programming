using ObjectOrientedPractices.Services;
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

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="CustomersTab"/>.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Customer"/>.
        /// </summary>
        private BindingList<Customer> _customers;

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
        }

        public void RefreshData()
        {
            FillCustomersListBox();
        }

        /// <summary>
        /// Заполняет CustomersListBox элементами коллекции _customers.
        /// </summary>
        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = Customers;
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Удаляет данные из IdTextBox, FullNameTextBox, AddressTextBox.
        /// </summary>
        private void ClearCurrentItem()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
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
        /// Заполняет IdTextBox, FullNameTextBox, AddressTextBox значениями выбранного в CustomersListBox элемента.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || Customers.Count == 0)
            {
                _currentCustomer = _newCustomer;
                AddressControl1.Address = _currentCustomer.Address;
                ClearCurrentItem();
                IdTextBox.Text = _newCustomer.Id.ToString();
                ApplyButton.Visible = true;
                return;
            }
            ApplyButton.Visible = false;
            _currentCustomer = Customers[CustomersListBox.SelectedIndex];
            AddressControl1.Address = _currentCustomer.Address;
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName;
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
            _customers.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в _customers заполненный значениям элемент _newCustomer.
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

        private void CustomersListBox_Leave(object sender, EventArgs e)
        {
            UpdateCustomersListBoxDisplayMember();
        }
    }
}
