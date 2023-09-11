namespace Programming.View
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Enums = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WeekdayParsingControl = new Programming.View.Panels.WeekdayParsingControl();
            this.SeasonsControl = new Programming.View.Panels.SeasonsControl();
            this.AllEnumerationsControl = new Programming.View.Panels.AllEnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RectanglesControl = new Programming.View.Panels.RectanglesControl();
            this.MoviesColntrol = new Programming.View.Panels.MoviesColntrol();
            this.RectangleTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.Panels.RectanglesCollisionControl();
            this.TabControl.SuspendLayout();
            this.Enums.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.RectangleTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Enums);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectangleTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1106, 720);
            this.TabControl.TabIndex = 0;
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.tableLayoutPanel1);
            this.Enums.Location = new System.Drawing.Point(4, 34);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(1098, 682);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AllEnumerationsControl, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.73196F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.26804F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1092, 676);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.WeekdayParsingControl, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SeasonsControl, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 393);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1086, 280);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeekdayParsingControl.Location = new System.Drawing.Point(4, 5);
            this.WeekdayParsingControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(535, 270);
            this.WeekdayParsingControl.TabIndex = 2;
            // 
            // SeasonsControl
            // 
            this.SeasonsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonsControl.Location = new System.Drawing.Point(547, 5);
            this.SeasonsControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SeasonsControl.Name = "SeasonsControl";
            this.SeasonsControl.Size = new System.Drawing.Size(535, 270);
            this.SeasonsControl.TabIndex = 3;
            // 
            // AllEnumerationsControl
            // 
            this.AllEnumerationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllEnumerationsControl.Location = new System.Drawing.Point(3, 3);
            this.AllEnumerationsControl.Name = "AllEnumerationsControl";
            this.AllEnumerationsControl.Size = new System.Drawing.Size(1086, 384);
            this.AllEnumerationsControl.TabIndex = 1;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.tableLayoutPanel3);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 34);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(1098, 682);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RectanglesControl, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.MoviesColntrol, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1092, 676);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // RectanglesControl
            // 
            this.RectanglesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesControl.Location = new System.Drawing.Point(4, 5);
            this.RectanglesControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectanglesControl.Name = "RectanglesControl";
            this.RectanglesControl.Size = new System.Drawing.Size(538, 666);
            this.RectanglesControl.TabIndex = 2;
            // 
            // MoviesColntrol
            // 
            this.MoviesColntrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesColntrol.Location = new System.Drawing.Point(550, 5);
            this.MoviesColntrol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MoviesColntrol.Name = "MoviesColntrol";
            this.MoviesColntrol.Size = new System.Drawing.Size(538, 666);
            this.MoviesColntrol.TabIndex = 3;
            // 
            // RectangleTabPage
            // 
            this.RectangleTabPage.AutoScroll = true;
            this.RectangleTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectangleTabPage.Location = new System.Drawing.Point(4, 34);
            this.RectangleTabPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleTabPage.Name = "RectangleTabPage";
            this.RectangleTabPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectangleTabPage.Size = new System.Drawing.Size(1098, 682);
            this.RectangleTabPage.TabIndex = 2;
            this.RectangleTabPage.Text = "Rectangles";
            this.RectangleTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(4, 5);
            this.RectanglesCollisionControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(1090, 672);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 720);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabControl.ResumeLayout(false);
            this.Enums.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.RectangleTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabControl;
        private TabPage Enums;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage ClassesTabPage;
        private TableLayoutPanel tableLayoutPanel3;
        private TabPage RectangleTabPage;
        private Panels.WeekdayParsingControl WeekdayParsingControl;
        private Panels.SeasonsControl SeasonsControl;
        private Panels.AllEnumerationsControl AllEnumerationsControl;
        private Panels.RectanglesControl RectanglesControl;
        private Panels.MoviesColntrol MoviesColntrol;
        private Panels.RectanglesCollisionControl RectanglesCollisionControl;
    }
}