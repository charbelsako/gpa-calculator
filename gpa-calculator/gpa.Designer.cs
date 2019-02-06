namespace gpa_calculator
{
    partial class gpa
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CurrGpaLabel = new System.Windows.Forms.Label();
            this.CumGpaLabel = new System.Windows.Forms.Label();
            this.CurrGpa = new System.Windows.Forms.Label();
            this.CumGpa = new System.Windows.Forms.Label();
            this.StudentId = new System.Windows.Forms.TextBox();
            this.StudentIdLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.AddGrade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(45, 59);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(173, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(42, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(85, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Enter name here";
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // CurrGpaLabel
            // 
            this.CurrGpaLabel.AutoSize = true;
            this.CurrGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrGpaLabel.Location = new System.Drawing.Point(40, 257);
            this.CurrGpaLabel.Name = "CurrGpaLabel";
            this.CurrGpaLabel.Size = new System.Drawing.Size(124, 25);
            this.CurrGpaLabel.TabIndex = 2;
            this.CurrGpaLabel.Text = "Current GPA";
            // 
            // CumGpaLabel
            // 
            this.CumGpaLabel.AutoSize = true;
            this.CumGpaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CumGpaLabel.Location = new System.Drawing.Point(40, 300);
            this.CumGpaLabel.Name = "CumGpaLabel";
            this.CumGpaLabel.Size = new System.Drawing.Size(157, 25);
            this.CumGpaLabel.TabIndex = 3;
            this.CumGpaLabel.Text = "Cumulative GPA";
            // 
            // CurrGpa
            // 
            this.CurrGpa.AutoSize = true;
            this.CurrGpa.Location = new System.Drawing.Point(193, 266);
            this.CurrGpa.Name = "CurrGpa";
            this.CurrGpa.Size = new System.Drawing.Size(35, 13);
            this.CurrGpa.TabIndex = 4;
            this.CurrGpa.Text = "label3";
            // 
            // CumGpa
            // 
            this.CumGpa.AutoSize = true;
            this.CumGpa.Location = new System.Drawing.Point(213, 309);
            this.CumGpa.Name = "CumGpa";
            this.CumGpa.Size = new System.Drawing.Size(35, 13);
            this.CumGpa.TabIndex = 5;
            this.CumGpa.Text = "label4";
            // 
            // StudentId
            // 
            this.StudentId.Location = new System.Drawing.Point(45, 124);
            this.StudentId.Name = "StudentId";
            this.StudentId.Size = new System.Drawing.Size(173, 20);
            this.StudentId.TabIndex = 6;
            // 
            // StudentIdLabel
            // 
            this.StudentIdLabel.AutoSize = true;
            this.StudentIdLabel.Location = new System.Drawing.Point(42, 108);
            this.StudentIdLabel.Name = "StudentIdLabel";
            this.StudentIdLabel.Size = new System.Drawing.Size(84, 13);
            this.StudentIdLabel.TabIndex = 7;
            this.StudentIdLabel.Text = "Enter Student Id";
            this.StudentIdLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(45, 172);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(173, 39);
            this.Register.TabIndex = 8;
            this.Register.Text = "Register or Get GPA";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddGrade
            // 
            this.AddGrade.Location = new System.Drawing.Point(327, 43);
            this.AddGrade.Name = "AddGrade";
            this.AddGrade.Size = new System.Drawing.Size(224, 45);
            this.AddGrade.TabIndex = 9;
            this.AddGrade.Text = "Add new grade";
            this.AddGrade.UseVisualStyleBackColor = true;
            this.AddGrade.Click += new System.EventHandler(this.AddGrade_Click);
            // 
            // gpa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 334);
            this.Controls.Add(this.AddGrade);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.StudentIdLabel);
            this.Controls.Add(this.StudentId);
            this.Controls.Add(this.CumGpa);
            this.Controls.Add(this.CurrGpa);
            this.Controls.Add(this.CumGpaLabel);
            this.Controls.Add(this.CurrGpaLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Name = "gpa";
            this.Text = "Save & Calculate Current and Cumulative GPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CurrGpaLabel;
        private System.Windows.Forms.Label CumGpaLabel;
        private System.Windows.Forms.Label CurrGpa;
        private System.Windows.Forms.Label CumGpa;
        private System.Windows.Forms.TextBox StudentId;
        private System.Windows.Forms.Label StudentIdLabel;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button AddGrade;
    }
}

