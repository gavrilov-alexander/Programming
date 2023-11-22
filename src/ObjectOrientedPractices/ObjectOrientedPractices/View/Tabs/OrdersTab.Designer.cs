namespace ObjectOrientedPractices.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedOrderGroupBox = new GroupBox();
            PriorityOptionsGroupBox = new GroupBox();
            DeliveryTimeComboBox = new ComboBox();
            DeliveryTimeLabel = new Label();
            AmountLabel = new Label();
            AmountTextLabel = new Label();
            ItemsListBox = new ListBox();
            ItemsLabel = new Label();
            AddressControl1 = new Controls.AddressControl();
            StatusComboBox = new ComboBox();
            StatusLabel = new Label();
            DataTextBox = new TextBox();
            CreationDataLabel = new Label();
            IdTextBox = new TextBox();
            IDLabel = new Label();
            OrdersDataGridView = new DataGridView();
            orderBindingSource = new BindingSource(components);
            Id = new DataGridViewTextBoxColumn();
            StatusToString = new DataGridViewTextBoxColumn();
            dateCreationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CustomerFullNameToString = new DataGridViewTextBoxColumn();
            AddressToString = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            totalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            TotalLabel = new Label();
            TotalTextLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SelectedOrderGroupBox.SuspendLayout();
            PriorityOptionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(SelectedOrderGroupBox, 1, 0);
            tableLayoutPanel1.Controls.Add(OrdersDataGridView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1400, 824);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(TotalLabel);
            SelectedOrderGroupBox.Controls.Add(TotalTextLabel);
            SelectedOrderGroupBox.Controls.Add(PriorityOptionsGroupBox);
            SelectedOrderGroupBox.Controls.Add(AmountLabel);
            SelectedOrderGroupBox.Controls.Add(AmountTextLabel);
            SelectedOrderGroupBox.Controls.Add(ItemsListBox);
            SelectedOrderGroupBox.Controls.Add(ItemsLabel);
            SelectedOrderGroupBox.Controls.Add(AddressControl1);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(DataTextBox);
            SelectedOrderGroupBox.Controls.Add(CreationDataLabel);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(IDLabel);
            SelectedOrderGroupBox.Dock = DockStyle.Fill;
            SelectedOrderGroupBox.Location = new Point(703, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(694, 818);
            SelectedOrderGroupBox.TabIndex = 0;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // PriorityOptionsGroupBox
            // 
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeComboBox);
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsGroupBox.Location = new Point(266, 0);
            PriorityOptionsGroupBox.Name = "PriorityOptionsGroupBox";
            PriorityOptionsGroupBox.Size = new Size(289, 91);
            PriorityOptionsGroupBox.TabIndex = 12;
            PriorityOptionsGroupBox.TabStop = false;
            PriorityOptionsGroupBox.Text = "Priority Options";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(134, 33);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(149, 33);
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
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.Location = new Point(400, 777);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(121, 38);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "4 999,90";
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountTextLabel.AutoSize = true;
            AmountTextLabel.Location = new Point(440, 741);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(81, 25);
            AmountTextLabel.TabIndex = 9;
            AmountTextLabel.Text = "Amount:\r\n";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(6, 381);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(682, 354);
            ItemsListBox.TabIndex = 8;
            ItemsListBox.KeyPress += ItemsListBox_KeyPress;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Location = new Point(6, 353);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(107, 25);
            ItemsLabel.TabIndex = 7;
            ItemsLabel.Text = "Order Items";
            // 
            // AddressControl1
            // 
            AddressControl1.Address = null;
            AddressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl1.Enabled = false;
            AddressControl1.Location = new Point(6, 152);
            AddressControl1.Name = "AddressControl1";
            AddressControl1.Size = new Size(682, 179);
            AddressControl1.TabIndex = 6;
            AddressControl1.KeyPress += AddressControl1_KeyPress;
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
            StatusLabel.Location = new Point(6, 116);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(64, 25);
            StatusLabel.TabIndex = 4;
            StatusLabel.Text = "Status:";
            // 
            // DataTextBox
            // 
            DataTextBox.Location = new Point(89, 76);
            DataTextBox.Name = "DataTextBox";
            DataTextBox.Size = new Size(171, 31);
            DataTextBox.TabIndex = 3;
            DataTextBox.KeyPress += DataTextBox_KeyPress;
            // 
            // CreationDataLabel
            // 
            CreationDataLabel.AutoSize = true;
            CreationDataLabel.Location = new Point(6, 79);
            CreationDataLabel.Name = "CreationDataLabel";
            CreationDataLabel.Size = new Size(77, 25);
            CreationDataLabel.TabIndex = 2;
            CreationDataLabel.Text = "Created:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(89, 39);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(171, 31);
            IdTextBox.TabIndex = 1;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(6, 42);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(34, 25);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID:";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeColumns = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, StatusToString, dateCreationDataGridViewTextBoxColumn, CustomerFullNameToString, AddressToString, Amount, totalDataGridViewTextBoxColumn });
            OrdersDataGridView.DataSource = orderBindingSource;
            OrdersDataGridView.Dock = DockStyle.Fill;
            OrdersDataGridView.Location = new Point(3, 3);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersWidth = 62;
            OrdersDataGridView.RowTemplate.Height = 33;
            OrdersDataGridView.Size = new Size(694, 818);
            OrdersDataGridView.TabIndex = 1;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Model.Classes.Orders.Order);
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 150;
            // 
            // StatusToString
            // 
            StatusToString.DataPropertyName = "StatusToString";
            StatusToString.HeaderText = "Order Status";
            StatusToString.MinimumWidth = 8;
            StatusToString.Name = "StatusToString";
            StatusToString.ReadOnly = true;
            StatusToString.Width = 150;
            // 
            // dateCreationDataGridViewTextBoxColumn
            // 
            dateCreationDataGridViewTextBoxColumn.DataPropertyName = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.HeaderText = "DateCreation";
            dateCreationDataGridViewTextBoxColumn.MinimumWidth = 8;
            dateCreationDataGridViewTextBoxColumn.Name = "dateCreationDataGridViewTextBoxColumn";
            dateCreationDataGridViewTextBoxColumn.ReadOnly = true;
            dateCreationDataGridViewTextBoxColumn.Width = 150;
            // 
            // CustomerFullNameToString
            // 
            CustomerFullNameToString.DataPropertyName = "CustomerFullNameToString";
            CustomerFullNameToString.HeaderText = "Customer Full Name";
            CustomerFullNameToString.MinimumWidth = 8;
            CustomerFullNameToString.Name = "CustomerFullNameToString";
            CustomerFullNameToString.ReadOnly = true;
            CustomerFullNameToString.Width = 300;
            // 
            // AddressToString
            // 
            AddressToString.DataPropertyName = "AddressToString";
            AddressToString.HeaderText = "Address";
            AddressToString.MinimumWidth = 8;
            AddressToString.Name = "AddressToString";
            AddressToString.ReadOnly = true;
            AddressToString.Width = 450;
            // 
            // Amount
            // 
            Amount.DataPropertyName = "Amount";
            Amount.HeaderText = "Amount";
            Amount.MinimumWidth = 8;
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            totalDataGridViewTextBoxColumn.HeaderText = "Total";
            totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            totalDataGridViewTextBoxColumn.ReadOnly = true;
            totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // TotalLabel
            // 
            TotalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            TotalLabel.Location = new Point(567, 777);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(121, 38);
            TotalLabel.TabIndex = 14;
            TotalLabel.Text = "4 999,90";
            // 
            // TotalTextLabel
            // 
            TotalTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalTextLabel.AutoSize = true;
            TotalTextLabel.Location = new Point(607, 741);
            TotalTextLabel.Name = "TotalTextLabel";
            TotalTextLabel.Size = new Size(81, 25);
            TotalTextLabel.TabIndex = 13;
            TotalTextLabel.Text = "Amount:\r\n";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(1400, 824);
            tableLayoutPanel1.ResumeLayout(false);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            PriorityOptionsGroupBox.ResumeLayout(false);
            PriorityOptionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SelectedOrderGroupBox;
        private Controls.AddressControl AddressControl1;
        private ComboBox StatusComboBox;
        private Label StatusLabel;
        private TextBox DataTextBox;
        private Label CreationDataLabel;
        private TextBox IdTextBox;
        private Label IDLabel;
        private Label AmountLabel;
        private Label AmountTextLabel;
        private ListBox ItemsListBox;
        private Label ItemsLabel;
        private DataGridView OrdersDataGridView;
        private DataGridViewTextBoxColumn orderStatusToStringDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private GroupBox PriorityOptionsGroupBox;
        private ComboBox DeliveryTimeComboBox;
        private Label DeliveryTimeLabel;
        private BindingSource orderBindingSource;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn StatusToString;
        private DataGridViewTextBoxColumn dateCreationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CustomerFullNameToString;
        private DataGridViewTextBoxColumn AddressToString;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private Label TotalLabel;
        private Label TotalTextLabel;
    }
}
