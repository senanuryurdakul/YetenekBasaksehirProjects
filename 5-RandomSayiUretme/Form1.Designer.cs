namespace _5_RandomSayiUretme
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
            btnRandom = new Button();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(12, 342);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(251, 55);
            btnRandom.TabIndex = 0;
            btnRandom.Text = "SAYI ÜRET";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(12, 12);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(251, 324);
            lstListe.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 411);
            Controls.Add(lstListe);
            Controls.Add(btnRandom);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRandom;
        private ListBox lstListe;
    }
}
