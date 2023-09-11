using ProgrammingAppInformationSystem.Model.Classes;
using ProgrammingAppInformationSystem.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingAppInformationSystem.View
{
    /// <summary>
    /// Хранит логику дополнительного окна приложения.
    /// </summary>
    public partial class AddAndEditForm : Form
    {
        /// <summary>
        /// Объект класса <see cref="Organization"/> который заполняется.
        /// </summary>
        public Organization currentOrganization;

        /// <summary>
        /// Флаг корректности введенных в NameTextBox данных.
        /// </summary>
        private bool _nameFlag = false;

        /// <summary>
        /// Флаг корректности введенных в AddressTextBox данных.
        /// </summary>
        private bool _addressFlag = false;

        /// <summary>
        /// Флаг корректности введенных в CategoryComboBox данных.
        /// </summary>
        private bool _categoryFlag = false;

        /// <summary>
        /// Флаг корректности введенных в RatingTextBox данных.
        /// </summary>
        private bool _ratingFlag = false;

        /// <summary>
        /// Создает объект типа <see cref="AddAndEditForm"/>.
        /// </summary>
        public AddAndEditForm(Organization organization)
        {
            InitializeComponent();
            InitializeCategoryComboBox();
            currentOrganization = organization;

            if (organization.Name != null || organization.Address != null
             || organization.Category != null || organization.Rating != default)
            {
                InitializeOrganizationGroupBox();
            }
        }

        /// <summary>
        /// Заполняет NameTextBox, AddressTextBox, CategoryComboBox, RatingTextBox значениями параметров <see cref="MainForm.AddOrEditOrganization"/>.
        /// </summary>
        private void InitializeOrganizationGroupBox()
        {
            NameTextBox.Text = currentOrganization.Name;
            AddressTextBox.Text = currentOrganization.Address;
            object parsedValue;
            if (Enum.TryParse(typeof(Category), currentOrganization.Category, out parsedValue))
            {
                CategoryComboBox.SelectedItem = parsedValue;
            }
            RatingTextBox.Text = currentOrganization.Rating.ToString();
        }

        /// <summary>
        /// Заполняет CategoryComboBox элементами перечисления <see cref="Category"/>.
        /// </summary>
        private void InitializeCategoryComboBox()
        {
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        /// <summary>
        /// Записывает в <see cref="MainForm.AddOrEditOrganization"/> значение из NameTextBox.
        /// </summary>
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColors.White;
                currentOrganization.Name = NameTextBox.Text;
                _nameFlag = true;
            }
            catch
            {
                _nameFlag = false;
                NameTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в <see cref="MainForm.AddOrEditOrganization"/> значение из AddressTextBox.
        /// </summary>
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColors.White;
                currentOrganization.Address = AddressTextBox.Text;
                _addressFlag = true;
            }
            catch
            {
                _addressFlag = false;
                AddressTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в <see cref="MainForm.AddOrEditOrganization"/> значение из CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryComboBox.BackColor = AppColors.White;
                currentOrganization.Category = CategoryComboBox.Text;
                _categoryFlag = true;
            }
            catch
            {
                _categoryFlag = false;
                CategoryComboBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Записывает в <see cref="MainForm.AddOrEditOrganization"/> значение из RatingTextBox.
        /// </summary>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = AppColors.White;
                currentOrganization.Rating = Double.Parse(RatingTextBox.Text);
                _ratingFlag = true;
            }
            catch
            {
                _ratingFlag = false;
                RatingTextBox.BackColor = AppColors.LightPink;
            }
        }

        /// <summary>
        /// Проверяет введенные в NameTextBox, AddressTextBox, CategoryComboBox, RatingTextBox 
        /// значения на корректность.
        /// </summary>
        private void AcceptPictureBox_Click(object sender, EventArgs e)
        {
            if (!(_nameFlag && _addressFlag && _categoryFlag && _ratingFlag))
            {   
                if (!_nameFlag)
                {
                    MessageBox.Show("Длина строки в свойстве Name должна быть не более 200 символов");
                }
                else if (!_addressFlag)
                {
                    MessageBox.Show("Длина строки в свойстве Address должна быть не более 100 символов");
                }
                else if (!_categoryFlag)
                {
                    MessageBox.Show("Значение в свойстве Category должно находиться в перечислении Category");
                }
                else if (!_ratingFlag)
                {
                    MessageBox.Show("Значение в свойстве Rating должно быть от 0 до 5");
                }
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Контролирует изменение CategoryComboBox.
        /// </summary>
        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Закрывает форму.
        /// </summary>
        private void CLosePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
