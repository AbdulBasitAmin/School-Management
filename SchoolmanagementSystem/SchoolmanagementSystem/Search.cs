using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolmanagementSystem
{
    public partial class Search : Form
    {

        viewclass vc = new viewclass();
        string q; 
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            q = "select std_id,std_name,std_fname,gender,std_address,std_admission_date,ad_name from student s inner join adminn a on a.ad_id = s.std_id_fk_id where s.std_id=" + textBox1.Text;
            dataGridView1.DataSource = vc.showrecords(q);
        }

        private void Search_Load(object sender, EventArgs e)
        {
            q = "select std_id,std_name,std_fname,gender,std_address,std_admission_date,ad_name from student s inner join adminn a on a.ad_id = s.std_id_fk_id ";
            dataGridView1.DataSource = vc.showrecords(q);

            returnclass rc = new returnclass();
        }
    }
}
