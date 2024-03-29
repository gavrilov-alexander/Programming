﻿namespace ObjectOrientedPractices.View.Tabs
{
    partial class CustomersTab
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
            CustomersListBox = new ListBox();
            ControlTableLayoutPanel = new TableLayoutPanel();
            CustomersTableLayoutPanel = new TableLayoutPanel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            AddListButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersGroupBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            SelectedCustomerGroupBox = new GroupBox();
            DiscountsGroupBox = new GroupBox();
            RemoveDiscountButton = new Button();
            AddDiscountButton = new Button();
            DiscountsListBox = new ListBox();
            PriorityCheckBox = new CheckBox();
            AddressControl1 = new Controls.AddressControl();
            ApplyButton = new Button();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            IdTextBox = new TextBox();
            IdLabel = new Label();
            toolTip1 = new ToolTip(components);
            ControlTableLayoutPanel.SuspendLayout();
            CustomersTableLayoutPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            CustomersGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            DiscountsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersListBox
            // 
            CustomersListBox.Dock = DockStyle.Fill;
            CustomersListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 25;
            CustomersListBox.Location = new Point(3, 27);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(521, 731);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.Leave += CustomersListBox_Leave;
            // 
            // ControlTableLayoutPanel
            // 
            ControlTableLayoutPanel.ColumnCount = 2;
            ControlTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ControlTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ControlTableLayoutPanel.Controls.Add(CustomersTableLayoutPanel, 0, 0);
            ControlTableLayoutPanel.Controls.Add(tableLayoutPanel1, 1, 0);
            ControlTableLayoutPanel.Dock = DockStyle.Fill;
            ControlTableLayoutPanel.Location = new Point(0, 0);
            ControlTableLayoutPanel.Name = "ControlTableLayoutPanel";
            ControlTableLayoutPanel.RowCount = 1;
            ControlTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ControlTableLayoutPanel.Size = new Size(1349, 828);
            ControlTableLayoutPanel.TabIndex = 1;
            // 
            // CustomersTableLayoutPanel
            // 
            CustomersTableLayoutPanel.ColumnCount = 1;
            CustomersTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CustomersTableLayoutPanel.Controls.Add(ButtonsTableLayoutPanel, 0, 1);
            CustomersTableLayoutPanel.Controls.Add(CustomersGroupBox, 0, 0);
            CustomersTableLayoutPanel.Dock = DockStyle.Fill;
            CustomersTableLayoutPanel.Location = new Point(3, 3);
            CustomersTableLayoutPanel.Name = "CustomersTableLayoutPanel";
            CustomersTableLayoutPanel.RowCount = 2;
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            CustomersTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            CustomersTableLayoutPanel.Size = new Size(533, 822);
            CustomersTableLayoutPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ButtonsTableLayoutPanel.Controls.Add(AddListButton, 0, 0);
            ButtonsTableLayoutPanel.Controls.Add(RemoveButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(AddButton, 0, 0);
            ButtonsTableLayoutPanel.Dock = DockStyle.Fill;
            ButtonsTableLayoutPanel.Location = new Point(3, 770);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(527, 49);
            ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // AddListButton
            // 
            AddListButton.Dock = DockStyle.Fill;
            AddListButton.Location = new Point(178, 3);
            AddListButton.Name = "AddListButton";
            AddListButton.Size = new Size(169, 43);
            AddListButton.TabIndex = 2;
            AddListButton.Text = "Add List";
            AddListButton.UseVisualStyleBackColor = true;
            AddListButton.Click += AddListButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(353, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(171, 43);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(169, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(527, 761);
            CustomersGroupBox.TabIndex = 1;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(SelectedCustomerGroupBox, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(542, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 62.6865654F));
            tableLayoutPanel1.Size = new Size(804, 822);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Controls.Add(DiscountsGroupBox);
            SelectedCustomerGroupBox.Controls.Add(PriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(AddressControl1);
            SelectedCustomerGroupBox.Controls.Add(ApplyButton);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IdTextBox);
            SelectedCustomerGroupBox.Controls.Add(IdLabel);
            SelectedCustomerGroupBox.Dock = DockStyle.Fill;
            SelectedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedCustomerGroupBox.Location = new Point(3, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(798, 816);
            SelectedCustomerGroupBox.TabIndex = 0;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // DiscountsGroupBox
            // 
            DiscountsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsGroupBox.Controls.Add(RemoveDiscountButton);
            DiscountsGroupBox.Controls.Add(AddDiscountButton);
            DiscountsGroupBox.Controls.Add(DiscountsListBox);
            DiscountsGroupBox.Location = new Point(6, 325);
            DiscountsGroupBox.Name = "DiscountsGroupBox";
            DiscountsGroupBox.Size = new Size(783, 436);
            DiscountsGroupBox.TabIndex = 12;
            DiscountsGroupBox.TabStop = false;
            DiscountsGroupBox.Text = "Discounts";
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            RemoveDiscountButton.Location = new Point(467, 79);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(147, 43);
            RemoveDiscountButton.TabIndex = 11;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddDiscountButton.Location = new Point(467, 30);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(147, 43);
            AddDiscountButton.TabIndex = 10;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.IntegralHeight = false;
            DiscountsListBox.ItemHeight = 25;
            DiscountsListBox.Location = new Point(6, 30);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(455, 158);
            DiscountsListBox.TabIndex = 0;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PriorityCheckBox.Location = new Point(107, 104);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(112, 29);
            PriorityCheckBox.TabIndex = 11;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // AddressControl1
            // 
            AddressControl1.Address = null;
            AddressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddressControl1.Location = new Point(-3, 139);
            AddressControl1.Name = "AddressControl1";
            AddressControl1.Size = new Size(792, 180);
            AddressControl1.TabIndex = 10;
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ApplyButton.Location = new Point(6, 767);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(147, 43);
            ApplyButton.TabIndex = 9;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTextBox.Location = new Point(107, 67);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(685, 31);
            FullNameTextBox.TabIndex = 3;
            toolTip1.SetToolTip(FullNameTextBox, "Не более 200 символов");
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameLabel.Location = new Point(6, 70);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(95, 25);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(107, 30);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(150, 31);
            IdTextBox.TabIndex = 1;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(6, 33);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(34, 25);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ControlTableLayoutPanel);
            Name = "CustomersTab";
            Size = new Size(1349, 828);
            ControlTableLayoutPanel.ResumeLayout(false);
            CustomersTableLayoutPanel.ResumeLayout(false);
            ButtonsTableLayoutPanel.ResumeLayout(false);
            CustomersGroupBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            DiscountsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox CustomersListBox;
        private TableLayoutPanel ControlTableLayoutPanel;
        private TableLayoutPanel CustomersTableLayoutPanel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private Button RemoveButton;
        private Button AddButton;
        private GroupBox CustomersGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox SelectedCustomerGroupBox;
        private TextBox IdTextBox;
        private Label IdLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private Button AddListButton;
        private Button ApplyButton;
        private Controls.AddressControl AddressControl1;
        private ToolTip toolTip1;
        private CheckBox PriorityCheckBox;
        private GroupBox DiscountsGroupBox;
        private ListBox DiscountsListBox;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
    }
}
