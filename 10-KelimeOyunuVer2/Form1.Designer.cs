namespace _10_KelimeOyunuVer2
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
            btnOyna = new Button();
            grpKelime = new GroupBox();
            flwHarfler = new FlowLayoutPanel();
            lblHak = new Label();
            lblDogru = new Label();
            SuspendLayout();
            // 
            // btnOyna
            // 
            btnOyna.Location = new Point(3, 27);
            btnOyna.Name = "btnOyna";
            btnOyna.Size = new Size(679, 90);
            btnOyna.TabIndex = 0;
            btnOyna.Text = "Kelime Seç ve Başla";
            btnOyna.UseVisualStyleBackColor = true;
            btnOyna.Click += btnOyna_Click;
            // 
            // grpKelime
            // 
            grpKelime.Location = new Point(12, 123);
            grpKelime.Name = "grpKelime";
            grpKelime.Size = new Size(1034, 237);
            grpKelime.TabIndex = 1;
            grpKelime.TabStop = false;
            grpKelime.Text = "Harf Tahmin Oyunu";
            // 
            // flwHarfler
            // 
            flwHarfler.Location = new Point(12, 366);
            flwHarfler.Name = "flwHarfler";
            flwHarfler.Size = new Size(1034, 356);
            flwHarfler.TabIndex = 2;
            // 
            // lblHak
            // 
            lblHak.BackColor = Color.Salmon;
            lblHak.Font = new Font("Segoe UI", 34F);
            lblHak.Location = new Point(688, 27);
            lblHak.Name = "lblHak";
            lblHak.Size = new Size(176, 90);
            lblHak.TabIndex = 0;
            lblHak.TextAlign = ContentAlignment.MiddleCenter;
            lblHak.Click += label1_Click;
            // 
            // lblDogru
            // 
            lblDogru.BackColor = Color.LimeGreen;
            lblDogru.Font = new Font("Segoe UI", 34F);
            lblDogru.Location = new Point(870, 27);
            lblDogru.Name = "lblDogru";
            lblDogru.Size = new Size(176, 90);
            lblDogru.TabIndex = 0;
            lblDogru.TextAlign = ContentAlignment.MiddleCenter;
            lblDogru.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1054, 734);
            Controls.Add(lblDogru);
            Controls.Add(lblHak);
            Controls.Add(flwHarfler);
            Controls.Add(grpKelime);
            Controls.Add(btnOyna);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnOyna;
        private GroupBox grpKelime;
        private FlowLayoutPanel flwHarfler;
        private Label lblHak;
        private Label lblDogru;
    }
}
