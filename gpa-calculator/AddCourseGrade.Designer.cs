namespace gpa_calculator
{
    partial class AddCourseGrade
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
            this.Course1 = new System.Windows.Forms.ComboBox();
            this.Grade1 = new System.Windows.Forms.ComboBox();
            this.Course2 = new System.Windows.Forms.ComboBox();
            this.Grade3 = new System.Windows.Forms.ComboBox();
            this.Course3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grade2 = new System.Windows.Forms.ComboBox();
            this.AddCourse = new System.Windows.Forms.Button();
            this.CalcGPA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Course1
            // 
            this.Course1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course1.FormattingEnabled = true;
            this.Course1.Location = new System.Drawing.Point(36, 60);
            this.Course1.Name = "Course1";
            this.Course1.Size = new System.Drawing.Size(121, 21);
            this.Course1.TabIndex = 0;
            // 
            // Grade1
            // 
            this.Grade1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Grade1.FormattingEnabled = true;
            this.Grade1.Location = new System.Drawing.Point(190, 60);
            this.Grade1.Name = "Grade1";
            this.Grade1.Size = new System.Drawing.Size(121, 21);
            this.Grade1.TabIndex = 1;
            this.Grade1.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Grade1_Format);
            // 
            // Course2
            // 
            this.Course2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course2.FormattingEnabled = true;
            this.Course2.Location = new System.Drawing.Point(36, 110);
            this.Course2.Name = "Course2";
            this.Course2.Size = new System.Drawing.Size(121, 21);
            this.Course2.TabIndex = 2;
            // 
            // Grade3
            // 
            this.Grade3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Grade3.FormattingEnabled = true;
            this.Grade3.Location = new System.Drawing.Point(190, 160);
            this.Grade3.Name = "Grade3";
            this.Grade3.Size = new System.Drawing.Size(121, 21);
            this.Grade3.TabIndex = 4;
            this.Grade3.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Grade1_Format);
            // 
            // Course3
            // 
            this.Course3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Course3.FormattingEnabled = true;
            this.Course3.Location = new System.Drawing.Point(36, 160);
            this.Course3.Name = "Course3";
            this.Course3.Size = new System.Drawing.Size(121, 21);
            this.Course3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grade";
            // 
            // Grade2
            // 
            this.Grade2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Grade2.FormattingEnabled = true;
            this.Grade2.Location = new System.Drawing.Point(190, 110);
            this.Grade2.Name = "Grade2";
            this.Grade2.Size = new System.Drawing.Size(121, 21);
            this.Grade2.TabIndex = 3;
            this.Grade2.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.Grade1_Format);
            // 
            // AddCourse
            // 
            this.AddCourse.Location = new System.Drawing.Point(81, 305);
            this.AddCourse.Name = "AddCourse";
            this.AddCourse.Size = new System.Drawing.Size(181, 49);
            this.AddCourse.TabIndex = 8;
            this.AddCourse.Text = "Add another course";
            this.AddCourse.UseVisualStyleBackColor = true;
            this.AddCourse.Click += new System.EventHandler(this.AddCourse_Click);
            // 
            // CalcGPA
            // 
            this.CalcGPA.Location = new System.Drawing.Point(489, 34);
            this.CalcGPA.Name = "CalcGPA";
            this.CalcGPA.Size = new System.Drawing.Size(177, 26);
            this.CalcGPA.TabIndex = 9;
            this.CalcGPA.Text = "calculate gpa";
            this.CalcGPA.UseVisualStyleBackColor = true;
            this.CalcGPA.Click += new System.EventHandler(this.CalcGPA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(483, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 63);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // AddCourseGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalcGPA);
            this.Controls.Add(this.AddCourse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Course3);
            this.Controls.Add(this.Grade3);
            this.Controls.Add(this.Grade2);
            this.Controls.Add(this.Course2);
            this.Controls.Add(this.Grade1);
            this.Controls.Add(this.Course1);
            this.Name = "AddCourseGrade";
            this.Text = "Add Your Courses and their Grades";
            this.Load += new System.EventHandler(this.AddCourseGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Course1;
        private System.Windows.Forms.ComboBox Grade1;
        private System.Windows.Forms.ComboBox Course2;
        private System.Windows.Forms.ComboBox Grade3;
        private System.Windows.Forms.ComboBox Course3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Grade2;
        private System.Windows.Forms.Button AddCourse;
        private System.Windows.Forms.Button CalcGPA;
        private System.Windows.Forms.Label label3;
    }
}