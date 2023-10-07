using ObjectOrientedPractices.Model.Classes;
using ObjectOrientedPractices.View.Tabs;

namespace ObjectOrientedPractices.View
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            ItemsTab1.Items = _store.Items;
            CustomersTab1.Customers = _store.Customers;
            CartsTab1.Items = _store.Items;
            CartsTab1.Customers = _store.Customers;
            //CartsTab1.Orders = _store.Orders;
            //OrdersTab1.Orders = _store.Orders;
            OrdersTab1.Customers = _store.Customers;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    {
                        ItemsTab1.RefreshData();
                        return;
                    }
                case 1:
                    {
                        CustomersTab1.RefreshData();
                        return;
                    }
                case 2:
                    {
                        CartsTab1.RefreshData();
                        return;
                    }
                case 3:
                    {
                        OrdersTab1.RefreshData();
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }
    }
}