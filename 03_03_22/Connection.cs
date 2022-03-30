using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace _03_03_22
{
    public class Connection
    {
        public static string con = @"Server=ONURP;Database=KUTUPHANE_DB;User Id=sa;Password=123;";
        
        public static void ConnectionCntrl(SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.ConnectionString = Connection.con;
                con.Open();
            }
        }
    }


}
