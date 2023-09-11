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
        private static BindingList<Customer> _customers = new BindingList<Customer>();

        /// <summary>
        /// Выбранный в CustomersListBox элемент.
        /// </summary>
        private static Customer _currentCustomer;

        /// <summary>
        /// Создаваемый объект класса <see cref="Customer"/>.
        /// </summary>
        private static Customer _newCustomer = new Customer();

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
        }

        /// <summary>
        /// Заполняет CustomersListBox элементами коллекции _customers.
        /// </summary>
        private void FillCustomersListBox()
        {
            CustomersListBox.DataSource = null;
            CustomersListBox.DataSource = _customers;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Удаляет данные из IdTextBox, FullNameTextBox, AddressTextBox.
        /// </summary>
        private void ClearCurrentItem()
        {
            IdTextBox.Text = "";
            FullNameTextBox.Text = "";
            AddressTextBox.Text = "";
            FullNameTextBox.BackColor = Color.White;
            AddressTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет данные, отображаемые в CustomersListBox.
        /// </summary>
        private void UpdateCustomersListBox()
        {
            CustomersListBox.DisplayMember = null;
            CustomersListBox.DisplayMember = nameof(Customer.FullName);
        }

        /// <summary>
        /// Заполняет IdTextBox, FullNameTextBox, AddressTextBox значениями выбранного в CustomersListBox элемента.
        /// </summary>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1 || _customers.Count == 0)
            {
                if (_currentCustomer == _newCustomer || _customers.Count == 0)
                {
                    ClearCurrentItem();
                    IdTextBox.Text = _newCustomer.Id.ToString();
                    ApplyButton.Visible = true;
                    return;
                }
                ClearCurrentItem();
                return;
            }
            ApplyButton.Visible = false;
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IdTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.FullName.ToString();
            AddressTextBox.Text = _currentCustomer.Address;
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
            _currentCustomer = null;
            _currentCustomer = _newCustomer;
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
                _customers.Add(_currentCustomer);
            }
            _currentCustomer = null;
            _currentCustomer = _newCustomer;
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
            _currentCustomer = null;
            _currentCustomer = _newCustomer;
            CustomersListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в _customers заполненный значениям элемент _newCustomer.
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.BackColor == Color.Pink
                || AddressTextBox.BackColor == Color.Pink
                || FullNameTextBox.Text == ""
                || AddressTextBox.Text == ""
                || _currentCustomer != _newCustomer)
            {
                return;
            }
            _customers.Add(_currentCustomer);
            _currentCustomer = null;
            _newCustomer = new Customer();
            _currentCustomer = _newCustomer;
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
                FullNameTextBox.BackColor = Color.White;
                _currentCustomer.FullName = FullNameTextBox.Text;
                if (!(_currentCustomer == _newCustomer))
                {
                    UpdateCustomersListBox();
                }
            }
            catch
            {
                FullNameTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Записывает в _currentCustomer значение из AddressTextBox.
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = Color.White;
                _currentCustomer.Address = AddressTextBox.Text;
            }
            catch
            {
                AddressTextBox.BackColor = Color.Pink;
            }
        }
    }
}
