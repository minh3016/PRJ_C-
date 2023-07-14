
namespace BuffetManagement.Forms
{
    partial class bmOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmOverview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.dtpkToDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dtpkFromDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvRevenue = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbShowSaleResults = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnAnalyze);
            this.panel1.Controls.Add(this.dtpkToDate);
            this.panel1.Controls.Add(this.dtpkFromDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 695);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalyze.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalyze.ForeColor = System.Drawing.Color.White;
            this.btnAnalyze.Location = new System.Drawing.Point(434, 178);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(126, 31);
            this.btnAnalyze.TabIndex = 9;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtpkToDate.BorderRadius = 0;
            this.dtpkToDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.ForeColor = System.Drawing.Color.White;
            this.dtpkToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkToDate.FormatCustom = null;
            this.dtpkToDate.Location = new System.Drawing.Point(567, 178);
            this.dtpkToDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(302, 31);
            this.dtpkToDate.TabIndex = 8;
            this.dtpkToDate.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            this.dtpkToDate.onValueChanged += new System.EventHandler(this.dtpkRevenue_onValueChanged);
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.dtpkFromDate.BorderRadius = 0;
            this.dtpkFromDate.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.ForeColor = System.Drawing.Color.White;
            this.dtpkFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFromDate.FormatCustom = null;
            this.dtpkFromDate.Location = new System.Drawing.Point(111, 178);
            this.dtpkFromDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(316, 31);
            this.dtpkFromDate.TabIndex = 7;
            this.dtpkFromDate.Value = new System.DateTime(2022, 2, 25, 0, 0, 0, 0);
            this.dtpkFromDate.onValueChanged += new System.EventHandler(this.dtgvRevenue_onValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 6;
            this.label6.Text = "Revenue ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.dgvRevenue);
            this.panel6.Location = new System.Drawing.Point(12, 216);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1065, 464);
            this.panel6.TabIndex = 5;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // dgvRevenue
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvRevenue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRevenue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevenue.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRevenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRevenue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRevenue.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRevenue.DoubleBuffered = true;
            this.dgvRevenue.EnableHeadersVisualStyles = false;
            this.dgvRevenue.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvRevenue.HeaderForeColor = System.Drawing.Color.White;
            this.dgvRevenue.Location = new System.Drawing.Point(3, 3);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.ReadOnly = true;
            this.dgvRevenue.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRevenue.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvRevenue.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.Size = new System.Drawing.Size(1059, 458);
            this.dgvRevenue.TabIndex = 0;
            this.dgvRevenue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRevenue_CellContentClick);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 154);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1064, 26);
            this.bunifuSeparator1.TabIndex = 4;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Today\'s sales results";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(297, 99);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txbShowSaleResults);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(13, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 74);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "5 Receipts";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txbShowSaleResults
            // 
            this.txbShowSaleResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(124)))), ((int)(((byte)(255)))));
            this.txbShowSaleResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbShowSaleResults.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbShowSaleResults.ForeColor = System.Drawing.Color.White;
            this.txbShowSaleResults.Location = new System.Drawing.Point(79, 25);
            this.txbShowSaleResults.Multiline = true;
            this.txbShowSaleResults.Name = "txbShowSaleResults";
            this.txbShowSaleResults.ReadOnly = true;
            this.txbShowSaleResults.Size = new System.Drawing.Size(176, 26);
            this.txbShowSaleResults.TabIndex = 4;
            this.txbShowSaleResults.Text = "VND 12.000.000";
            this.txbShowSaleResults.TextChanged += new System.EventHandler(this.txbShowSaleResults_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semilight", 8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sales";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bmOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 695);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bmOverview";
            this.Text = "bmOverview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbShowSaleResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkFromDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvRevenue;
        private Bunifu.Framework.UI.BunifuDatepicker dtpkToDate;
        private System.Windows.Forms.Button btnAnalyze;
    }
}