namespace _7_NotHesaplama
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
            txtAdSoyad = new TextBox();
            lstListe = new ListBox();
            btnHesapla = new Button();
            label2 = new Label();
            txtVize = new TextBox();
            label3 = new Label();
            txtFinal = new TextBox();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(145, 41);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(12, 53);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(544, 47);
            txtAdSoyad.TabIndex = 1;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(12, 201);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(544, 164);
            lstListe.TabIndex = 4;
            // 
            // btnHesapla
            // 
            btnHesapla.Location = new Point(12, 371);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(544, 74);
            btnHesapla.TabIndex = 5;
            btnHesapla.Text = "Not Ortalaması Hesapla";
            btnHesapla.UseVisualStyleBackColor = true;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 104);
            label2.Name = "label2";
            label2.Size = new Size(149, 41);
            label2.TabIndex = 0;
            label2.Text = "Vize Notu";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(12, 148);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(239, 47);
            txtVize.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 104);
            label3.Name = "label3";
            label3.Size = new Size(154, 41);
            label3.TabIndex = 0;
            label3.Text = "Final Notu";
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(317, 148);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(239, 47);
            txtFinal.TabIndex = 3;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(12, 448);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(544, 113);
            lblMesaj.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(580, 563);
            Controls.Add(btnHesapla);
            Controls.Add(lstListe);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(txtAdSoyad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private ListBox lstListe;
        private Button btnHesapla;
        private Label label2;
        private TextBox txtVize;
        private Label label3;
        private TextBox txtFinal;
        private Label lblMesaj;
    }
}
