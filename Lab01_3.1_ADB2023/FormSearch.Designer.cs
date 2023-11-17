namespace Lab01_3._1_ADB2023
{
    partial class FormSearch
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
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.groupStudentBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker_YoA = new System.Windows.Forms.DateTimePicker();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.button_SearchFull = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.groupStudentBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.AllowUserToAddRows = false;
            this.dataGridView_Student.AllowUserToDeleteRows = false;
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(28, 191);
            this.dataGridView_Student.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.ReadOnly = true;
            this.dataGridView_Student.RowHeadersWidth = 51;
            this.dataGridView_Student.Size = new System.Drawing.Size(841, 260);
            this.dataGridView_Student.TabIndex = 2;
            // 
            // groupStudentBox
            // 
            this.groupStudentBox.Controls.Add(this.checkBox1);
            this.groupStudentBox.Controls.Add(this.dateTimePicker_YoA);
            this.groupStudentBox.Controls.Add(this.textBox_LName);
            this.groupStudentBox.Controls.Add(this.textBox_Id);
            this.groupStudentBox.Controls.Add(this.textBox_FName);
            this.groupStudentBox.Controls.Add(this.LNameLabel);
            this.groupStudentBox.Controls.Add(this.FNameLabel);
            this.groupStudentBox.Controls.Add(this.IdLabel);
            this.groupStudentBox.Location = new System.Drawing.Point(28, 38);
            this.groupStudentBox.Margin = new System.Windows.Forms.Padding(4);
            this.groupStudentBox.Name = "groupStudentBox";
            this.groupStudentBox.Padding = new System.Windows.Forms.Padding(4);
            this.groupStudentBox.Size = new System.Drawing.Size(545, 132);
            this.groupStudentBox.TabIndex = 3;
            this.groupStudentBox.TabStop = false;
            this.groupStudentBox.Text = "Student";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(13, 87);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Year Of Admission";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dateTimePicker_YoA
            // 
            this.dateTimePicker_YoA.Checked = false;
            this.dateTimePicker_YoA.CustomFormat = "yyyy";
            this.dateTimePicker_YoA.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_YoA.Location = new System.Drawing.Point(160, 87);
            this.dateTimePicker_YoA.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_YoA.Name = "dateTimePicker_YoA";
            this.dateTimePicker_YoA.ShowUpDown = true;
            this.dateTimePicker_YoA.Size = new System.Drawing.Size(78, 22);
            this.dateTimePicker_YoA.TabIndex = 5;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(350, 83);
            this.textBox_LName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(164, 22);
            this.textBox_LName.TabIndex = 5;
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(64, 33);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.Size = new System.Drawing.Size(174, 22);
            this.textBox_Id.TabIndex = 3;
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(350, 36);
            this.textBox_FName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(164, 22);
            this.textBox_FName.TabIndex = 4;
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(270, 87);
            this.LNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(69, 16);
            this.LNameLabel.TabIndex = 2;
            this.LNameLabel.Text = "LastName";
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.Location = new System.Drawing.Point(272, 40);
            this.FNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(69, 16);
            this.FNameLabel.TabIndex = 1;
            this.FNameLabel.Text = "FirstName";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(36, 37);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 16);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id";
            // 
            // button_SearchFull
            // 
            this.button_SearchFull.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_SearchFull.Location = new System.Drawing.Point(603, 78);
            this.button_SearchFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_SearchFull.Name = "button_SearchFull";
            this.button_SearchFull.Size = new System.Drawing.Size(81, 49);
            this.button_SearchFull.TabIndex = 9;
            this.button_SearchFull.Text = "Search";
            this.button_SearchFull.UseVisualStyleBackColor = false;
            this.button_SearchFull.Click += new System.EventHandler(this.button_SearchFull_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 479);
            this.Controls.Add(this.button_SearchFull);
            this.Controls.Add(this.groupStudentBox);
            this.Controls.Add(this.dataGridView_Student);
            this.Name = "FormSearch";
            this.Text = "FormSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.groupStudentBox.ResumeLayout(false);
            this.groupStudentBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.GroupBox groupStudentBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker_YoA;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Button button_SearchFull;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}