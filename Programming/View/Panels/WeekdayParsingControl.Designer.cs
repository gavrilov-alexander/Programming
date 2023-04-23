namespace Programming.View.Panels
{
    partial class WeekdayParsingControl
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
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingLable = new System.Windows.Forms.Label();
            this.ParsingResultLable = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsingValueTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingLable);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingResultLable);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingValueTextBox);
            this.WeekdayParsingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(0, 0);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(536, 270);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingLable
            // 
            this.ParsingLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingLable.AutoSize = true;
            this.ParsingLable.Location = new System.Drawing.Point(6, 95);
            this.ParsingLable.Name = "ParsingLable";
            this.ParsingLable.Size = new System.Drawing.Size(191, 25);
            this.ParsingLable.TabIndex = 6;
            this.ParsingLable.Text = "Type value for parsing:";
            // 
            // ParsingResultLable
            // 
            this.ParsingResultLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingResultLable.AutoSize = true;
            this.ParsingResultLable.Location = new System.Drawing.Point(6, 167);
            this.ParsingResultLable.Name = "ParsingResultLable";
            this.ParsingResultLable.Size = new System.Drawing.Size(198, 25);
            this.ParsingResultLable.TabIndex = 7;
            this.ParsingResultLable.Text = "Weekday Parsing Result";
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParseButton.Location = new System.Drawing.Point(399, 123);
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
            this.ParsingValueTextBox.Location = new System.Drawing.Point(6, 125);
            this.ParsingValueTextBox.Name = "ParsingValueTextBox";
            this.ParsingValueTextBox.Size = new System.Drawing.Size(385, 31);
            this.ParsingValueTextBox.TabIndex = 2;
            // 
            // WeekdayParsingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WeekdayParsingGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WeekdayParsingControl";
            this.Size = new System.Drawing.Size(536, 270);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox WeekdayParsingGroupBox;
        private Label ParsingLable;
        private Label ParsingResultLable;
        private Button ParseButton;
        private TextBox ParsingValueTextBox;
    }
}
