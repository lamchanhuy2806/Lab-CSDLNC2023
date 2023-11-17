using Db4objects.Db4o;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_3._2_ADB2023
{
    public partial class Form1 : Form
    {
        IObjectContainer db = Manager.Database;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UploadForm();
        }
        private void UploadForm()
        {
            List<Course> query = db.Query<Course>().ToList<Course>();
            if (query.Count != 0)
            {
                List<Course> Course = query.ToList();
                dataGridView_Course.DataSource = Course;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string code = textBox_CourseCode.Text;
            string name = textBox_CourseName.Text;
            if (code.Length > 0 && name.Length > 0 )
            {
                db.Store(new Course(code, name));
                db.Commit();
                UploadForm();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string code = textBox_CourseCode.Text;
            string name = textBox_CourseName.Text;
            List<Course> query = db.Query<Course>().Where(s => s.CourseCode == code).ToList<Course>();
            String message = "Bạn có chắc xoá Mã sinh viên: " + name + " ?";
            String title = "Thông Báo!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                textBox_CourseCode.Text = "";
                textBox_CourseName.Text = "";
                Course a = query[0];
                db.Delete(a);
                db.Commit();

                UploadForm();
            }
        }

        private void dataGridView_Course_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridView_Course.Rows[e.RowIndex];

            button_delete.Enabled = true;
            textBox_CourseCode.Text = dataGridViewRow.Cells[0].Value.ToString();
            textBox_CourseName.Text = dataGridViewRow.Cells[1].Value.ToString();

        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string code = textBox_CourseCode.Text;
            string name = textBox_CourseName.Text;


            Course foundCourse = db.Query<Course>().Where(p => p.CourseCode == code).Single();
            foundCourse.CourseCode = code;
            foundCourse.CourseName = name; 
            db.Store(foundCourse);
            db.Commit();
            UploadForm();
        }

        private void button_MStudent_Click(object sender, EventArgs e)
        {
            db.Close();
            this.Hide();
            ManagerStudent ManagerStudent = new ManagerStudent();
            ManagerStudent.ShowDialog();
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
            this.Hide();
            this.Close();
        }
    }
}
