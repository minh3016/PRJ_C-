using BuffetManagement.DAO;
using BuffetManagement.DTO;
using BuffetManagement.Forms;
using System;
using System.Data;
using System.Windows.Forms;

namespace BuffetManagement
{
    public partial class bmInterface : Form
    {

        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public bmInterface(Account acc)
        {
            InitializeComponent();

            this.loginAccount = acc;

            ChangeAccount(acc.Type);

            OpenOverview(new Forms.bmOverview());

        }

        private Form activeForm;
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        public void OpenOverview(Form childForm)
        {
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        #region method

        void ChangeAccount(int type)
        {
            btnStaff.Enabled = type == 1;
            btnProducts.Enabled = type == 1;
            btnReports.Enabled = type == 1;
            btnCategory.Enabled = type == 1;
            btnTableManagement.Enabled = type == 1;

            txbShowUsername.Text = loginAccount.DisplayName;
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/            OpenChildForm(new Forms.bmOverview(), sender);

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.bmTables(), sender);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /*void MoveIndicator(Control control)
        {
            indicator.Top = control.Top;
            indicator.Height = control.Height;
        }*/

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/            OpenChildForm(new Forms.bmProducts(), sender);
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/            OpenChildForm(new Forms.bmCategory(), sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/            OpenChildForm(new Forms.bmReports(), sender);
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/            OpenChildForm(new Forms.bmStaff(), sender);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.bmTableManagement(), sender);
        }

        private void indicator_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
/*            MoveIndicator((Control)sender);
*/        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất khỏi tài khoản này không?", "Thông báo!", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            bmProfile bm = new bmProfile(loginAccount);
            OpenChildForm(new Forms.bmProfile(loginAccount), sender);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        
    }
}
