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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            btnDeleteCustomer = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            comboBoxGender = new Krypton.Toolkit.KryptonComboBox();
            kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            addCustomerSurnameTextBox = new Krypton.Toolkit.KryptonTextBox();
            addCustomerNameTextBox = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            ((System.ComponentModel.ISupportInitialize)customersDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxGender).BeginInit();
            SuspendLayout();
            // 
            // customersDataGrid
            // 
            customersDataGrid.AutoGenerateKryptonColumns = false;
            customersDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            customersDataGrid.BorderStyle = BorderStyle.None;
            customersDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGrid.Columns.AddRange(new DataGridViewColumn[] { Column1, Column5, Column2, Column3, Column4 });
            customersDataGrid.Dock = DockStyle.Fill;
            customersDataGrid.Location = new Point(0, 0);
            customersDataGrid.Name = "customersDataGrid";
            customersDataGrid.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            customersDataGrid.RowHeadersWidth = 51;
            customersDataGrid.Size = new Size(629, 621);
            customersDataGrid.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "#";
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
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
            Column2.HeaderText = "Müşteri Adı";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Müşteri Soyadı";
            Column3.HeaderText = "Müşteri Soyadı";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Müşterinin Cinsiyeti";
            Column4.HeaderText = "Müşterinin Cinsiyeti";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(btnDeleteCustomer);
            kryptonPanel1.Controls.Add(customersDataGrid);
            kryptonPanel1.Dock = DockStyle.Left;
            kryptonPanel1.Location = new Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(629, 621);
            kryptonPanel1.TabIndex = 1;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Dock = DockStyle.Bottom;
            btnDeleteCustomer.Location = new Point(0, 590);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(629, 31);
            btnDeleteCustomer.TabIndex = 1;
            btnDeleteCustomer.Values.DropDownArrowColor = Color.Empty;
            btnDeleteCustomer.Values.Text = "Müşteriyi Sil";
            btnDeleteCustomer.Click += btnDeleteCustomer_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(comboBoxGender);
            kryptonPanel2.Controls.Add(kryptonButton1);
            kryptonPanel2.Controls.Add(addCustomerSurnameTextBox);
            kryptonPanel2.Controls.Add(addCustomerNameTextBox);
            kryptonPanel2.Controls.Add(kryptonLabel3);
            kryptonPanel2.Controls.Add(kryptonLabel2);
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(629, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel2.Size = new Size(942, 153);
            kryptonPanel2.TabIndex = 2;
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.None;
            comboBoxGender.DropDownWidth = 112;
            comboBoxGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxGender.Location = new Point(360, 49);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(112, 26);
            comboBoxGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            comboBoxGender.TabIndex = 6;
            comboBoxGender.Text = "Gender";
            // 
            // kryptonButton1
            // 
            kryptonButton1.Anchor = AnchorStyles.None;
            kryptonButton1.Location = new Point(360, 116);
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
            addCustomerSurnameTextBox.Location = new Point(174, 116);
            addCustomerSurnameTextBox.Name = "addCustomerSurnameTextBox";
            addCustomerSurnameTextBox.Size = new Size(125, 27);
            addCustomerSurnameTextBox.TabIndex = 4;
            // 
            // addCustomerNameTextBox
            // 
            addCustomerNameTextBox.Anchor = AnchorStyles.None;
            addCustomerNameTextBox.Location = new Point(174, 48);
            addCustomerNameTextBox.Name = "addCustomerNameTextBox";
            addCustomerNameTextBox.Size = new Size(125, 27);
            addCustomerNameTextBox.TabIndex = 3;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.None;
            kryptonLabel3.Location = new Point(55, 116);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(113, 24);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Müşteri Soyadı";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(78, 49);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(90, 24);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Müşteri Adı";
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            kryptonLabel1.Size = new Size(942, 26);
            kryptonLabel1.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "YENİ MÜŞTERİ EKLE";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 621);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "Customers";
            Text = "Customers";
            Load += Customers_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comboBoxGender).EndInit();
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}