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

namespace ObjectOrientedPractices.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                UpdateAddressTextBoxes();
            }
        }
        public AddressControl()
        {
            InitializeComponent();
        }
        private void FillAdressTextBoxes()
        {
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }
        private void UpdateAddressTextBoxes()
        {
            if (Address == null || Address.Index == 0 || Address.Country == "" || Address.City == ""
                || Address.Street == "" || Address.Building == "" || Address.Apartment == "")
            {
                IndexTextBox.Clear();
                CountryTextBox.Clear();
                CityTextBox.Clear();
                StreetTextBox.Clear();
                BuildingTextBox.Clear();
                ApartmentTextBox.Clear();
                return;
            }
            FillAdressTextBoxes();
        }

        private void IndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                IndexTextBox.BackColor = Color.White;
                Address.Index = int.Parse(IndexTextBox.Text);
            }
            catch
            {
                if (!(IndexTextBox.Text == ""))
                {
                    IndexTextBox.BackColor = Color.Pink;
                }

            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CountryTextBox.BackColor = Color.White;
                Address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = Color.Pink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CityTextBox.BackColor = Color.White;
                Address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = Color.Pink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                StreetTextBox.BackColor = Color.White;
                Address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = Color.Pink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                BuildingTextBox.BackColor = Color.White;
                Address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = Color.Pink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ApartmentTextBox.BackColor = Color.White;
                Address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = Color.Pink;
            }
        }
    }
}
