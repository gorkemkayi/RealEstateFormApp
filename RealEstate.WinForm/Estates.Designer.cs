namespace RealEstate.WinForm
{
    partial class Estates
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
            estateDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            btnDeleteEstate = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            comboBoxCustomers = new Krypton.Toolkit.KryptonComboBox();
            btnCreateEstate = new Krypton.Toolkit.KryptonButton();
            txtPrice = new Krypton.Toolkit.KryptonTextBox();
            txtEstateName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)estateDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxCustomers).BeginInit();
            SuspendLayout();
            // 
            // estateDataGridView
            // 
            estateDataGridView.AutoGenerateKryptonColumns = false;
            estateDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            estateDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            estateDataGridView.BorderStyle = BorderStyle.None;
            estateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estateDataGridView.Dock = DockStyle.Fill;
            estateDataGridView.Location = new Point(0, 0);
            estateDataGridView.Name = "estateDataGridView";
            estateDataGridView.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            estateDataGridView.RowHeadersWidth = 51;
            estateDataGridView.Size = new Size(443, 637);
            estateDataGridView.TabIndex = 0;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(443, 662);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPanel3);
            kryptonPanel2.Controls.Add(estateDataGridView);
            kryptonPanel2.Dock = DockStyle.Fill;
            kryptonPanel2.Location = new Point(0, 25);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel2.Size = new Size(443, 637);
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(btnDeleteEstate);
            kryptonPanel3.Dock = DockStyle.Bottom;
            kryptonPanel3.Location = new Point(0, 602);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(443, 35);
            kryptonPanel3.TabIndex = 2;
            // 
            // btnDeleteEstate
            // 
            btnDeleteEstate.Dock = DockStyle.Bottom;
            btnDeleteEstate.Location = new Point(0, 0);
            btnDeleteEstate.Name = "btnDeleteEstate";
            btnDeleteEstate.Size = new Size(443, 35);
            btnDeleteEstate.TabIndex = 0;
            btnDeleteEstate.Values.DropDownArrowColor = Color.Empty;
            btnDeleteEstate.Values.Text = "Sil";
            btnDeleteEstate.Click += btnDeleteEstate_Click;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(443, 25);
            kryptonLabel1.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel1.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Varlık Listesi";
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(kryptonPanel5);
            kryptonPanel4.Dock = DockStyle.Fill;
            kryptonPanel4.Location = new Point(443, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007SilverLightMode;
            kryptonPanel4.Size = new Size(913, 662);
            kryptonPanel4.TabIndex = 2;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(comboBoxCustomers);
            kryptonPanel5.Controls.Add(btnCreateEstate);
            kryptonPanel5.Controls.Add(txtPrice);
            kryptonPanel5.Controls.Add(txtEstateName);
            kryptonPanel5.Controls.Add(kryptonLabel6);
            kryptonPanel5.Controls.Add(kryptonLabel4);
            kryptonPanel5.Controls.Add(kryptonLabel3);
            kryptonPanel5.Controls.Add(kryptonLabel2);
            kryptonPanel5.Dock = DockStyle.Top;
            kryptonPanel5.Location = new Point(0, 0);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel5.Size = new Size(913, 225);
            kryptonPanel5.TabIndex = 0;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.DropDownWidth = 129;
            comboBoxCustomers.Location = new Point(498, 88);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            comboBoxCustomers.Size = new Size(129, 26);
            comboBoxCustomers.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxCustomers.TabIndex = 9;
            comboBoxCustomers.Text = "Müşteri Seç";
            // 
            // btnCreateEstate
            // 
            btnCreateEstate.Location = new Point(498, 151);
            btnCreateEstate.Name = "btnCreateEstate";
            btnCreateEstate.Size = new Size(129, 31);
            btnCreateEstate.TabIndex = 8;
            btnCreateEstate.Values.DropDownArrowColor = Color.Empty;
            btnCreateEstate.Values.Text = "Ekle";
            btnCreateEstate.Click += btnCreateEstate_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(149, 155);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 6;
            // 
            // txtEstateName
            // 
            txtEstateName.Location = new Point(149, 88);
            txtEstateName.Name = "txtEstateName";
            txtEstateName.Size = new Size(125, 27);
            txtEstateName.TabIndex = 5;
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new Point(364, 91);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new Size(113, 24);
            kryptonLabel6.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel6.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.TabIndex = 4;
            kryptonLabel6.Values.Text = "Müşteri Adı :";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(66, 158);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(66, 24);
            kryptonLabel4.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel4.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel4.TabIndex = 2;
            kryptonLabel4.Values.Text = "Fiyat  :";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(33, 88);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(99, 24);
            kryptonLabel3.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel3.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel3.TabIndex = 1;
            kryptonLabel3.Values.Text = "Varlık Adı :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Dock = DockStyle.Top;
            kryptonLabel2.Location = new Point(0, 0);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(913, 28);
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel2.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 0;
            kryptonLabel2.Values.Text = "Yeni Varlık Ekle";
            // 
            // Estates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 662);
            Controls.Add(kryptonPanel4);
            Controls.Add(kryptonPanel1);
            Name = "Estates";
            Text = "Estates";
            Load += Estates_Load;
            ((System.ComponentModel.ISupportInitialize)estateDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            kryptonPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView estateDataGridView;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton btnDeleteEstate;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox txtEstateName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btnCreateEstate;
        private Krypton.Toolkit.KryptonTextBox txtPrice;
        private Krypton.Toolkit.KryptonComboBox comboBoxCustomers;
    }
}