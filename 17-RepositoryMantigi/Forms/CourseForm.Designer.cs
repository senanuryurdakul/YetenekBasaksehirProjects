namespace _17_RepositoryMantigi.Forms
{
    partial class CourseForm
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
            groupBox1 = new GroupBox();
            cmbInstructor = new ComboBox();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            txtCourseName = new TextBox();
            groupBox2 = new GroupBox();
            txtLessonTime = new MaskedTextBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label9 = new Label();
            label5 = new Label();
            txtLessonContent = new TextBox();
            txtLessonDuration = new TextBox();
            txtLessonName = new TextBox();
            dtLessonDate = new DateTimePicker();
            btnSaveCourse = new Button();
            lstLessonList = new ListBox();
            btnAddLesson = new Button();
            lstCourseList = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbInstructor);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtEndDate);
            groupBox1.Controls.Add(dtStartDate);
            groupBox1.Controls.Add(txtCourseName);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(577, 465);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kurs Bilgi Formu";
            // 
            // cmbInstructor
            // 
            cmbInstructor.FormattingEnabled = true;
            cmbInstructor.Location = new Point(29, 389);
            cmbInstructor.Name = "cmbInstructor";
            cmbInstructor.Size = new Size(520, 48);
            cmbInstructor.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 340);
            label8.Name = "label8";
            label8.Size = new Size(233, 41);
            label8.TabIndex = 3;
            label8.Text = "Eğitmen Seçiniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 246);
            label3.Name = "label3";
            label3.Size = new Size(149, 41);
            label3.TabIndex = 3;
            label3.Text = "Bitiş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 152);
            label2.Name = "label2";
            label2.Size = new Size(218, 41);
            label2.TabIndex = 3;
            label2.Text = "Başlangıç Tarihi";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 58);
            label1.Name = "label1";
            label1.Size = new Size(127, 41);
            label1.TabIndex = 3;
            label1.Text = "Kurs Adı";
            // 
            // dtEndDate
            // 
            dtEndDate.Location = new Point(29, 290);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(520, 47);
            dtEndDate.TabIndex = 2;
            // 
            // dtStartDate
            // 
            dtStartDate.Location = new Point(29, 196);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(520, 47);
            dtStartDate.TabIndex = 2;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(29, 102);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(520, 47);
            txtCourseName.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtLessonTime);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtLessonContent);
            groupBox2.Controls.Add(txtLessonDuration);
            groupBox2.Controls.Add(txtLessonName);
            groupBox2.Controls.Add(dtLessonDate);
            groupBox2.Location = new Point(595, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(546, 714);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ders Bilgileri";
            // 
            // txtLessonTime
            // 
            txtLessonTime.Location = new Point(6, 290);
            txtLessonTime.Name = "txtLessonTime";
            txtLessonTime.Size = new Size(519, 47);
            txtLessonTime.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 434);
            label7.Name = "label7";
            label7.Size = new Size(166, 41);
            label7.TabIndex = 3;
            label7.Text = "Ders İçeriği";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 340);
            label6.Name = "label6";
            label6.Size = new Size(165, 41);
            label6.TabIndex = 3;
            label6.Text = "Ders Süresi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 58);
            label4.Name = "label4";
            label4.Size = new Size(130, 41);
            label4.TabIndex = 3;
            label4.Text = "Ders Adı";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 246);
            label9.Name = "label9";
            label9.Size = new Size(74, 41);
            label9.TabIndex = 3;
            label9.Text = "Saat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 152);
            label5.Name = "label5";
            label5.Size = new Size(80, 41);
            label5.TabIndex = 3;
            label5.Text = "Tarih";
            // 
            // txtLessonContent
            // 
            txtLessonContent.Location = new Point(7, 482);
            txtLessonContent.Multiline = true;
            txtLessonContent.Name = "txtLessonContent";
            txtLessonContent.Size = new Size(520, 137);
            txtLessonContent.TabIndex = 1;
            // 
            // txtLessonDuration
            // 
            txtLessonDuration.Location = new Point(6, 384);
            txtLessonDuration.Name = "txtLessonDuration";
            txtLessonDuration.Size = new Size(520, 47);
            txtLessonDuration.TabIndex = 1;
            // 
            // txtLessonName
            // 
            txtLessonName.Location = new Point(6, 102);
            txtLessonName.Name = "txtLessonName";
            txtLessonName.Size = new Size(520, 47);
            txtLessonName.TabIndex = 1;
            // 
            // dtLessonDate
            // 
            dtLessonDate.Location = new Point(6, 196);
            dtLessonDate.Name = "dtLessonDate";
            dtLessonDate.Size = new Size(519, 47);
            dtLessonDate.TabIndex = 2;
            // 
            // btnSaveCourse
            // 
            btnSaveCourse.Location = new Point(41, 501);
            btnSaveCourse.Name = "btnSaveCourse";
            btnSaveCourse.Size = new Size(548, 75);
            btnSaveCourse.TabIndex = 0;
            btnSaveCourse.Text = "KURS KAYDET";
            btnSaveCourse.UseVisualStyleBackColor = true;
            btnSaveCourse.Click += btnSaveCourse_Click;
            // 
            // lstLessonList
            // 
            lstLessonList.FormattingEnabled = true;
            lstLessonList.ItemHeight = 40;
            lstLessonList.Location = new Point(1147, 45);
            lstLessonList.Name = "lstLessonList";
            lstLessonList.Size = new Size(313, 604);
            lstLessonList.TabIndex = 1;
            // 
            // btnAddLesson
            // 
            btnAddLesson.Location = new Point(1147, 655);
            btnAddLesson.Name = "btnAddLesson";
            btnAddLesson.Size = new Size(313, 87);
            btnAddLesson.TabIndex = 0;
            btnAddLesson.Text = "Ders Ekle";
            btnAddLesson.UseVisualStyleBackColor = true;
            btnAddLesson.Click += btnAddLesson_Click;
            // 
            // lstCourseList
            // 
            lstCourseList.FormattingEnabled = true;
            lstCourseList.ItemHeight = 40;
            lstCourseList.Location = new Point(41, 582);
            lstCourseList.Name = "lstCourseList";
            lstCourseList.Size = new Size(548, 164);
            lstCourseList.TabIndex = 1;
            lstCourseList.SelectedIndexChanged += lstCourseList_SelectedIndexChanged;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1479, 756);
            Controls.Add(lstCourseList);
            Controls.Add(lstLessonList);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnAddLesson);
            Controls.Add(btnSaveCourse);
            Font = new Font("Segoe UI", 22F);
            Margin = new Padding(7, 8, 7, 8);
            Name = "CourseForm";
            Text = "CourseForm";
            Load += CourseForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private TextBox txtCourseName;
        private GroupBox groupBox2;
        private Button btnSaveCourse;
        private Label label4;
        private Label label5;
        private TextBox txtLessonName;
        private DateTimePicker dtLessonDate;
        private ComboBox cmbInstructor;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox txtLessonContent;
        private TextBox txtLessonDuration;
        private MaskedTextBox txtLessonTime;
        private Label label9;
        private ListBox lstLessonList;
        private Button btnAddLesson;
        private ListBox lstCourseList;
    }
}