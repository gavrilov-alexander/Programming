using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractices.Model.Classes.Discounts;
using ObjectOrientedPractices.Model.Enums;

namespace ObjectOrientedPractices.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        public Category Category { get; set; }
        public AddDiscountForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            FillCategoryComboBox();
        }

        private void FillCategoryComboBox()
        {
            var categories = Enum.GetValues(typeof(Category));
            CategoryComboBox.DataSource = categories;
        }
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
