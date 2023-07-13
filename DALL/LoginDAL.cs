using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class LoginDAL : DataacessDAL
    {
        List<login> dstk = new List<login>();
        public List<login> laytaikhoan()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from taikhoan";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
              
                string taikhoan = reader.GetString(0);
                string matkhau = reader.GetString(1);

                login tk = new login();

                tk.TaiKhoan = taikhoan;
                tk.matKhau = matkhau;

              
                dstk.Add(tk);
                

            }
            reader.Close();
            return dstk;
        }
        public bool Themtaikhoan(login lg)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO taikhoan VALUES(@taikhoan,@matkhau)";
            command.Connection = conn;

            command.Parameters.Add("@taikhoan", SqlDbType.NVarChar).Value = lg.TaiKhoan;
            command.Parameters.Add("@matkhau", SqlDbType.VarChar).Value = lg.matKhau;
           



            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

    }
}
