using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SchoolmanagementSystem
{
    class returnclass
    {
        private string connstring = ConfigurationManager.ConnectionStrings["TESTDB"].ConnectionString;
            public string scalerReturn(string q)
        {
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
            SqlCommand cmd = new SqlCommand(q, conn);
            string s = cmd.ExecuteScalar().ToString();
            return s;




        }




    }
}
