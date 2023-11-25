namespace ObjectOrientedPractices.View.Tabs
{
    partial class DiscountsTab
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
            InfoTextLabel = new Label();
            CalculateButton = new Button();
            ApplyButton = new Button();
            UpdateButton = new Button();
            DiscountAmountLabel = new Label();
            DiscountAmountTextLabel = new Label();
            ProductsAmountLabel = new Label();
            ProductsAmountTextLabel = new Label();
            InfoLabel = new Label();
            PercentDiscountButton = new Button();
            PointsDiscountButton = new Button();
            SuspendLayout();
            // 
            // InfoTextLabel
            // 
            InfoTextLabel.AutoSize = true;
            InfoTextLabel.Location = new Point(3, 13);
            InfoTextLabel.Name = "InfoTextLabel";
            InfoTextLabel.Size = new Size(48, 25);
            InfoTextLabel.TabIndex = 0;
            InfoTextLabel.Text = "Info:";
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(3, 41);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 46);
            CalculateButton.TabIndex = 1;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(121, 41);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(112, 46);
            ApplyButton.TabIndex = 11;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(239, 41);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(112, 46);
            UpdateButton.TabIndex = 12;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(303, 115);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(175, 38);
            DiscountAmountLabel.TabIndex = 16;
            DiscountAmountLabel.Text = "499";
            DiscountAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DiscountAmountTextLabel
            // 
            DiscountAmountTextLabel.AutoSize = true;
            DiscountAmountTextLabel.Location = new Point(331, 90);
            DiscountAmountTextLabel.Name = "DiscountAmountTextLabel";
            DiscountAmountTextLabel.Size = new Size(156, 25);
            DiscountAmountTextLabel.TabIndex = 15;
            DiscountAmountTextLabel.Text = "Discount Amount:\r\n";
            // 
            // ProductsAmountLabel
            // 
            ProductsAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ProductsAmountLabel.Location = new Point(357, 41);
            ProductsAmountLabel.Name = "ProductsAmountLabel";
            ProductsAmountLabel.Size = new Size(121, 38);
            ProductsAmountLabel.TabIndex = 14;
            ProductsAmountLabel.Text = "4 999,90";
            ProductsAmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ProductsAmountTextLabel
            // 
            ProductsAmountTextLabel.AutoSize = true;
            ProductsAmountTextLabel.Location = new Point(331, 13);
            ProductsAmountTextLabel.Name = "ProductsAmountTextLabel";
            ProductsAmountTextLabel.Size = new Size(156, 25);
            ProductsAmountTextLabel.TabIndex = 13;
            ProductsAmountTextLabel.Text = "Products Amount:\r\n";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(57, 13);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(43, 25);
            InfoLabel.TabIndex = 17;
            InfoLabel.Text = "info";
            // 
            // PercentDiscountButton
            // 
            PercentDiscountButton.Location = new Point(493, 65);
            PercentDiscountButton.Name = "PercentDiscountButton";
            PercentDiscountButton.Size = new Size(161, 46);
            PercentDiscountButton.TabIndex = 20;
            PercentDiscountButton.Text = "PercentDiscount";
            PercentDiscountButton.UseVisualStyleBackColor = true;
            PercentDiscountButton.Click += PercentDiscountButton_Click;
            // 
            // PointsDiscountButton
            // 
            PointsDiscountButton.Location = new Point(493, 13);
            PointsDiscountButton.Name = "PointsDiscountButton";
            PointsDiscountButton.Size = new Size(161, 46);
            PointsDiscountButton.TabIndex = 21;
            PointsDiscountButton.Text = "PointsDiscount";
            PointsDiscountButton.UseVisualStyleBackColor = true;
            PointsDiscountButton.Click += PointsDiscountButton_Click;
            // 
            // DiscountsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PointsDiscountButton);
            Controls.Add(PercentDiscountButton);
            Controls.Add(InfoLabel);
            Controls.Add(DiscountAmountLabel);
            Controls.Add(DiscountAmountTextLabel);
            Controls.Add(ProductsAmountLabel);
            Controls.Add(ProductsAmountTextLabel);
            Controls.Add(UpdateButton);
            Controls.Add(ApplyButton);
            Controls.Add(CalculateButton);
            Controls.Add(InfoTextLabel);
            Name = "DiscountsTab";
            Size = new Size(657, 167);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label InfoTextLabel;
        private Button CalculateButton;
        private Button ApplyButton;
        private Button UpdateButton;
        private Label DiscountAmountLabel;
        private Label DiscountAmountTextLabel;
        private Label ProductsAmountLabel;
        private Label ProductsAmountTextLabel;
        private Label InfoLabel;
        private Button PercentDiscountButton;
        private Button PointsDiscountButton;
    }
}
