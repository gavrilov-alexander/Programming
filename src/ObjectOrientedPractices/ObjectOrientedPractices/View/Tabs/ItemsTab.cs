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
    /// Хранит логику пользовательского элемента управления <see cref="ItemsTab"/>.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        private static BindingList<Item> _items = new BindingList<Item>();

        /// <summary>
        /// Выбранный в ItemsListBox элемент.
        /// </summary>
        private static Item _currentItem;

        /// <summary>
        /// Создаваемый объект класса <see cref="Item"/>.
        /// </summary>
        private static Item _newItem = new Item();

        /// <summary>
        /// Количество случайно генерируемых элементов коллекции _items по нажатию кнопки AddListButton.
        /// </summary>
        public const int DesualtSize = 10;

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            _currentItem = _newItem;
            IdTextBox.Text = _currentItem.Id.ToString();
            FillItemsListBox();
        }

        /// <summary>
        /// Заполняет ItemsListBox элементами коллекции _items.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = _items;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Удаляет данные из IdTextBox, CostTextBox, NameTextBox, InfoTextBox.
        /// </summary>
        private void ClearCurrentItem()
        {
            IdTextBox.Text = "";
            CostTextBox.Text = "";
            NameTextBox.Text = "";
            InfoTextBox.Text = "";
            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            InfoTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет данные, отображаемые в ItemsListBox.
        /// </summary>
        private void UpdateItemsListBox()
        {
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Заполняет IdTextBox, CostTextBox, NameTextBox, InfoTextBox значениями выбранного в ItemsListBox элемента.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || _items.Count == 0)
            {
                if (_currentItem == _newItem || _items.Count == 0)
                {
                    ClearCurrentItem();
                    IdTextBox.Text = _newItem.Id.ToString();
                    ApplyButton.Visible = true;
                    return;
                }
                ClearCurrentItem();
                return;
            }
            ApplyButton.Visible = false;
            _currentItem = _items[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            InfoTextBox.Text = _currentItem.Info;
        }

        /// <summary>
        /// Выбирает активным для заполнения элемент _newItem.
        /// </summary>
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem = null;
            _currentItem = _newItem;
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в _items случайно сгенерированные элементы класса <see cref="Item"/>.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DesualtSize; i++)
            {
                _currentItem = null;
                _currentItem = ItemFactory.GenerateItem();
                _items.Add(_currentItem);
            }
            _currentItem = null;
            _currentItem = _newItem;
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Удаляет из _items выбранный в ItemsListBox элемент.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem == null)
            {
                return;
            }
            _items.Remove(_currentItem);
            _currentItem = null;
            _currentItem = _newItem;
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Добавляет в _items заполненный значениям элемент _newItem.
        /// </summary>
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (CostTextBox.BackColor == Color.Pink
                || NameTextBox.BackColor == Color.Pink
                || InfoTextBox.BackColor == Color.Pink
                || CostTextBox.Text == ""
                || NameTextBox.Text == ""
                || InfoTextBox.Text == ""
                || _currentItem != _newItem)
            {
                return;
            }
            _items.Add(_currentItem);
            _currentItem = null;
            _newItem = new Item();
            _currentItem = _newItem;
            ItemsListBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Контролирует изменение IdTextBox.
        /// </summary>
        private void IdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Записывает в _currentItem значение из CostTextBox.
        /// </summary>
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CostTextBox.BackColor = Color.White;
                _currentItem.Cost = Double.Parse(CostTextBox.Text);
            }
            catch
            {
                CostTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Записывает в _currentItem значение из NameTextBox.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = Color.White;
                _currentItem.Name = NameTextBox.Text;
                if (!(_currentItem == _newItem))
                {
                    UpdateItemsListBox();
                }
            }
            catch
            {
                NameTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Записывает в _currentItem значение из InfoTextBox.
        /// </summary>
        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                InfoTextBox.BackColor = Color.White;
                _currentItem.Info = InfoTextBox.Text;
            }
            catch
            {
                InfoTextBox.BackColor = Color.Pink;
            }
        }
    }
}
