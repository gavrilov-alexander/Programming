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

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит логику пользовательского элемента управления <see cref="WeekdayParsingControl"/>.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создает объект типа <see cref="WeekdayParsingControl"/>
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
            ParsingResultLable.Visible = false;
        }

        /// <summary>
        /// Проверяет введенное в ParsingValueTextBox значение на вхождение в перечисление <see cref="Weekday"/>.
        /// Если проверяемое значение входит в <see cref="Weekday"/>, в ParsingResultLable выводится номер дня недели.
        /// </summary>
        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (ParsingValueTextBox.Text == null)
            {
                return;
            }
            ParsingResultLable.Visible = true;
            object ParsedValue;
            if (Enum.TryParse(typeof(Weekday), ParsingValueTextBox.Text, out ParsedValue))
            {
                ParsingResultLable.Text = $"Это день недели ({ParsedValue}  =  {(int)ParsedValue + 1})";
            }
            else
            {
                ParsingResultLable.Text = "Нет такого дня недели";
            }
        }
    }
}