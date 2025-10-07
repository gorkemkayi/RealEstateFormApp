namespace RealEstate.WinForm
{
    partial class MyVoiceNotes
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
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            txtPath = new Krypton.Toolkit.KryptonTextBox();
            btnStopRecord = new Krypton.Toolkit.KryptonButton();
            btnStartRecord = new Krypton.Toolkit.KryptonButton();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            dataGridViewVoice = new Krypton.Toolkit.KryptonDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoice).BeginInit();
            SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(txtPath);
            kryptonPanel1.Controls.Add(btnStopRecord);
            kryptonPanel1.Controls.Add(btnStartRecord);
            kryptonPanel1.Location = new Point(12, 12);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonPanel1.Size = new Size(393, 165);
            kryptonPanel1.TabIndex = 0;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(10, 65);
            txtPath.Multiline = true;
            txtPath.Name = "txtPath";
            txtPath.ReadOnly = true;
            txtPath.ScrollBars = ScrollBars.Vertical;
            txtPath.Size = new Size(371, 77);
            txtPath.TabIndex = 2;
            txtPath.Text = "Dosya Yolu";
            // 
            // btnStopRecord
            // 
            btnStopRecord.Location = new Point(269, 13);
            btnStopRecord.Name = "btnStopRecord";
            btnStopRecord.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnStopRecord.Size = new Size(112, 31);
            btnStopRecord.TabIndex = 1;
            btnStopRecord.Values.DropDownArrowColor = Color.Empty;
            btnStopRecord.Values.Text = "Kaydı Durdur";
            btnStopRecord.Click += btnStopRecord_Click;
            // 
            // btnStartRecord
            // 
            btnStartRecord.Location = new Point(10, 13);
            btnStartRecord.Name = "btnStartRecord";
            btnStartRecord.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnStartRecord.Size = new Size(112, 31);
            btnStartRecord.TabIndex = 0;
            btnStartRecord.Values.DropDownArrowColor = Color.Empty;
            btnStartRecord.Values.Text = "Kaydı Başlat";
            btnStartRecord.Click += btnStartRecord_Click;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(dataGridViewVoice);
            kryptonPanel2.Controls.Add(kryptonLabel1);
            kryptonPanel2.Location = new Point(430, 12);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(358, 426);
            kryptonPanel2.TabIndex = 1;
            // 
            // dataGridViewVoice
            // 
            dataGridViewVoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVoice.BorderStyle = BorderStyle.None;
            dataGridViewVoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVoice.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridViewVoice.Dock = DockStyle.Fill;
            dataGridViewVoice.Location = new Point(0, 26);
            dataGridViewVoice.Name = "dataGridViewVoice";
            dataGridViewVoice.RowHeadersWidth = 51;
            dataGridViewVoice.Size = new Size(358, 400);
            dataGridViewVoice.TabIndex = 1;
            dataGridViewVoice.CellDoubleClick += dataGridViewVoice_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "#";
            Column1.FillWeight = 53.4759369F;
            Column1.HeaderText = "#";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Kayıt";
            Column2.FillWeight = 146.524063F;
            Column2.HeaderText = "Kayıt";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel1.Size = new Size(358, 26);
            kryptonLabel1.StateNormal.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Sesli Notlarım";
            // 
            // MyVoiceNotes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kryptonPanel2);
            Controls.Add(kryptonPanel1);
            Name = "MyVoiceNotes";
            Text = "MyVoiceNotes";
            Load += MyVoiceNotes_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVoice).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnStopRecord;
        private Krypton.Toolkit.KryptonButton btnStartRecord;
        private Krypton.Toolkit.KryptonTextBox txtPath;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonDataGridView dataGridViewVoice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}