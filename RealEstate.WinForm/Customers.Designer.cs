namespace RealEstate.WinForm
{
    partial class Customers
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
            customersDataGrid = new Krypton.Toolkit.KryptonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel5 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            txtCustomerSearch = new Krypton.Toolkit.KryptonTextBox();
            btnDeleteCustomer = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            txtPhoneNumber = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            comboBoxGender = new Krypton.Toolkit.KryptonComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            addCustomerSurnameTextBox = new Krypton.Toolkit.KryptonTextBox();
            addCustomerNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            btnUpdateNote = new Krypton.Toolkit.KryptonButton();
            txtCustomerNote = new Krypton.Toolkit.KryptonRichTextBox();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            btnExportToPdf = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)customersDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).BeginInit();
            kryptonPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // customersDataGrid
            // 
            customersDataGrid.AutoGenerateKryptonColumns = false;
            customersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            customersDataGrid.BorderStyle = BorderStyle.None;
            customersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column3, Column4, Column6 });
            customersDataGrid.Dock = DockStyle.Fill;
            customersDataGrid.Location = new Point(0, 0);
            customersDataGrid.Name = "customersDataGrid";
            customersDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            customersDataGrid.RowHeadersWidth = 51;
            customersDataGrid.Size = new Size(664, 561);
            customersDataGrid.TabIndex = 0;
            customersDataGrid.SelectionChanged += customersDataGrid_SelectionChanged;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.DataPropertyName = "#";
            Column1.FillWeight = 12F;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Müşteri Id";
            Column5.HeaderText = "Müşteri Id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Visible = false;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Müşteri Adı";
            Column2.FillWeight = 41.44385F;
            Column2.HeaderText = "Müşteri Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Müşteri Soyadı";
            Column3.FillWeight = 41.44385F;
            Column3.HeaderText = "Müşteri Soyadı";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Müşterinin Cinsiyeti";
            Column4.FillWeight = 41.44385F;
            Column4.HeaderText = "Müşterinin Cinsiyeti";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Müşteri Numarası";
            Column6.FillWeight = 41.44385F;
            Column6.HeaderText = "Müşteri Numarası";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel5);
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Controls.Add(btnDeleteCustomer);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(664, 621);
            kryptonPanel1.TabIndex = 1;
            // 
            // kryptonPanel5
            // 
            kryptonPanel5.Controls.Add(customersDataGrid);
            kryptonPanel5.Dock = DockStyle.Fill;
            kryptonPanel5.Location = new Point(0, 29);
            kryptonPanel5.Name = "kryptonPanel5";
            kryptonPanel5.Size = new Size(664, 561);
            kryptonPanel5.TabIndex = 3;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Controls.Add(btnExportToPdf);
            kryptonPanel4.Controls.Add(txtCustomerSearch);
            kryptonPanel4.Dock = DockStyle.Top;
            kryptonPanel4.Location = new Point(0, 0);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(664, 29);
            kryptonPanel4.TabIndex = 2;
            // 
            // txtCustomerSearch
            // 
            txtCustomerSearch.Location = new Point(0, 0);
            txtCustomerSearch.Name = "txtCustomerSearch";
            txtCustomerSearch.Size = new Size(248, 27);
            txtCustomerSearch.TabIndex = 2;
            txtCustomerSearch.Text = "Müşteri Ara...";
            txtCustomerSearch.TextAlign = HorizontalAlignment.Center;
            txtCustomerSearch.TextChanged += kryptonTextBox1_TextChanged;
            txtCustomerSearch.Enter += txtCustomerSearch_Enter;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Dock = DockStyle.Bottom;
            btnDeleteCustomer.Location = new Point(0, 590);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(664, 31);
            btnDeleteCustomer.TabIndex = 1;
            btnDeleteCustomer.Values.DropDownArrowColor = Color.Empty;
            btnDeleteCustomer.Values.Text = "Müşteriyi Sil";
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel2.Controls.Add(kryptonLabel5);
            kryptonPanel2.Controls.Add(txtPhoneNumber);
            kryptonPanel2.Controls.Add(kryptonLabel4);
            kryptonPanel2.Controls.Add(comboBoxGender);
            kryptonPanel2.Controls.Add(kryptonButton1);
            kryptonPanel2.Controls.Add(addCustomerSurnameTextBox);
            kryptonPanel2.Controls.Add(addCustomerNameTextBox);
            kryptonPanel2.Controls.Add(kryptonLabel3);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Location = new Point(701, 3);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel2.Size = new Size(858, 153);
            kryptonPanel2.TabIndex = 2;
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Anchor = AnchorStyles.None;
            kryptonLabel5.Location = new Point(326, 104);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new Size(132, 24);
            kryptonLabel5.TabIndex = 8;
            kryptonLabel5.Values.Text = "Müşteri Cinsiyeti :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Anchor = AnchorStyles.None;
            txtPhoneNumber.Location = new Point(464, 49);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(144, 27);
            txtPhoneNumber.TabIndex = 4;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Anchor = AnchorStyles.None;
            kryptonLabel4.Location = new Point(318, 51);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(140, 24);
            kryptonLabel4.TabIndex = 7;
            kryptonLabel4.Values.Text = "Müşteri Numarası :";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.None;
            comboBoxGender.DropDownWidth = 112;
            comboBoxGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxGender.Location = new Point(464, 102);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(144, 26);
            comboBoxGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxGender.TabIndex = 6;
            comboBoxGender.Text = "Gender";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(674, 100);
            kryptonButton1.Name = "kryptonButton1";
            kryptonButton1.Size = new Size(112, 31);
            kryptonButton1.TabIndex = 5;
            kryptonButton1.Values.DropDownArrowColor = Color.Empty;
            kryptonButton1.Values.Text = "Ekle";
            kryptonButton1.Click += kryptonButton1_Click;
            // 
            // addCustomerSurnameTextBox
            // 
            addCustomerSurnameTextBox.Anchor = AnchorStyles.None;
            addCustomerSurnameTextBox.Location = new Point(134, 104);
            addCustomerSurnameTextBox.Name = "addCustomerSurnameTextBox";
            addCustomerSurnameTextBox.Size = new Size(125, 27);
            addCustomerSurnameTextBox.TabIndex = 4;
            // 
            // addCustomerNameTextBox
            // 
            addCustomerNameTextBox.Anchor = AnchorStyles.None;
            addCustomerNameTextBox.Location = new Point(134, 48);
            addCustomerNameTextBox.Name = "addCustomerNameTextBox";
            addCustomerNameTextBox.Size = new Size(125, 27);
            addCustomerNameTextBox.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(14, 107);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(120, 24);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Müşteri Soyadı :";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(36, 49);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(98, 24);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Müşteri Adı :";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            kryptonLabel1.Size = new Size(858, 26);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "YENİ MÜŞTERİ EKLE";
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonPanel3.Controls.Add(btnUpdateNote);
            kryptonPanel3.Controls.Add(txtCustomerNote);
            kryptonPanel3.Controls.Add(kryptonLabel6);
            kryptonPanel3.Location = new Point(710, 192);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new Size(849, 162);
            kryptonPanel3.TabIndex = 3;
            // 
            // btnUpdateNote
            // 
            btnUpdateNote.Location = new Point(734, 128);
            btnUpdateNote.Name = "btnUpdateNote";
            btnUpdateNote.Size = new Size(112, 31);
            btnUpdateNote.TabIndex = 3;
            btnUpdateNote.Values.DropDownArrowColor = Color.Empty;
            btnUpdateNote.Values.Text = "Notu Güncelle";
            btnUpdateNote.Click += btnUpdateNote_Click;
            // 
            // txtCustomerNote
            // 
            txtCustomerNote.Dock = DockStyle.Fill;
            txtCustomerNote.Location = new Point(0, 26);
            txtCustomerNote.Name = "txtCustomerNote";
            txtCustomerNote.Size = new Size(849, 136);
            txtCustomerNote.TabIndex = 2;
            txtCustomerNote.Text = "Notlar";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Dock = DockStyle.Top;
            kryptonLabel6.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel6.Location = new Point(0, 0);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            kryptonLabel6.Size = new Size(849, 26);
            kryptonLabel6.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel6.TabIndex = 1;
            kryptonLabel6.Values.Text = "MÜŞTERİ NOTU";
            // 
            // btnExportToPdf
            // 
            btnExportToPdf.Location = new Point(254, 0);
            btnExportToPdf.Name = "btnExportToPdf";
            btnExportToPdf.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnExportToPdf.Size = new Size(112, 29);
            btnExportToPdf.TabIndex = 3;
            btnExportToPdf.Values.DropDownArrowColor = Color.Empty;
            btnExportToPdf.Values.Text = "Pdf Çıktısı Al";
            btnExportToPdf.Click += btnExportToPdf_Click;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 621);
            Controls.Add(kryptonPanel3);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel5).EndInit();
            kryptonPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            kryptonPanel4.ResumeLayout(false);
            kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView customersDataGrid;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonTextBox addCustomerSurnameTextBox;
        private Krypton.Toolkit.KryptonTextBox addCustomerNameTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonButton btnDeleteCustomer;
        private Krypton.Toolkit.KryptonComboBox comboBoxGender;
        private Krypton.Toolkit.KryptonTextBox txtPhoneNumber;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonRichTextBox txtCustomerNote;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonButton btnUpdateNote;
        private Krypton.Toolkit.KryptonTextBox txtCustomerSearch;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private Krypton.Toolkit.KryptonButton btnExportToPdf;
    }
}