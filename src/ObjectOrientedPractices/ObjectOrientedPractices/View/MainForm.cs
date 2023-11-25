using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices.View
{
    /// <summary>
    /// Хранит логику окна <see cref="MainForm"/>.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит объект класса <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        /// <summary>
        /// Создает объект типа <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ItemsTab1.Items = _store.Items;
            CustomersTab1.Customers = _store.Customers;
            CartsTab1.Items = _store.Items;
            CartsTab1.Customers = _store.Customers;
            OrdersTab1.Customers = _store.Customers;

            ItemsTab1.ItemsChanged += CartsTab1.RefreshData;
            CustomersTab1.CustomersChanged += CartsTab1.RefreshData;
            ItemsTab1.ItemsChanged += OrdersTab1.RefreshData;
            CustomersTab1.CustomersChanged += OrdersTab1.RefreshData;
            CartsTab1.OrdersChanged += OrdersTab1.RefreshData;
        }
    }
}