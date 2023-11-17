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
using System.Xml.Linq;

namespace Lab01_3._2_ADB2023
{
    public partial class ManagerStudent : Form
    {
        IObjectContainer db = Manager.Database;
        public ManagerStudent()
        {
            InitializeComponent();
            var query = from c in db.Query<Course>() select c;

            // Duyệt qua kết quả của truy vấn và thêm các đối tượng vào combox
            foreach (var course in query)
            {
                cbx_Course.Items.Add(course.CourseName);
            }
            UploadForm();

        }
        private void ManagerStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
            this.Hide();
            Form1 ManagerCourse = new Form1();
            ManagerCourse.ShowDialog();
            this.Close();
        }
        private void UploadForm()
        {
            textBox_Id.ReadOnly = false; 
            List<Student> query = db.Query<Student>().ToList<Student>();
            if (query.Count != 0)
            {
                List<Student> Students = query.ToList();
                dataGridView_Student.DataSource = Students;
                dataGridView_Student.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == 6)
                    {
                        // Lấy đối tượng Student tương ứng với ô đang được định dạng
                        var student = Students[e.RowIndex];

                        // Hiển thị tên của khóa học
                        e.Value = student.Course.CourseName;
                    }
                };
            }
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            string firstname = textBox_FName.Text;
            string lastname = textBox_LName.Text;
            DateTime yearofadmission = dateTimePicker_YoA.Value;
            DateTime dateofbirth = dateTimePicker_DoB.Value;
            int age = DateTime.Now.Year - dateofbirth.Year;
            string coursename = cbx_Course.Text;  
            Course chooseCourse =  db.Query<Course>().Where(p => p.CourseName == coursename).Single(); 
            if (id.Length > 0 && firstname.Length > 0 && lastname.Length > 0
                    && age > 0)
            { 
                db.Store(new Student(id, firstname, lastname, yearofadmission, dateofbirth, age, chooseCourse));
                db.Commit();
                UploadForm();
            }
        }

        private void dataGridView_Student_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1) return;
            DataGridViewRow dataGridViewRow = dataGridView_Student.Rows[e.RowIndex];

            button_delete.Enabled = true;
            textBox_Id.Text = dataGridViewRow.Cells[0].Value.ToString();
            textBox_FName.Text = dataGridViewRow.Cells[1].Value.ToString();
            textBox_LName.Text = dataGridViewRow.Cells[2].Value.ToString();
            dateTimePicker_YoA.Value = Convert.ToDateTime(dataGridViewRow.Cells[3].Value.ToString());
            dateTimePicker_DoB.Value = Convert.ToDateTime(dataGridViewRow.Cells[4].Value.ToString());

        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            List<Student> query = db.Query<Student>().Where(s => s.Id == id).ToList<Student>();
            String message = "Bạn có chắc xoá Mã sinh viên: " + id + " ?";
            String title = "Thông Báo!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Student a = query[0];
                db.Delete(a);
                db.Commit();

                UploadForm();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            string firstname = textBox_FName.Text;
            string lastname = textBox_LName.Text;
            DateTime yearofadmission = dateTimePicker_YoA.Value;
            DateTime dateofbirth = dateTimePicker_DoB.Value;
            int age = DateTime.Now.Year - dateofbirth.Year;
            string coursename = cbx_Course.Text;
            Course chooseCourse = db.Query<Course>().Where(p => p.CourseName == coursename).Single();

            Student foundStudent = db.Query<Student>().Where(p => p.Id == id).Single();
            foundStudent.Id = id;
            foundStudent.FirstName = firstname;
            foundStudent.LastName = lastname;
            foundStudent.YearOfAdmission = yearofadmission;
            foundStudent.DateOfBirth = dateofbirth;
            foundStudent.Age = age;
            foundStudent.Course= chooseCourse;
            db.Store(foundStudent);
            db.Commit();
            UploadForm();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            db.Close();
            FormSearch FormSearch = new FormSearch();
            FormSearch.ShowDialog();
        }
    }
}
