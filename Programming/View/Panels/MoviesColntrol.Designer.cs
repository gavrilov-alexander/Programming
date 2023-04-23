namespace Programming.View.Panels
{
    partial class MoviesColntrol
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
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
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
            this.MoviesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieFindButton);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieRatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieGenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieYearLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieListBox);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieDurationTextBox);
            this.MoviesGroupBox.Controls.Add(this.MovieNameLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieNameTextBox);
            this.MoviesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(539, 660);
            this.MoviesGroupBox.TabIndex = 2;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieFindButton
            // 
            this.MovieFindButton.Location = new System.Drawing.Point(350, 385);
            this.MovieFindButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieFindButton.Name = "MovieFindButton";
            this.MovieFindButton.Size = new System.Drawing.Size(107, 38);
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
            this.MovieRatingLabel.Location = new System.Drawing.Point(349, 308);
            this.MovieRatingLabel.Name = "MovieRatingLabel";
            this.MovieRatingLabel.Size = new System.Drawing.Size(67, 25);
            this.MovieRatingLabel.TabIndex = 20;
            this.MovieRatingLabel.Text = "Rating:";
            // 
            // MovieRatingTextBox
            // 
            this.MovieRatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieRatingTextBox.Location = new System.Drawing.Point(349, 337);
            this.MovieRatingTextBox.Name = "MovieRatingTextBox";
            this.MovieRatingTextBox.Size = new System.Drawing.Size(177, 31);
            this.MovieRatingTextBox.TabIndex = 19;
            this.MovieRatingTextBox.TextChanged += new System.EventHandler(this.MovieRatingTextBox_TextChanged);
            // 
            // MovieGenreLabel
            // 
            this.MovieGenreLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieGenreLabel.AutoSize = true;
            this.MovieGenreLabel.Location = new System.Drawing.Point(349, 238);
            this.MovieGenreLabel.Name = "MovieGenreLabel";
            this.MovieGenreLabel.Size = new System.Drawing.Size(62, 25);
            this.MovieGenreLabel.TabIndex = 18;
            this.MovieGenreLabel.Text = "Genre:";
            // 
            // MovieGenreTextBox
            // 
            this.MovieGenreTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieGenreTextBox.Location = new System.Drawing.Point(349, 267);
            this.MovieGenreTextBox.Name = "MovieGenreTextBox";
            this.MovieGenreTextBox.Size = new System.Drawing.Size(177, 31);
            this.MovieGenreTextBox.TabIndex = 17;
            this.MovieGenreTextBox.TextChanged += new System.EventHandler(this.MovieGenreTextBox_TextChanged);
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(349, 168);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(48, 25);
            this.MovieYearLabel.TabIndex = 16;
            this.MovieYearLabel.Text = "Year:";
            // 
            // MovieYearTextBox
            // 
            this.MovieYearTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieYearTextBox.Location = new System.Drawing.Point(349, 197);
            this.MovieYearTextBox.Name = "MovieYearTextBox";
            this.MovieYearTextBox.Size = new System.Drawing.Size(177, 31);
            this.MovieYearTextBox.TabIndex = 15;
            this.MovieYearTextBox.TextChanged += new System.EventHandler(this.MovieYearTextBox_TextChanged);
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
            this.MovieListBox.Size = new System.Drawing.Size(338, 630);
            this.MovieListBox.TabIndex = 14;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // MovieDurationLabel
            // 
            this.MovieDurationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieDurationLabel.AutoSize = true;
            this.MovieDurationLabel.Location = new System.Drawing.Point(349, 98);
            this.MovieDurationLabel.Name = "MovieDurationLabel";
            this.MovieDurationLabel.Size = new System.Drawing.Size(85, 25);
            this.MovieDurationLabel.TabIndex = 13;
            this.MovieDurationLabel.Text = "Duration:";
            // 
            // MovieDurationTextBox
            // 
            this.MovieDurationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieDurationTextBox.Location = new System.Drawing.Point(349, 127);
            this.MovieDurationTextBox.Name = "MovieDurationTextBox";
            this.MovieDurationTextBox.Size = new System.Drawing.Size(177, 31);
            this.MovieDurationTextBox.TabIndex = 12;
            this.MovieDurationTextBox.TextChanged += new System.EventHandler(this.MovieDurationTextBox_TextChanged);
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.Location = new System.Drawing.Point(349, 28);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(63, 25);
            this.MovieNameLabel.TabIndex = 11;
            this.MovieNameLabel.Text = "Name:";
            // 
            // MovieNameTextBox
            // 
            this.MovieNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieNameTextBox.Location = new System.Drawing.Point(349, 57);
            this.MovieNameTextBox.Name = "MovieNameTextBox";
            this.MovieNameTextBox.Size = new System.Drawing.Size(177, 31);
            this.MovieNameTextBox.TabIndex = 10;
            this.MovieNameTextBox.TextChanged += new System.EventHandler(this.MovieNameTextBox_TextChanged);
            // 
            // MoviesColntrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MoviesColntrol";
            this.Size = new System.Drawing.Size(539, 660);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox MoviesGroupBox;
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
    }
}
