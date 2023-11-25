namespace ObjectOrientedPractices.View
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TabControl = new TabControl();
            ItemsTabPage = new TabPage();
            ItemsTab1 = new Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            CustomersTab1 = new Tabs.CustomersTab();
            CartsTabPage = new TabPage();
            CartsTab1 = new Tabs.CartsTab();
            OrdersTabPage = new TabPage();
            OrdersTab1 = new Tabs.OrdersTab();
            bindingSource1 = new BindingSource(components);
            TabControl.SuspendLayout();
            ItemsTabPage.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            CartsTabPage.SuspendLayout();
            OrdersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsTabPage);
            TabControl.Controls.Add(CustomersTabPage);
            TabControl.Controls.Add(CartsTabPage);
            TabControl.Controls.Add(OrdersTabPage);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Margin = new Padding(4, 5, 4, 5);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1143, 750);
            TabControl.TabIndex = 0;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsTab1);
            ItemsTabPage.Location = new Point(4, 34);
            ItemsTabPage.Margin = new Padding(4, 5, 4, 5);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(4, 5, 4, 5);
            ItemsTabPage.Size = new Size(1135, 712);
            ItemsTabPage.TabIndex = 0;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab1
            // 
            ItemsTab1.Dock = DockStyle.Fill;
            ItemsTab1.DisplayedItems = null;
            ItemsTab1.Location = new Point(4, 5);
            ItemsTab1.Name = "ItemsTab1";
            ItemsTab1.Size = new Size(1127, 702);
            ItemsTab1.TabIndex = 1;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(CustomersTab1);
            CustomersTabPage.Location = new Point(4, 34);
            CustomersTabPage.Margin = new Padding(4, 5, 4, 5);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(4, 5, 4, 5);
            CustomersTabPage.Size = new Size(1135, 712);
            CustomersTabPage.TabIndex = 1;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab1
            // 
            CustomersTab1.Customers = null;
            CustomersTab1.Dock = DockStyle.Fill;
            CustomersTab1.Location = new Point(4, 5);
            CustomersTab1.Name = "CustomersTab1";
            CustomersTab1.Size = new Size(1127, 702);
            CustomersTab1.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            CartsTabPage.Controls.Add(CartsTab1);
            CartsTabPage.Location = new Point(4, 34);
            CartsTabPage.Name = "CartsTabPage";
            CartsTabPage.Padding = new Padding(3);
            CartsTabPage.Size = new Size(1135, 712);
            CartsTabPage.TabIndex = 2;
            CartsTabPage.Text = "Carts";
            CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab1
            // 
            CartsTab1.Dock = DockStyle.Fill;
            CartsTab1.Location = new Point(3, 3);
            CartsTab1.Name = "CartsTab1";
            CartsTab1.Size = new Size(1129, 706);
            CartsTab1.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            OrdersTabPage.Controls.Add(OrdersTab1);
            OrdersTabPage.Location = new Point(4, 34);
            OrdersTabPage.Name = "OrdersTabPage";
            OrdersTabPage.Padding = new Padding(3);
            OrdersTabPage.Size = new Size(1135, 712);
            OrdersTabPage.TabIndex = 3;
            OrdersTabPage.Text = "Orders";
            OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab1
            // 
            OrdersTab1.Customers = null;
            OrdersTab1.Dock = DockStyle.Fill;
            OrdersTab1.Location = new Point(3, 3);
            OrdersTab1.Name = "OrdersTab1";
            OrdersTab1.Size = new Size(1129, 706);
            OrdersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Object Oriented Practices";
            TabControl.ResumeLayout(false);
            ItemsTabPage.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            CartsTabPage.ResumeLayout(false);
            OrdersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ItemsTabPage;
        private TabPage CustomersTabPage;
        private BindingSource bindingSource1;
        private Tabs.ItemsTab ItemsTab1;
        private Tabs.CustomersTab CustomersTab1;
        private TabPage CartsTabPage;
        private Tabs.CartsTab CartsTab1;
        private TabPage OrdersTabPage;
        private Tabs.OrdersTab OrdersTab1;
    }
}