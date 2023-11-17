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
    public partial class FormSearchId : Form
    {

         IObjectContainer db = Manager.Database;
        public FormSearchId()
        {
            InitializeComponent();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string id = textBox_Id.Text;
            if (id == "")
            {
                MessageBox.Show("Mời nhập Id","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
            else
            {
                List<Student> query = db.Query<Student>().Where(s => s.Id == id).ToList<Student>();
                dataGridView_Student.DataSource = query.ToList();
                
            }
      
        }

        private void FormSearchId_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Close();
        }

        
    }
}
