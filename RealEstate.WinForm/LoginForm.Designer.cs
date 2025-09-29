namespace RealEstate.WinForm
{
    partial class LoginForm
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
            components = new System.ComponentModel.Container();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            textBoxUsername = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            btnLogin = new Krypton.Toolkit.KryptonButton();
            textBoxPassword = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            btnRegister = new Krypton.Toolkit.KryptonButton();
            kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).BeginInit();
            SuspendLayout();
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(kryptonPictureBox1);
            kryptonPanel2.Dock = DockStyle.Top;
            kryptonPanel2.Location = new Point(0, 0);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new Size(1193, 125);
            kryptonPanel2.TabIndex = 9;
            // 
            // kryptonPictureBox1
            // 
            kryptonPictureBox1.Dock = DockStyle.Fill;
            kryptonPictureBox1.Image = Properties.Resources.login;
            kryptonPictureBox1.Location = new Point(0, 0);
            kryptonPictureBox1.Margin = new Padding(0);
            kryptonPictureBox1.Name = "kryptonPictureBox1";
            kryptonPictureBox1.Size = new Size(1193, 125);
            kryptonPictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            kryptonPictureBox1.TabIndex = 0;
            kryptonPictureBox1.TabStop = false;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonPanel3);
            kryptonPanel1.Controls.Add(kryptonPanel4);
            kryptonPanel1.Dock = DockStyle.Fill;
            kryptonPanel1.Location = new Point(0, 125);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new Size(1193, 519);
            kryptonPanel1.TabIndex = 10;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(textBoxUsername);
            kryptonPanel3.Controls.Add(kryptonLabel1);
            kryptonPanel3.Controls.Add(btnLogin);
            kryptonPanel3.Controls.Add(textBoxPassword);
            kryptonPanel3.Controls.Add(kryptonLabel2);
            kryptonPanel3.Controls.Add(btnRegister);
            kryptonPanel3.Dock = DockStyle.Fill;
            kryptonPanel3.Location = new Point(0, 0);
            kryptonPanel3.Margin = new Padding(0);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.PanelBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelAlternate;
            kryptonPanel3.Size = new Size(1193, 394);
            kryptonPanel3.TabIndex = 8;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.None;
            textBoxUsername.Location = new Point(528, 64);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            textBoxUsername.Size = new Size(125, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Anchor = AnchorStyles.None;
            kryptonLabel1.Location = new Point(421, 64);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel1.Size = new Size(80, 26);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.Location = new Point(528, 227);
            btnLogin.Name = "btnLogin";
            btnLogin.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnLogin.Size = new Size(125, 31);
            btnLogin.TabIndex = 4;
            btnLogin.Values.DropDownArrowColor = Color.Empty;
            btnLogin.Values.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(528, 152);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.None;
            kryptonLabel2.Location = new Point(421, 153);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            kryptonLabel2.Size = new Size(76, 26);
            kryptonLabel2.TabIndex = 1;
            kryptonLabel2.Values.Text = "Password";
            // 
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.None;
            btnRegister.Location = new Point(528, 297);
            btnRegister.Name = "btnRegister";
            btnRegister.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            btnRegister.Size = new Size(125, 31);
            btnRegister.TabIndex = 5;
            btnRegister.Values.DropDownArrowColor = Color.Empty;
            btnRegister.Values.Text = "Register";
            btnRegister.Click += btnRegister_Click;
            // 
            // kryptonPanel4
            // 
            kryptonPanel4.Dock = DockStyle.Bottom;
            kryptonPanel4.Location = new Point(0, 394);
            kryptonPanel4.Name = "kryptonPanel4";
            kryptonPanel4.Size = new Size(1193, 125);
            kryptonPanel4.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1193, 644);
            Controls.Add(kryptonPanel1);
            Controls.Add(kryptonPanel2);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)kryptonPanel2).EndInit();
            kryptonPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel1).EndInit();
            kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kryptonPanel3).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kryptonPanel4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonTextBox textBoxUsername;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnLogin;
        private Krypton.Toolkit.KryptonTextBox textBoxPassword;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonButton btnRegister;
    }
}