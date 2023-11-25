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
using ObjectOrientedPractices.Model.Enums;
using System.Diagnostics;
using System.Reflection;

namespace ObjectOrientedPractices.View.Tabs
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="ItemsTab"/>.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Событие, вызываемое при каждом изменении элементов Items.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>.
        /// </summary>
        private BindingList<Item> _items;

        /// <summary>
        /// Возвращает и задает коллекцию элементов класса <see cref="Item"/>.
        /// </summary>
        public BindingList<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Коллекция элементов класса <see cref="Item"/>, отображаемая в ItemsListBox.
        /// </summary>
        private BindingList<Item> _displayedItems;

        /// <summary>
        /// Возвращает и задает коллекцию элементов класса <see cref="Item"/>, отображаемаю в ItemsListBox.
        /// </summary>
        public BindingList<Item> DisplayedItems
        {
            get
            {
                return _displayedItems;
            }
            set
            {
                _displayedItems = value;
            }
        }

        /// <summary>
        /// Текущий фильтр.
        /// </summary>
        private string _currentFilter = "";

        /// <summary>
        /// Создаваемый объект класса <see cref="Item"/>.
        /// </summary>
        private Item _newItem = new Item();

        /// <summary>
        /// Выбранный в ItemsListBox элемент.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Количество случайно генерируемых элементов коллекции _items по нажатию кнопки AddListButton.
        /// </summary>
        public const int DefualtSize = 10;

        /// <summary>
        /// Коллекция элементов перечисления <see cref="Category"/>.
        /// </summary>
        public Array Categories = Enum.GetValues(typeof(Category));

        /// <summary>
        /// Коллекция методов сортировки класса <see cref="SortingMethod"/>.
        /// </summary>
        public SortingMethod[] SortingMethods = new SortingMethod[] { new SortingMethod("Name (Alphabetical)",
                                                                            (x1, x2) => {return string.Compare(((Item)x1).Name,((Item)x2).Name) > 0; }),
                                                                        new SortingMethod("Name (Reverse Alphabetical)",
                                                                            (x1, x2) => {return string.Compare(((Item)x1).Name,((Item)x2).Name) < 0; }),
                                                                        new SortingMethod("Cost (Ascending)",
                                                                            (x1, x2) => { return (((Item)x1).Cost > ((Item)x2).Cost); }),
                                                                        new SortingMethod("Cost (Descending)",
                                                                            (x1, x2) => { return (((Item)x1).Cost < ((Item)x2).Cost); }),
                                                                        new SortingMethod("Id (Ascending)",
                                                                            (x1, x2) => { return (((Item)x1).Id > ((Item)x2).Id); }),
                                                                        new SortingMethod("Id (Descending )",
                                                                            (x1, x2) => { return (((Item)x1).Id < ((Item)x2).Id); }) };

        /// <summary>
        /// Создает объект типа <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            _currentItem = _newItem;
            IdTextBox.Text = _currentItem.Id.ToString();
            FillItemsListBox();
            CategoryComboBox.Items.Clear();
            CategoryComboBox.DataSource = Categories;
            FillOrderByComboBox();
        }

        /// <summary>
        /// Заполняет ItemsListBox элементами коллекции DisplayedItems.
        /// </summary>
        private void FillItemsListBox()
        {
            ItemsListBox.DataSource = null;
            ItemsListBox.DataSource = DisplayedItems;
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }
        /// <summary>
        /// Заполняет OrderByComboBox элементами коллекции SortingMethods.
        /// </summary>
        private void FillOrderByComboBox()
        {
            OrderByComboBox.DataSource = null;
            OrderByComboBox.DataSource = SortingMethods;
            OrderByComboBox.DisplayMember = null;
            OrderByComboBox.DisplayMember = nameof(SortingMethod.Name);
        }

        /// <summary>
        /// Удаляет данные из IdTextBox, CostTextBox, NameTextBox, InfoTextBox.
        /// </summary>
        private void ClearCurrentItem()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CostTextBox.BackColor = Color.White;
            NameTextBox.BackColor = Color.White;
            InfoTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Обновляет данные, отображаемые в ItemsListBox.
        /// </summary>
        private void UpdateItemsListBoxDisplayMember(object sender, EventArgs e)
        {
            ItemsListBox.DisplayMember = null;
            ItemsListBox.DisplayMember = nameof(Item.Name);
        }

        /// <summary>
        /// Заполняет IdTextBox, CostTextBox, NameTextBox, CategoryComboBox, InfoTextBox значениями выбранного в ItemsListBox элемента.
        /// </summary>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == ItemsListBox.SelectedItem)
            {
                return;
            }
            if (ItemsListBox.SelectedIndex == -1 || DisplayedItems.Count == 0)
            {
                _currentItem = _newItem;
                ClearCurrentItem();
                IdTextBox.Text = _newItem.Id.ToString();
                CategoryComboBox.SelectedIndex = 0;
                ApplyButton.Visible = true;
                return;
            }
            ApplyButton.Visible = false;
            _currentItem = DisplayedItems[ItemsListBox.SelectedIndex];
            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            CategoryComboBox.SelectedItem = _currentItem.Category;
            InfoTextBox.Text = _currentItem.Info;
            _currentItem.NameChanged += UpdateItemsListBoxDisplayMember;
            _currentItem.NameChanged += delegate { ItemsChanged?.Invoke(this, EventArgs.Empty); };
            _currentItem.CostChanged += delegate { ItemsChanged?.Invoke(this, EventArgs.Empty); };
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
            ItemsListBox.SelectedIndex = -1;

        }

        /// <summary>
        /// Добавляет в Items случайно сгенерированные элементы класса <see cref="Item"/>.
        /// </summary>
        private void AddListButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < DefualtSize; i++)
            {
                _currentItem = null;
                _currentItem = ItemFactory.GenerateItem();
                Items.Add(_currentItem);
            }
            UpdateDisplaedItems();
            _currentItem = null;
            FillItemsListBox();
            ItemsListBox.SelectedIndex = -1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);

        }

        /// <summary>
        /// Удаляет из Items выбранный в ItemsListBox элемент.
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || ItemsListBox.SelectedItem == null)
            {
                return;
            }
            Items.Remove(_currentItem);
            _currentItem.NameChanged -= UpdateItemsListBoxDisplayMember;
            UpdateDisplaedItems();
            ItemsListBox.SelectedIndex = -1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Добавляет в Items заполненный значениями элемент _newItem.
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
            _currentItem = null;
            Items.Add(_newItem);
            _newItem = new Item();
            UpdateDisplaedItems();
            ItemsListBox.SelectedIndex = -1;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                if (_currentItem == null)
                {
                    return;
                }
                CostTextBox.BackColor = Color.White;
                if (_currentItem.Cost != Double.Parse(CostTextBox.Text))
                {
                    _currentItem.Cost = Double.Parse(CostTextBox.Text);
                }
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
                if (_currentItem == null)
                {
                    return;
                }
                NameTextBox.BackColor = Color.White;
                if (_currentItem.Name != NameTextBox.Text)
                {
                    _currentItem.Name = NameTextBox.Text;
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
                if (_currentItem == null)
                {
                    return;
                }
                InfoTextBox.BackColor = Color.White;
                if (_currentItem.Info != InfoTextBox.Text)
                {
                    _currentItem.Info = InfoTextBox.Text;
                }
            }
            catch
            {
                InfoTextBox.BackColor = Color.Pink;
            }
        }

        /// <summary>
        /// Записывает в _currentItem значение из CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentItem == null)
            {
                return;
            }
            _currentItem.Category = (Category)(CategoryComboBox.SelectedItem);
        }

        /// <summary>
        /// Контролирует изменение CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Контролирует фокусировку ItemsListBox.
        /// </summary>
        private void ItemsListBox_Leave(object sender, EventArgs e)
        {
            ItemsListBox.Update();
        }

        /// <summary>
        /// Вызывает метод обновления отображаемых элементов.
        /// </summary>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateDisplaedItems();
        }

        /// <summary>
        /// Обновляет отображаемые в ItemsListBox объекты.
        /// </summary>
        private void UpdateDisplaedItems()
        {
            if (Items == null)
            {
                return;
            }
            if (Items.Count == 0)
            {
                DisplayedItems = Items;
            }
            if (FindTextBox.Text.Length > _currentFilter.Length)
            {
                FilterDisplayedItems(DisplayedItems);
            }
            else
            {
                FilterDisplayedItems(Items);
            }
            SortDisplaedItems();
        }

        /// <summary>
        /// Фильтрует отображаемые в ItemsListBox объекты.
        /// </summary>
        private void FilterDisplayedItems(BindingList<Item> list)
        {
            if (FindTextBox.Text == "")
            {
                DisplayedItems = Items;
                _currentFilter = "";
                return;
            }
            BindingList<Item> result = new BindingList<Item>();
            BindingList<object> filteredList = new BindingList<object>();
            foreach (Item item in Items)
            {
                filteredList.Add(item);
            }
            BindingList<object> resultList = DataTools.Filter(filteredList, (x) =>
            {
                return ((((Item)x).Id).ToString().Contains(FindTextBox.Text)
                || ((Item)x).Name.Contains(FindTextBox.Text));
            });
            foreach (Item item in resultList)
            {
                result.Add(item);
            }
            DisplayedItems = result;
            _currentFilter = FindTextBox.Text;
        }

        /// <summary>
        /// Сортирует отображаемые в ItemsListBox объекты.
        /// </summary>
        private void SortDisplaedItems()
        {
            SortingMethod method = (SortingMethod)OrderByComboBox.SelectedItem;
            BindingList<Item> result = new BindingList<Item>();
            BindingList<object> sortedList = new BindingList<object>();
            foreach (Item item in DisplayedItems)
            {
                sortedList.Add(item);
            }
            BindingList<object> resultList = DataTools.Sort(sortedList, method.Method);
            foreach (Item item in resultList)
            {
                result.Add(item);
            }
            DisplayedItems = result;
            FillItemsListBox();
        }

        /// <summary>
        /// Обновляет отображаемые в ItemsListBox объекты.
        /// </summary>
        private void OrederByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DisplayedItems == null || DisplayedItems.Count == 0)
            {
                return;
            }
            var selectedItem = ItemsListBox.SelectedItem;
            SortDisplaedItems();
            ItemsListBox.SelectedItem = selectedItem;
        }
    }
}
