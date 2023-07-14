
namespace BuffetManagement.Forms
{
    partial class bmTables
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
            if (disposing && (components != null))
            {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmTables));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nmFoodCount = new System.Windows.Forms.NumericUpDown();
            this.btnFoodAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.btnSwapTable = new System.Windows.Forms.Button();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.nmDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 662);
            this.panel1.TabIndex = 3;
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(12, 12);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(475, 637);
            this.flpTable.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbFood);
            this.panel5.Controls.Add(this.cbCategory);
            this.panel5.Controls.Add(this.nmFoodCount);
            this.panel5.Controls.Add(this.btnFoodAdd);
            this.panel5.Location = new System.Drawing.Point(493, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(378, 72);
            this.panel5.TabIndex = 1;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(3, 41);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(205, 24);
            this.cbFood.TabIndex = 12;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(3, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(205, 24);
            this.cbCategory.TabIndex = 11;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_Selected);
            // 
            // nmFoodCount
            // 
            this.nmFoodCount.Location = new System.Drawing.Point(329, 24);
            this.nmFoodCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmFoodCount.Name = "nmFoodCount";
            this.nmFoodCount.Size = new System.Drawing.Size(46, 22);
            this.nmFoodCount.TabIndex = 10;
            this.nmFoodCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnFoodAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnFoodAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodAdd.BorderRadius = 0;
            this.btnFoodAdd.ButtonText = " Add";
            this.btnFoodAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnFoodAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFoodAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFoodAdd.Iconimage")));
            this.btnFoodAdd.Iconimage_right = null;
            this.btnFoodAdd.Iconimage_right_Selected = null;
            this.btnFoodAdd.Iconimage_Selected = null;
            this.btnFoodAdd.IconMarginLeft = 0;
            this.btnFoodAdd.IconMarginRight = 0;
            this.btnFoodAdd.IconRightVisible = true;
            this.btnFoodAdd.IconRightZoom = 0D;
            this.btnFoodAdd.IconVisible = true;
            this.btnFoodAdd.IconZoom = 60D;
            this.btnFoodAdd.IsTab = true;
            this.btnFoodAdd.Location = new System.Drawing.Point(216, 6);
            this.btnFoodAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnFoodAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnFoodAdd.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnFoodAdd.selected = true;
            this.btnFoodAdd.Size = new System.Drawing.Size(105, 59);
            this.btnFoodAdd.TabIndex = 7;
            this.btnFoodAdd.Text = " Add";
            this.btnFoodAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodAdd.Textcolor = System.Drawing.Color.White;
            this.btnFoodAdd.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txbTotalPrice);
            this.panel4.Controls.Add(this.cbSwitchTable);
            this.panel4.Controls.Add(this.btnSwapTable);
            this.panel4.Controls.Add(this.btnDiscount);
            this.panel4.Controls.Add(this.nmDiscount);
            this.panel4.Controls.Add(this.btnCheckout);
            this.panel4.Location = new System.Drawing.Point(493, 579);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 71);
            this.panel4.TabIndex = 0;
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.ForeColor = System.Drawing.Color.Black;
            this.txbTotalPrice.Location = new System.Drawing.Point(155, 22);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(104, 27);
            this.txbTotalPrice.TabIndex = 18;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(3, 41);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(61, 24);
            this.cbSwitchTable.TabIndex = 17;
            // 
            // btnSwapTable
            // 
            this.btnSwapTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwapTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwapTable.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwapTable.ForeColor = System.Drawing.Color.White;
            this.btnSwapTable.Location = new System.Drawing.Point(3, 6);
            this.btnSwapTable.Name = "btnSwapTable";
            this.btnSwapTable.Size = new System.Drawing.Size(61, 31);
            this.btnSwapTable.TabIndex = 16;
            this.btnSwapTable.Text = "Swap";
            this.btnSwapTable.UseVisualStyleBackColor = true;
            this.btnSwapTable.Click += new System.EventHandler(this.btnSwapTable_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscount.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(70, 6);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(79, 31);
            this.btnDiscount.TabIndex = 15;
            this.btnDiscount.Text = "Discount";
            this.btnDiscount.UseVisualStyleBackColor = true;
            // 
            // nmDiscount
            // 
            this.nmDiscount.Location = new System.Drawing.Point(70, 43);
            this.nmDiscount.Name = "nmDiscount";
            this.nmDiscount.Size = new System.Drawing.Size(79, 22);
            this.nmDiscount.TabIndex = 13;
            this.nmDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Activecolor = System.Drawing.Color.HotPink;
            this.btnCheckout.BackColor = System.Drawing.Color.HotPink;
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.BorderRadius = 0;
            this.btnCheckout.ButtonText = " Pay";
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.DisabledColor = System.Drawing.Color.Gray;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCheckout.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.Iconimage")));
            this.btnCheckout.Iconimage_right = null;
            this.btnCheckout.Iconimage_right_Selected = null;
            this.btnCheckout.Iconimage_Selected = null;
            this.btnCheckout.IconMarginLeft = 0;
            this.btnCheckout.IconMarginRight = 0;
            this.btnCheckout.IconRightVisible = true;
            this.btnCheckout.IconRightZoom = 0D;
            this.btnCheckout.IconVisible = true;
            this.btnCheckout.IconZoom = 70D;
            this.btnCheckout.IsTab = true;
            this.btnCheckout.Location = new System.Drawing.Point(267, 6);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Normalcolor = System.Drawing.Color.HotPink;
            this.btnCheckout.OnHovercolor = System.Drawing.Color.HotPink;
            this.btnCheckout.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnCheckout.selected = true;
            this.btnCheckout.Size = new System.Drawing.Size(106, 59);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = " Pay";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.Textcolor = System.Drawing.Color.White;
            this.btnCheckout.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lsvBill);
            this.panel3.Location = new System.Drawing.Point(493, 86);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 487);
            this.panel3.TabIndex = 1;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(3, 4);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(372, 480);
            this.lsvBill.TabIndex = 0;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 65;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 83;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 87;
            // 
            // bmTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 662);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bmTables";
            this.Text = "bmSetting";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmFoodCount)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDiscount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nmFoodCount;
        private Bunifu.Framework.UI.BunifuFlatButton btnFoodAdd;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnCheckout;
        private System.Windows.Forms.NumericUpDown nmDiscount;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.Button btnSwapTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
    }
}