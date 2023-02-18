namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),     
                typeof(Manufactures), typeof(Season), typeof(Weekday) };                            //Создание массива перечислений
            EnumsListBox.Items.AddRange(enums);                                                     //Добавление перечислений в EnumsListBox
            EnumsListBox.SelectedIndex = 0;                                                         //Задание начального выброного перечисления из списка перечислений

            ParsingResult.Visible = false;                                                          //Скрытие лэйбла для вывода результата из WeekdayParsing GroupBox 

            var seasons = Enum.GetValues(typeof(Season));                                           //Добавление перечисления Season в ComboBox в SeasonHandle
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            SeasonComboBox.SelectedIndex = 0;                                                       //Задание начального выброного элемента из списка в ComboBox
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                  //Изменение отображаемого перечисления в ValuesListBox
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            ValueTextBox.Clear();                                                                   //Очистка отображения индекса выбранного элемента из перечисления
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                 //Отображение индекса выбранного элемента из списка ValuesListBox
        {
            if (ValuesListBox.SelectedItem == null)
            {
                return;
            }
            int selectedValue = (int)ValuesListBox.SelectedItem;
            ValueTextBox.Text = selectedValue.ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            if (ParsingValueTextBox.Text == null)                                                           //Проверка введенной строки
            {
                return;
            }
            ParsingResult.Visible = true;
            object ParsedValue;
            if (Enum.TryParse(typeof(Weekday), ParsingValueTextBox.Text, out ParsedValue))                  //Попытка преобразования введенной строки в тип Enum
            {
                ParsingResult.Text = $"Это день недели ({ParsedValue}  =  {(int)ParsedValue+1})";
            }
            else
            {
                ParsingResult.Text = "Нет такого дня недели";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;                                       //Очистка изменнений при запуске инструкций изменения выбранного сезона
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:                                                                                    //Зима
                    
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case 1:                                                                                    //Весна
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 2:                                                                                    //Лето

                    MessageBox.Show("Ура! Солнце!");
                    break;
                case 3:                                                                                    //Осень
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                default:                                                                                   //Инструкции на случай, если введен ни один из сезонов
                    MessageBox.Show("Выберете время года из выпадающего списка");
                    break;
            }
        }
    }
}