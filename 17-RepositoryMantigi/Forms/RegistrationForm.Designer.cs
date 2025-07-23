namespace _17_RepositoryMantigi.Forms
{
    partial class RegistrationForm
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
            label1 = new Label();
            cmbKurs = new ComboBox();
            txtFiyat = new TextBox();
            btnKaydet = new Button();
            lstListe = new ListBox();
            label2 = new Label();
            cmbOgrenci = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 43);
            label1.Name = "label1";
            label1.Size = new Size(181, 41);
            label1.TabIndex = 0;
            label1.Text = "Kurs Seçiniz:";
            // 
            // cmbKurs
            // 
            cmbKurs.FormattingEnabled = true;
            cmbKurs.Location = new Point(43, 87);
            cmbKurs.Name = "cmbKurs";
            cmbKurs.Size = new Size(703, 48);
            cmbKurs.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(43, 277);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(703, 47);
            txtFiyat.TabIndex = 2;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(532, 330);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(214, 62);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(43, 398);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(703, 204);
            lstListe.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 138);
            label2.Name = "label2";
            label2.Size = new Size(229, 41);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Seçiniz:";
            // 
            // cmbOgrenci
            // 
            cmbOgrenci.FormattingEnabled = true;
            cmbOgrenci.Location = new Point(43, 182);
            cmbOgrenci.Name = "cmbOgrenci";
            cmbOgrenci.Size = new Size(703, 48);
            cmbOgrenci.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 233);
            label3.Name = "label3";
            label3.Size = new Size(152, 41);
            label3.TabIndex = 0;
            label3.Text = "Kurs Fiyatı";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(791, 631);
            Controls.Add(lstListe);
            Controls.Add(btnKaydet);
            Controls.Add(txtFiyat);
            Controls.Add(cmbOgrenci);
            Controls.Add(cmbKurs);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKurs;
        private TextBox txtFiyat;
        private Button btnKaydet;
        private ListBox lstListe;
        private Label label2;
        private ComboBox cmbOgrenci;
        private Label label3;
    }
}