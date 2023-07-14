
namespace BuffetManagement
{
    partial class bmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bmLogin));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(355, 120);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Log In";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(21, 133);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 23);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Username";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Location = new System.Drawing.Point(25, 255);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.txbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbUsername.Location = new System.Drawing.Point(61, 166);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(270, 23);
            this.txbUsername.TabIndex = 1;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(21, 225);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(80, 23);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "Password";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbPassword.Location = new System.Drawing.Point(61, 258);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(270, 23);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(25, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 1);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(25, 287);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.BorderRadius = 7;
            this.btnLogin.ButtonText = "LOGIN";
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.DisabledColor = System.Drawing.Color.Transparent;
            this.btnLogin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogin.Iconimage = null;
            this.btnLogin.Iconimage_right = null;
            this.btnLogin.Iconimage_right_Selected = null;
            this.btnLogin.Iconimage_Selected = null;
            this.btnLogin.IconMarginLeft = 0;
            this.btnLogin.IconMarginRight = 0;
            this.btnLogin.IconRightVisible = true;
            this.btnLogin.IconRightZoom = 0D;
            this.btnLogin.IconVisible = true;
            this.btnLogin.IconZoom = 90D;
            this.btnLogin.IsTab = false;
            this.btnLogin.Location = new System.Drawing.Point(25, 344);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(72)))), ((int)(((byte)(101)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.selected = false;
            this.btnLogin.Size = new System.Drawing.Size(306, 46);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.Textcolor = System.Drawing.Color.White;
            this.btnLogin.TextFont = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Activecolor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.BorderRadius = 7;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(56)))), ((int)(((byte)(89)))));
            this.btnExit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExit.Iconimage = null;
            this.btnExit.Iconimage_right = null;
            this.btnExit.Iconimage_right_Selected = null;
            this.btnExit.Iconimage_Selected = null;
            this.btnExit.IconMarginLeft = 0;
            this.btnExit.IconMarginRight = 0;
            this.btnExit.IconRightVisible = true;
            this.btnExit.IconRightZoom = 0D;
            this.btnExit.IconVisible = true;
            this.btnExit.IconZoom = 90D;
            this.btnExit.IsTab = false;
            this.btnExit.Location = new System.Drawing.Point(25, 402);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Normalcolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnExit.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.btnExit.selected = false;
            this.btnExit.Size = new System.Drawing.Size(306, 29);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.btnExit.TextFont = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Click += new System.EventHandler(this.bunifuFlatButton2_Click_2);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Nirmala UI Semilight", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(0, 483);
            this.bunifuCustomLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(355, 44);
            this.bunifuCustomLabel5.TabIndex = 6;
            this.bunifuCustomLabel5.Text = "design by CaptainzOverkill";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(355, 527);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txbUsername);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "bmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bmLogin_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txbUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btnExit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}

