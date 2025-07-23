namespace _13_OOPOrnek1
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
            cmbKategoriler = new ComboBox();
            label2 = new Label();
            txtUrunAdi = new TextBox();
            nmrAdet = new NumericUpDown();
            btnEkle = new Button();
            lstListe = new ListBox();
            btnAddList = new Button();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(162, 41);
            label1.TabIndex = 0;
            label1.Text = "Kategoriler";
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(12, 74);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(500, 48);
            cmbKategoriler.TabIndex = 1;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(135, 41);
            label2.TabIndex = 0;
            label2.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(12, 178);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(500, 47);
            txtUrunAdi.TabIndex = 2;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(12, 237);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(120, 47);
            nmrAdet.TabIndex = 3;
            nmrAdet.ValueChanged += nmrAdet_ValueChanged;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(527, 284);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(417, 57);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Temel Anlatım";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(527, 74);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(417, 204);
            lstListe.TabIndex = 6;
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(138, 237);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(374, 58);
            btnAddList.TabIndex = 7;
            btnAddList.Text = "Listeye Ekle";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += btnAddList_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(956, 350);
            Controls.Add(btnAddList);
            Controls.Add(lstListe);
            Controls.Add(btnEkle);
            Controls.Add(nmrAdet);
            Controls.Add(txtUrunAdi);
            Controls.Add(cmbKategoriler);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbKategoriler;
        private Label label2;
        private TextBox txtUrunAdi;
        private NumericUpDown nmrAdet;
        private Button btnEkle;
        private ListBox lstListe;
        private Button btnAddList;
    }
}
