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
            this.TabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.SeasonHandle.SuspendLayout();
            this.Enumerations.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Enums);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(979, 517);
            this.TabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tableLayoutPanel1);
            this.Enums.Location = new System.Drawing.Point(4, 24);
            this.Enums.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enums.Size = new System.Drawing.Size(971, 489);
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
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.73196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.26804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(967, 485);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 282);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(963, 201);
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
            this.WeekdayParsing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WeekdayParsing.Size = new System.Drawing.Size(477, 197);
            this.WeekdayParsing.TabIndex = 0;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing";
            // 
            // ParsingLable
            // 
            this.ParsingLable.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParsingLable.AutoSize = true;
            this.ParsingLable.Location = new System.Drawing.Point(4, 75);
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
            this.ParsingResult.Location = new System.Drawing.Point(4, 118);
            this.ParsingResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ParsingResult.Name = "ParsingResult";
            this.ParsingResult.Size = new System.Drawing.Size(132, 15);
            this.ParsingResult.TabIndex = 7;
            this.ParsingResult.Text = "Weekday Parsing Result";
            // 
            // ParseButton
            // 
            this.ParseButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ParseButton.Location = new System.Drawing.Point(279, 92);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ParsingValueTextBox.Location = new System.Drawing.Point(4, 93);
            this.ParsingValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.SeasonHandle.Location = new System.Drawing.Point(483, 2);
            this.SeasonHandle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeasonHandle.Name = "SeasonHandle";
            this.SeasonHandle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeasonHandle.Size = new System.Drawing.Size(478, 197);
            this.SeasonHandle.TabIndex = 1;
            this.SeasonHandle.TabStop = false;
            this.SeasonHandle.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(4, 93);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(271, 23);
            this.SeasonComboBox.TabIndex = 6;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(4, 75);
            this.SeasonLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(89, 15);
            this.SeasonLabel.TabIndex = 8;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SeasonButton.Location = new System.Drawing.Point(279, 92);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.Enumerations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Enumerations.Size = new System.Drawing.Size(963, 276);
            this.Enumerations.TabIndex = 2;
            this.Enumerations.TabStop = false;
            this.Enumerations.Text = "Enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(407, 42);
            this.ValueTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueTextBox.Multiline = true;
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(106, 29);
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
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(178, 232);
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
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(165, 232);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 517);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
    }
}