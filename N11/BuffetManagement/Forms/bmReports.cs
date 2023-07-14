using BuffetManagement.DAO;
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
    public partial class bmReports : Form
    {
        BindingSource foodList = new BindingSource();

        public bmReports()
        {
            InitializeComponent();
            LoadMethod();
        }

        void LoadMethod()
        {
            LoadListFood();
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetReportFood();
        }

        private void btnLoadReports_Click(object sender, EventArgs e)
        {
            chrReports.Series["Food"].XValueMember = "Name";
            chrReports.Series["Food"].YValueMembers = "Price";
            chrReports.DataSource = FoodDAO.Instance.GetReportFood();
            chrReports.DataBind();
            LoadListFood();
        }
    }
}
