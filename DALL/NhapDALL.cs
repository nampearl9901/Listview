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
    public class NhapDALL :DataacessDAL
    {

        List<Nhap> dsn = new List<Nhap>();
        public List<Nhap> laytoanbonhap()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Nhap";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int manhap = reader.GetInt32(0);

                DateTime ngaynhap = reader.GetDateTime(1);

                int manvnhap = reader.GetInt32(2);
                int manccnhap = reader.GetInt32(3);


                Nhap n = new Nhap();

                n.Manhap = manhap;
                n.Ngaynhap = ngaynhap;
                n.Manv = manvnhap;
                n.Mancc = manccnhap;




                dsn.Add(n);

            }
            reader.Close();
            return dsn;
        }
        public bool Themnhap(Nhap n)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Nhap VALUES(@manhap,@ngaynhap,@manvnhap,@manccnhap)";
            command.Connection = conn;

            command.Parameters.Add("@manhap", SqlDbType.Int).Value = n.Manhap;
            command.Parameters.Add("@ngaynhap", SqlDbType.DateTime).Value = n.Ngaynhap;
            command.Parameters.Add("@manvnhap", SqlDbType.Int).Value = n.Manv;
            command.Parameters.Add("@manccnhap", SqlDbType.Int).Value = n.Mancc;



            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Xoanhap(int manhap)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Nhap where Manhap = @manhap";
            command.Connection = conn;
            command.Parameters.Add("@manhap", SqlDbType.Int).Value = manhap;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
    }
}
