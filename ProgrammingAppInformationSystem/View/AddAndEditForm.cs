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
    public partial class AddAndEditForm : Form
    {
        private bool _nameFlag = false;
        private bool _addressFlag = false;
        private bool _categoryFlag = false;
        private bool _ratingFlag = false;
        public AddAndEditForm()
        {
            InitializeComponent();
            InitializeCategoryComboBox();
            if (StaticData.currentOrganization.Name != null)
            {
                InitializeOrganizationGroupBox();
            }
        }
        private void InitializeOrganizationGroupBox()
        {
            NameTextBox.Text = StaticData.currentOrganization.Name;
            AddressTextBox.Text = StaticData.currentOrganization.Address;
            object parsedValue;
            if (Enum.TryParse(typeof(Category), StaticData.currentOrganization.Category, out parsedValue))
            {
                CategoryComboBox.SelectedItem = parsedValue;
            }
            RatingTextBox.Text = StaticData.currentOrganization.Rating.ToString();
        }
        private void InitializeCategoryComboBox()
        {
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                NameTextBox.BackColor = AppColors.White;
                StaticData.currentOrganization.Name = NameTextBox.Text;
                _nameFlag = true;
            }
            catch
            {
                _nameFlag = false;
                NameTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AddressTextBox.BackColor = AppColors.White;
                StaticData.currentOrganization.Address = AddressTextBox.Text;
                _addressFlag = true;
            }
            catch
            {
                _addressFlag = false;
                AddressTextBox.BackColor = AppColors.LightPink;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CategoryComboBox.BackColor = AppColors.White;
                StaticData.currentOrganization.Category = CategoryComboBox.Text;
                _categoryFlag = true;
            }
            catch
            {
                _categoryFlag = false;
                CategoryComboBox.BackColor = AppColors.LightPink;
            }
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RatingTextBox.BackColor = AppColors.White;
                StaticData.currentOrganization.Rating = Double.Parse(RatingTextBox.Text);
                _ratingFlag = true;
            }
            catch
            {
                _ratingFlag = false;
                RatingTextBox.BackColor = AppColors.LightPink;
            }
        }

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
            StaticData.Flag = true;
            this.Close();
        }

        private void CategoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
