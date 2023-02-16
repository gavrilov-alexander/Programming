namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            object[] enums = new object[] { typeof(Color), typeof(EducationalForm), typeof(Genre), typeof(Manufactures), typeof(Season), typeof(Weekday) };
            EnumsListBox.Items.AddRange(enums);
            EnumsListBox.SelectedIndex = 0;
            ParsingResult.Visible = false;
        }

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

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
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
            if (ParsingValueTextBox.Text == null)
            {
                return;
            }
            ParsingResult.Visible = true;
            object ParsedValue;
            if (Enum.TryParse(typeof(Weekday), ParsingValueTextBox.Text, out ParsedValue))
            {
                ParsingResult.Text = $"Это день недели ({ParsedValue}  =  {(int)ParsedValue+1})";
            }
            else
            {
                ParsingResult.Text = "Нет такого дня недели";
            }
        }
    }
}