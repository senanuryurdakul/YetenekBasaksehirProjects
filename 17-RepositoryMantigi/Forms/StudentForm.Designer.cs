namespace _17_RepositoryMantigi.Forms
{
    partial class StudentForm
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
            groupBox1 = new GroupBox();
            txtSoyad = new MaskedTextBox();
            txtAd = new MaskedTextBox();
            txtDTarihi = new MaskedTextBox();
            txtTC = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            btnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            lstListe = new ListBox();
            btnSil = new Button();
            lblMesaj = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(txtDTarihi);
            groupBox1.Controls.Add(txtTC);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnKaydet);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(839, 346);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Bilgileri";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(218, 169);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(602, 47);
            txtSoyad.TabIndex = 4;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(218, 116);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(602, 47);
            txtAd.TabIndex = 4;
            // 
            // txtDTarihi
            // 
            txtDTarihi.Location = new Point(218, 222);
            txtDTarihi.Mask = "00/00/0000";
            txtDTarihi.Name = "txtDTarihi";
            txtDTarihi.Size = new Size(602, 47);
            txtDTarihi.TabIndex = 4;
            txtDTarihi.ValidatingType = typeof(DateTime);
            // 
            // txtTC
            // 
            txtTC.Location = new Point(218, 63);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(602, 47);
            txtTC.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 222);
            label4.Name = "label4";
            label4.Size = new Size(195, 41);
            label4.TabIndex = 0;
            label4.Text = "Doğum Tarihi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 169);
            label3.Name = "label3";
            label3.Size = new Size(100, 41);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(604, 275);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(213, 57);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 116);
            label2.Name = "label2";
            label2.Size = new Size(55, 41);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 63);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 0;
            label1.Text = "TC Kimlik";
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(12, 364);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(823, 204);
            lstListe.TabIndex = 3;
            lstListe.SelectedIndexChanged += lstListe_SelectedIndexChanged;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(622, 574);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(213, 57);
            btnSil.TabIndex = 2;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.BorderStyle = BorderStyle.FixedSingle;
            lblMesaj.Location = new Point(12, 634);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(817, 59);
            lblMesaj.TabIndex = 0;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(844, 712);
            Controls.Add(groupBox1);
            Controls.Add(lstListe);
            Controls.Add(btnSil);
            Controls.Add(lblMesaj);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private MaskedTextBox txtSoyad;
        private MaskedTextBox txtAd;
        private MaskedTextBox txtTC;
        private Label label4;
        private Label label3;
        private Button btnKaydet;
        private Label label2;
        private Label label1;
        private ListBox lstListe;
        private Button btnSil;
        private Label lblMesaj;
        private MaskedTextBox txtDTarihi;
    }
}