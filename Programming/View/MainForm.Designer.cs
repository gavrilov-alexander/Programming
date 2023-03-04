namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsing = new System.Windows.Forms.GroupBox();
            this.ParsingLable = new System.Windows.Forms.Label();
            this.ParsingResult = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingValueTextBox = new System.Windows.Forms.TextBox();
            this.SeasonHandle = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.Enumerations = new System.Windows.Forms.GroupBox();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Movies = new System.Windows.Forms.GroupBox();
            this.MovieFindButton = new System.Windows.Forms.Button();
            this.MovieRatingLabel = new System.Windows.Forms.Label();
            this.MovieRatingTextBox = new System.Windows.Forms.TextBox();
            this.MovieGenreLabel = new System.Windows.Forms.Label();
            this.MovieGenreTextBox = new System.Windows.Forms.TextBox();
            this.MovieYearLabel = new System.Windows.Forms.Label();
            this.MovieYearTextBox = new System.Windows.Forms.TextBox();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.MovieDurationLabel = new System.Windows.Forms.Label();
            this.MovieDurationTextBox = new System.Windows.Forms.TextBox();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.MovieNameTextBox = new System.Windows.Forms.TextBox();
            this.Rectangles = new System.Windows.Forms.GroupBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.RectangleColorLabel = new System.Windows.Forms.Label();
            this.RectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.Movies.SuspendLayout();
            this.Rectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Enums);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1399, 862);
            this.TabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tableLayoutPanel1);
            this.Enums.Location = new System.Drawing.Point(4, 34);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1391, 824);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Enumerations, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.73196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.26804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1385, 818);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.WeekdayParsing, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SeasonHandle, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 475);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1379, 340);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.ParsingLable);
            this.WeekdayParsing.Controls.Add(this.ParsingResult);
            this.WeekdayParsing.Controls.Add(this.ParseButton);
            this.WeekdayParsing.Controls.Add(this.ParsingValueTextBox);
            this.WeekdayParsing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsing.Location = new System.Drawing.Point(3, 3);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Size = new System.Drawing.Size(683, 334);
            this.WeekdayParsing.TabIndex = 0;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing";
            // 
            // ParsingLable
            // 
            this.ParsingLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingLable.AutoSize = true;
            this.ParsingLable.Location = new System.Drawing.Point(6, 128);
            this.ParsingLable.Name = "ParsingLable";
            this.ParsingLable.Size = new System.Drawing.Size(191, 25);
            this.ParsingLable.TabIndex = 6;
            this.ParsingLable.Text = "Type value for parsing:";
            // 
            // ParsingResult
            // 
            this.ParsingResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingResult.AutoSize = true;
            this.ParsingResult.Location = new System.Drawing.Point(6, 200);
            this.ParsingResult.Name = "ParsingResult";
            this.ParsingResult.Size = new System.Drawing.Size(198, 25);
            this.ParsingResult.TabIndex = 7;
            this.ParsingResult.Text = "Weekday Parsing Result";
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParseButton.Location = new System.Drawing.Point(399, 156);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(111, 40);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsingValueTextBox
            // 
            this.ParsingValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingValueTextBox.Location = new System.Drawing.Point(6, 158);
            this.ParsingValueTextBox.Name = "ParsingValueTextBox";
            this.ParsingValueTextBox.Size = new System.Drawing.Size(385, 31);
            this.ParsingValueTextBox.TabIndex = 2;
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.SeasonLabel);
            this.SeasonHandle.Controls.Add(this.SeasonButton);
            this.SeasonHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandle.Location = new System.Drawing.Point(692, 3);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Size = new System.Drawing.Size(684, 334);
            this.SeasonHandle.TabIndex = 1;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(6, 158);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(385, 33);
            this.SeasonComboBox.TabIndex = 6;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 128);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(136, 25);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonButton.Location = new System.Drawing.Point(399, 156);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(111, 40);
            this.SeasonButton.TabIndex = 7;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.ValueTextBox);
            this.Enumerations.Controls.Add(this.IntValueLabel);
            this.Enumerations.Controls.Add(this.ValueLabel);
            this.Enumerations.Controls.Add(this.EnumsLabel);
            this.Enumerations.Controls.Add(this.ValuesListBox);
            this.Enumerations.Controls.Add(this.EnumsListBox);
            this.Enumerations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enumerations.Location = new System.Drawing.Point(3, 3);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Size = new System.Drawing.Size(1379, 466);
            this.Enumerations.TabIndex = 2;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(581, 70);
            this.ValueTextBox.Multiline = true;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(150, 46);
            this.ValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(581, 42);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(83, 25);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(273, 42);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(122, 25);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(6, 42);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(181, 25);
            this.EnumsLabel.TabIndex = 2;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.ItemHeight = 25;
            this.ValuesListBox.Location = new System.Drawing.Point(273, 70);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(253, 390);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 25;
            this.EnumsListBox.Location = new System.Drawing.Point(6, 70);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(234, 390);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 34);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(1391, 824);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.Movies, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.Rectangles, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1385, 818);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Movies
            // 
            this.Movies.Controls.Add(this.MovieFindButton);
            this.Movies.Controls.Add(this.MovieRatingLabel);
            this.Movies.Controls.Add(this.MovieRatingTextBox);
            this.Movies.Controls.Add(this.MovieGenreLabel);
            this.Movies.Controls.Add(this.MovieGenreTextBox);
            this.Movies.Controls.Add(this.MovieYearLabel);
            this.Movies.Controls.Add(this.MovieYearTextBox);
            this.Movies.Controls.Add(this.MovieListBox);
            this.Movies.Controls.Add(this.MovieDurationLabel);
            this.Movies.Controls.Add(this.MovieDurationTextBox);
            this.Movies.Controls.Add(this.MovieNameLabel);
            this.Movies.Controls.Add(this.MovieNameTextBox);
            this.Movies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Movies.Location = new System.Drawing.Point(695, 3);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(687, 812);
            this.Movies.TabIndex = 1;
            this.Movies.TabStop = false;
            this.Movies.Text = "Movies";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MovieFindButton.Location = new System.Drawing.Point(341, 744);
            this.MovieFindButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(343, 65);
            this.MovieFindButton.TabIndex = 22;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(350, 310);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(67, 25);
            this.MovieRatingLabel.TabIndex = 20;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingTextBox.Location = new System.Drawing.Point(350, 338);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(327, 31);
            this.MovieRatingTextBox.TabIndex = 19;
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(350, 240);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(62, 25);
            this.MovieGenreLabel.TabIndex = 18;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreTextBox.Location = new System.Drawing.Point(350, 268);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(327, 31);
            this.MovieGenreTextBox.TabIndex = 17;
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(350, 170);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(48, 25);
            this.MovieYearLabel.TabIndex = 16;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearTextBox.Location = new System.Drawing.Point(350, 198);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(327, 31);
            this.MovieYearTextBox.TabIndex = 15;
            // 
            // MovieListBox
            // 
            this.MovieListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.IntegralHeight = false;
            this.MovieListBox.ItemHeight = 25;
            this.MovieListBox.Location = new System.Drawing.Point(3, 27);
            this.MovieListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(338, 782);
            this.MovieListBox.TabIndex = 14;
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(350, 100);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(85, 25);
            this.MovieDurationLabel.TabIndex = 13;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationTextBox.Location = new System.Drawing.Point(350, 128);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(327, 31);
            this.MovieDurationTextBox.TabIndex = 12;
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(350, 30);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(63, 25);
            this.MovieNameLabel.TabIndex = 11;
            this.MovieNameLabel.Text = "Name:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieNameTextBox.Location = new System.Drawing.Point(350, 58);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(327, 31);
            this.MovieNameTextBox.TabIndex = 10;
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.RectangleFindButton);
            this.Rectangles.Controls.Add(this.RectangleColorLabel);
            this.Rectangles.Controls.Add(this.RectangleColorTextBox);
            this.Rectangles.Controls.Add(this.RectangleListBox);
            this.Rectangles.Controls.Add(this.RectangleWidthLabel);
            this.Rectangles.Controls.Add(this.RectangleWidthTextBox);
            this.Rectangles.Controls.Add(this.RectangleLengthLabel);
            this.Rectangles.Controls.Add(this.RectangleLengthTextBox);
            this.Rectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rectangles.Location = new System.Drawing.Point(3, 3);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Size = new System.Drawing.Size(686, 812);
            this.Rectangles.TabIndex = 0;
            this.Rectangles.TabStop = false;
            this.Rectangles.Text = "Rectangles";
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RectangleFindButton.Location = new System.Drawing.Point(341, 744);
            this.RectangleFindButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(342, 65);
            this.RectangleFindButton.TabIndex = 21;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            // 
            // RectangleColorLabel
            // 
            this.RectangleColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleColorLabel.AutoSize = true;
            this.RectangleColorLabel.Location = new System.Drawing.Point(350, 170);
            this.RectangleColorLabel.Name = "RectangleColorLabel";
            this.RectangleColorLabel.Size = new System.Drawing.Size(59, 25);
            this.RectangleColorLabel.TabIndex = 9;
            this.RectangleColorLabel.Text = "Color:";
            // 
            // RectangleColorTextBox
            // 
            this.RectangleColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleColorTextBox.Location = new System.Drawing.Point(350, 198);
            this.RectangleColorTextBox.Name = "RectangleColorTextBox";
            this.RectangleColorTextBox.Size = new System.Drawing.Size(327, 31);
            this.RectangleColorTextBox.TabIndex = 8;
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.IntegralHeight = false;
            this.RectangleListBox.ItemHeight = 25;
            this.RectangleListBox.Location = new System.Drawing.Point(3, 27);
            this.RectangleListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(338, 782);
            this.RectangleListBox.TabIndex = 7;
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(350, 100);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(64, 25);
            this.RectangleWidthLabel.TabIndex = 6;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(350, 128);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(327, 31);
            this.RectangleWidthTextBox.TabIndex = 5;
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(350, 30);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(70, 25);
            this.RectangleLengthLabel.TabIndex = 4;
            this.RectangleLengthLabel.Text = "Length:";
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(350, 58);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(327, 31);
            this.RectangleLengthTextBox.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1399, 862);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.SeasonHandle.ResumeLayout(false);
            this.SeasonHandle.PerformLayout();
            this.Enumerations.ResumeLayout(false);
            this.Enumerations.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.Movies.ResumeLayout(false);
            this.Movies.PerformLayout();
            this.Rectangles.ResumeLayout(false);
            this.Rectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage Enums;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private GroupBox Enumerations;
        private TextBox ValueTextBox;
        private Label IntValueLabel;
        private Label ValueLabel;
        private Label EnumsLabel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox WeekdayParsing;
        private GroupBox SeasonHandle;
        private Label ParsingLable;
        private Label ParsingResult;
        private Button ParseButton;
        private TextBox ParsingValueTextBox;
        private Label SeasonLabel;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox Movies;
        private GroupBox Rectangles;
        private Label RectangleLengthLabel;
        private TextBox RectangleLengthTextBox;
        private Button MovieFindButton;
        private Label MovieRatingLabel;
        private TextBox MovieRatingTextBox;
        private Label MovieGenreLabel;
        private TextBox MovieGenreTextBox;
        private Label MovieYearLabel;
        private TextBox MovieYearTextBox;
        private ListBox MovieListBox;
        private Label MovieDurationLabel;
        private TextBox MovieDurationTextBox;
        private Label MovieNameLabel;
        private TextBox MovieNameTextBox;
        private Button RectangleFindButton;
        private Label RectangleColorLabel;
        private TextBox RectangleColorTextBox;
        private ListBox RectangleListBox;
        private Label RectangleWidthLabel;
        private TextBox RectangleWidthTextBox;
    }
}