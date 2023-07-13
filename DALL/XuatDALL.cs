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
   public class XuatDALL :DataacessDAL
    {
        List<Xuat> dsx = new List<Xuat>();
        public List<Xuat> laytoanboxuat()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Xuat";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maxuat = reader.GetInt32(0);

                DateTime ngayxuat = reader.GetDateTime(1);

                int manvxuat = reader.GetInt32(2);



                Xuat x = new Xuat();

                x.Maxuat = maxuat;
                x.Ngayxuat = ngayxuat;
                x.Manv = manvxuat;
               
                


                dsx.Add(x);

            }
            reader.Close();
            return dsx;
        }
        public bool Themxuat(Xuat x)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Xuat VALUES(@maxuat,@ngayxuat,@manvxuat)";
            command.Connection = conn;

            command.Parameters.Add("@maxuat", SqlDbType.Int).Value =x.Maxuat;
            command.Parameters.Add("@ngayxuat", SqlDbType.DateTime).Value = x.Ngayxuat;
            command.Parameters.Add("@manvxuat", SqlDbType.Int).Value = x.Manv;


            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Xoaxuat(int maxuat)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Xuat where Maxuat = @maxuat";
            command.Connection = conn;
            command.Parameters.Add("@maxuat", SqlDbType.Int).Value = maxuat;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
