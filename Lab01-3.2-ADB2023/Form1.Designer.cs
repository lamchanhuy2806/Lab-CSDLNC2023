namespace Lab01_3._2_ADB2023
{
    partial class Form1
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
            this.groupCourseBox = new System.Windows.Forms.GroupBox();
            this.button_MStudent = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_CourseCode = new System.Windows.Forms.TextBox();
            this.textBox_CourseName = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseCodeLabel = new System.Windows.Forms.Label();
            this.dataGridView_Course = new System.Windows.Forms.DataGridView();
            this.groupCourseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).BeginInit();
            this.SuspendLayout();
            // 
            // groupCourseBox
            // 
            this.groupCourseBox.Controls.Add(this.button_MStudent);
            this.groupCourseBox.Controls.Add(this.button_Update);
            this.groupCourseBox.Controls.Add(this.button_delete);
            this.groupCourseBox.Controls.Add(this.button_add);
            this.groupCourseBox.Controls.Add(this.textBox_CourseCode);
            this.groupCourseBox.Controls.Add(this.textBox_CourseName);
            this.groupCourseBox.Controls.Add(this.CourseNameLabel);
            this.groupCourseBox.Controls.Add(this.CourseCodeLabel);
            this.groupCourseBox.Location = new System.Drawing.Point(48, 23);
            this.groupCourseBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupCourseBox.Name = "groupCourseBox";
            this.groupCourseBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupCourseBox.Size = new System.Drawing.Size(610, 198);
            this.groupCourseBox.TabIndex = 1;
            this.groupCourseBox.TabStop = false;
            this.groupCourseBox.Text = "Course";
            // 
            // button_MStudent
            // 
            this.button_MStudent.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_MStudent.Location = new System.Drawing.Point(470, 127);
            this.button_MStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_MStudent.Name = "button_MStudent";
            this.button_MStudent.Size = new System.Drawing.Size(78, 41);
            this.button_MStudent.TabIndex = 9;
            this.button_MStudent.Text = "Manager Student";
            this.button_MStudent.UseVisualStyleBackColor = false;
            this.button_MStudent.Click += new System.EventHandler(this.button_MStudent_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Update.Location = new System.Drawing.Point(242, 127);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(87, 41);
            this.button_Update.TabIndex = 8;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Location = new System.Drawing.Point(350, 127);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 41);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.Location = new System.Drawing.Point(133, 127);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 41);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_CourseCode
            // 
            this.textBox_CourseCode.Location = new System.Drawing.Point(101, 47);
            this.textBox_CourseCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CourseCode.Name = "textBox_CourseCode";
            this.textBox_CourseCode.Size = new System.Drawing.Size(164, 20);
            this.textBox_CourseCode.TabIndex = 3;
            // 
            // textBox_CourseName
            // 
            this.textBox_CourseName.Location = new System.Drawing.Point(400, 50);
            this.textBox_CourseName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_CourseName.Name = "textBox_CourseName";
            this.textBox_CourseName.Size = new System.Drawing.Size(164, 20);
            this.textBox_CourseName.TabIndex = 4;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(322, 54);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(68, 13);
            this.CourseNameLabel.TabIndex = 1;
            this.CourseNameLabel.Text = "CourseName";
            // 
            // CourseCodeLabel
            // 
            this.CourseCodeLabel.AutoSize = true;
            this.CourseCodeLabel.Location = new System.Drawing.Point(29, 50);
            this.CourseCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CourseCodeLabel.Name = "CourseCodeLabel";
            this.CourseCodeLabel.Size = new System.Drawing.Size(65, 13);
            this.CourseCodeLabel.TabIndex = 0;
            this.CourseCodeLabel.Text = "CourseCode";
            // 
            // dataGridView_Course
            // 
            this.dataGridView_Course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Course.Location = new System.Drawing.Point(181, 246);
            this.dataGridView_Course.Name = "dataGridView_Course";
            this.dataGridView_Course.Size = new System.Drawing.Size(372, 177);
            this.dataGridView_Course.TabIndex = 2;
            this.dataGridView_Course.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Course_CellMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_Course);
            this.Controls.Add(this.groupCourseBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupCourseBox.ResumeLayout(false);
            this.groupCourseBox.PerformLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupCourseBox;
        private System.Windows.Forms.TextBox textBox_CourseCode;
        private System.Windows.Forms.TextBox textBox_CourseName;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseCodeLabel;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_MStudent;
        private System.Windows.Forms.DataGridView dataGridView_Course;
    }
}

