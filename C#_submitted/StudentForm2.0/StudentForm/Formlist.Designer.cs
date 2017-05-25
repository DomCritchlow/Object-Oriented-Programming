namespace StudentForm
{
    partial class Formlist
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
            this.listBox_student = new System.Windows.Forms.ListBox();
            this.Add_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Student_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_student
            // 
            this.listBox_student.FormattingEnabled = true;
            this.listBox_student.Location = new System.Drawing.Point(13, 13);
            this.listBox_student.Name = "listBox_student";
            this.listBox_student.Size = new System.Drawing.Size(246, 407);
            this.listBox_student.TabIndex = 0;
            this.listBox_student.SelectedIndexChanged += new System.EventHandler(this.listBox_student_SelectedIndexChanged);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(285, 396);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(83, 23);
            this.Add_button.TabIndex = 1;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(392, 395);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(86, 23);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(495, 396);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(85, 23);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Student_Label
            // 
            this.Student_Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Student_Label.Location = new System.Drawing.Point(285, 13);
            this.Student_Label.Name = "Student_Label";
            this.Student_Label.Size = new System.Drawing.Size(295, 366);
            this.Student_Label.TabIndex = 4;
            this.Student_Label.Text = "label1";
            this.Student_Label.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Formlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 437);
            this.Controls.Add(this.Student_Label);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.listBox_student);
            this.Name = "Formlist";
            this.Text = "Formlist";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_student;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label Student_Label;
    }
}