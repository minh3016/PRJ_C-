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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label3.Text = "";
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            if(email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng ký!"); }
            else
            {
                string query = "Select *from TaiKhoan where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label3.ForeColor = Color.Blue;
                    label3.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
