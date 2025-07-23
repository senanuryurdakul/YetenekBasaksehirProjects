namespace _11_Ado.Net
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
            label1 = new Label();
            cmbCategories = new ComboBox();
            label2 = new Label();
            lstProductList = new ListBox();
            dgwOrderDetails = new DataGridView();
            label3 = new Label();
            lblProductCount = new Label();
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 14);
            label1.Name = "label1";
            label1.Size = new Size(235, 41);
            label1.TabIndex = 0;
            label1.Text = "Kategori Seçiniz:";
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(9, 58);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(517, 48);
            cmbCategories.TabIndex = 1;
            cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 134);
            label2.Name = "label2";
            label2.Size = new Size(171, 41);
            label2.TabIndex = 0;
            label2.Text = "Ürün Listesi";
            // 
            // lstProductList
            // 
            lstProductList.FormattingEnabled = true;
            lstProductList.ItemHeight = 40;
            lstProductList.Location = new Point(9, 190);
            lstProductList.Name = "lstProductList";
            lstProductList.Size = new Size(218, 324);
            lstProductList.TabIndex = 2;
            lstProductList.SelectedIndexChanged += lstProductList_SelectedIndexChanged;
            // 
            // dgwOrderDetails
            // 
            dgwOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwOrderDetails.Location = new Point(233, 190);
            dgwOrderDetails.Name = "dgwOrderDetails";
            dgwOrderDetails.Size = new Size(643, 320);
            dgwOrderDetails.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(233, 134);
            label3.Name = "label3";
            label3.Size = new Size(228, 41);
            label3.TabIndex = 0;
            label3.Text = "Sipariş Detayları";
            // 
            // lblProductCount
            // 
            lblProductCount.AutoSize = true;
            lblProductCount.Location = new Point(532, 58);
            lblProductCount.Name = "lblProductCount";
            lblProductCount.Size = new Size(176, 41);
            lblProductCount.TabIndex = 0;
            lblProductCount.Text = "Ürün Adedi:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(891, 523);
            Controls.Add(dgwOrderDetails);
            Controls.Add(lstProductList);
            Controls.Add(cmbCategories);
            Controls.Add(lblProductCount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgwOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbCategories;
        private Label label2;
        private ListBox lstProductList;
        private DataGridView dgwOrderDetails;
        private Label label3;
        private Label lblProductCount;
    }
}