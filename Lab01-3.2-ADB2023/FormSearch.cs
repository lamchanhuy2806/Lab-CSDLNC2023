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
    public partial class FormSearch : Form
    {
        IObjectContainer db = Manager.Database;
        public FormSearch()
        {
            InitializeComponent();
            var query = from c in db.Query<Course>() select c;

            // Duyệt qua kết quả của truy vấn và thêm các đối tượng vào combox
            foreach (var course in query)
            {
                cbx_Course.Items.Add(course.CourseName);
            }
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string name = cbx_Course.Text;

            if (cbx_Course.Text == "")
            {
                MessageBox.Show("Mời lựa Lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                List<Student> query = db.Query<Student>().Where(s => s.Course.CourseName == name).ToList<Student>();
                dataGridView_Student.DataSource = query.ToList();
                if (query.Count != 0)
                {
                    List<Student> Students = query.ToList();
                    dataGridView_Student.DataSource = Students;
                    dataGridView_Student.CellFormatting += (senders, q) =>
                    {
                        if (q.ColumnIndex == 6)
                        {
                            // Lấy đối tượng Student tương ứng với ô đang được định dạng
                            var student = Students[q.RowIndex];

                            // Hiển thị tên của khóa học
                            q.Value = student.Course.CourseName;
                        }
                    };
                }
                else
                {
                    MessageBox.Show("Hiện không có sv nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
                    
            }
        }
    }
}
