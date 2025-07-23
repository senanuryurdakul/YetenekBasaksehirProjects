namespace _11_Ado.Net
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lstListe = new ListBox();
            txtUrunAdi = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 22);
            button1.Name = "button1";
            button1.Size = new Size(419, 56);
            button1.TabIndex = 0;
            button1.Text = "Ürünleri Getir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(23, 84);
            button2.Name = "button2";
            button2.Size = new Size(419, 56);
            button2.TabIndex = 0;
            button2.Text = "Kategorileri Getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(23, 208);
            button3.Name = "button3";
            button3.Size = new Size(419, 56);
            button3.TabIndex = 0;
            button3.Text = "Ürün Ekleme (insert)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(23, 270);
            button4.Name = "button4";
            button4.Size = new Size(419, 56);
            button4.TabIndex = 0;
            button4.Text = "Ürün Silme (delete)";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(23, 332);
            button5.Name = "button5";
            button5.Size = new Size(419, 56);
            button5.TabIndex = 0;
            button5.Text = "Ürün Güncelleme (update)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(448, 102);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(270, 284);
            lstListe.TabIndex = 1;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(448, 22);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(279, 47);
            txtUrunAdi.TabIndex = 2;
            txtUrunAdi.TextChanged += txtUrunAdi_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(739, 407);
            Controls.Add(txtUrunAdi);
            Controls.Add(lstListe);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private ListBox lstListe;
        private TextBox txtUrunAdi;
    }
}
