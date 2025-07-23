namespace _9_KelimeOyunuV1
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
            txtKelime = new TextBox();
            btnOyna = new Button();
            grpHarfler = new GroupBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 41);
            label1.TabIndex = 0;
            label1.Text = "Lütfen bir kelime giriniz:";
            // 
            // txtKelime
            // 
            txtKelime.Location = new Point(8, 44);
            txtKelime.Name = "txtKelime";
            txtKelime.Size = new Size(861, 47);
            txtKelime.TabIndex = 1;
            // 
            // btnOyna
            // 
            btnOyna.Location = new Point(12, 97);
            btnOyna.Name = "btnOyna";
            btnOyna.Size = new Size(322, 50);
            btnOyna.TabIndex = 2;
            btnOyna.Text = "Oyuna Başla";
            btnOyna.UseVisualStyleBackColor = true;
            btnOyna.Click += btnOyna_Click;
            // 
            // grpHarfler
            // 
            grpHarfler.Location = new Point(8, 251);
            grpHarfler.Name = "grpHarfler";
            grpHarfler.Size = new Size(861, 230);
            grpHarfler.TabIndex = 3;
            grpHarfler.TabStop = false;
            grpHarfler.Text = "Harf Tahmin Oyunu";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 493);
            Controls.Add(grpHarfler);
            Controls.Add(btnOyna);
            Controls.Add(txtKelime);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKelime;
        private Button btnOyna;
        private GroupBox grpHarfler;
    }
}
