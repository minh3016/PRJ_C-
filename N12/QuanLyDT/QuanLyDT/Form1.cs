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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect(); //Mở kết nối
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DMChatLieu());
            label1.Text = button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DMHang());
            label1.Text = button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DMNhanVien());
            label1.Text = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhachHang());
            label1.Text = button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HoaDonBan());
            label1.Text = button5.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TimHDBan());
            label1.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            label1.Text = "QUẢN LÝ CỬA HÀNG ĐIỆN THOẠI 24H";
        }

    }
}
