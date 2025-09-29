namespace RealEstate.WinForm
{
    partial class MainPage
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            menuStrip1 = new MenuStrip();
            emaklarımToolStripMenuItem = new ToolStripMenuItem();
            müşterilerimToolStripMenuItem = new ToolStripMenuItem();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            txtSurname = new Krypton.Toolkit.KryptonTextBox();
            txtName = new Krypton.Toolkit.KryptonTextBox();
            txtUsername = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            pieCharEstates = new System.Windows.Forms.DataVisualization.Charting.Chart();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            pieChartCustomers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            lblRentedEstateCount = new Krypton.Toolkit.KryptonLabel();
            lblActiveEstateCount = new Krypton.Toolkit.KryptonLabel();
            lblCustomerCount = new Krypton.Toolkit.KryptonLabel();
            lblEstateCount = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            lblSelledEstates = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieCharEstates).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pieChartCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(menuStrip1);
            kryptonPanel1.Dock = DockStyle.Top;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            kryptonPanel1.Size = new Size(1649, 29);
            kryptonPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Segoe UI", 9F);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { emaklarımToolStripMenuItem, müşterilerimToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1649, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // emaklarımToolStripMenuItem
            // 
            emaklarımToolStripMenuItem.Name = "emaklarımToolStripMenuItem";
            emaklarımToolStripMenuItem.Size = new Size(93, 25);
            emaklarımToolStripMenuItem.Text = "Emaklarım";
            emaklarımToolStripMenuItem.Click += emaklarımToolStripMenuItem_Click;
            // 
            // müşterilerimToolStripMenuItem
            // 
            müşterilerimToolStripMenuItem.Name = "müşterilerimToolStripMenuItem";
            müşterilerimToolStripMenuItem.Size = new Size(106, 25);
            müşterilerimToolStripMenuItem.Text = "Müşterilerim";
            müşterilerimToolStripMenuItem.Click += müşterilerimToolStripMenuItem_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(txtSurname);
            kryptonPanel2.Controls.Add(txtName);
            kryptonPanel2.Controls.Add(txtUsername);
            kryptonPanel2.Controls.Add(kryptonLabel4);
            kryptonPanel2.Controls.Add(kryptonLabel3);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Location = new Point(12, 55);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel2.Size = new Size(327, 277);
            kryptonPanel2.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(139, 137);
            txtSurname.Name = "txtSurname";
            txtSurname.ReadOnly = true;
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(139, 94);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(139, 57);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 3;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.AutoSize = false;
            kryptonLabel4.ImeMode = ImeMode.NoControl;
            kryptonLabel4.Location = new Point(40, 137);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(67, 19);
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel4.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.TabIndex = 2;
            kryptonLabel4.Values.Text = "Soyisim :";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.AutoSize = false;
            kryptonLabel3.ImeMode = ImeMode.NoControl;
            kryptonLabel3.Location = new Point(56, 94);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(58, 19);
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel3.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "İsim :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.AutoSize = false;
            kryptonLabel2.ImeMode = ImeMode.NoControl;
            kryptonLabel2.Location = new Point(3, 57);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(104, 19);
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel2.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Kullanıcı Adı :";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.ImeMode = ImeMode.NoControl;
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.TitlePanel;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel1.Size = new Size(327, 26);
            kryptonLabel1.StateNormal.ShortText.Color1 = Color.Black;
            kryptonLabel1.StateNormal.ShortText.Color2 = Color.Black;
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel1.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Bilgilerim";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel3.Controls.Add(pieCharEstates);
            kryptonPanel3.Controls.Add(kryptonLabel5);
            kryptonPanel3.Location = new Point(353, 55);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(1284, 277);
            kryptonPanel3.TabIndex = 3;
            // 
            // pieCharEstates
            // 
            chartArea1.Name = "ChartArea1";
            pieCharEstates.ChartAreas.Add(chartArea1);
            pieCharEstates.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            pieCharEstates.Legends.Add(legend1);
            pieCharEstates.Location = new Point(0, 30);
            pieCharEstates.Name = "pieCharEstates";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            pieCharEstates.Series.Add(series1);
            pieCharEstates.Size = new Size(1284, 247);
            pieCharEstates.TabIndex = 2;
            pieCharEstates.Text = "chart1";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = DockStyle.Top;
            kryptonLabel5.Location = new Point(0, 0);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel5.Size = new Size(1284, 30);
            kryptonLabel5.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel5.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 0;
            kryptonLabel5.Values.Text = "Varlık Grafiği";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel4.Controls.Add(pieChartCustomers);
            kryptonPanel4.Controls.Add(kryptonLabel6);
            kryptonPanel4.Location = new Point(353, 366);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1284, 371);
            kryptonPanel4.TabIndex = 4;
            // 
            // pieChartCustomers
            // 
            chartArea2.Name = "ChartArea1";
            pieChartCustomers.ChartAreas.Add(chartArea2);
            pieChartCustomers.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            pieChartCustomers.Legends.Add(legend2);
            pieChartCustomers.Location = new Point(0, 30);
            pieChartCustomers.Name = "pieChartCustomers";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            pieChartCustomers.Series.Add(series2);
            pieChartCustomers.Size = new Size(1284, 341);
            pieChartCustomers.TabIndex = 1;
            pieChartCustomers.Text = "chart1";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Dock = DockStyle.Top;
            kryptonLabel6.Location = new Point(0, 0);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel6.Size = new Size(1284, 30);
            kryptonLabel6.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel6.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.TabIndex = 0;
            kryptonLabel6.Values.Text = "Müşteri Grafiği";
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(lblSelledEstates);
            kryptonPanel5.Controls.Add(kryptonLabel12);
            kryptonPanel5.Controls.Add(kryptonLabel11);
            kryptonPanel5.Controls.Add(lblRentedEstateCount);
            kryptonPanel5.Controls.Add(lblActiveEstateCount);
            kryptonPanel5.Controls.Add(lblCustomerCount);
            kryptonPanel5.Controls.Add(lblEstateCount);
            kryptonPanel5.Controls.Add(kryptonLabel10);
            kryptonPanel5.Controls.Add(kryptonLabel9);
            kryptonPanel5.Controls.Add(kryptonLabel8);
            kryptonPanel5.Controls.Add(kryptonLabel7);
            kryptonPanel5.Location = new Point(15, 366);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(324, 371);
            kryptonPanel5.TabIndex = 5;
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Dock = DockStyle.Top;
            kryptonLabel11.Location = new Point(0, 0);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel11.Size = new Size(324, 26);
            kryptonLabel11.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel11.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel11.TabIndex = 8;
            kryptonLabel11.Values.Text = "Genel İstatistikler";
            // 
            // lblRentedEstateCount
            // 
            lblRentedEstateCount.Location = new Point(169, 252);
            lblRentedEstateCount.Name = "lblRentedEstateCount";
            lblRentedEstateCount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblRentedEstateCount.Size = new Size(22, 26);
            lblRentedEstateCount.StateNormal.ShortText.Color1 = Color.Red;
            lblRentedEstateCount.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRentedEstateCount.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblRentedEstateCount.TabIndex = 7;
            lblRentedEstateCount.Values.Text = "0";
            // 
            // lblActiveEstateCount
            // 
            lblActiveEstateCount.Location = new Point(169, 177);
            lblActiveEstateCount.Name = "lblActiveEstateCount";
            lblActiveEstateCount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblActiveEstateCount.Size = new Size(22, 26);
            lblActiveEstateCount.StateNormal.ShortText.Color1 = Color.Red;
            lblActiveEstateCount.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblActiveEstateCount.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblActiveEstateCount.TabIndex = 6;
            lblActiveEstateCount.Values.Text = "0";
            // 
            // lblCustomerCount
            // 
            lblCustomerCount.Location = new Point(169, 105);
            lblCustomerCount.Name = "lblCustomerCount";
            lblCustomerCount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblCustomerCount.Size = new Size(22, 26);
            lblCustomerCount.StateNormal.ShortText.Color1 = Color.Red;
            lblCustomerCount.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCustomerCount.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblCustomerCount.TabIndex = 5;
            lblCustomerCount.Values.Text = "0";
            // 
            // lblEstateCount
            // 
            lblEstateCount.Location = new Point(169, 64);
            lblEstateCount.Name = "lblEstateCount";
            lblEstateCount.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblEstateCount.Size = new Size(22, 26);
            lblEstateCount.StateNormal.ShortText.Color1 = Color.Red;
            lblEstateCount.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblEstateCount.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblEstateCount.TabIndex = 4;
            lblEstateCount.Values.Text = "0";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new Point(19, 226);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel10.Size = new Size(144, 52);
            kryptonLabel10.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel10.StateNormal.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            kryptonLabel10.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel10.TabIndex = 3;
            kryptonLabel10.Values.Text = "Kiradaki \r\nVarlık Sayım :";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new Point(19, 151);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel9.Size = new Size(144, 52);
            kryptonLabel9.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel9.StateNormal.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            kryptonLabel9.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel9.TabIndex = 2;
            kryptonLabel9.Values.Text = "İlandaki \r\nVarlık Sayım :";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new Point(3, 105);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel8.Size = new Size(160, 30);
            kryptonLabel8.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel8.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel8.TabIndex = 1;
            kryptonLabel8.Values.Text = "Müşteri Sayım :";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new Point(19, 60);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel7.Size = new Size(144, 30);
            kryptonLabel7.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel7.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel7.TabIndex = 0;
            kryptonLabel7.Values.Text = "Varlık Sayım :";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new Point(19, 304);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel12.Size = new Size(144, 52);
            kryptonLabel12.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel12.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel12.TabIndex = 9;
            kryptonLabel12.Values.Text = "Satılan\r\nVarlık Sayım :";
            // 
            // lblSelledEstates
            // 
            lblSelledEstates.Location = new Point(169, 330);
            lblSelledEstates.Name = "lblSelledEstates";
            lblSelledEstates.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            lblSelledEstates.Size = new Size(22, 26);
            lblSelledEstates.StateNormal.ShortText.Color1 = Color.Red;
            lblSelledEstates.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSelledEstates.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSelledEstates.TabIndex = 10;
            lblSelledEstates.Values.Text = "0";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1649, 816);
            Controls.Add(kryptonPanel5);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            MainMenuStrip = menuStrip1;
            Name = "MainPage";
            Text = "MainPage";
            FormClosing += MainPage_FormClosing;
            Load += MainPage_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pieCharEstates).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pieChartCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem emaklarımToolStripMenuItem;
        private ToolStripMenuItem müşterilerimToolStripMenuItem;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox txtSurname;
        private Krypton.Toolkit.KryptonTextBox txtName;
        private Krypton.Toolkit.KryptonTextBox txtUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieCharEstates;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart pieChartCustomers;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel lblEstateCount;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonLabel lblRentedEstateCount;
        private Krypton.Toolkit.KryptonLabel lblActiveEstateCount;
        private Krypton.Toolkit.KryptonLabel lblCustomerCount;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel lblSelledEstates;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
    }
}