namespace _8_UrunSiparisFormu
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
            label1 = new Label();
            cmbKategori = new ComboBox();
            lstListe = new ListBox();
            nmrAdet = new NumericUpDown();
            btnAktar = new Button();
            grpFaturaTipleri = new GroupBox();
            rdKurumsal = new RadioButton();
            rdBireysel = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBirimFiyat = new TextBox();
            label5 = new Label();
            txtToplamTutar = new TextBox();
            lstSepet = new ListBox();
            lblSepetToplami = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            grpFaturaTipleri.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(364, 41);
            label1.TabIndex = 0;
            label1.Text = "Lütfen bir kategori seçiniz:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(15, 53);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(453, 48);
            cmbKategori.TabIndex = 1;
            cmbKategori.SelectedIndexChanged += cmbKategori_SelectedIndexChanged;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(15, 148);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(453, 204);
            lstListe.TabIndex = 2;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(15, 414);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(120, 47);
            nmrAdet.TabIndex = 3;
            // 
            // btnAktar
            // 
            btnAktar.Location = new Point(484, 178);
            btnAktar.Name = "btnAktar";
            btnAktar.Size = new Size(120, 138);
            btnAktar.TabIndex = 4;
            btnAktar.Text = ">>>";
            btnAktar.UseVisualStyleBackColor = true;
            btnAktar.Click += btnAktar_Click;
            // 
            // grpFaturaTipleri
            // 
            grpFaturaTipleri.Controls.Add(rdKurumsal);
            grpFaturaTipleri.Controls.Add(rdBireysel);
            grpFaturaTipleri.Location = new Point(627, 53);
            grpFaturaTipleri.Name = "grpFaturaTipleri";
            grpFaturaTipleri.Size = new Size(284, 191);
            grpFaturaTipleri.TabIndex = 5;
            grpFaturaTipleri.TabStop = false;
            grpFaturaTipleri.Text = "Fatura Tipi";
            // 
            // rdKurumsal
            // 
            rdKurumsal.AutoSize = true;
            rdKurumsal.Location = new Point(31, 102);
            rdKurumsal.Name = "rdKurumsal";
            rdKurumsal.Size = new Size(247, 45);
            rdKurumsal.TabIndex = 0;
            rdKurumsal.TabStop = true;
            rdKurumsal.Text = "Kurumsal Fatura";
            rdKurumsal.UseVisualStyleBackColor = true;
            // 
            // rdBireysel
            // 
            rdBireysel.AutoSize = true;
            rdBireysel.Location = new Point(31, 51);
            rdBireysel.Name = "rdBireysel";
            rdBireysel.Size = new Size(226, 45);
            rdBireysel.TabIndex = 0;
            rdBireysel.TabStop = true;
            rdBireysel.Text = "Bireysel Fatura";
            rdBireysel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 104);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 0;
            label2.Text = "Ürün Listesi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 0;
            label3.Text = "Adet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(141, 370);
            label4.Name = "label4";
            label4.Size = new Size(162, 41);
            label4.TabIndex = 0;
            label4.Text = "Birim Fiyatı";
            // 
            // txtBirimFiyat
            // 
            txtBirimFiyat.Location = new Point(141, 414);
            txtBirimFiyat.Name = "txtBirimFiyat";
            txtBirimFiyat.Size = new Size(327, 47);
            txtBirimFiyat.TabIndex = 6;
            txtBirimFiyat.TextChanged += txtBirimFiyat_TextChanged;
            txtBirimFiyat.KeyDown += txtBirimFiyat_KeyDown;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 463);
            label5.Name = "label5";
            label5.Size = new Size(191, 41);
            label5.TabIndex = 0;
            label5.Text = "Toplam Tutar";
            // 
            // txtToplamTutar
            // 
            txtToplamTutar.Location = new Point(15, 507);
            txtToplamTutar.Name = "txtToplamTutar";
            txtToplamTutar.Size = new Size(453, 47);
            txtToplamTutar.TabIndex = 6;
            // 
            // lstSepet
            // 
            lstSepet.FormattingEnabled = true;
            lstSepet.ItemHeight = 40;
            lstSepet.Location = new Point(627, 257);
            lstSepet.Name = "lstSepet";
            lstSepet.Size = new Size(804, 204);
            lstSepet.TabIndex = 2;
            // 
            // lblSepetToplami
            // 
            lblSepetToplami.Location = new Point(1147, 463);
            lblSepetToplami.Name = "lblSepetToplami";
            lblSepetToplami.Size = new Size(284, 65);
            lblSepetToplami.TabIndex = 0;
            lblSepetToplami.Text = "Sepet Toplamı";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1501, 566);
            Controls.Add(txtToplamTutar);
            Controls.Add(txtBirimFiyat);
            Controls.Add(grpFaturaTipleri);
            Controls.Add(btnAktar);
            Controls.Add(nmrAdet);
            Controls.Add(lstSepet);
            Controls.Add(lstListe);
            Controls.Add(cmbKategori);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(lblSepetToplami);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            grpFaturaTipleri.ResumeLayout(false);
            grpFaturaTipleri.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategori;
        private ListBox lstListe;
        private NumericUpDown nmrAdet;
        private Button btnAktar;
        private GroupBox grpFaturaTipleri;
        private RadioButton rdBireysel;
        private RadioButton rdKurumsal;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBirimFiyat;
        private Label label5;
        private TextBox txtToplamTutar;
        private ListBox lstSepet;
        private Label lblSepetToplami;
    }
}
