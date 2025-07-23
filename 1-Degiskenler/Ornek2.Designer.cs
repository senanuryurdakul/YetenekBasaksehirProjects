namespace _1_Degiskenler
{
    partial class Ornek2
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
            btnKaydet = new Button();
            txtUrunFiyati = new TextBox();
            lblMesaj = new Label();
            label3 = new Label();
            txtUrunAdedi = new TextBox();
            label2 = new Label();
            txtUrunAdi = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(12, 289);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(495, 57);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(12, 230);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(495, 47);
            txtUrunFiyati.TabIndex = 7;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(12, 363);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(495, 145);
            lblMesaj.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(160, 41);
            label3.TabIndex = 4;
            label3.Text = "Ürün Fiyatı";
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Location = new Point(12, 139);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(495, 47);
            txtUrunAdedi.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 99);
            label2.Name = "label2";
            label2.Size = new Size(169, 41);
            label2.TabIndex = 5;
            label2.Text = "Ürün Adedi";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(12, 49);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(495, 47);
            txtUrunAdi.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 41);
            label1.TabIndex = 6;
            label1.Text = "Ürün Adı";
            // 
            // Ornek2
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 583);
            Controls.Add(btnKaydet);
            Controls.Add(txtUrunFiyati);
            Controls.Add(lblMesaj);
            Controls.Add(label3);
            Controls.Add(txtUrunAdedi);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Ornek2";
            Text = "Ornek2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private TextBox txtUrunFiyati;
        private Label lblMesaj;
        private Label label3;
        private TextBox txtUrunAdedi;
        private Label label2;
        private TextBox txtUrunAdi;
        private Label label1;
    }
}