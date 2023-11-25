namespace ObjectOrientedPractices.View.Forms
{
    partial class AddDiscountForm
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
            PercentDiscountLabel = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            CancelButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PercentDiscountLabel.Location = new Point(12, 28);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(161, 25);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(106, 69);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(287, 33);
            CategoryComboBox.TabIndex = 1;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 72);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(88, 25);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category:";
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CancelButton.Location = new Point(246, 140);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(147, 43);
            CancelButton.TabIndex = 11;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OkButton.Location = new Point(93, 140);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(147, 43);
            OkButton.TabIndex = 12;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 195);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryComboBox);
            Controls.Add(PercentDiscountLabel);
            MaximumSize = new Size(427, 251);
            MinimumSize = new Size(427, 251);
            Name = "AddDiscountForm";
            Text = "AddDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Button CancelButton;
        private Button OkButton;
    }
}