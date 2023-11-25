namespace ObjectOrientedPractices.View.Tabs
{
    partial class CartsTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            ItemsGroupBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            CartGroupBox = new GroupBox();
            TotalLabel = new Label();
            TotalTextLabel = new Label();
            DiscountsAmountLabel = new Label();
            DiscountsAmountTextLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            DiscountsLabel = new Label();
            CartListBox = new ListBox();
            ClearCartButton = new Button();
            RemoveItemButton = new Button();
            CreateOrderButton = new Button();
            AmountLabel = new Label();
            AmountTextLabel = new Label();
            CartLabel = new Label();
            CustomerLabel = new Label();
            CustomersComboBox = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            CartGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.Controls.Add(ItemsGroupBox, 0, 0);
            tableLayoutPanel1.Controls.Add(CartGroupBox, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1041, 731);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(tableLayoutPanel2);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(410, 725);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(ItemsListBox, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(404, 695);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel3.Controls.Add(AddToCartButton, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 653);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(398, 39);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Fill;
            AddToCartButton.Location = new Point(3, 3);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(126, 33);
            AddToCartButton.TabIndex = 0;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(3, 3);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(398, 644);
            ItemsListBox.TabIndex = 1;
            // 
            // CartGroupBox
            // 
            CartGroupBox.Controls.Add(TotalLabel);
            CartGroupBox.Controls.Add(TotalTextLabel);
            CartGroupBox.Controls.Add(DiscountsAmountLabel);
            CartGroupBox.Controls.Add(DiscountsAmountTextLabel);
            CartGroupBox.Controls.Add(DiscountsCheckedListBox);
            CartGroupBox.Controls.Add(DiscountsLabel);
            CartGroupBox.Controls.Add(CartListBox);
            CartGroupBox.Controls.Add(ClearCartButton);
            CartGroupBox.Controls.Add(RemoveItemButton);
            CartGroupBox.Controls.Add(CreateOrderButton);
            CartGroupBox.Controls.Add(AmountLabel);
            CartGroupBox.Controls.Add(AmountTextLabel);
            CartGroupBox.Controls.Add(CartLabel);
            CartGroupBox.Controls.Add(CustomerLabel);
            CartGroupBox.Controls.Add(CustomersComboBox);
            CartGroupBox.Dock = DockStyle.Fill;
            CartGroupBox.Location = new Point(419, 3);
            CartGroupBox.Name = "CartGroupBox";
            CartGroupBox.Size = new Size(619, 725);
            CartGroupBox.TabIndex = 1;
            CartGroupBox.TabStop = false;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(440, 681);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(164, 38);
            TotalLabel.TabIndex = 17;
            TotalLabel.Text = "0";
            TotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Location = new Point(539, 649);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(65, 25);
            TotalTextLabel.TabIndex = 16;
            TotalTextLabel.Text = "TOTAL:\r\n";
            // 
            // DiscountsAmountLabel
            // 
            DiscountsAmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountsAmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountsAmountLabel.ImageAlign = ContentAlignment.MiddleRight;
            DiscountsAmountLabel.Location = new Point(440, 505);
            DiscountsAmountLabel.Name = "DiscountsAmountLabel";
            DiscountsAmountLabel.Size = new Size(164, 38);
            DiscountsAmountLabel.TabIndex = 15;
            DiscountsAmountLabel.Text = "0";
            DiscountsAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // DiscountsAmountTextLabel
            // 
            DiscountsAmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DiscountsAmountTextLabel.AutoSize = true;
            DiscountsAmountTextLabel.Location = new Point(440, 468);
            DiscountsAmountTextLabel.Name = "DiscountsAmountTextLabel";
            DiscountsAmountTextLabel.Size = new Size(164, 25);
            DiscountsAmountTextLabel.TabIndex = 14;
            DiscountsAmountTextLabel.Text = "Discounts Amount:\r\n";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(13, 468);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(421, 172);
            DiscountsCheckedListBox.TabIndex = 13;
            DiscountsCheckedListBox.ItemCheck += DiscountsCheckedListBox_ItemCheck;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountsLabel.Location = new Point(13, 440);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(100, 25);
            DiscountsLabel.TabIndex = 12;
            DiscountsLabel.Text = "Discounts:";
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.IntegralHeight = false;
            CartListBox.ItemHeight = 25;
            CartListBox.Location = new Point(13, 111);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(591, 194);
            CartListBox.TabIndex = 11;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearCartButton.Location = new Point(483, 403);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(130, 34);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveItemButton.Location = new Point(347, 403);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(130, 34);
            RemoveItemButton.TabIndex = 9;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateOrderButton.Location = new Point(13, 403);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(130, 34);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.Location = new Point(440, 343);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(164, 38);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Location = new Point(523, 308);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(81, 25);
            AmountTextLabel.TabIndex = 5;
            AmountTextLabel.Text = "Amount:\r\n";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(13, 83);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(48, 25);
            CartLabel.TabIndex = 2;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(13, 46);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(93, 25);
            CustomerLabel.TabIndex = 1;
            CustomerLabel.Text = "Customer:";
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(112, 43);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(492, 33);
            CustomersComboBox.TabIndex = 0;
            CustomersComboBox.SelectedIndexChanged += CustomersComboBox_SelectedIndexChanged;
            CustomersComboBox.KeyPress += CustomersComboBox_KeyPress;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CartsTab";
            Size = new Size(1041, 731);
            tableLayoutPanel1.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            CartGroupBox.ResumeLayout(false);
            CartGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox ItemsGroupBox;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddToCartButton;
        private GroupBox CartGroupBox;
        private ComboBox CustomersComboBox;
        private Label CartLabel;
        private Label CustomerLabel;
        private Label AmountTextLabel;
        private Button CreateOrderButton;
        private Label AmountLabel;
        private ListBox ItemsListBox;
        private Button ClearCartButton;
        private Button RemoveItemButton;
        private ListBox CartListBox;
        private Label TotalLabel;
        private Label TotalTextLabel;
        private Label DiscountsAmountLabel;
        private Label DiscountsAmountTextLabel;
        private CheckedListBox DiscountsCheckedListBox;
        private Label DiscountsLabel;
    }
}
