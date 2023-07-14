using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace QuanLyDT
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)//check mật khẩu và tên tài khoản
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check Email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = txtTenTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            string xnmatkhau = txtXNMatKhau.Text;
            string email = txtEmail.Text;
            if (!checkAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường! "); return; }
            if (!checkAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường! "); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận lại mật khẩu chính xác!"); return; }
            if (!checkEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if(modify.TaiKhoans("Select * from TaiKhoan where Email= '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác!"); return; }
            try
            {
                string query = "Insert into TaiKhoan values ('" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công, bạn có muốn đăng nhập luôn không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    this.Close();
                }    
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
