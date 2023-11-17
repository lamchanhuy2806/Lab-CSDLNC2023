namespace Lab01_3._1_ADB2023
{
    partial class FormSearchAge
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
            this.label_Id = new System.Windows.Forms.Label();
            this.dataGridView_Student = new System.Windows.Forms.DataGridView();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Location = new System.Drawing.Point(363, 82);
            this.label_Id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(32, 16);
            this.label_Id.TabIndex = 0;
            this.label_Id.Text = "Age";
            // 
            // dataGridView_Student
            // 
            this.dataGridView_Student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Student.Location = new System.Drawing.Point(91, 166);
            this.dataGridView_Student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView_Student.Name = "dataGridView_Student";
            this.dataGridView_Student.Size = new System.Drawing.Size(857, 260);
            this.dataGridView_Student.TabIndex = 1;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(417, 79);
            this.textBox_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(164, 22);
            this.textBox_Age.TabIndex = 4;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_search.Location = new System.Drawing.Point(644, 70);
            this.button_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(87, 41);
            this.button_search.TabIndex = 5;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // FormSearchAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 554);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.dataGridView_Student);
            this.Controls.Add(this.label_Id);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSearchAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSearchAge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSearchAge_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.DataGridView dataGridView_Student;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Button button_search;
    }
}