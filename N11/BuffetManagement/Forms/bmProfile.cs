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

namespace BuffetManagement.Forms
{
    public partial class bmProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public bmProfile(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        void ChangeAccount(Account acc)
        {
            txbUsername.Text = LoginAccount.UserName;
            txbDisplayName.Text = LoginAccount.DisplayName;
        }

        void UpdateAccount()
        {
            string displayName = txbDisplayName.Text;
            string passWord = txbPassword.Text;
            string newPass = txbNewPass.Text;
            string retypePass = txbConfirmPass.Text;
            string userName = txbUsername.Text;

            if (!newPass.Equals(retypePass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(userName, displayName, passWord, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu!");
                }
            }
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}
