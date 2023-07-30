namespace WinFormsApp1
{
    partial class frm3
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
            panel1 = new Panel();
            label8 = new Label();
            groupBox1 = new GroupBox();
            txSaat = new MaskedTextBox();
            dtTarih = new DateTimePicker();
            cmbNereye = new ComboBox();
            cmbNereden = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txAdSoyad = new TextBox();
            btKaydet = new Button();
            txTcNo = new MaskedTextBox();
            txTelefon = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            lstListe = new ListBox();
            btSifirla = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 84);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Banner", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(26, 7);
            label8.Name = "label8";
            label8.Size = new Size(380, 69);
            label8.TabIndex = 0;
            label8.Text = "Uzay Hava Yolları";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txSaat);
            groupBox1.Controls.Add(dtTarih);
            groupBox1.Controls.Add(cmbNereye);
            groupBox1.Controls.Add(cmbNereden);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(356, 143);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Uçuş Bilgileri";
            // 
            // txSaat
            // 
            txSaat.Location = new Point(114, 106);
            txSaat.Mask = "00:00";
            txSaat.Name = "txSaat";
            txSaat.Size = new Size(100, 23);
            txSaat.TabIndex = 3;
            txSaat.ValidatingType = typeof(DateTime);
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(114, 78);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(200, 23);
            dtTarih.TabIndex = 2;
            // 
            // cmbNereye
            // 
            cmbNereye.FormattingEnabled = true;
            cmbNereye.Items.AddRange(new object[] { "Adana", "Istanbul", "Ankara", "Edirne", "Malatya", "Elazığ" });
            cmbNereye.Location = new Point(114, 49);
            cmbNereye.Name = "cmbNereye";
            cmbNereye.Size = new Size(200, 23);
            cmbNereye.TabIndex = 1;
            // 
            // cmbNereden
            // 
            cmbNereden.FormattingEnabled = true;
            cmbNereden.Items.AddRange(new object[] { "Adana", "Istanbul", "Ankara", "Edirne", "Malatya", "Elazığ" });
            cmbNereden.Location = new Point(114, 22);
            cmbNereden.Name = "cmbNereden";
            cmbNereden.Size = new Size(200, 23);
            cmbNereden.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 109);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 0;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 84);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Tarih:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 0;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txAdSoyad);
            groupBox2.Controls.Add(btSifirla);
            groupBox2.Controls.Add(btKaydet);
            groupBox2.Controls.Add(txTcNo);
            groupBox2.Controls.Add(txTelefon);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(408, 125);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 143);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yolcu Bilgileri";
            // 
            // txAdSoyad
            // 
            txAdSoyad.Location = new Point(104, 20);
            txAdSoyad.Name = "txAdSoyad";
            txAdSoyad.Size = new Size(255, 23);
            txAdSoyad.TabIndex = 5;
            // 
            // btKaydet
            // 
            btKaydet.Location = new Point(250, 110);
            btKaydet.Name = "btKaydet";
            btKaydet.Size = new Size(109, 23);
            btKaydet.TabIndex = 4;
            btKaydet.Text = "Kaydet";
            btKaydet.UseVisualStyleBackColor = true;
            btKaydet.Click += btKaydet_Click;
            // 
            // txTcNo
            // 
            txTcNo.Location = new Point(104, 49);
            txTcNo.Mask = "00000000000";
            txTcNo.Name = "txTcNo";
            txTcNo.Size = new Size(255, 23);
            txTcNo.TabIndex = 3;
            txTcNo.ValidatingType = typeof(int);
            // 
            // txTelefon
            // 
            txTelefon.Location = new Point(104, 81);
            txTelefon.Mask = "00000000000";
            txTelefon.Name = "txTelefon";
            txTelefon.Size = new Size(255, 23);
            txTelefon.TabIndex = 3;
            txTelefon.ValidatingType = typeof(int);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 84);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 0;
            label7.Text = "Telefon:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 57);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 0;
            label6.Text = "Tc:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 30);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 0;
            label5.Text = "Yolcu Ad Soyad:";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 15;
            lstListe.Location = new Point(12, 283);
            lstListe.Name = "lstListe";
            lstListe.RightToLeft = RightToLeft.Yes;
            lstListe.Size = new Size(764, 154);
            lstListe.TabIndex = 2;
            // 
            // btSifirla
            // 
            btSifirla.Location = new Point(135, 110);
            btSifirla.Name = "btSifirla";
            btSifirla.Size = new Size(109, 23);
            btSifirla.TabIndex = 4;
            btSifirla.Text = "Formu Sıfırla";
            btSifirla.UseVisualStyleBackColor = true;
            btSifirla.Click += btSifirla_Click;
            // 
            // frm3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstListe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frm3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private MaskedTextBox txTelefon;
        private Button btKaydet;
        private Label label8;
        private MaskedTextBox txSaat;
        private DateTimePicker dtTarih;
        private ComboBox cmbNereye;
        private ComboBox cmbNereden;
        private TextBox txAdSoyad;
        private MaskedTextBox txTcNo;
        private ListBox lstListe;
        private Button btSifirla;
    }
}