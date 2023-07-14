
namespace BuffetManagement.Forms
{
    partial class bmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.nmProductFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.panel13 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cbProductsCategory = new System.Windows.Forms.ComboBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txbProductsFoodName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txbProductsFoodID = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnProductsSearch = new System.Windows.Forms.Button();
            this.txbProductsSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dvgProducts = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProductsShow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductsChange = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductsDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductsAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductFoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 693);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.Controls.Add(this.panel12);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(567, 89);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(309, 592);
            this.panel5.TabIndex = 0;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.nmProductFoodPrice);
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.bunifuCustomLabel4);
            this.panel12.Controls.Add(this.pictureBox4);
            this.panel12.Location = new System.Drawing.Point(3, 270);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(303, 83);
            this.panel12.TabIndex = 9;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // nmProductFoodPrice
            // 
            this.nmProductFoodPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.nmProductFoodPrice.Location = new System.Drawing.Point(48, 38);
            this.nmProductFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nmProductFoodPrice.Name = "nmProductFoodPrice";
            this.nmProductFoodPrice.Size = new System.Drawing.Size(244, 27);
            this.nmProductFoodPrice.TabIndex = 10;
            this.nmProductFoodPrice.ValueChanged += new System.EventHandler(this.nmProductFoodPrice_ValueChanged);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.LightGray;
            this.panel13.Location = new System.Drawing.Point(12, 71);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(281, 2);
            this.panel13.TabIndex = 8;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(8, 7);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(100, 23);
            this.bunifuCustomLabel4.TabIndex = 7;
            this.bunifuCustomLabel4.Text = "Food price: ";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.bunifuCustomLabel4_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 37);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 27);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cbProductsCategory);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.bunifuCustomLabel3);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Location = new System.Drawing.Point(3, 181);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(303, 83);
            this.panel10.TabIndex = 9;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // cbProductsCategory
            // 
            this.cbProductsCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbProductsCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.cbProductsCategory.FormattingEnabled = true;
            this.cbProductsCategory.Location = new System.Drawing.Point(48, 37);
            this.cbProductsCategory.Name = "cbProductsCategory";
            this.cbProductsCategory.Size = new System.Drawing.Size(244, 28);
            this.cbProductsCategory.TabIndex = 9;
            this.cbProductsCategory.SelectedIndexChanged += new System.EventHandler(this.cbProductsCategory_SelectedIndexChanged);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.LightGray;
            this.panel11.Location = new System.Drawing.Point(12, 71);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(281, 2);
            this.panel11.TabIndex = 8;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(8, 7);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(85, 23);
            this.bunifuCustomLabel3.TabIndex = 7;
            this.bunifuCustomLabel3.Text = "Category:";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 27);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.txbProductsFoodName);
            this.panel8.Controls.Add(this.bunifuCustomLabel1);
            this.panel8.Controls.Add(this.pictureBox2);
            this.panel8.Location = new System.Drawing.Point(3, 92);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(303, 83);
            this.panel8.TabIndex = 9;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.LightGray;
            this.panel9.Location = new System.Drawing.Point(12, 71);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(281, 2);
            this.panel9.TabIndex = 8;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // txbProductsFoodName
            // 
            this.txbProductsFoodName.BackColor = System.Drawing.SystemColors.Window;
            this.txbProductsFoodName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProductsFoodName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbProductsFoodName.Location = new System.Drawing.Point(48, 41);
            this.txbProductsFoodName.Name = "txbProductsFoodName";
            this.txbProductsFoodName.Size = new System.Drawing.Size(244, 23);
            this.txbProductsFoodName.TabIndex = 5;
            this.txbProductsFoodName.TextChanged += new System.EventHandler(this.txbProductsFoodName_TextChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(8, 7);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(106, 23);
            this.bunifuCustomLabel1.TabIndex = 7;
            this.bunifuCustomLabel1.Text = "Food name: ";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.txbProductsFoodID);
            this.panel6.Controls.Add(this.bunifuCustomLabel2);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(303, 83);
            this.panel6.TabIndex = 0;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.LightGray;
            this.panel7.Location = new System.Drawing.Point(12, 71);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(281, 2);
            this.panel7.TabIndex = 8;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txbProductsFoodID
            // 
            this.txbProductsFoodID.BackColor = System.Drawing.SystemColors.Window;
            this.txbProductsFoodID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbProductsFoodID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txbProductsFoodID.Location = new System.Drawing.Point(48, 41);
            this.txbProductsFoodID.Name = "txbProductsFoodID";
            this.txbProductsFoodID.ReadOnly = true;
            this.txbProductsFoodID.Size = new System.Drawing.Size(244, 23);
            this.txbProductsFoodID.TabIndex = 5;
            this.txbProductsFoodID.TextChanged += new System.EventHandler(this.txbProductsFoodID_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 7);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel2.TabIndex = 7;
            this.bunifuCustomLabel2.Text = "Food ID: ";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 27);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnProductsSearch);
            this.panel4.Controls.Add(this.txbProductsSearch);
            this.panel4.Location = new System.Drawing.Point(567, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 71);
            this.panel4.TabIndex = 0;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btnProductsSearch
            // 
            this.btnProductsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProductsSearch.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsSearch.ForeColor = System.Drawing.Color.White;
            this.btnProductsSearch.Location = new System.Drawing.Point(231, 22);
            this.btnProductsSearch.Name = "btnProductsSearch";
            this.btnProductsSearch.Size = new System.Drawing.Size(75, 28);
            this.btnProductsSearch.TabIndex = 1;
            this.btnProductsSearch.Text = "Search";
            this.btnProductsSearch.UseVisualStyleBackColor = true;
            this.btnProductsSearch.Click += new System.EventHandler(this.btnProductsSearch_Click);
            // 
            // txbProductsSearch
            // 
            this.txbProductsSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txbProductsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProductsSearch.Location = new System.Drawing.Point(3, 22);
            this.txbProductsSearch.Name = "txbProductsSearch";
            this.txbProductsSearch.Size = new System.Drawing.Size(222, 28);
            this.txbProductsSearch.TabIndex = 0;
            this.txbProductsSearch.TextChanged += new System.EventHandler(this.txbProductsSearch_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.dvgProducts);
            this.panel3.Location = new System.Drawing.Point(12, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 592);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dvgProducts
            // 
            this.dvgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dvgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgProducts.Location = new System.Drawing.Point(3, 3);
            this.dvgProducts.Name = "dvgProducts";
            this.dvgProducts.RowHeadersWidth = 51;
            this.dvgProducts.RowTemplate.Height = 24;
            this.dvgProducts.Size = new System.Drawing.Size(543, 586);
            this.dvgProducts.TabIndex = 0;
            this.dvgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnProductsShow);
            this.panel2.Controls.Add(this.btnProductsChange);
            this.panel2.Controls.Add(this.btnProductsDelete);
            this.panel2.Controls.Add(this.btnProductsAdd);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(549, 71);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnProductsShow
            // 
            this.btnProductsShow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.btnProductsShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.btnProductsShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductsShow.BorderRadius = 0;
            this.btnProductsShow.ButtonText = " Show";
            this.btnProductsShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductsShow.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductsShow.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsShow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductsShow.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductsShow.Iconimage")));
            this.btnProductsShow.Iconimage_right = null;
            this.btnProductsShow.Iconimage_right_Selected = null;
            this.btnProductsShow.Iconimage_Selected = null;
            this.btnProductsShow.IconMarginLeft = 0;
            this.btnProductsShow.IconMarginRight = 0;
            this.btnProductsShow.IconRightVisible = true;
            this.btnProductsShow.IconRightZoom = 0D;
            this.btnProductsShow.IconVisible = true;
            this.btnProductsShow.IconZoom = 60D;
            this.btnProductsShow.IsTab = true;
            this.btnProductsShow.Location = new System.Drawing.Point(409, 6);
            this.btnProductsShow.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProductsShow.Name = "btnProductsShow";
            this.btnProductsShow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.btnProductsShow.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(122)))), ((int)(((byte)(162)))));
            this.btnProductsShow.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnProductsShow.selected = true;
            this.btnProductsShow.Size = new System.Drawing.Size(133, 59);
            this.btnProductsShow.TabIndex = 6;
            this.btnProductsShow.Text = " Show";
            this.btnProductsShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsShow.Textcolor = System.Drawing.Color.White;
            this.btnProductsShow.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductsShow.Click += new System.EventHandler(this.btnProductsView_Click);
            // 
            // btnProductsChange
            // 
            this.btnProductsChange.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnProductsChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnProductsChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductsChange.BorderRadius = 0;
            this.btnProductsChange.ButtonText = " Change";
            this.btnProductsChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductsChange.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductsChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsChange.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductsChange.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductsChange.Iconimage")));
            this.btnProductsChange.Iconimage_right = null;
            this.btnProductsChange.Iconimage_right_Selected = null;
            this.btnProductsChange.Iconimage_Selected = null;
            this.btnProductsChange.IconMarginLeft = 0;
            this.btnProductsChange.IconMarginRight = 0;
            this.btnProductsChange.IconRightVisible = true;
            this.btnProductsChange.IconRightZoom = 0D;
            this.btnProductsChange.IconVisible = true;
            this.btnProductsChange.IconZoom = 60D;
            this.btnProductsChange.IsTab = true;
            this.btnProductsChange.Location = new System.Drawing.Point(275, 6);
            this.btnProductsChange.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProductsChange.Name = "btnProductsChange";
            this.btnProductsChange.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnProductsChange.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(57)))), ((int)(((byte)(248)))));
            this.btnProductsChange.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnProductsChange.selected = true;
            this.btnProductsChange.Size = new System.Drawing.Size(133, 59);
            this.btnProductsChange.TabIndex = 5;
            this.btnProductsChange.Text = " Change";
            this.btnProductsChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsChange.Textcolor = System.Drawing.Color.White;
            this.btnProductsChange.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductsChange.Click += new System.EventHandler(this.btnProductsChange_Click);
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.btnProductsDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.btnProductsDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductsDelete.BorderRadius = 0;
            this.btnProductsDelete.ButtonText = " Delete";
            this.btnProductsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductsDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductsDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductsDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductsDelete.Iconimage")));
            this.btnProductsDelete.Iconimage_right = null;
            this.btnProductsDelete.Iconimage_right_Selected = null;
            this.btnProductsDelete.Iconimage_Selected = null;
            this.btnProductsDelete.IconMarginLeft = 0;
            this.btnProductsDelete.IconMarginRight = 0;
            this.btnProductsDelete.IconRightVisible = true;
            this.btnProductsDelete.IconRightZoom = 0D;
            this.btnProductsDelete.IconVisible = true;
            this.btnProductsDelete.IconZoom = 60D;
            this.btnProductsDelete.IsTab = true;
            this.btnProductsDelete.Location = new System.Drawing.Point(140, 6);
            this.btnProductsDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.btnProductsDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(220)))), ((int)(((byte)(234)))));
            this.btnProductsDelete.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnProductsDelete.selected = true;
            this.btnProductsDelete.Size = new System.Drawing.Size(133, 59);
            this.btnProductsDelete.TabIndex = 4;
            this.btnProductsDelete.Text = " Delete";
            this.btnProductsDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsDelete.Textcolor = System.Drawing.Color.White;
            this.btnProductsDelete.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnProductsAdd
            // 
            this.btnProductsAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnProductsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnProductsAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductsAdd.BorderRadius = 0;
            this.btnProductsAdd.ButtonText = " Add";
            this.btnProductsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductsAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductsAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductsAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductsAdd.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductsAdd.Iconimage")));
            this.btnProductsAdd.Iconimage_right = null;
            this.btnProductsAdd.Iconimage_right_Selected = null;
            this.btnProductsAdd.Iconimage_Selected = null;
            this.btnProductsAdd.IconMarginLeft = 0;
            this.btnProductsAdd.IconMarginRight = 0;
            this.btnProductsAdd.IconRightVisible = true;
            this.btnProductsAdd.IconRightZoom = 0D;
            this.btnProductsAdd.IconVisible = true;
            this.btnProductsAdd.IconZoom = 60D;
            this.btnProductsAdd.IsTab = true;
            this.btnProductsAdd.Location = new System.Drawing.Point(5, 6);
            this.btnProductsAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnProductsAdd.Name = "btnProductsAdd";
            this.btnProductsAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnProductsAdd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.btnProductsAdd.OnHoverTextColor = System.Drawing.Color.Silver;
            this.btnProductsAdd.selected = true;
            this.btnProductsAdd.Size = new System.Drawing.Size(133, 59);
            this.btnProductsAdd.TabIndex = 3;
            this.btnProductsAdd.Text = " Add";
            this.btnProductsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductsAdd.Textcolor = System.Drawing.Color.White;
            this.btnProductsAdd.TextFont = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnProductsAdd.Click += new System.EventHandler(this.btnProductsAdd_Click);
            // 
            // bmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 693);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bmProducts";
            this.Text = "bmProducts";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmProductFoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductsAdd;
        private System.Windows.Forms.TextBox txbProductsSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductsShow;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductsChange;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductsDelete;
        private System.Windows.Forms.Button btnProductsSearch;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dvgProducts;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbProductsFoodID;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbProductsFoodName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbProductsCategory;
        private System.Windows.Forms.NumericUpDown nmProductFoodPrice;
    }
}