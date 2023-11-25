namespace ObjectOrientedPractices.View.Tabs
{
    partial class PriorityOrdersTab
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
            SelectedOrderGroupBox = new GroupBox();
            ItemsListBox = new ListBox();
            ClearOrderButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            AmountLabel = new Label();
            AmoutTextLabel = new Label();
            PriorityOptionsGroupBox = new GroupBox();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            ItemsLabel = new Label();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            DataTextBox = new TextBox();
            CreationDataLabel = new Label();
            IdTextBox = new TextBox();
            IDLabel = new Label();
            AddressControl1 = new Controls.AddressControl();
            SelectedOrderGroupBox.SuspendLayout();
            PriorityOptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(ItemsListBox);
            SelectedOrderGroupBox.Controls.Add(ClearOrderButton);
            SelectedOrderGroupBox.Controls.Add(RemoveItemButton);
            SelectedOrderGroupBox.Controls.Add(AddItemButton);
            SelectedOrderGroupBox.Controls.Add(AmountLabel);
            SelectedOrderGroupBox.Controls.Add(AmoutTextLabel);
            SelectedOrderGroupBox.Controls.Add(PriorityOptionsGroupBox);
            SelectedOrderGroupBox.Controls.Add(ItemsLabel);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(DataTextBox);
            SelectedOrderGroupBox.Controls.Add(CreationDataLabel);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(IDLabel);
            SelectedOrderGroupBox.Controls.Add(AddressControl1);
            SelectedOrderGroupBox.Dock = DockStyle.Fill;
            SelectedOrderGroupBox.Location = new Point(0, 0);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(679, 828);
            SelectedOrderGroupBox.TabIndex = 1;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(4, 380);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(665, 304);
            ItemsListBox.TabIndex = 8;
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearOrderButton.Location = new Point(540, 782);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(130, 33);
            ClearOrderButton.TabIndex = 21;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            ClearOrderButton.Click += ClearOrderButton_Click;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(141, 782);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(130, 33);
            RemoveItemButton.TabIndex = 20;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 782);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(130, 33);
            AddItemButton.TabIndex = 19;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.Location = new Point(498, 726);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(171, 38);
            AmountLabel.TabIndex = 18;
            AmountLabel.Text = "0";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AmoutTextLabel
            // 
            AmoutTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmoutTextLabel.AutoSize = true;
            AmoutTextLabel.Location = new Point(589, 687);
            AmoutTextLabel.Name = "AmoutTextLabel";
            AmoutTextLabel.Size = new Size(81, 25);
            AmoutTextLabel.TabIndex = 17;
            AmoutTextLabel.Text = "Amount:\r\n";
            // 
            // PriorityOptionsGroupBox
            // 
            PriorityOptionsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsGroupBox.Location = new Point(266, 3);
            PriorityOptionsGroupBox.Name = "PriorityOptionsGroupBox";
            PriorityOptionsGroupBox.Size = new Size(404, 150);
            PriorityOptionsGroupBox.TabIndex = 11;
            PriorityOptionsGroupBox.TabStop = false;
            PriorityOptionsGroupBox.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(134, 33);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(171, 33);
            DeliveryTimeComboBox.TabIndex = 13;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(6, 37);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(122, 25);
            DeliveryTimeLabel.TabIndex = 12;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(4, 352);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(107, 25);
            ItemsLabel.TabIndex = 7;
            ItemsLabel.Text = "Order Items";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(89, 113);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(171, 33);
            StatusComboBox.TabIndex = 5;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(4, 115);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(89, 77);
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(171, 31);
            DataTextBox.TabIndex = 3;
            DataTextBox.KeyPress += DataTextBox_KeyPress;
            // 
            // CreationDataLabel
            // 
            CreationDataLabel.AutoSize = true;
            CreationDataLabel.Location = new Point(4, 77);
            CreationDataLabel.Name = "CreationDataLabel";
            CreationDataLabel.Size = new Size(77, 25);
            CreationDataLabel.TabIndex = 2;
            CreationDataLabel.Text = "Created:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(89, 38);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(171, 31);
            IdTextBox.TabIndex = 1;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(4, 40);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(34, 25);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // AddressControl1
            // 
            AddressControl1.Address = null;
            AddressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl1.Enabled = false;
            AddressControl1.Location = new Point(4, 157);
            AddressControl1.Margin = new Padding(1, 2, 1, 2);
            AddressControl1.Name = "AddressControl1";
            AddressControl1.Size = new Size(669, 178);
            AddressControl1.TabIndex = 6;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedOrderGroupBox);
            Name = "PriorityOrdersTab";
            Size = new Size(679, 828);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            PriorityOptionsGroupBox.ResumeLayout(false);
            PriorityOptionsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SelectedOrderGroupBox;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private Controls.AddressControl AddressControl1;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private TextBox DataTextBox;
        private Label CreationDataLabel;
        private TextBox IdTextBox;
        private Label IDLabel;
        private GroupBox PriorityOptionsGroupBox;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private Button ClearOrderButton;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private Label AmountLabel;
        private Label AmoutTextLabel;
    }
}
