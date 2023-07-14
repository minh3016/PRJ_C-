using BuffetManagement.DAO;
using BuffetManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuffetManagement.Forms
{
    public partial class bmTables : Form
    {
        public bmTables()
        {
            InitializeComponent();

            loadTable();
            loadCategory();
            LoadComboBoxTable(cbSwitchTable);
        }
        #region Method

        void loadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";
        }

        void loadFoodListByCategoryId(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";
        }

        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.loadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.ForeColor = Color.White;
                btn.Text = item.Name + Environment.NewLine + item.Status;

                btn.Click += btn_Click;
                btn.Tag = item;

                if(item.Status == "Có người")
                {
                    btn.BackColor = Color.IndianRed;
                }             
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<DTO.Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);

            float totalPrice = 0;

            foreach (DTO.Menu item in listBillInfo)
            {
                ListViewItem lvsItem = new ListViewItem(item.FoodName.ToString());
                lvsItem.SubItems.Add(item.Count.ToString());
                lvsItem.SubItems.Add(item.Price.ToString());
                lvsItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;

                lsvBill.Items.Add(lvsItem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");

            txbTotalPrice.Text = totalPrice.ToString(); // totalPrice.toString("c", culture)

            
        }

        void LoadComboBoxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.loadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion

        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_Selected(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            loadFoodListByCategoryId(id);
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if(idBill == -1) //Chưa có bill
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIdBill(), foodID, count);
            }
            else //Có bill
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            loadTable();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;

            int idBill = BillDAO.Instance.GetUnCheckBillIdByTableId(table.ID);
            int discount = (int)nmDiscount.Value;

            double totalPrice = Convert.ToDouble(txbTotalPrice.Text.Split(',')[0]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show("Bạn có chắc muốn thanh toán hóa đơn cho bàn " + table.Name + "\n Tổng tiền sau khi thanh toán là: " + finalTotalPrice + " đ", "Thông báo!!", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount, (float)finalTotalPrice);
                    ShowBill(table.ID);
                    loadTable();
                }
            }
        }

        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsvBill.Tag as Table).ID;

            int id2 = (cbSwitchTable.SelectedItem as Table).ID;

            if (MessageBox.Show(String.Format("Bạn có thật sự muốn chuyển {0} qua {1}", (lsvBill.Tag as Table).Name, (cbSwitchTable.SelectedItem as Table).Name), "Thông báo!", MessageBoxButtons.OK) == DialogResult.OK)
            {
                TableDAO.Instance.SwitchTable(id1, id2);

                loadTable();
            }
            
        }

        #endregion


    }
}
