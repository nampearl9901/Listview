using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DALL
{
    public class DataacessDAL
    {
        public SqlConnection conn = null;
        string strconec = @"server = MSI\SQLSERVER; Database=quanlyxe; User ID = sa; PWd=1";
        public void Moketnoi()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strconec);
            }    
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }    

        }
        public void Dongketnoi()
        {
            if(conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();

            }    
        }
    }
}
