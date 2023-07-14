using BuffetManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuffetManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance { 
            get { if (instance == null) instance = new AccountDAO(); return instance; } 
            private set => instance = value; 
        }
        private AccountDAO() { }

        public bool Login(string userName, string passWord)
        {
            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[]{userName, passWord});
            return result.Rows.Count > 0;
        }

        public bool UpdateAccount(string userName, string displayName, string password, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @passWord , @newPassword", new object[] { userName, displayName, password, newPass });

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT UserName, DisplayName, Type FROM dbo.Account");
        }

        public Account GetAccountByUserName (string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Account WHERE UserName = '" + userName + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }

        public bool InsertAccount(string userName, string displayName, int Type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName , Type )VALUES (   N'{0}', N'{1}',  {2})", userName, displayName, Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string userName, string displayName, int Type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{1}', Type = {2} WHERE UserName = N'{0}'", userName, displayName, Type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string userName)
        {
            string query = string.Format("DELETE dbo.Account WHERE UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string userName)
        {
            string query = string.Format("UPDATE dbo.Account SET password = 0 WHERE UserName = N'{0}'", userName);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
