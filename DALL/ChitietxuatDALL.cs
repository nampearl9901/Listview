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
    public class ChitietxuatDALL : DataacessDAL
    {
        List<Chitietxuat> dsctx = new List<Chitietxuat>();
        public List<Chitietxuat> laytoanbochitietxuat()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Chitietxuat";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int maxuat = reader.GetInt32(0);

                int masp = reader.GetInt32(1);
                int soluong = reader.GetInt32(2);
                int dongiaxuat = reader.GetInt32(3);
                string baohanh = reader.GetString(4);



                Chitietxuat ctx = new Chitietxuat();

                ctx.Maxuat = maxuat;
                ctx.Masp = masp;
                ctx.Soluong = soluong;
                ctx.Dongiaxuat = dongiaxuat;
                ctx.Baohanh = baohanh;



                dsctx.Add(ctx);

            }
            reader.Close();
            return dsctx;
        }
        public bool Themchitietxuat(Chitietxuat ctx)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Chitietxuat VALUES(@maxuat,@masp,@soluong,@dongiaxuat,@baohanh)";
            command.Connection = conn;

            command.Parameters.Add("@maxuat", SqlDbType.Int).Value = ctx.Maxuat;
            command.Parameters.Add("@masp", SqlDbType.Int).Value = ctx.Masp;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = ctx.Soluong;
            command.Parameters.Add("@dongiaxuat", SqlDbType.Int).Value = ctx.Dongiaxuat;
            command.Parameters.Add("@baohanh", SqlDbType.NVarChar).Value = ctx.Baohanh;



            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Xoachitietxuat(int maxuat)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Chitietxuat where Maxuat = @maxuat";
            command.Connection = conn;
            command.Parameters.Add("@maxuat", SqlDbType.Int).Value = maxuat;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
       
    }
}
