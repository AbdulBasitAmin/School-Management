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
    public partial class Insertform : Form
    {
        public Insertform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            student s = new student();


            s.s_fk = Convert.ToInt32(Form1.fk_id);

         s.s_date= System.DateTime.Now.ToShortDateString();


            s.s_name = textBox1.Text;

            s.s_fname = textBox2.Text;

            if (radioButton1.Checked==true)
            {
                s.s_gender = "male";
            }
            else if(radioButton2.Checked==true)

            {

                s.s_gender = "female";

            }
            else
            {

                MessageBox.Show("Please select gender");

            }

            s.s_address = richTextBox1.Text;

            insert i = new insert();
            MessageBox.Show(i.insert_stdrecord(s));
        }
    }
}
