namespace ProgrammingAppInformationSystem.View
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
            this.OrganizationListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AdressLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.AddOrganizationPictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedOrganizationGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.RemoveOrganizationPictureBox = new System.Windows.Forms.PictureBox();
            this.EditOrganizationPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddOrganizationPictureBox)).BeginInit();
            this.SelectedOrganizationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveOrganizationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrganizationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrganizationListBox
            // 
            this.OrganizationListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrganizationListBox.FormattingEnabled = true;
            this.OrganizationListBox.IntegralHeight = false;
            this.OrganizationListBox.ItemHeight = 25;
            this.OrganizationListBox.Location = new System.Drawing.Point(12, 12);
            this.OrganizationListBox.Name = "OrganizationListBox";
            this.OrganizationListBox.Size = new System.Drawing.Size(410, 525);
            this.OrganizationListBox.TabIndex = 12;
            this.OrganizationListBox.SelectedIndexChanged += new System.EventHandler(this.OrganizationListBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 55);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(528, 31);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameTextBox_KeyPress);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(6, 151);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(88, 25);
            this.CategoryLabel.TabIndex = 7;
            this.CategoryLabel.Text = "Category:";
            // 
            // AdressLabel
            // 
            this.AdressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressLabel.AutoSize = true;
            this.AdressLabel.Location = new System.Drawing.Point(6, 89);
            this.AdressLabel.Name = "AdressLabel";
            this.AdressLabel.Size = new System.Drawing.Size(73, 25);
            this.AdressLabel.TabIndex = 3;
            this.AdressLabel.Text = "Addres:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RatingTextBox.Location = new System.Drawing.Point(6, 243);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(264, 31);
            this.RatingTextBox.TabIndex = 6;
            this.RatingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RatingTextBox_KeyPress);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(6, 117);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(264, 31);
            this.AddressTextBox.TabIndex = 4;
            this.AddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressTextBox_KeyPress);
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(6, 215);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(67, 25);
            this.RatingLabel.TabIndex = 5;
            this.RatingLabel.Text = "Rating:";
            // 
            // AddOrganizationPictureBox
            // 
            this.AddOrganizationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrganizationPictureBox.Image = global::ProgrammingAppInformationSystem.Properties.Resources.organization_add_50x50;
            this.AddOrganizationPictureBox.Location = new System.Drawing.Point(428, 309);
            this.AddOrganizationPictureBox.Name = "AddOrganizationPictureBox";
            this.AddOrganizationPictureBox.Size = new System.Drawing.Size(50, 50);
            this.AddOrganizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AddOrganizationPictureBox.TabIndex = 14;
            this.AddOrganizationPictureBox.TabStop = false;
            this.AddOrganizationPictureBox.Click += new System.EventHandler(this.AddOrganizationPictureBox_Click);
            // 
            // SelectedOrganizationGroupBox
            // 
            this.SelectedOrganizationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrganizationGroupBox.Controls.Add(this.CategoryTextBox);
            this.SelectedOrganizationGroupBox.Controls.Add(this.NameLabel);
            this.SelectedOrganizationGroupBox.Controls.Add(this.NameTextBox);
            this.SelectedOrganizationGroupBox.Controls.Add(this.CategoryLabel);
            this.SelectedOrganizationGroupBox.Controls.Add(this.AdressLabel);
            this.SelectedOrganizationGroupBox.Controls.Add(this.RatingTextBox);
            this.SelectedOrganizationGroupBox.Controls.Add(this.AddressTextBox);
            this.SelectedOrganizationGroupBox.Controls.Add(this.RatingLabel);
            this.SelectedOrganizationGroupBox.Location = new System.Drawing.Point(428, 12);
            this.SelectedOrganizationGroupBox.Name = "SelectedOrganizationGroupBox";
            this.SelectedOrganizationGroupBox.Size = new System.Drawing.Size(540, 291);
            this.SelectedOrganizationGroupBox.TabIndex = 13;
            this.SelectedOrganizationGroupBox.TabStop = false;
            this.SelectedOrganizationGroupBox.Text = "Selected Organization";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(6, 179);
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(264, 31);
            this.CategoryTextBox.TabIndex = 17;
            this.CategoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CategoryTextBox_KeyPress);
            // 
            // RemoveOrganizationPictureBox
            // 
            this.RemoveOrganizationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveOrganizationPictureBox.Image = global::ProgrammingAppInformationSystem.Properties.Resources.organization_remove_50x50;
            this.RemoveOrganizationPictureBox.Location = new System.Drawing.Point(540, 309);
            this.RemoveOrganizationPictureBox.Name = "RemoveOrganizationPictureBox";
            this.RemoveOrganizationPictureBox.Size = new System.Drawing.Size(50, 50);
            this.RemoveOrganizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RemoveOrganizationPictureBox.TabIndex = 15;
            this.RemoveOrganizationPictureBox.TabStop = false;
            this.RemoveOrganizationPictureBox.Click += new System.EventHandler(this.RemoveOrganizationPictureBox_Click);
            // 
            // EditOrganizationPictureBox
            // 
            this.EditOrganizationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditOrganizationPictureBox.Image = global::ProgrammingAppInformationSystem.Properties.Resources.organization_edit_50x50;
            this.EditOrganizationPictureBox.Location = new System.Drawing.Point(484, 309);
            this.EditOrganizationPictureBox.Name = "EditOrganizationPictureBox";
            this.EditOrganizationPictureBox.Size = new System.Drawing.Size(50, 50);
            this.EditOrganizationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EditOrganizationPictureBox.TabIndex = 16;
            this.EditOrganizationPictureBox.TabStop = false;
            this.EditOrganizationPictureBox.Click += new System.EventHandler(this.EditOrganizationPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 549);
            this.Controls.Add(this.EditOrganizationPictureBox);
            this.Controls.Add(this.RemoveOrganizationPictureBox);
            this.Controls.Add(this.OrganizationListBox);
            this.Controls.Add(this.AddOrganizationPictureBox);
            this.Controls.Add(this.SelectedOrganizationGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OrganizationsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.AddOrganizationPictureBox)).EndInit();
            this.SelectedOrganizationGroupBox.ResumeLayout(false);
            this.SelectedOrganizationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveOrganizationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditOrganizationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox OrganizationListBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label CategoryLabel;
        private Label AdressLabel;
        private TextBox RatingTextBox;
        private TextBox AddressTextBox;
        private Label RatingLabel;
        private PictureBox AddOrganizationPictureBox;
        private GroupBox SelectedOrganizationGroupBox;
        private PictureBox RemoveOrganizationPictureBox;
        private PictureBox EditOrganizationPictureBox;
        private TextBox CategoryTextBox;
    }
}