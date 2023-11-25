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
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="AddressControl"/>.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Элемент класса <see cref="Model.Classes.Address"/>.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Возвращает и задает элемент класса <see cref="Model.Classes.Address"/>.
        /// </summary>
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                UpdateAddressTextBoxes();
            }
        }

        /// <summary>
        /// Создает объект типа <see cref="AddressControl"/>
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Заполняет IndexTextBox, CountryTextBox, CityTextBox, StreetTextBox, BuildingTextBox, ApartmentTextBox значениями из Address.
        /// </summary>
        private void FillAdressTextBoxes()
        {
            IndexTextBox.Text = Address.Index.ToString();
            CountryTextBox.Text = Address.Country;
            CityTextBox.Text = Address.City;
            StreetTextBox.Text = Address.Street;
            BuildingTextBox.Text = Address.Building;
            ApartmentTextBox.Text = Address.Apartment;
        }

        /// <summary>
        /// Очищает IndexTextBox, CountryTextBox, CityTextBox, StreetTextBox, BuildingTextBox, ApartmentTextBox.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из IndexTextBox в Address.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из CountryTextBox в Address.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из CityTextBox в Address.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из StreetTextBox в Address.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из BuildingTextBox в Address.
        /// </summary>
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

        /// <summary>
        /// Записывает значение из ApartmentTextBox в Address.
        /// </summary>
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
