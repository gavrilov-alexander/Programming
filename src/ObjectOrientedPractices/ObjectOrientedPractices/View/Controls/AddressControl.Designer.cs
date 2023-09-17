namespace ObjectOrientedPractices.View.Controls
{
    partial class AddressControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            AddressGroupBox = new GroupBox();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            ApartmentTextBox = new TextBox();
            ApartmentLabel = new Label();
            BuildingTextBox = new TextBox();
            BuildingLabel = new Label();
            StreetTextBox = new TextBox();
            StreetLabel = new Label();
            CountryTextBox = new TextBox();
            CountryLabel = new Label();
            IndexTextBox = new TextBox();
            IndexLabel = new Label();
            AddressGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressGroupBox
            // 
            AddressGroupBox.Controls.Add(CityTextBox);
            AddressGroupBox.Controls.Add(CityLabel);
            AddressGroupBox.Controls.Add(ApartmentTextBox);
            AddressGroupBox.Controls.Add(ApartmentLabel);
            AddressGroupBox.Controls.Add(BuildingTextBox);
            AddressGroupBox.Controls.Add(BuildingLabel);
            AddressGroupBox.Controls.Add(StreetTextBox);
            AddressGroupBox.Controls.Add(StreetLabel);
            AddressGroupBox.Controls.Add(CountryTextBox);
            AddressGroupBox.Controls.Add(CountryLabel);
            AddressGroupBox.Controls.Add(IndexTextBox);
            AddressGroupBox.Controls.Add(IndexLabel);
            AddressGroupBox.Dock = DockStyle.Fill;
            AddressGroupBox.Location = new Point(0, 0);
            AddressGroupBox.Name = "AddressGroupBox";
            AddressGroupBox.Size = new Size(722, 171);
            AddressGroupBox.TabIndex = 0;
            AddressGroupBox.TabStop = false;
            AddressGroupBox.Text = "Delivery Address";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(442, 61);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(274, 31);
            CityTextBox.TabIndex = 12;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(390, 64);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(46, 25);
            CityLabel.TabIndex = 10;
            CityLabel.Text = "City:";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(370, 135);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(150, 31);
            ApartmentTextBox.TabIndex = 9;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(266, 138);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(101, 25);
            ApartmentLabel.TabIndex = 8;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(110, 135);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(150, 31);
            BuildingTextBox.TabIndex = 7;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(6, 138);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(80, 25);
            BuildingLabel.TabIndex = 6;
            BuildingLabel.Text = "Building:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(110, 98);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(606, 31);
            StreetTextBox.TabIndex = 5;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 101);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(61, 25);
            StreetLabel.TabIndex = 4;
            StreetLabel.Text = "Street:";
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(110, 61);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(274, 31);
            CountryTextBox.TabIndex = 3;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(6, 64);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(79, 25);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // IndexTextBox
            // 
            IndexTextBox.Location = new Point(110, 24);
            IndexTextBox.Name = "IndexTextBox";
            IndexTextBox.Size = new Size(150, 31);
            IndexTextBox.TabIndex = 1;
            IndexTextBox.TextChanged += IndexTextBox_TextChanged;
            // 
            // IndexLabel
            // 
            IndexLabel.AutoSize = true;
            IndexLabel.Location = new Point(6, 27);
            IndexLabel.Name = "IndexLabel";
            IndexLabel.Size = new Size(98, 25);
            IndexLabel.TabIndex = 0;
            IndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressGroupBox);
            Name = "AddressControl";
            Size = new Size(722, 171);
            AddressGroupBox.ResumeLayout(false);
            AddressGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddressGroupBox;
        private Label IndexLabel;
        private TextBox ApartmentTextBox;
        private Label ApartmentLabel;
        private TextBox BuildingTextBox;
        private Label BuildingLabel;
        private TextBox StreetTextBox;
        private Label StreetLabel;
        private TextBox CountryTextBox;
        private Label CountryLabel;
        private TextBox IndexTextBox;
        private TextBox CityTextBox;
        private Label CityLabel;
    }
}
