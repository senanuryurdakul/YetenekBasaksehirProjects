namespace _18_BankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            cmbHesapTuru = new ComboBox();
            btnHesapAc = new Button();
            txtAySonuBakiye = new TextBox();
            lblAySonu = new Label();
            txtIlkBakiye = new TextBox();
            label4 = new Label();
            txtAdSoyad = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtHesapNo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            cmbIslemTuru = new ComboBox();
            btnAySonu = new Button();
            btnIslemYap = new Button();
            txtNot = new TextBox();
            label7 = new Label();
            txtTutar = new TextBox();
            label8 = new Label();
            label9 = new Label();
            grpHesapHareketleri = new GroupBox();
            lblHesapHareketleri = new Label();
            lblSonBakiye = new Label();
            lstHesapListesi = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpHesapHareketleri.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbHesapTuru);
            groupBox1.Controls.Add(btnHesapAc);
            groupBox1.Controls.Add(txtAySonuBakiye);
            groupBox1.Controls.Add(lblAySonu);
            groupBox1.Controls.Add(txtIlkBakiye);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHesapNo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(780, 389);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Açma İşlemleri";
            // 
            // cmbHesapTuru
            // 
            cmbHesapTuru.FormattingEnabled = true;
            cmbHesapTuru.Location = new Point(320, 104);
            cmbHesapTuru.Name = "cmbHesapTuru";
            cmbHesapTuru.Size = new Size(454, 48);
            cmbHesapTuru.TabIndex = 3;
            cmbHesapTuru.SelectedIndexChanged += cmbHesapTuru_SelectedIndexChanged;
            // 
            // btnHesapAc
            // 
            btnHesapAc.Location = new Point(320, 317);
            btnHesapAc.Name = "btnHesapAc";
            btnHesapAc.Size = new Size(454, 66);
            btnHesapAc.TabIndex = 2;
            btnHesapAc.Text = "Hesap Aç";
            btnHesapAc.UseVisualStyleBackColor = true;
            btnHesapAc.Click += btnHesapAc_Click;
            // 
            // txtAySonuBakiye
            // 
            txtAySonuBakiye.Location = new Point(320, 264);
            txtAySonuBakiye.Name = "txtAySonuBakiye";
            txtAySonuBakiye.Size = new Size(454, 47);
            txtAySonuBakiye.TabIndex = 1;
            txtAySonuBakiye.Visible = false;
            // 
            // lblAySonu
            // 
            lblAySonu.AutoSize = true;
            lblAySonu.Location = new Point(17, 270);
            lblAySonu.Name = "lblAySonu";
            lblAySonu.Size = new Size(220, 41);
            lblAySonu.TabIndex = 0;
            lblAySonu.Text = "Ay Sonu Bakiye";
            lblAySonu.Visible = false;
            // 
            // txtIlkBakiye
            // 
            txtIlkBakiye.Location = new Point(320, 211);
            txtIlkBakiye.Name = "txtIlkBakiye";
            txtIlkBakiye.Size = new Size(454, 47);
            txtIlkBakiye.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 217);
            label4.Name = "label4";
            label4.Size = new Size(141, 41);
            label4.TabIndex = 0;
            label4.Text = "İlk Bakiye";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(320, 158);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(454, 47);
            txtAdSoyad.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 164);
            label3.Name = "label3";
            label3.Size = new Size(145, 41);
            label3.TabIndex = 0;
            label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 111);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 0;
            label2.Text = "Hesap Türü";
            // 
            // txtHesapNo
            // 
            txtHesapNo.Location = new Point(320, 52);
            txtHesapNo.Name = "txtHesapNo";
            txtHesapNo.Size = new Size(454, 47);
            txtHesapNo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 58);
            label1.Name = "label1";
            label1.Size = new Size(159, 41);
            label1.TabIndex = 0;
            label1.Text = "HESAP NO";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cmbIslemTuru);
            groupBox2.Controls.Add(btnAySonu);
            groupBox2.Controls.Add(btnIslemYap);
            groupBox2.Controls.Add(txtNot);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtTutar);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(12, 407);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 297);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nakit İşlemleri";
            // 
            // cmbIslemTuru
            // 
            cmbIslemTuru.FormattingEnabled = true;
            cmbIslemTuru.Location = new Point(321, 50);
            cmbIslemTuru.Name = "cmbIslemTuru";
            cmbIslemTuru.Size = new Size(454, 48);
            cmbIslemTuru.TabIndex = 3;
            // 
            // btnAySonu
            // 
            btnAySonu.Location = new Point(321, 210);
            btnAySonu.Name = "btnAySonu";
            btnAySonu.Size = new Size(227, 66);
            btnAySonu.TabIndex = 2;
            btnAySonu.Text = "Ay Sonu";
            btnAySonu.UseVisualStyleBackColor = true;
            // 
            // btnIslemYap
            // 
            btnIslemYap.Location = new Point(548, 210);
            btnIslemYap.Name = "btnIslemYap";
            btnIslemYap.Size = new Size(227, 66);
            btnIslemYap.TabIndex = 2;
            btnIslemYap.Text = "İşlem Yap";
            btnIslemYap.UseVisualStyleBackColor = true;
            btnIslemYap.Click += btnIslemYap_Click;
            // 
            // txtNot
            // 
            txtNot.Location = new Point(321, 157);
            txtNot.Name = "txtNot";
            txtNot.Size = new Size(454, 47);
            txtNot.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 163);
            label7.Name = "label7";
            label7.Size = new Size(163, 41);
            label7.TabIndex = 0;
            label7.Text = "İşlem Notu";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(321, 104);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(454, 47);
            txtTutar.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 110);
            label8.Name = "label8";
            label8.Size = new Size(86, 41);
            label8.TabIndex = 0;
            label8.Text = "Tutar";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 57);
            label9.Name = "label9";
            label9.Size = new Size(156, 41);
            label9.TabIndex = 0;
            label9.Text = "İşlem Türü";
            // 
            // grpHesapHareketleri
            // 
            grpHesapHareketleri.Controls.Add(lblHesapHareketleri);
            grpHesapHareketleri.Controls.Add(lblSonBakiye);
            grpHesapHareketleri.Location = new Point(1183, 30);
            grpHesapHareketleri.Name = "grpHesapHareketleri";
            grpHesapHareketleri.Size = new Size(480, 674);
            grpHesapHareketleri.TabIndex = 1;
            grpHesapHareketleri.TabStop = false;
            grpHesapHareketleri.Text = "Hesap Hareketleri";
            // 
            // lblHesapHareketleri
            // 
            lblHesapHareketleri.Location = new Point(16, 54);
            lblHesapHareketleri.Name = "lblHesapHareketleri";
            lblHesapHareketleri.Size = new Size(458, 527);
            lblHesapHareketleri.TabIndex = 0;
            // 
            // lblSonBakiye
            // 
            lblSonBakiye.Location = new Point(6, 587);
            lblSonBakiye.Name = "lblSonBakiye";
            lblSonBakiye.Size = new Size(468, 75);
            lblSonBakiye.TabIndex = 0;
            // 
            // lstHesapListesi
            // 
            lstHesapListesi.FormattingEnabled = true;
            lstHesapListesi.ItemHeight = 40;
            lstHesapListesi.Location = new Point(798, 30);
            lstHesapListesi.Name = "lstHesapListesi";
            lstHesapListesi.Size = new Size(379, 684);
            lstHesapListesi.TabIndex = 2;
            lstHesapListesi.SelectedIndexChanged += lstHesapListesi_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1675, 767);
            Controls.Add(lstHesapListesi);
            Controls.Add(grpHesapHareketleri);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpHesapHareketleri.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cmbHesapTuru;
        private Button btnHesapAc;
        private TextBox txtAySonuBakiye;
        private Label lblAySonu;
        private TextBox txtIlkBakiye;
        private Label label4;
        private TextBox txtAdSoyad;
        private Label label3;
        private Label label2;
        private TextBox txtHesapNo;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox cmbIslemTuru;
        private Button btnAySonu;
        private Button btnIslemYap;
        private TextBox txtNot;
        private Label label7;
        private TextBox txtTutar;
        private Label label8;
        private Label label9;
        private GroupBox grpHesapHareketleri;
        private Label lblHesapHareketleri;
        private Label lblSonBakiye;
        private ListBox lstHesapListesi;
    }
}
