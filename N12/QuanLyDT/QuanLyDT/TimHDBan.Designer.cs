
namespace QuanLyDT
{
    partial class TimHDBan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimLai = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTKHoaDon = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDon)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDong);
            this.panel1.Controls.Add(this.btnTimLai);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nháy đúp vào hóa đơn để hiện thị thông tin chi tiết";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(616, 58);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimLai
            // 
            this.btnTimLai.Location = new System.Drawing.Point(348, 58);
            this.btnTimLai.Name = "btnTimLai";
            this.btnTimLai.Size = new System.Drawing.Size(75, 23);
            this.btnTimLai.TabIndex = 5;
            this.btnTimLai.Text = "Tìm lại";
            this.btnTimLai.UseVisualStyleBackColor = true;
            this.btnTimLai.Click += new System.EventHandler(this.btnTimLai_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(103, 58);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvTKHoaDon
            // 
            this.dgvTKHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTKHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTKHoaDon.Location = new System.Drawing.Point(0, 134);
            this.dgvTKHoaDon.Name = "dgvTKHoaDon";
            this.dgvTKHoaDon.Size = new System.Drawing.Size(800, 207);
            this.dgvTKHoaDon.TabIndex = 1;
            this.dgvTKHoaDon.DoubleClick += new System.EventHandler(this.dgvTKHoaDon_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTongTien);
            this.panel2.Controls.Add(this.txtMaKhachHang);
            this.panel2.Controls.Add(this.txtNam);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.txtThang);
            this.panel2.Controls.Add(this.txtMaHoaDon);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, -11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 145);
            this.panel2.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Tổng tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Mã khách hàng";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(584, 61);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(164, 20);
            this.txtTongTien.TabIndex = 21;
            this.txtTongTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTongTien_KeyPress);
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(584, 21);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(164, 20);
            this.txtMaKhachHang.TabIndex = 20;
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(261, 61);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(57, 20);
            this.txtNam.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(226, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Năm";
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(137, 103);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(181, 20);
            this.txtMaNhanVien.TabIndex = 17;
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(137, 61);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(57, 20);
            this.txtThang.TabIndex = 16;
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Location = new System.Drawing.Point(137, 21);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(181, 20);
            this.txtMaHoaDon.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Mã hóa đơn";
            // 
            // TimHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTKHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "TimHDBan";
            this.Text = "Tìm kiếm hóa đơn bán";
            this.Load += new System.EventHandler(this.TimHDBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKHoaDon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvTKHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimLai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}