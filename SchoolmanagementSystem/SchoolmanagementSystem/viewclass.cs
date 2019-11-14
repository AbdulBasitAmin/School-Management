using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolmanagementSystem
{
    class viewclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;

        public DataTable showrecords(string query)
        {

            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstring);
            SqlCommand cmd = new SqlCommand(query,conn);


            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Load(dr);
                }
                else
                {

                    MessageBox.Show("No Record Found.........................");


                }

            }
            catch (Exception)
            {
                MessageBox.Show("No Record Found.........................");

            }


            finally
            {

                conn.Close();
            }



            return dt; 

        }

       

    }
}
