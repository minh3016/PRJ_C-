using BuffetManagement.DAO;
using BuffetManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetManagement
{
    public partial class bmLogin : Form
    {
        public bmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord) == true)
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUserName(userName);
                bmInterface newForm = new bmInterface(loginAccount);
                this.Hide();
                newForm.ShowDialog();
                this.Show();
               
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo!");
            }
            
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }

        private void bunifuFlatButton2_Click_2(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void bmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Thông báo!", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
