namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre),     
                typeof(Manufactures), typeof(Season), typeof(Weekday) };                            //�������� ������� ������������
            EnumsListBox.Items.AddRange(enums);                                                     //���������� ������������ � EnumsListBox
            EnumsListBox.SelectedIndex = 0;                                                         //������� ���������� ��������� ������������ �� ������ ������������

            ParsingResult.Visible = false;                                                          //������� ������ ��� ������ ���������� �� WeekdayParsing GroupBox 

            var seasons = Enum.GetValues(typeof(Season));                                           //���������� ������������ Season � ComboBox � SeasonHandle
            foreach (var season in seasons)
            {
                SeasonComboBox.Items.Add(season);
            }
            SeasonComboBox.SelectedIndex = 0;                                                       //������� ���������� ��������� �������� �� ������ � ComboBox
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)                  //��������� ������������� ������������ � ValuesListBox
        {
            var selectedEnum = (Type)EnumsListBox.SelectedItem;
            var enumValues = Enum.GetValues(selectedEnum);
            ValuesListBox.Items.Clear();
            foreach (var enumValue in enumValues)
            {
                ValuesListBox.Items.Add(enumValue);
            }
            ValueTextBox.Clear();                                                                   //������� ����������� ������� ���������� �������� �� ������������
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)                 //����������� ������� ���������� �������� �� ������ ValuesListBox
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
            if (ParsingValueTextBox.Text == null)                                                           //�������� ��������� ������
            {
                return;
            }
            ParsingResult.Visible = true;
            object ParsedValue;
            if (Enum.TryParse(typeof(Weekday), ParsingValueTextBox.Text, out ParsedValue))                  //������� �������������� ��������� ������ � ��� Enum
            {
                ParsingResult.Text = $"��� ���� ������ ({ParsedValue}  =  {(int)ParsedValue+1})";
            }
            else
            {
                ParsingResult.Text = "��� ������ ��� ������";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;                                       //������� ���������� ��� ������� ���������� ��������� ���������� ������
            switch (SeasonComboBox.SelectedIndex)
            {
                case 0:                                                                                    //����
                    
                    MessageBox.Show("����! �������!");
                    break;
                case 1:                                                                                    //�����
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case 2:                                                                                    //����

                    MessageBox.Show("���! ������!");
                    break;
                case 3:                                                                                    //�����
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    tableLayoutPanel1.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
                default:                                                                                   //���������� �� ������, ���� ������ �� ���� �� �������
                    MessageBox.Show("�������� ����� ���� �� ����������� ������");
                    break;
            }
        }
    }
}