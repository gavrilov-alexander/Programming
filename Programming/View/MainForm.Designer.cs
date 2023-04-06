namespace Programming.View
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
            this.ClassesRectangleIdLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleCenterGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesRectangleCenterYLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleCenterXLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleCenterYTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectangleCenterXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleFindButton = new System.Windows.Forms.Button();
            this.ClassesRectangleColorLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleColorTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectangleListBox = new System.Windows.Forms.ListBox();
            this.ClassesRectangleWidthLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectangleLengthLabel = new System.Windows.Forms.Label();
            this.ClassesRectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleTabPage = new System.Windows.Forms.TabPage();
            this.RectanglePanel = new System.Windows.Forms.Panel();
            this.RectangleLengthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleLengthLabel = new System.Windows.Forms.Label();
            this.RectangleWidthTextBox = new System.Windows.Forms.TextBox();
            this.RectangleWidthLabel = new System.Windows.Forms.Label();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.RectangleIdTextBox = new System.Windows.Forms.TextBox();
            this.RectangleIdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleListBox = new System.Windows.Forms.ListBox();
            this.RectangleDeletePictureBox = new System.Windows.Forms.PictureBox();
            this.RectangleAddPictureBox = new System.Windows.Forms.PictureBox();
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
            this.RectangleCenterGroupBox.SuspendLayout();
            this.RectangleTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleDeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleAddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Enums);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectangleTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(771, 443);
            this.TabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tableLayoutPanel1);
            this.Enums.Location = new System.Drawing.Point(4, 24);
            this.Enums.Margin = new System.Windows.Forms.Padding(2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(2);
            this.Enums.Size = new System.Drawing.Size(763, 415);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.73196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.26804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 411);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 239);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(755, 170);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.ParsingLable);
            this.WeekdayParsing.Controls.Add(this.ParsingResult);
            this.WeekdayParsing.Controls.Add(this.ParseButton);
            this.WeekdayParsing.Controls.Add(this.ParsingValueTextBox);
            this.WeekdayParsing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsing.Location = new System.Drawing.Point(2, 2);
            this.WeekdayParsing.Margin = new System.Windows.Forms.Padding(2);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Padding = new System.Windows.Forms.Padding(2);
            this.WeekdayParsing.Size = new System.Drawing.Size(373, 166);
            this.WeekdayParsing.TabIndex = 0;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing";
            // 
            // ParsingLable
            // 
            this.ParsingLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingLable.AutoSize = true;
            this.ParsingLable.Location = new System.Drawing.Point(4, 60);
            this.ParsingLable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParsingLable.Name = "ParsingLable";
            this.ParsingLable.Size = new System.Drawing.Size(125, 15);
            this.ParsingLable.TabIndex = 6;
            this.ParsingLable.Text = "Type value for parsing:";
            // 
            // ParsingResult
            // 
            this.ParsingResult.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingResult.AutoSize = true;
            this.ParsingResult.Location = new System.Drawing.Point(4, 103);
            this.ParsingResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParsingResult.Name = "ParsingResult";
            this.ParsingResult.Size = new System.Drawing.Size(132, 15);
            this.ParsingResult.TabIndex = 7;
            this.ParsingResult.Text = "Weekday Parsing Result";
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParseButton.Location = new System.Drawing.Point(279, 77);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(78, 24);
            this.ParseButton.TabIndex = 6;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // ParsingValueTextBox
            // 
            this.ParsingValueTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingValueTextBox.Location = new System.Drawing.Point(4, 78);
            this.ParsingValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ParsingValueTextBox.Name = "ParsingValueTextBox";
            this.ParsingValueTextBox.Size = new System.Drawing.Size(271, 23);
            this.ParsingValueTextBox.TabIndex = 2;
            // 
            // SeasonHandle
            // 
            this.SeasonHandle.Controls.Add(this.SeasonComboBox);
            this.SeasonHandle.Controls.Add(this.SeasonLabel);
            this.SeasonHandle.Controls.Add(this.SeasonButton);
            this.SeasonHandle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandle.Location = new System.Drawing.Point(379, 2);
            this.SeasonHandle.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Padding = new System.Windows.Forms.Padding(2);
            this.SeasonHandle.Size = new System.Drawing.Size(374, 166);
            this.SeasonHandle.TabIndex = 1;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(4, 78);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(271, 23);
            this.SeasonComboBox.TabIndex = 6;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(4, 60);
            this.SeasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonButton.Location = new System.Drawing.Point(279, 77);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(2);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(78, 24);
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
            this.Enumerations.Location = new System.Drawing.Point(2, 2);
            this.Enumerations.Margin = new System.Windows.Forms.Padding(2);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Padding = new System.Windows.Forms.Padding(2);
            this.Enumerations.Size = new System.Drawing.Size(755, 233);
            this.Enumerations.TabIndex = 2;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(407, 42);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValueTextBox.Multiline = true;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(106, 23);
            this.ValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(407, 25);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(55, 15);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(191, 25);
            this.ValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(81, 15);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(4, 25);
            this.EnumsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(121, 15);
            this.EnumsLabel.TabIndex = 2;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.IntegralHeight = false;
            this.ValuesListBox.ItemHeight = 15;
            this.ValuesListBox.Location = new System.Drawing.Point(191, 42);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(178, 189);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.IntegralHeight = false;
            this.EnumsListBox.ItemHeight = 15;
            this.EnumsListBox.Location = new System.Drawing.Point(4, 42);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(165, 189);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.ClassesTabPage.Size = new System.Drawing.Size(763, 415);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(759, 411);
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
            this.Movies.Location = new System.Drawing.Point(381, 2);
            this.Movies.Margin = new System.Windows.Forms.Padding(2);
            this.Movies.Name = "Movies";
            this.Movies.Padding = new System.Windows.Forms.Padding(2);
            this.Movies.Size = new System.Drawing.Size(376, 407);
            this.Movies.TabIndex = 1;
            this.Movies.TabStop = false;
            this.Movies.Text = "Movies";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(245, 231);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(75, 23);
            this.MovieFindButton.TabIndex = 22;
            this.MovieFindButton.Text = "Find";
            this.MovieFindButton.UseVisualStyleBackColor = true;
            this.MovieFindButton.Click += new System.EventHandler(this.MovieFindButton_Click);
            // 
            // MovieRatingLabel
            // 
            this.MovieRatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieRatingLabel.AutoSize = true;
            this.MovieRatingLabel.Location = new System.Drawing.Point(245, 186);
            this.MovieRatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(44, 15);
            this.MovieRatingLabel.TabIndex = 20;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieRatingTextBox.Location = new System.Drawing.Point(245, 203);
            this.MovieRatingTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(125, 23);
            this.MovieRatingTextBox.TabIndex = 19;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(245, 144);
            this.MovieGenreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(41, 15);
            this.MovieGenreLabel.TabIndex = 18;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieGenreTextBox.Location = new System.Drawing.Point(245, 161);
            this.MovieGenreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(125, 23);
            this.MovieGenreTextBox.TabIndex = 17;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(245, 102);
            this.MovieYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(32, 15);
            this.MovieYearLabel.TabIndex = 16;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieYearTextBox.Location = new System.Drawing.Point(245, 119);
            this.MovieYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(125, 23);
            this.MovieYearTextBox.TabIndex = 15;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
            // 
            // MovieListBox
            // 
            this.MovieListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.IntegralHeight = false;
            this.MovieListBox.ItemHeight = 15;
            this.MovieListBox.Location = new System.Drawing.Point(2, 18);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(238, 387);
            this.MovieListBox.TabIndex = 14;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(245, 60);
            this.MovieDurationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(56, 15);
            this.MovieDurationLabel.TabIndex = 13;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieDurationTextBox.Location = new System.Drawing.Point(245, 77);
            this.MovieDurationTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(125, 23);
            this.MovieDurationTextBox.TabIndex = 12;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(245, 18);
            this.MovieNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(42, 15);
            this.MovieNameLabel.TabIndex = 11;
            this.MovieNameLabel.Text = "Name:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieNameTextBox.Location = new System.Drawing.Point(245, 35);
            this.MovieNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(125, 23);
            this.MovieNameTextBox.TabIndex = 10;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // Rectangles
            // 
            this.Rectangles.Controls.Add(this.ClassesRectangleIdLabel);
            this.Rectangles.Controls.Add(this.ClassesRectangleIdTextBox);
            this.Rectangles.Controls.Add(this.RectangleCenterGroupBox);
            this.Rectangles.Controls.Add(this.RectangleFindButton);
            this.Rectangles.Controls.Add(this.ClassesRectangleColorLabel);
            this.Rectangles.Controls.Add(this.ClassesRectangleColorTextBox);
            this.Rectangles.Controls.Add(this.ClassesRectangleListBox);
            this.Rectangles.Controls.Add(this.ClassesRectangleWidthLabel);
            this.Rectangles.Controls.Add(this.ClassesRectangleWidthTextBox);
            this.Rectangles.Controls.Add(this.ClassesRectangleLengthLabel);
            this.Rectangles.Controls.Add(this.ClassesRectangleLengthTextBox);
            this.Rectangles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rectangles.Location = new System.Drawing.Point(2, 2);
            this.Rectangles.Margin = new System.Windows.Forms.Padding(2);
            this.Rectangles.Name = "Rectangles";
            this.Rectangles.Padding = new System.Windows.Forms.Padding(2);
            this.Rectangles.Size = new System.Drawing.Size(375, 407);
            this.Rectangles.TabIndex = 0;
            this.Rectangles.TabStop = false;
            this.Rectangles.Text = "Rectangles";
            // 
            // ClassesRectangleIdLabel
            // 
            this.ClassesRectangleIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleIdLabel.AutoSize = true;
            this.ClassesRectangleIdLabel.Location = new System.Drawing.Point(245, 144);
            this.ClassesRectangleIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleIdLabel.Name = "ClassesRectangleIdLabel";
            this.ClassesRectangleIdLabel.Size = new System.Drawing.Size(20, 15);
            this.ClassesRectangleIdLabel.TabIndex = 23;
            this.ClassesRectangleIdLabel.Text = "Id:";
            // 
            // ClassesRectangleIdTextBox
            // 
            this.ClassesRectangleIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassesRectangleIdTextBox.Location = new System.Drawing.Point(245, 161);
            this.ClassesRectangleIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesRectangleIdTextBox.Name = "ClassesRectangleIdTextBox";
            this.ClassesRectangleIdTextBox.ReadOnly = true;
            this.ClassesRectangleIdTextBox.Size = new System.Drawing.Size(125, 23);
            this.ClassesRectangleIdTextBox.TabIndex = 22;
            // 
            // RectangleCenterGroupBox
            // 
            this.RectangleCenterGroupBox.Controls.Add(this.ClassesRectangleCenterYLabel);
            this.RectangleCenterGroupBox.Controls.Add(this.ClassesRectangleCenterXLabel);
            this.RectangleCenterGroupBox.Controls.Add(this.ClassesRectangleCenterYTextBox);
            this.RectangleCenterGroupBox.Controls.Add(this.ClassesRectangleCenterXTextBox);
            this.RectangleCenterGroupBox.Location = new System.Drawing.Point(245, 189);
            this.RectangleCenterGroupBox.Name = "RectangleCenterGroupBox";
            this.RectangleCenterGroupBox.Size = new System.Drawing.Size(125, 114);
            this.RectangleCenterGroupBox.TabIndex = 1;
            this.RectangleCenterGroupBox.TabStop = false;
            this.RectangleCenterGroupBox.Text = "Center";
            // 
            // ClassesRectangleCenterYLabel
            // 
            this.ClassesRectangleCenterYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleCenterYLabel.AutoSize = true;
            this.ClassesRectangleCenterYLabel.Location = new System.Drawing.Point(6, 64);
            this.ClassesRectangleCenterYLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleCenterYLabel.Name = "ClassesRectangleCenterYLabel";
            this.ClassesRectangleCenterYLabel.Size = new System.Drawing.Size(17, 15);
            this.ClassesRectangleCenterYLabel.TabIndex = 23;
            this.ClassesRectangleCenterYLabel.Text = "Y:";
            // 
            // ClassesRectangleCenterXLabel
            // 
            this.ClassesRectangleCenterXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleCenterXLabel.AutoSize = true;
            this.ClassesRectangleCenterXLabel.Location = new System.Drawing.Point(6, 20);
            this.ClassesRectangleCenterXLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleCenterXLabel.Name = "ClassesRectangleCenterXLabel";
            this.ClassesRectangleCenterXLabel.Size = new System.Drawing.Size(17, 15);
            this.ClassesRectangleCenterXLabel.TabIndex = 22;
            this.ClassesRectangleCenterXLabel.Text = "X:";
            // 
            // ClassesRectangleCenterYTextBox
            // 
            this.ClassesRectangleCenterYTextBox.Location = new System.Drawing.Point(6, 82);
            this.ClassesRectangleCenterYTextBox.Name = "ClassesRectangleCenterYTextBox";
            this.ClassesRectangleCenterYTextBox.ReadOnly = true;
            this.ClassesRectangleCenterYTextBox.Size = new System.Drawing.Size(113, 23);
            this.ClassesRectangleCenterYTextBox.TabIndex = 1;
            // 
            // ClassesRectangleCenterXTextBox
            // 
            this.ClassesRectangleCenterXTextBox.Location = new System.Drawing.Point(6, 38);
            this.ClassesRectangleCenterXTextBox.Name = "ClassesRectangleCenterXTextBox";
            this.ClassesRectangleCenterXTextBox.ReadOnly = true;
            this.ClassesRectangleCenterXTextBox.Size = new System.Drawing.Size(113, 23);
            this.ClassesRectangleCenterXTextBox.TabIndex = 0;
            // 
            // RectangleFindButton
            // 
            this.RectangleFindButton.Location = new System.Drawing.Point(245, 309);
            this.RectangleFindButton.Name = "RectangleFindButton";
            this.RectangleFindButton.Size = new System.Drawing.Size(75, 23);
            this.RectangleFindButton.TabIndex = 21;
            this.RectangleFindButton.Text = "Find";
            this.RectangleFindButton.UseVisualStyleBackColor = true;
            this.RectangleFindButton.Click += new System.EventHandler(this.RectangleFindButton_Click);
            // 
            // ClassesRectangleColorLabel
            // 
            this.ClassesRectangleColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleColorLabel.AutoSize = true;
            this.ClassesRectangleColorLabel.Location = new System.Drawing.Point(245, 102);
            this.ClassesRectangleColorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleColorLabel.Name = "ClassesRectangleColorLabel";
            this.ClassesRectangleColorLabel.Size = new System.Drawing.Size(39, 15);
            this.ClassesRectangleColorLabel.TabIndex = 9;
            this.ClassesRectangleColorLabel.Text = "Color:";
            // 
            // ClassesRectangleColorTextBox
            // 
            this.ClassesRectangleColorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassesRectangleColorTextBox.Location = new System.Drawing.Point(245, 119);
            this.ClassesRectangleColorTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesRectangleColorTextBox.Name = "ClassesRectangleColorTextBox";
            this.ClassesRectangleColorTextBox.Size = new System.Drawing.Size(125, 23);
            this.ClassesRectangleColorTextBox.TabIndex = 8;
            this.ClassesRectangleColorTextBox.TextChanged += new System.EventHandler(this.RectangleColorTextBox_TextChanged);
            // 
            // ClassesRectangleListBox
            // 
            this.ClassesRectangleListBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassesRectangleListBox.FormattingEnabled = true;
            this.ClassesRectangleListBox.IntegralHeight = false;
            this.ClassesRectangleListBox.ItemHeight = 15;
            this.ClassesRectangleListBox.Location = new System.Drawing.Point(2, 18);
            this.ClassesRectangleListBox.Name = "ClassesRectangleListBox";
            this.ClassesRectangleListBox.Size = new System.Drawing.Size(238, 387);
            this.ClassesRectangleListBox.TabIndex = 7;
            this.ClassesRectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // ClassesRectangleWidthLabel
            // 
            this.ClassesRectangleWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleWidthLabel.AutoSize = true;
            this.ClassesRectangleWidthLabel.Location = new System.Drawing.Point(245, 60);
            this.ClassesRectangleWidthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleWidthLabel.Name = "ClassesRectangleWidthLabel";
            this.ClassesRectangleWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.ClassesRectangleWidthLabel.TabIndex = 6;
            this.ClassesRectangleWidthLabel.Text = "Width:";
            // 
            // ClassesRectangleWidthTextBox
            // 
            this.ClassesRectangleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassesRectangleWidthTextBox.Location = new System.Drawing.Point(245, 77);
            this.ClassesRectangleWidthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesRectangleWidthTextBox.Name = "ClassesRectangleWidthTextBox";
            this.ClassesRectangleWidthTextBox.Size = new System.Drawing.Size(125, 23);
            this.ClassesRectangleWidthTextBox.TabIndex = 5;
            this.ClassesRectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // ClassesRectangleLengthLabel
            // 
            this.ClassesRectangleLengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassesRectangleLengthLabel.AutoSize = true;
            this.ClassesRectangleLengthLabel.Location = new System.Drawing.Point(245, 18);
            this.ClassesRectangleLengthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ClassesRectangleLengthLabel.Name = "ClassesRectangleLengthLabel";
            this.ClassesRectangleLengthLabel.Size = new System.Drawing.Size(47, 15);
            this.ClassesRectangleLengthLabel.TabIndex = 4;
            this.ClassesRectangleLengthLabel.Text = "Length:";
            // 
            // ClassesRectangleLengthTextBox
            // 
            this.ClassesRectangleLengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ClassesRectangleLengthTextBox.Location = new System.Drawing.Point(245, 35);
            this.ClassesRectangleLengthTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ClassesRectangleLengthTextBox.Name = "ClassesRectangleLengthTextBox";
            this.ClassesRectangleLengthTextBox.Size = new System.Drawing.Size(125, 23);
            this.ClassesRectangleLengthTextBox.TabIndex = 3;
            this.ClassesRectangleLengthTextBox.TextChanged += new System.EventHandler(this.RectangleLengthTextBox_TextChanged);
            // 
            // RectangleTabPage
            // 
            this.RectangleTabPage.AutoScroll = true;
            this.RectangleTabPage.Controls.Add(this.RectanglePanel);
            this.RectangleTabPage.Controls.Add(this.RectangleLengthTextBox);
            this.RectangleTabPage.Controls.Add(this.RectangleLengthLabel);
            this.RectangleTabPage.Controls.Add(this.RectangleWidthTextBox);
            this.RectangleTabPage.Controls.Add(this.RectangleWidthLabel);
            this.RectangleTabPage.Controls.Add(this.RectangleYTextBox);
            this.RectangleTabPage.Controls.Add(this.RectangleYLabel);
            this.RectangleTabPage.Controls.Add(this.RectangleXTextBox);
            this.RectangleTabPage.Controls.Add(this.RectangleXLabel);
            this.RectangleTabPage.Controls.Add(this.RectangleIdTextBox);
            this.RectangleTabPage.Controls.Add(this.RectangleIdLabel);
            this.RectangleTabPage.Controls.Add(this.SelectedRectangleLabel);
            this.RectangleTabPage.Controls.Add(this.RectangleListBox);
            this.RectangleTabPage.Controls.Add(this.RectangleDeletePictureBox);
            this.RectangleTabPage.Controls.Add(this.RectangleAddPictureBox);
            this.RectangleTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectangleTabPage.Name = "RectangleTabPage";
            this.RectangleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectangleTabPage.Size = new System.Drawing.Size(763, 415);
            this.RectangleTabPage.TabIndex = 2;
            this.RectangleTabPage.Text = "Rectangles";
            this.RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglePanel
            // 
            this.RectanglePanel.Location = new System.Drawing.Point(350, 6);
            this.RectanglePanel.Name = "RectanglePanel";
            this.RectanglePanel.Size = new System.Drawing.Size(405, 401);
            this.RectanglePanel.TabIndex = 14;
            // 
            // RectangleLengthTextBox
            // 
            this.RectangleLengthTextBox.Location = new System.Drawing.Point(61, 358);
            this.RectangleLengthTextBox.Name = "RectangleLengthTextBox";
            this.RectangleLengthTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleLengthTextBox.TabIndex = 13;
            // 
            // RectangleLengthLabel
            // 
            this.RectangleLengthLabel.AutoSize = true;
            this.RectangleLengthLabel.Location = new System.Drawing.Point(8, 361);
            this.RectangleLengthLabel.Name = "RectangleLengthLabel";
            this.RectangleLengthLabel.Size = new System.Drawing.Size(47, 15);
            this.RectangleLengthLabel.TabIndex = 12;
            this.RectangleLengthLabel.Text = "Length:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(61, 329);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleWidthTextBox.TabIndex = 11;
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(13, 332);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.RectangleWidthLabel.TabIndex = 10;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Location = new System.Drawing.Point(61, 300);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleYTextBox.TabIndex = 9;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(38, 303);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(17, 15);
            this.RectangleYLabel.TabIndex = 8;
            this.RectangleYLabel.Text = "Y:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Location = new System.Drawing.Point(61, 271);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleXTextBox.TabIndex = 7;
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(38, 274);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(17, 15);
            this.RectangleXLabel.TabIndex = 6;
            this.RectangleXLabel.Text = "X:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Location = new System.Drawing.Point(61, 242);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleIdTextBox.TabIndex = 5;
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(35, 245);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(20, 15);
            this.RectangleIdLabel.TabIndex = 4;
            this.RectangleIdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(8, 223);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 3;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.ItemHeight = 15;
            this.RectangleListBox.Location = new System.Drawing.Point(8, 6);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(297, 169);
            this.RectangleListBox.TabIndex = 2;
            // 
            // RectangleDeletePictureBox
            // 
            this.RectangleDeletePictureBox.Image = global::Programming.Properties.Resources.rectangle_remove_24x24;
            this.RectangleDeletePictureBox.Location = new System.Drawing.Point(38, 181);
            this.RectangleDeletePictureBox.Name = "RectangleDeletePictureBox";
            this.RectangleDeletePictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectangleDeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectangleDeletePictureBox.TabIndex = 1;
            this.RectangleDeletePictureBox.TabStop = false;
            // 
            // RectangleAddPictureBox
            // 
            this.RectangleAddPictureBox.Image = global::Programming.Properties.Resources.rectangle_add_24x24;
            this.RectangleAddPictureBox.Location = new System.Drawing.Point(8, 181);
            this.RectangleAddPictureBox.Name = "RectangleAddPictureBox";
            this.RectangleAddPictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectangleAddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectangleAddPictureBox.TabIndex = 0;
            this.RectangleAddPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 443);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
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
            this.RectangleCenterGroupBox.ResumeLayout(false);
            this.RectangleCenterGroupBox.PerformLayout();
            this.RectangleTabPage.ResumeLayout(false);
            this.RectangleTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleDeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleAddPictureBox)).EndInit();
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
        private Label ClassesRectangleLengthLabel;
        private TextBox ClassesRectangleLengthTextBox;
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
        private Label ClassesRectangleColorLabel;
        private TextBox ClassesRectangleColorTextBox;
        private ListBox ClassesRectangleListBox;
        private Label ClassesRectangleWidthLabel;
        private TextBox ClassesRectangleWidthTextBox;
        private GroupBox RectangleCenterGroupBox;
        private Label ClassesRectangleCenterYLabel;
        private Label ClassesRectangleCenterXLabel;
        private TextBox ClassesRectangleCenterYTextBox;
        private TextBox ClassesRectangleCenterXTextBox;
        private Label ClassesRectangleIdLabel;
        private TextBox ClassesRectangleIdTextBox;
        private TabPage RectangleTabPage;
        private PictureBox RectangleDeletePictureBox;
        private PictureBox RectangleAddPictureBox;
        private TextBox RectangleLengthTextBox;
        private Label RectangleLengthLabel;
        private TextBox RectangleWidthTextBox;
        private Label RectangleWidthLabel;
        private TextBox RectangleYTextBox;
        private Label RectangleYLabel;
        private TextBox RectangleXTextBox;
        private Label RectangleXLabel;
        private TextBox RectangleIdTextBox;
        private Label RectangleIdLabel;
        private Label SelectedRectangleLabel;
        private ListBox RectangleListBox;
        private Panel RectanglePanel;
    }
}