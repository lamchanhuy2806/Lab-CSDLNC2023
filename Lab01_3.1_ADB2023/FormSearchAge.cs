using Db4objects.Db4o;
using Db4objects.Db4o.Internal.Slots;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab01_3._1_ADB2023
{
    public partial class FormSearchAge : Form
    {

         IObjectContainer db = Manager.Database;




        public FormSearchAge()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            int age = Int32.Parse(textBox_Age.Text);
            if (textBox_Age.Text == "")
            {
                MessageBox.Show("Mời nhập Tuổi","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            else
            {
                List<Student> query = db.Query<Student>().Where(s => s.Age == age).ToList<Student>();
                dataGridView_Student.DataSource = query.ToList();
                
            }
            db.Close();
        }

        private void FormSearchAge_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }
    }
}
