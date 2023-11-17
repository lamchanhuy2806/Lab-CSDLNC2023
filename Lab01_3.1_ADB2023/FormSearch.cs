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

namespace Lab01_3._1_ADB2023
{
    public partial class FormSearch : Form
    {
        IObjectContainer db = Manager.Database;
        public FormSearch()
        {
            InitializeComponent();
        }

        private void button_SearchFull_Click(object sender, EventArgs e)
        {    
            string fname = textBox_FName.Text;
            string lname = textBox_LName.Text;
            string id = textBox_Id.Text;
            int year = dateTimePicker_YoA.Value.Year;
            List<Student> query = db.Query<Student>().ToList<Student>();
            if (id != "")
            {
                query = query.Where(s => s.Id == id).ToList<Student>();
            }
            if(fname != "")
            {
                query = query.Where(s => s.FirstName == fname).ToList<Student>();
            }
            if (lname != "")
            {
                query = query.Where(s => s.LastName == lname).ToList<Student>();
            }
            if (year != 0)
            {
                query = query.Where(s => s.YearOfAdmission.Year == year).ToList<Student>();
            }
            dataGridView_Student.DataSource = query.ToList();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            List<Student> query = db.Query<Student>().ToList<Student>();
            if (query.Count != 0)
            {
                List<Student> Students = query.ToList();
                dataGridView_Student.DataSource = Students;
            }
        }

        private void FormSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }


    }
}
