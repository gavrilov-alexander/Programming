namespace ObjectOrientedPractices.View.Tabs
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
            InfoTextBox.Location = new Point(7, 370);
            InfoTextBox.Margin = new Padding(4, 5, 4, 5);
            InfoTextBox.Multiline = true;
            InfoTextBox.Name = "InfoTextBox";
            InfoTextBox.Size = new Size(622, 321);
            InfoTextBox.TabIndex = 7;
            InfoTextBox.TextChanged += InfoTextBox_TextChanged;
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            InfoLabel.Location = new Point(6, 340);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(106, 25);
            InfoLabel.TabIndex = 6;
            InfoLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NameTextBox.Location = new Point(7, 195);
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
            NameLabel.Location = new Point(6, 165);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(63, 25);
            NameLabel.TabIndex = 4;
            NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            CostTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostTextBox.Location = new Point(67, 102);
            CostTextBox.Margin = new Padding(4, 5, 4, 5);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(141, 31);
            CostTextBox.TabIndex = 3;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            IdTextBox.Location = new Point(67, 43);
            IdTextBox.Margin = new Padding(4, 5, 4, 5);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(141, 31);
            IdTextBox.TabIndex = 2;
            IdTextBox.KeyPress += IdTextBox_KeyPress;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CostLabel.Location = new Point(6, 107);
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
            // ItemsListBox
            // 
            ItemsListBox.Dock = DockStyle.Fill;
            ItemsListBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 25;
            ItemsListBox.Location = new Point(3, 27);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(413, 680);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
    }
}
