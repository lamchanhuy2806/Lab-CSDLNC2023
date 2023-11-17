namespace Lab01_3._2_ADB2023
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
            this.label_Course = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.cbx_Course = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(33, 143);
            this.dataGridView_Student.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(1084, 260);
            this.dataGridView_Student.TabIndex = 7;
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(416, 68);
            this.label_Course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(50, 16);
            this.label_Course.TabIndex = 6;
            this.label_Course.Text = "Course";
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_search.Location = new System.Drawing.Point(697, 56);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(87, 41);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // cbx_Course
            // 
            this.cbx_Course.FormattingEnabled = true;
            this.cbx_Course.Location = new System.Drawing.Point(471, 65);
            this.cbx_Course.Name = "cbx_Course";
            this.cbx_Course.Size = new System.Drawing.Size(203, 24);
            this.cbx_Course.TabIndex = 10;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 457);
            this.Controls.Add(this.cbx_Course);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.label_Course);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearch";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearch_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox cbx_Course;
    }
}