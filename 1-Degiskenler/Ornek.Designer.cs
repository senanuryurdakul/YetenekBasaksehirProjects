namespace _1_Degiskenler
{
    partial class Ornek
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
            txtUrunAdi = new TextBox();
            btnKaydet = new Button();
            label2 = new Label();
            txtUrunAdedi = new TextBox();
            label3 = new Label();
            txtUrunFiyati = new TextBox();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(37, 49);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(495, 43);
            txtUrunAdi.TabIndex = 1;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(384, 289);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(148, 57);
            btnKaydet.TabIndex = 2;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 99);
            label2.Name = "label2";
            label2.Size = new Size(152, 37);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adedi";
            // 
            // txtUrunAdedi
            // 
            txtUrunAdedi.Location = new Point(37, 139);
            txtUrunAdedi.Name = "txtUrunAdedi";
            txtUrunAdedi.Size = new Size(495, 43);
            txtUrunAdedi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 190);
            label3.Name = "label3";
            label3.Size = new Size(145, 37);
            label3.TabIndex = 0;
            label3.Text = "Ürün Fiyatı";
            // 
            // txtUrunFiyati
            // 
            txtUrunFiyati.Location = new Point(37, 230);
            txtUrunFiyati.Name = "txtUrunFiyati";
            txtUrunFiyati.Size = new Size(495, 43);
            txtUrunFiyati.TabIndex = 1;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(37, 394);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(495, 145);
            lblMesaj.TabIndex = 0;
            // 
            // Ornek
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 587);
            Controls.Add(btnKaydet);
            Controls.Add(txtUrunFiyati);
            Controls.Add(lblMesaj);
            Controls.Add(label3);
            Controls.Add(txtUrunAdedi);
            Controls.Add(label2);
            Controls.Add(txtUrunAdi);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Ornek";
            Text = "Ornek";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUrunAdi;
        private Button btnKaydet;
        private Label label2;
        private TextBox txtUrunAdedi;
        private Label label3;
        private TextBox txtUrunFiyati;
        private Label lblMesaj;
    }
}