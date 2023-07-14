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
    public partial class bmProducts : Form
    {
        BindingSource foodList = new BindingSource();
        public bmProducts()
        {
            InitializeComponent();
            LoadMethod();
        }

        void LoadMethod()
        {
            dvgProducts.DataSource = foodList;

            LoadListFood();
            AddFoodBinding();
            LoadCategoryIntoComboBox(cbProductsCategory);
        }

        void AddFoodBinding()
        {
            txbProductsFoodName.DataBindings.Add(new Binding("Text", dvgProducts.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txbProductsFoodID.DataBindings.Add(new Binding("Text", dvgProducts.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmProductFoodPrice.DataBindings.Add(new Binding("Value", dvgProducts.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoComboBox(ComboBox cb)
        {
            cbProductsCategory.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        private void btnProductsView_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nmProductFoodPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbProductsCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbProductsFoodName_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txbProductsFoodID_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (dvgProducts.SelectedCells.Count > 0)
                {
                    int id = (int)dvgProducts.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
                    Category category = CategoryDAO.Instance.GetCategoryById(id);
                    cbProductsCategory.SelectedItem = category;

                    int index = 0;
                    int i = 0;

                    foreach (Category item in cbProductsCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }

                    cbProductsCategory.SelectedItem = index;
                }
            }
            catch { }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductsSearch_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbProductsSearch.Text);
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);

            return listFood;
        }

        private void txbProductsSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnProductsChange_Click(object sender, EventArgs e)
        {
            string name = txbProductsFoodName.Text;
            int categoryID = (cbProductsCategory.SelectedItem as Category).ID;
            float price = (float)nmProductFoodPrice.Value;
            int idFood = Convert.ToInt32(txbProductsFoodID.Text);

            if (FoodDAO.Instance.UpdateFood(idFood, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn!");
            }
        }

        private void btnProductsDelete_Click(object sender, EventArgs e)
        {
            int idFood = Convert.ToInt32(txbProductsFoodID.Text);

            if (FoodDAO.Instance.DeleteFood(idFood))
            {
                MessageBox.Show("Xóa món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa thức ăn!");
            }
        }

        private void btnProductsAdd_Click(object sender, EventArgs e)
        {
            string name = txbProductsFoodName.Text;
            int categoryID = (cbProductsCategory.SelectedItem as Category).ID;
            float price = (float)nmProductFoodPrice.Value;

            if(FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công!");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn!");
            }
        }
    }
}
