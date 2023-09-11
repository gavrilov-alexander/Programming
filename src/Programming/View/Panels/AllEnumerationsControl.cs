using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = Programming.Model.Enums.Color;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="AllEnumerationsControl"/>.
    /// </summary>
    public partial class AllEnumerationsControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="AllEnumerationsControl"/>
        /// </summary>
        public AllEnumerationsControl()
        {
            InitializeComponent();
            InitializeEnumsListBox();
        }

        /// <summary>
        /// Заполняет EnumsListBox всеми перечислениями.
        /// </summary>
        private void InitializeEnumsListBox()
        {
            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),
                typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.DisplayMember = nameof(Type.Name);
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Заполняет ValuesListBox элементами выбранного перечисления.
        /// </summary>
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            ValueTextBox.Clear();
        }

        /// <summary>
        /// Записывает в ValueTextBox номер выбранного в ValuesListBox элемента перечисления.
        /// </summary>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            int selectedValue = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = selectedValue.ToString();
        }
    }
}
