namespace _3_KararYapilari
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
            txtTutar = new TextBox();
            button1 = new Button();
            lblMesaj = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 12);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Satış Tutarı";
            // 
            // txtTutar
            // 
            txtTutar.Location = new Point(29, 52);
            txtTutar.Name = "txtTutar";
            txtTutar.Size = new Size(502, 43);
            txtTutar.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(383, 101);
            button1.Name = "button1";
            button1.Size = new Size(148, 53);
            button1.TabIndex = 2;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMesaj
            // 
            lblMesaj.Location = new Point(29, 179);
            lblMesaj.Name = "lblMesaj";
            lblMesaj.Size = new Size(502, 171);
            lblMesaj.TabIndex = 0;
            // 
            // Ornek
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(581, 375);
            Controls.Add(button1);
            Controls.Add(txtTutar);
            Controls.Add(lblMesaj);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 20F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "Ornek";
            Text = "Ornek";
            Load += Ornek_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTutar;
        private Button button1;
        private Label lblMesaj;
    }
}