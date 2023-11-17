using Db4objects.Db4o;
using Db4objects.Db4o.Internal.Slots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab01_3._1_ADB2023
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
            
            button_delete.Enabled= false; 
            UploadForm();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            string firstname = textBox_FName.Text;
            string lastname = textBox_LName.Text;
            DateTime yearofadmission = dateTimePicker_YoA.Value;
            DateTime dateofbirth = dateTimePicker_DoB.Value;
            int age = DateTime.Now.Year - dateofbirth.Year;
            //int age = Int32.Parse(textBox_Age.Text);
            if (id.Length > 0 && firstname.Length > 0 && lastname.Length > 0 
                    && age > 0)
            {
                db.Store(new Student(id, firstname, lastname, yearofadmission, dateofbirth, age));
                db.Commit();
                UploadForm();
            }
        }
        private void UploadForm()
        {
            textBox_Id.ReadOnly = false; 
            List<Student> query = db.Query<Student>().ToList<Student>();
            if (query.Count != 0)
            {
                List<Student> Students = query.ToList();
                dataGridView_Student.DataSource = Students;
            }
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


            Student foundStudent = db.Query<Student>().Where(p => p.Id == id).Single();
            foundStudent.Id= id;
            foundStudent.FirstName= firstname;
            foundStudent.LastName= lastname;
            foundStudent.YearOfAdmission= yearofadmission;
            foundStudent.DateOfBirth= dateofbirth;
            foundStudent.Age= age;
            db.Store(foundStudent); 
            db.Commit();
            UploadForm();

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

        private void button_Search_Click(object sender, EventArgs e)
        {
            db.Close();
            FormSearchId FormSearchId = new FormSearchId();
            FormSearchId.ShowDialog(); 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Close();
            FormSearchAge FormSearchAge = new FormSearchAge();
            FormSearchAge.ShowDialog(); 
        }

       
    }
}
