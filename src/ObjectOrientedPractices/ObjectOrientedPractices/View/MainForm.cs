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
        }
    }
}