﻿namespace ObjectOrientedPractices.View.Tabs
{
    partial class ItemsTab
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
            ControlTableLayoutPanel = new TableLayoutPanel();
            SelectedItemGroupBox = new GroupBox();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            ApplyButton = new Button();
            InfoTextBox = new TextBox();
            InfoLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            ItemsTableLayoutPanel = new TableLayoutPanel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            AddListButton = new Button();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsGroupBox = new GroupBox();
            OrderByComboBox = new ComboBox();
            OrderByLabel = new Label();
            FindTextBox = new TextBox();
            FindLabel = new Label();
            ItemsListBox = new ListBox();
            ControlTableLayoutPanel.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            ItemsTableLayoutPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ControlTableLayoutPanel
            // 
            ControlTableLayoutPanel.ColumnCount = 2;
            ControlTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ControlTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            ControlTableLayoutPanel.Controls.Add(SelectedItemGroupBox, 1, 0);
            ControlTableLayoutPanel.Controls.Add(ItemsTableLayoutPanel, 0, 0);
            ControlTableLayoutPanel.Dock = DockStyle.Fill;
            ControlTableLayoutPanel.Location = new Point(0, 0);
            ControlTableLayoutPanel.Name = "ControlTableLayoutPanel";
            ControlTableLayoutPanel.RowCount = 1;
            ControlTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ControlTableLayoutPanel.Size = new Size(1079, 777);
            ControlTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemGroupBox.Controls.Add(CategoryLabel);
            SelectedItemGroupBox.Controls.Add(ApplyButton);
            SelectedItemGroupBox.Controls.Add(InfoTextBox);
            SelectedItemGroupBox.Controls.Add(InfoLabel);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IdTextBox);
            SelectedItemGroupBox.Controls.Add(CostLabel);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Dock = DockStyle.Fill;
            SelectedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedItemGroupBox.Location = new Point(434, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(642, 771);
            SelectedItemGroupBox.TabIndex = 2;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(100, 120);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(182, 33);
            CategoryComboBox.TabIndex = 11;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            CategoryComboBox.KeyPress += CategoryComboBox_KeyPress;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CategoryLabel.Location = new Point(6, 128);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(88, 25);
            CategoryLabel.TabIndex = 9;
            CategoryLabel.Text = "Category:";
            // 
            // ApplyButton
            // 
            ApplyButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ApplyButton.Location = new Point(7, 699);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(133, 43);
            ApplyButton.TabIndex = 8;
            ApplyButton.Text = "Apply";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // InfoTextBox
            // 
            InfoTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            InfoTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InfoTextBox.Location = new Point(8, 374);
            InfoTextBox.Margin = new Padding(4, 5, 4, 5);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(622, 317);
            InfoTextBox.TabIndex = 7;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.Location = new Point(7, 344);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(106, 25);
            InfoLabel.TabIndex = 6;
            InfoLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(8, 199);
            NameTextBox.Margin = new Padding(4, 5, 4, 5);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(622, 131);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(7, 169);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 25);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostTextBox.Location = new Point(100, 81);
            CostTextBox.Margin = new Padding(4, 5, 4, 5);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(182, 31);
            CostTextBox.TabIndex = 3;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(100, 40);
            IdTextBox.Margin = new Padding(4, 5, 4, 5);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(182, 31);
            IdTextBox.TabIndex = 2;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostLabel.Location = new Point(6, 89);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(52, 25);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(6, 48);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(34, 25);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // ItemsTableLayoutPanel
            // 
            ItemsTableLayoutPanel.ColumnCount = 1;
            ItemsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.Controls.Add(ButtonsTableLayoutPanel, 0, 1);
            ItemsTableLayoutPanel.Controls.Add(ItemsGroupBox, 0, 0);
            ItemsTableLayoutPanel.Dock = DockStyle.Fill;
            ItemsTableLayoutPanel.Location = new Point(3, 3);
            ItemsTableLayoutPanel.Name = "ItemsTableLayoutPanel";
            ItemsTableLayoutPanel.RowCount = 2;
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ItemsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            ItemsTableLayoutPanel.Size = new Size(425, 771);
            ItemsTableLayoutPanel.TabIndex = 0;
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
            ButtonsTableLayoutPanel.Location = new Point(3, 719);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(419, 49);
            ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // AddListButton
            // 
            AddListButton.Dock = DockStyle.Fill;
            AddListButton.Location = new Point(142, 3);
            AddListButton.Name = "AddListButton";
            AddListButton.Size = new Size(133, 43);
            AddListButton.TabIndex = 2;
            AddListButton.Text = "Add List";
            AddListButton.UseVisualStyleBackColor = true;
            AddListButton.Click += AddListButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Dock = DockStyle.Fill;
            RemoveButton.Location = new Point(281, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(135, 43);
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
            AddButton.Size = new Size(133, 43);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(OrderByComboBox);
            ItemsGroupBox.Controls.Add(OrderByLabel);
            ItemsGroupBox.Controls.Add(FindTextBox);
            ItemsGroupBox.Controls.Add(FindLabel);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(419, 710);
            ItemsGroupBox.TabIndex = 1;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // OrderByComboBox
            // 
            OrderByComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderByComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrderByComboBox.FormattingEnabled = true;
            OrderByComboBox.Location = new Point(96, 671);
            OrderByComboBox.Name = "OrderByComboBox";
            OrderByComboBox.Size = new Size(317, 33);
            OrderByComboBox.TabIndex = 4;
            OrderByComboBox.SelectedIndexChanged += OrederByComboBox_SelectedIndexChanged;
            // 
            // OrderByLabel
            // 
            OrderByLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OrderByLabel.AutoSize = true;
            OrderByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            OrderByLabel.Location = new Point(3, 674);
            OrderByLabel.Name = "OrderByLabel";
            OrderByLabel.Size = new Size(87, 25);
            OrderByLabel.TabIndex = 3;
            OrderByLabel.Text = "Order by:";
            // 
            // FindTextBox
            // 
            FindTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FindTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FindTextBox.Location = new Point(59, 42);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(354, 31);
            FindTextBox.TabIndex = 2;
            FindTextBox.TextChanged += FindTextBox_TextChanged;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FindLabel.Location = new Point(3, 45);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(50, 25);
            FindLabel.TabIndex = 1;
            FindLabel.Text = "Find:";
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.IntegralHeight = false;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(3, 78);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(413, 587);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            ItemsListBox.Leave += ItemsListBox_Leave;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ControlTableLayoutPanel);
            Name = "ItemsTab";
            Size = new Size(1079, 777);
            ControlTableLayoutPanel.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ItemsTableLayoutPanel.ResumeLayout(false);
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ControlTableLayoutPanel;
        private TableLayoutPanel ItemsTableLayoutPanel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private GroupBox SelectedItemGroupBox;
        private GroupBox ItemsGroupBox;
        private Label CostLabel;
        private Label IdLabel;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private TextBox NameTextBox;
        private Label NameLabel;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private TextBox InfoTextBox;
        private Label InfoLabel;
        private Button ApplyButton;
        private Button AddListButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Label FindLabel;
        private TextBox FindTextBox;
        private Label OrderByLabel;
        private ComboBox OrderByComboBox;
    }
}
