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
    /// <summary>
    /// Хранит логику окна <see cref="AddDiscountForm"/>.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает категорию скидки.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Создает объект типа <see cref="AddDiscountForm"/>.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
            MaximizeBox = false;
            FillCategoryComboBox();
        }

        /// <summary>
        /// Заполняет CategoryComboBox элементами перечисления <see cref="Model.Enums.Category"/>
        /// </summary>
        private void FillCategoryComboBox()
        {
            var categories = Enum.GetValues(typeof(Category));
            CategoryComboBox.DataSource = categories;
        }

        /// <summary>
        /// Записывает в Category выбранный в CategoryComboBox элемент.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category = (Category)CategoryComboBox.SelectedItem;
        }

        /// <summary>
        /// Закрывает форму с результатом OK.
        /// </summary>
        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        /// Закрывает форму с результатом Cancel.
        /// </summary>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
