namespace ProgrammingAppInformationSystem.View
{
    partial class AddAndEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAndEditForm));
            this.OrganizationGroupBox = new System.Windows.Forms.GroupBox();
            this.AcceptPictureBox = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.OrganizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganizationGroupBox
            // 
            this.OrganizationGroupBox.Controls.Add(this.AcceptPictureBox);
            this.OrganizationGroupBox.Controls.Add(this.NameLabel);
            this.OrganizationGroupBox.Controls.Add(this.CategoryComboBox);
            this.OrganizationGroupBox.Controls.Add(this.NameTextBox);
            this.OrganizationGroupBox.Controls.Add(this.CategoryLabel);
            this.OrganizationGroupBox.Controls.Add(this.AddressLabel);
            this.OrganizationGroupBox.Controls.Add(this.RatingTextBox);
            this.OrganizationGroupBox.Controls.Add(this.AddressTextBox);
            this.OrganizationGroupBox.Controls.Add(this.RatingLabel);
            this.OrganizationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.OrganizationGroupBox.Name = "OrganizationGroupBox";
            this.OrganizationGroupBox.Size = new System.Drawing.Size(539, 287);
            this.OrganizationGroupBox.TabIndex = 14;
            this.OrganizationGroupBox.TabStop = false;
            this.OrganizationGroupBox.Text = "Organization";
            // 
            // AcceptPictureBox
            // 
            this.AcceptPictureBox.Image = global::ProgrammingAppInformationSystem.Properties.Resources.accept_150x150;
            this.AcceptPictureBox.Location = new System.Drawing.Point(384, 135);
            this.AcceptPictureBox.Name = "AcceptPictureBox";
            this.AcceptPictureBox.Size = new System.Drawing.Size(150, 150);
            this.AcceptPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AcceptPictureBox.TabIndex = 10;
            this.AcceptPictureBox.TabStop = false;
            this.AcceptPictureBox.Click += new System.EventHandler(this.AcceptPictureBox_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(6, 177);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(264, 33);
            this.CategoryComboBox.TabIndex = 9;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            this.CategoryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryComboBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NameTextBox.Location = new System.Drawing.Point(6, 53);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(528, 31);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 149);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(88, 25);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(6, 87);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(81, 25);
            this.AddressLabel.TabIndex = 3;
            this.AddressLabel.Text = "Address:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RatingTextBox.Location = new System.Drawing.Point(6, 241);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(264, 31);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AddressTextBox.Location = new System.Drawing.Point(6, 115);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(264, 31);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(6, 213);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(67, 25);
            this.RatingLabel.TabIndex = 5;
            this.RatingLabel.Text = "Rating:";
            // 
            // AddAndEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 311);
            this.Controls.Add(this.OrganizationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAndEditForm";
            this.Text = "AddAndEditForm";
            this.OrganizationGroupBox.ResumeLayout(false);
            this.OrganizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcceptPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox OrganizationGroupBox;
        private Label NameLabel;
        private ComboBox CategoryComboBox;
        private TextBox NameTextBox;
        private Label CategoryLabel;
        private Label AddressLabel;
        private TextBox RatingTextBox;
        private TextBox AddressTextBox;
        private Label RatingLabel;
        private PictureBox AcceptPictureBox;
    }
}