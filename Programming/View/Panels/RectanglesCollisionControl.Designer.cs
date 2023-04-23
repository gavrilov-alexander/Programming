namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectangleCanvasPanel = new System.Windows.Forms.Panel();
            this.RectangleHeightTextBox = new System.Windows.Forms.TextBox();
            this.RectangleHeightLabel = new System.Windows.Forms.Label();
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
            this.RectanglesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleDeletePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleAddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectangleCanvasPanel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleHeightTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleHeightLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleWidthLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleIdLabel);
            this.RectanglesGroupBox.Controls.Add(this.SelectedRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleListBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleDeletePictureBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleAddPictureBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.RectanglesGroupBox.Size = new System.Drawing.Size(760, 398);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectangleCanvasPanel
            // 
            this.RectangleCanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectangleCanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectangleCanvasPanel.Location = new System.Drawing.Point(355, 18);
            this.RectangleCanvasPanel.Name = "RectangleCanvasPanel";
            this.RectangleCanvasPanel.Size = new System.Drawing.Size(403, 378);
            this.RectangleCanvasPanel.TabIndex = 44;
            // 
            // RectangleHeightTextBox
            // 
            this.RectangleHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleHeightTextBox.Location = new System.Drawing.Point(58, 360);
            this.RectangleHeightTextBox.Name = "RectangleHeightTextBox";
            this.RectangleHeightTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleHeightTextBox.TabIndex = 43;
            this.RectangleHeightTextBox.TextChanged += new System.EventHandler(this.RectangleHeightTextBox_TextChanged);
            // 
            // RectangleHeightLabel
            // 
            this.RectangleHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleHeightLabel.AutoSize = true;
            this.RectangleHeightLabel.Location = new System.Drawing.Point(5, 363);
            this.RectangleHeightLabel.Name = "RectangleHeightLabel";
            this.RectangleHeightLabel.Size = new System.Drawing.Size(46, 15);
            this.RectangleHeightLabel.TabIndex = 42;
            this.RectangleHeightLabel.Text = "Height:";
            // 
            // RectangleWidthTextBox
            // 
            this.RectangleWidthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleWidthTextBox.Location = new System.Drawing.Point(58, 331);
            this.RectangleWidthTextBox.Name = "RectangleWidthTextBox";
            this.RectangleWidthTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleWidthTextBox.TabIndex = 41;
            this.RectangleWidthTextBox.TextChanged += new System.EventHandler(this.RectangleWidthTextBox_TextChanged);
            // 
            // RectangleWidthLabel
            // 
            this.RectangleWidthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleWidthLabel.AutoSize = true;
            this.RectangleWidthLabel.Location = new System.Drawing.Point(10, 334);
            this.RectangleWidthLabel.Name = "RectangleWidthLabel";
            this.RectangleWidthLabel.Size = new System.Drawing.Size(42, 15);
            this.RectangleWidthLabel.TabIndex = 40;
            this.RectangleWidthLabel.Text = "Width:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleYTextBox.Location = new System.Drawing.Point(58, 302);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleYTextBox.TabIndex = 39;
            this.RectangleYTextBox.TextChanged += new System.EventHandler(this.RectangleYTextBox_TextChanged);
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(35, 305);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(17, 15);
            this.RectangleYLabel.TabIndex = 38;
            this.RectangleYLabel.Text = "Y:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleXTextBox.Location = new System.Drawing.Point(58, 273);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleXTextBox.TabIndex = 37;
            this.RectangleXTextBox.TextChanged += new System.EventHandler(this.RectangleXTextBox_TextChanged);
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(35, 276);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(17, 15);
            this.RectangleXLabel.TabIndex = 36;
            this.RectangleXLabel.Text = "X:";
            // 
            // RectangleIdTextBox
            // 
            this.RectangleIdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleIdTextBox.Location = new System.Drawing.Point(58, 244);
            this.RectangleIdTextBox.Name = "RectangleIdTextBox";
            this.RectangleIdTextBox.Size = new System.Drawing.Size(100, 23);
            this.RectangleIdTextBox.TabIndex = 35;
            this.RectangleIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RectangleIdTextBox_KeyPress);
            // 
            // RectangleIdLabel
            // 
            this.RectangleIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleIdLabel.AutoSize = true;
            this.RectangleIdLabel.Location = new System.Drawing.Point(32, 247);
            this.RectangleIdLabel.Name = "RectangleIdLabel";
            this.RectangleIdLabel.Size = new System.Drawing.Size(20, 15);
            this.RectangleIdLabel.TabIndex = 34;
            this.RectangleIdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(5, 225);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(109, 15);
            this.SelectedRectangleLabel.TabIndex = 33;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectangleListBox
            // 
            this.RectangleListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleListBox.FormattingEnabled = true;
            this.RectangleListBox.IntegralHeight = false;
            this.RectangleListBox.ItemHeight = 15;
            this.RectangleListBox.Location = new System.Drawing.Point(5, 19);
            this.RectangleListBox.Name = "RectangleListBox";
            this.RectangleListBox.Size = new System.Drawing.Size(297, 158);
            this.RectangleListBox.TabIndex = 32;
            this.RectangleListBox.SelectedIndexChanged += new System.EventHandler(this.RectangleListBox_SelectedIndexChanged);
            // 
            // RectangleDeletePictureBox
            // 
            this.RectangleDeletePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleDeletePictureBox.Image = global::Programming.Properties.Resources.rectangle_remove_24x24;
            this.RectangleDeletePictureBox.Location = new System.Drawing.Point(35, 183);
            this.RectangleDeletePictureBox.Name = "RectangleDeletePictureBox";
            this.RectangleDeletePictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectangleDeletePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectangleDeletePictureBox.TabIndex = 31;
            this.RectangleDeletePictureBox.TabStop = false;
            this.RectangleDeletePictureBox.Click += new System.EventHandler(this.RectangleDeletePictureBox_Click);
            // 
            // RectangleAddPictureBox
            // 
            this.RectangleAddPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RectangleAddPictureBox.Image = global::Programming.Properties.Resources.rectangle_add_24x24;
            this.RectangleAddPictureBox.Location = new System.Drawing.Point(5, 183);
            this.RectangleAddPictureBox.Name = "RectangleAddPictureBox";
            this.RectangleAddPictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectangleAddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectangleAddPictureBox.TabIndex = 30;
            this.RectangleAddPictureBox.TabStop = false;
            this.RectangleAddPictureBox.Click += new System.EventHandler(this.RectangleAddPictureBox_Click);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(760, 398);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleDeletePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleAddPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox RectanglesGroupBox;
        private Panel RectangleCanvasPanel;
        private TextBox RectangleHeightTextBox;
        private Label RectangleHeightLabel;
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
        private PictureBox RectangleDeletePictureBox;
        private PictureBox RectangleAddPictureBox;
    }
}
