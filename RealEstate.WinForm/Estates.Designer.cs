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
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            btnDeleteEstate = new Krypton.Toolkit.KryptonButton();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            btnSelectImage = new Krypton.Toolkit.KryptonButton();
            comboBoxCustomers = new Krypton.Toolkit.KryptonComboBox();
            btnCreateEstate = new Krypton.Toolkit.KryptonButton();
            txtPrice = new Krypton.Toolkit.KryptonTextBox();
            txtEstateName = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            estatePictureBox = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPanel6 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel7 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
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
            ((System.ComponentModel.ISupportInitialize)estatePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).BeginInit();
            kryptonPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel7).BeginInit();
            kryptonPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // estateDataGridView
            // 
            estateDataGridView.AutoGenerateKryptonColumns = false;
            estateDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            estateDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            estateDataGridView.BorderStyle = BorderStyle.None;
            estateDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            estateDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            estateDataGridView.Dock = DockStyle.Fill;
            estateDataGridView.Location = new Point(0, 0);
            estateDataGridView.Name = "estateDataGridView";
            estateDataGridView.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            estateDataGridView.RowHeadersWidth = 51;
            estateDataGridView.Size = new Size(443, 708);
            estateDataGridView.TabIndex = 0;
            estateDataGridView.SelectionChanged += estateDataGridView_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Emlak Adı";
            Column1.HeaderText = "Emlak Adı";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Fiyat";
            Column2.HeaderText = "Fiyat";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Müşteri Adı";
            Column3.HeaderText = "Müşteri Adı";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Durum";
            Column4.HeaderText = "Durum";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Emlak Id";
            Column5.HeaderText = "Emlak Id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Visible = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel2);
            kryptonPanel1.Controls.Add(kryptonLabel1);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(443, 733);
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
            kryptonPanel2.Size = new Size(443, 708);
            kryptonPanel2.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(btnDeleteEstate);
            kryptonPanel3.Dock = DockStyle.Bottom;
            kryptonPanel3.Location = new Point(0, 673);
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
            kryptonPanel4.Location = new Point(460, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel4.Size = new Size(627, 313);
            kryptonPanel4.TabIndex = 2;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(btnSelectImage);
            kryptonPanel5.Controls.Add(comboBoxCustomers);
            kryptonPanel5.Controls.Add(btnCreateEstate);
            kryptonPanel5.Controls.Add(txtPrice);
            kryptonPanel5.Controls.Add(txtEstateName);
            kryptonPanel5.Controls.Add(kryptonLabel6);
            kryptonPanel5.Controls.Add(kryptonLabel4);
            kryptonPanel5.Controls.Add(kryptonLabel3);
            kryptonPanel5.Controls.Add(kryptonLabel2);
            kryptonPanel5.Dock = DockStyle.Fill;
            kryptonPanel5.Location = new Point(0, 0);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel5.Size = new Size(627, 313);
            kryptonPanel5.TabIndex = 0;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(450, 141);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(129, 31);
            btnSelectImage.TabIndex = 10;
            btnSelectImage.Values.DropDownArrowColor = Color.Empty;
            btnSelectImage.Values.Text = "Resim Ekle";
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.DropDownWidth = 129;
            comboBoxCustomers.Location = new Point(450, 88);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            comboBoxCustomers.Size = new Size(129, 26);
            comboBoxCustomers.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxCustomers.TabIndex = 9;
            comboBoxCustomers.Text = "Müşteri Seç";
            // 
            // btnCreateEstate
            // 
            btnCreateEstate.Location = new Point(450, 220);
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
            kryptonLabel6.Location = new Point(316, 91);
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
            kryptonLabel2.Size = new Size(627, 28);
            kryptonLabel2.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel2.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel2.TabIndex = 0;
            kryptonLabel2.Values.Text = "Yeni Varlık Ekle";
            // 
            // estatePictureBox
            // 
            estatePictureBox.Dock = DockStyle.Fill;
            estatePictureBox.Location = new Point(0, 0);
            estatePictureBox.Name = "estatePictureBox";
            estatePictureBox.Size = new Size(626, 287);
            estatePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            estatePictureBox.TabIndex = 3;
            estatePictureBox.TabStop = false;
            // 
            // kryptonPanel6
            // 
            kryptonPanel6.Controls.Add(kryptonPanel7);
            kryptonPanel6.Controls.Add(kryptonLabel5);
            kryptonPanel6.Location = new Point(460, 335);
            kryptonPanel6.Name = "kryptonPanel6";
            kryptonPanel6.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel6.Size = new Size(626, 315);
            kryptonPanel6.TabIndex = 4;
            // 
            // kryptonPanel7
            // 
            kryptonPanel7.Controls.Add(estatePictureBox);
            kryptonPanel7.Dock = DockStyle.Fill;
            kryptonPanel7.Location = new Point(0, 28);
            kryptonPanel7.Name = "kryptonPanel7";
            kryptonPanel7.Size = new Size(626, 287);
            kryptonPanel7.TabIndex = 5;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = DockStyle.Top;
            kryptonLabel5.Location = new Point(0, 0);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(626, 28);
            kryptonLabel5.StateNormal.ShortText.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kryptonLabel5.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel5.TabIndex = 4;
            kryptonLabel5.Values.Text = "Varlığımın Görseli";
            // 
            // Estates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 733);
            Controls.Add(kryptonPanel6);
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
            ((System.ComponentModel.ISupportInitialize)estatePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel6).EndInit();
            kryptonPanel6.ResumeLayout(false);
            kryptonPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel7).EndInit();
            kryptonPanel7.ResumeLayout(false);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Krypton.Toolkit.KryptonButton btnSelectImage;
        private Krypton.Toolkit.KryptonPictureBox estatePictureBox;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel7;
    }
}