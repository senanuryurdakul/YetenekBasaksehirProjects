namespace _13_OOPOrnek1
{
    partial class Form2
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
            btnAddList = new Button();
            lstListe = new ListBox();
            nmrAdet = new NumericUpDown();
            txtUrunAdi = new TextBox();
            cmbKategoriler = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrAdet).BeginInit();
            SuspendLayout();
            // 
            // btnAddList
            // 
            btnAddList.Location = new Point(329, 229);
            btnAddList.Margin = new Padding(6, 7, 6, 7);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(338, 51);
            btnAddList.TabIndex = 15;
            btnAddList.Text = "Listeye Ekle";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += btnAddList_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 37;
            lstListe.Location = new Point(679, 76);
            lstListe.Margin = new Padding(6, 7, 6, 7);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(415, 411);
            lstListe.TabIndex = 14;
            // 
            // nmrAdet
            // 
            nmrAdet.Location = new Point(30, 229);
            nmrAdet.Margin = new Padding(6, 7, 6, 7);
            nmrAdet.Name = "nmrAdet";
            nmrAdet.Size = new Size(230, 43);
            nmrAdet.TabIndex = 12;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(30, 172);
            txtUrunAdi.Margin = new Padding(6, 7, 6, 7);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(641, 43);
            txtUrunAdi.TabIndex = 11;
            // 
            // cmbKategoriler
            // 
            cmbKategoriler.FormattingEnabled = true;
            cmbKategoriler.Location = new Point(26, 76);
            cmbKategoriler.Margin = new Padding(6, 7, 6, 7);
            cmbKategoriler.Name = "cmbKategoriler";
            cmbKategoriler.Size = new Size(641, 45);
            cmbKategoriler.TabIndex = 10;
            cmbKategoriler.SelectedIndexChanged += cmbKategoriler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 128);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 37);
            label2.TabIndex = 8;
            label2.Text = "Ürün Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 9;
            label1.Text = "Kategoriler";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1104, 502);
            Controls.Add(btnAddList);
            Controls.Add(lstListe);
            Controls.Add(nmrAdet);
            Controls.Add(txtUrunAdi);
            Controls.Add(cmbKategoriler);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)nmrAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddList;
        private ListBox lstListe;
        private NumericUpDown nmrAdet;
        private TextBox txtUrunAdi;
        private ComboBox cmbKategoriler;
        private Label label2;
        private Label label1;
    }
}