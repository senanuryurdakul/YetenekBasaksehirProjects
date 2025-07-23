namespace _2_Diziler
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
            txtName = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            txtSurname = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 28);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 41);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci Adı";
            // 
            // txtName
            // 
            txtName.Location = new Point(16, 77);
            txtName.Margin = new Padding(7, 8, 7, 8);
            txtName.Name = "txtName";
            txtName.Size = new Size(513, 47);
            txtName.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(358, 245);
            btnSave.Margin = new Padding(7, 8, 7, 8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(171, 61);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 133);
            label2.Margin = new Padding(7, 0, 7, 0);
            label2.Name = "label2";
            label2.Size = new Size(220, 41);
            label2.TabIndex = 0;
            label2.Text = "Öğrenci Soyadı";
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(16, 182);
            txtSurname.Margin = new Padding(7, 8, 7, 8);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(513, 47);
            txtSurname.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(566, 342);
            Controls.Add(btnSave);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
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
        private TextBox txtName;
        private Button btnSave;
        private Label label2;
        private TextBox txtSurname;
    }
}
