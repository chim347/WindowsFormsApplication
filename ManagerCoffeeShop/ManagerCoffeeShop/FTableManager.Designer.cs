namespace ManagerCoffeeShop
{
    partial class FTableManager
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
            if (disposing && (components != null)) {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invidualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btSwitchTable = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.btDiscount = new System.Windows.Forms.Button();
            this.btCheckout = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btAddFood = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.floPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.accountInformationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(985, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // accountInformationToolStripMenuItem
            // 
            this.accountInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invidualToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountInformationToolStripMenuItem.Name = "accountInformationToolStripMenuItem";
            this.accountInformationToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.accountInformationToolStripMenuItem.Text = "Account Information";
            // 
            // invidualToolStripMenuItem
            // 
            this.invidualToolStripMenuItem.Name = "invidualToolStripMenuItem";
            this.invidualToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.invidualToolStripMenuItem.Text = "Individual Information";
            this.invidualToolStripMenuItem.Click += new System.EventHandler(this.invidualToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Location = new System.Drawing.Point(493, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(479, 419);
            this.panel2.TabIndex = 2;
            // 
            // lstBill
            // 
            this.lstBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(3, 3);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(473, 413);
            this.lstBill.TabIndex = 4;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            this.lstBill.View = System.Windows.Forms.View.Details;
            this.lstBill.Click += new System.EventHandler(this.lstBill_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Food Name";
            this.columnHeader1.Width = 131;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Total Price";
            this.columnHeader4.Width = 83;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.cbSwitchTable);
            this.panel3.Controls.Add(this.btSwitchTable);
            this.panel3.Controls.Add(this.numDiscount);
            this.panel3.Controls.Add(this.btDiscount);
            this.panel3.Controls.Add(this.btCheckout);
            this.panel3.Location = new System.Drawing.Point(493, 554);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 81);
            this.panel3.TabIndex = 3;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 50);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(111, 28);
            this.cbSwitchTable.TabIndex = 7;
            // 
            // btSwitchTable
            // 
            this.btSwitchTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSwitchTable.Location = new System.Drawing.Point(3, 3);
            this.btSwitchTable.Name = "btSwitchTable";
            this.btSwitchTable.Size = new System.Drawing.Size(111, 45);
            this.btSwitchTable.TabIndex = 6;
            this.btSwitchTable.Text = "ChangeTable";
            this.btSwitchTable.UseVisualStyleBackColor = false;
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(120, 50);
            this.numDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(106, 27);
            this.numDiscount.TabIndex = 5;
            this.numDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btDiscount
            // 
            this.btDiscount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDiscount.Location = new System.Drawing.Point(120, 3);
            this.btDiscount.Name = "btDiscount";
            this.btDiscount.Size = new System.Drawing.Size(106, 45);
            this.btDiscount.TabIndex = 4;
            this.btDiscount.Text = "Discount";
            this.btDiscount.UseVisualStyleBackColor = false;
            // 
            // btCheckout
            // 
            this.btCheckout.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckout.Location = new System.Drawing.Point(351, 3);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(125, 72);
            this.btCheckout.TabIndex = 3;
            this.btCheckout.Text = "Payment";
            this.btCheckout.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numFoodCount);
            this.panel4.Controls.Add(this.btAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCategory);
            this.panel4.Location = new System.Drawing.Point(493, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 92);
            this.panel4.TabIndex = 4;
            // 
            // numFoodCount
            // 
            this.numFoodCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFoodCount.Location = new System.Drawing.Point(410, 26);
            this.numFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numFoodCount.Name = "numFoodCount";
            this.numFoodCount.Size = new System.Drawing.Size(63, 27);
            this.numFoodCount.TabIndex = 3;
            this.numFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numFoodCount.ValueChanged += new System.EventHandler(this.numFoodCount_ValueChanged);
            // 
            // btAddFood
            // 
            this.btAddFood.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddFood.Location = new System.Drawing.Point(283, 3);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(125, 72);
            this.btAddFood.TabIndex = 2;
            this.btAddFood.Text = "Add Food ";
            this.btAddFood.UseVisualStyleBackColor = false;
            // 
            // cbFood
            // 
            this.cbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 47);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(274, 28);
            this.cbFood.TabIndex = 1;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 3);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(274, 28);
            this.cbCategory.TabIndex = 0;
            // 
            // floPanelTable
            // 
            this.floPanelTable.AutoScroll = true;
            this.floPanelTable.Location = new System.Drawing.Point(13, 34);
            this.floPanelTable.Name = "floPanelTable";
            this.floPanelTable.Size = new System.Drawing.Size(477, 601);
            this.floPanelTable.TabIndex = 5;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Red;
            this.txbTotalPrice.Location = new System.Drawing.Point(232, 15);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(113, 27);
            this.txbTotalPrice.TabIndex = 8;
            // 
            // FTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 642);
            this.Controls.Add(this.floPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CoffeeShop Management Software";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFoodCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invidualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown numFoodCount;
        private System.Windows.Forms.Button btAddFood;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btSwitchTable;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Button btDiscount;
        private System.Windows.Forms.Button btCheckout;
        private System.Windows.Forms.FlowLayoutPanel floPanelTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
    }
}