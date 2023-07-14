using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDT
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {

        }
        Modify modify = new Modify();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if(matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TaiKhoan= '"+tentk+"'and MatKhau = '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void linkLabel2_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
    }
}
