﻿namespace Lab01_3._1_ADB2023
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
            this.groupStudentBox = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_DoB = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_YoA = new System.Windows.Forms.DateTimePicker();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.YoALabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupStudentBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // groupStudentBox
            // 
            this.groupStudentBox.Controls.Add(this.dateTimePicker_DoB);
            this.groupStudentBox.Controls.Add(this.dateTimePicker_YoA);
            this.groupStudentBox.Controls.Add(this.textBox_LName);
            this.groupStudentBox.Controls.Add(this.textBox_Id);
            this.groupStudentBox.Controls.Add(this.textBox_FName);
            this.groupStudentBox.Controls.Add(this.DoBLabel);
            this.groupStudentBox.Controls.Add(this.YoALabel);
            this.groupStudentBox.Controls.Add(this.LNameLabel);
            this.groupStudentBox.Controls.Add(this.FNameLabel);
            this.groupStudentBox.Controls.Add(this.IdLabel);
            this.groupStudentBox.Location = new System.Drawing.Point(33, 47);
            this.groupStudentBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupStudentBox.Name = "groupStudentBox";
            this.groupStudentBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupStudentBox.Size = new System.Drawing.Size(679, 202);
            this.groupStudentBox.TabIndex = 0;
            this.groupStudentBox.TabStop = false;
            this.groupStudentBox.Text = "Student";
            // 
            // dateTimePicker_DoB
            // 
            this.dateTimePicker_DoB.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker_DoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_DoB.Location = new System.Drawing.Point(492, 92);
            this.dateTimePicker_DoB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_DoB.Name = "dateTimePicker_DoB";
            this.dateTimePicker_DoB.Size = new System.Drawing.Size(133, 22);
            this.dateTimePicker_DoB.TabIndex = 4;
            // 
            // dateTimePicker_YoA
            // 
            this.dateTimePicker_YoA.CustomFormat = "yyyy";
            this.dateTimePicker_YoA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_YoA.Location = new System.Drawing.Point(492, 47);
            this.dateTimePicker_YoA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_YoA.Name = "dateTimePicker_YoA";
            this.dateTimePicker_YoA.Size = new System.Drawing.Size(116, 22);
            this.dateTimePicker_YoA.TabIndex = 5;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(101, 139);
            this.textBox_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(164, 22);
            this.textBox_LName.TabIndex = 5;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(101, 47);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(164, 22);
            this.textBox_Id.TabIndex = 3;
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(101, 92);
            this.textBox_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(164, 22);
            this.textBox_FName.TabIndex = 4;
            // 
            // DoBLabel
            // 
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.Location = new System.Drawing.Point(387, 92);
            this.DoBLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(75, 16);
            this.DoBLabel.TabIndex = 4;
            this.DoBLabel.Text = "DateOfBirth";
            // 
            // YoALabel
            // 
            this.YoALabel.AutoSize = true;
            this.YoALabel.Location = new System.Drawing.Point(345, 50);
            this.YoALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YoALabel.Name = "YoALabel";
            this.YoALabel.Size = new System.Drawing.Size(118, 16);
            this.YoALabel.TabIndex = 3;
            this.YoALabel.Text = "Year Of Admission";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(21, 143);
            this.LNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(69, 16);
            this.LNameLabel.TabIndex = 2;
            this.LNameLabel.Text = "LastName";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(23, 96);
            this.FNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(69, 16);
            this.FNameLabel.TabIndex = 1;
            this.FNameLabel.Text = "FirstName";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(61, 50);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 16);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_add.Location = new System.Drawing.Point(748, 73);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(87, 41);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightCoral;
            this.button_delete.Location = new System.Drawing.Point(965, 73);
            this.button_delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(87, 41);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(33, 255);
            this.dataGridView_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.RowHeadersWidth = 51;
            this.dataGridView_Student.RowTemplate.Height = 24;
            this.dataGridView_Student.Size = new System.Drawing.Size(1004, 262);
            this.dataGridView_Student.TabIndex = 4;
            this.dataGridView_Student.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Student_CellMouseClick);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.LemonChiffon;
            this.button_Update.Location = new System.Drawing.Point(857, 73);
            this.button_Update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(87, 41);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Search.Location = new System.Drawing.Point(799, 153);
            this.button_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(81, 49);
            this.button_Search.TabIndex = 6;
            this.button_Search.Text = "SearchById";
            this.button_Search.UseVisualStyleBackColor = false;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button1.Location = new System.Drawing.Point(928, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "SearchByAge";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.groupStudentBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupStudentBox.ResumeLayout(false);
            this.groupStudentBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupStudentBox;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label YoALabel;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DoB;
        private System.Windows.Forms.DateTimePicker dateTimePicker_YoA;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button1;
    }
}

