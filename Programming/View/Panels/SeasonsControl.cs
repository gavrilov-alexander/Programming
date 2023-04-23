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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();
            InitializeSeasonComboBox();
        }

        private void InitializeSeasonComboBox()
        {
            var seasons = Enum.GetValues(typeof(Season));
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            SeasonComboBox.SelectedIndex = 0;
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            SeasonHandleGroupBox.BackColor = AppColors.Defualt;
            switch (SeasonComboBox.SelectedIndex)
            {
                // Зима
                case 0:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                // Весна
                case 1:
                    SeasonHandleGroupBox.BackColor = AppColors.SpringGreen;
                    break;
                // Лето
                case 2:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                // Осень
                case 3:
                    SeasonHandleGroupBox.BackColor = AppColors.AutumnYellow;
                    break;

                default:
                    MessageBox.Show("Выберете время года из выпадающего списка");
                    break;
            }
        }
    }
}
