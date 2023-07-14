using BuffetManagement.DAO;
using BuffetManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetManagement.Forms
{
    public partial class bmStaff : Form
    {
        BindingSource accountList = new BindingSource();


        public bmStaff()
        {
            InitializeComponent();
            LoadMethod();
        }

        void LoadMethod()
        {
            dvgAccounts.DataSource = accountList;

            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txbStaffUsername.DataBindings.Add(new Binding("Text", dvgAccounts.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbStaffDisplayName.DataBindings.Add(new Binding("Text", dvgAccounts.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dvgAccounts.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        void ResetPassword(string username)
        {
            if (AccountDAO.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }

        private void btnStaffShow_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            string userName = txbStaffUsername.Text;
            string displayName = txbStaffDisplayName.Text;
            int type = (int)nmAccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            string userName = txbStaffUsername.Text;

            DeleteAccount(userName);
        }

        private void btnStaffChange_Click(object sender, EventArgs e)
        {
            string userName = txbStaffUsername.Text;
            string displayName = txbStaffDisplayName.Text;
            int type = (int)nmAccountType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txbStaffUsername.Text;

            ResetPassword(userName);
        }
    }
}
