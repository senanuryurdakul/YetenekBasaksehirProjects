namespace _6_Metodlar
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
            button6 = new Button();
            lblMesaj = new Label();
            button7 = new Button();
            lstListe = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(189, 50);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 79);
            button2.Name = "button2";
            button2.Size = new Size(189, 50);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 135);
            button3.Name = "button3";
            button3.Size = new Size(189, 57);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 198);
            button4.Name = "button4";
            button4.Size = new Size(300, 51);
            button4.TabIndex = 3;
            button4.Text = "Dizi Sıfırlama";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 255);
            button5.Name = "button5";
            button5.Size = new Size(300, 46);
            button5.TabIndex = 4;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(207, 12);
            button6.Name = "button6";
            button6.Size = new Size(140, 50);
            button6.TabIndex = 5;
            button6.Text = "REF";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(353, 17);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(132, 64);
            lblMesaj.TabIndex = 6;
            // 
            // button7
            // 
            button7.Location = new Point(207, 68);
            button7.Name = "button7";
            button7.Size = new Size(140, 61);
            button7.TabIndex = 7;
            button7.Text = "OUT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // lstListe
            // 
            lstListe.FormattingEnabled = true;
            lstListe.ItemHeight = 40;
            lstListe.Location = new Point(353, 68);
            lstListe.Name = "lstListe";
            lstListe.Size = new Size(156, 124);
            lstListe.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(547, 352);
            Controls.Add(lstListe);
            Controls.Add(button7);
            Controls.Add(lblMesaj);
            Controls.Add(button6);
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
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label lblMesaj;
        private Button button7;
        private ListBox lstListe;
    }
}
