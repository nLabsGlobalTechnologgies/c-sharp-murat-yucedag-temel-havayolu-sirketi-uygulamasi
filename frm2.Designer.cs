namespace WinFormsApp1
{
    partial class frm2
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
            btLogin = new Button();
            txUserName = new MaskedTextBox();
            checkBox1 = new CheckBox();
            txPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.Location = new Point(206, 57);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(109, 23);
            btLogin.TabIndex = 0;
            btLogin.Text = "Giriş Yap";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // txUserName
            // 
            txUserName.Location = new Point(12, 28);
            txUserName.Mask = "00000000000";
            txUserName.Name = "txUserName";
            txUserName.Size = new Size(188, 23);
            txUserName.TabIndex = 2;
            txUserName.ValidatingType = typeof(int);
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(206, 32);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(114, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Şifremi Unuttum";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txPassword
            // 
            txPassword.Location = new Point(12, 57);
            txPassword.Name = "txPassword";
            txPassword.Size = new Size(188, 23);
            txPassword.TabIndex = 4;
            txPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 111);
            label2.Name = "label2";
            label2.Size = new Size(208, 15);
            label2.TabIndex = 5;
            label2.Text = "Kullanıcı bilgisi Otomatik gelmektedir.";
            // 
            // frm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 146);
            Controls.Add(label2);
            Controls.Add(txPassword);
            Controls.Add(checkBox1);
            Controls.Add(txUserName);
            Controls.Add(btLogin);
            Name = "frm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            Load += frm2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btLogin;
        private MaskedTextBox txUserName;
        private CheckBox checkBox1;
        private TextBox txPassword;
        private Label label2;
    }
}