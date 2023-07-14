
namespace BuffetManagement.Forms
{
    partial class bmReports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chrReports = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLoadReports = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrReports)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.panel1.Controls.Add(this.btnLoadReports);
            this.panel1.Controls.Add(this.chrReports);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 659);
            this.panel1.TabIndex = 4;
            // 
            // chrReports
            // 
            this.chrReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            chartArea1.Name = "ChartArea1";
            this.chrReports.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrReports.Legends.Add(legend1);
            this.chrReports.Location = new System.Drawing.Point(12, 12);
            this.chrReports.Name = "chrReports";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Food";
            this.chrReports.Series.Add(series1);
            this.chrReports.Size = new System.Drawing.Size(859, 578);
            this.chrReports.TabIndex = 0;
            this.chrReports.Text = "chart1";
            // 
            // btnLoadReports
            // 
            this.btnLoadReports.Activecolor = System.Drawing.Color.DarkMagenta;
            this.btnLoadReports.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnLoadReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadReports.BorderRadius = 7;
            this.btnLoadReports.ButtonText = "Load";
            this.btnLoadReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadReports.DisabledColor = System.Drawing.Color.Gray;
            this.btnLoadReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadReports.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLoadReports.Iconimage = null;
            this.btnLoadReports.Iconimage_right = null;
            this.btnLoadReports.Iconimage_right_Selected = null;
            this.btnLoadReports.Iconimage_Selected = null;
            this.btnLoadReports.IconMarginLeft = 0;
            this.btnLoadReports.IconMarginRight = 0;
            this.btnLoadReports.IconRightVisible = true;
            this.btnLoadReports.IconRightZoom = 0D;
            this.btnLoadReports.IconVisible = true;
            this.btnLoadReports.IconZoom = 90D;
            this.btnLoadReports.IsTab = false;
            this.btnLoadReports.Location = new System.Drawing.Point(683, 599);
            this.btnLoadReports.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLoadReports.Name = "btnLoadReports";
            this.btnLoadReports.Normalcolor = System.Drawing.Color.DarkMagenta;
            this.btnLoadReports.OnHovercolor = System.Drawing.Color.DarkMagenta;
            this.btnLoadReports.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnLoadReports.selected = false;
            this.btnLoadReports.Size = new System.Drawing.Size(186, 45);
            this.btnLoadReports.TabIndex = 2;
            this.btnLoadReports.Text = "Load";
            this.btnLoadReports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLoadReports.Textcolor = System.Drawing.Color.White;
            this.btnLoadReports.TextFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadReports.Click += new System.EventHandler(this.btnLoadReports_Click);
            // 
            // bmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 659);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "bmReports";
            this.Text = "bmReports";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrReports;
        private Bunifu.Framework.UI.BunifuFlatButton btnLoadReports;
    }
}