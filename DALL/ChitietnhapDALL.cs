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
    public class ChitietnhapDALL : DataacessDAL
    {
        List<Chitietnhap> dsctn = new List<Chitietnhap>();
        public List<Chitietnhap> laytoanbochitietnhap()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Chitietnhap";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int manhap = reader.GetInt32(0);

                int masp = reader.GetInt32(1);
                int soluong = reader.GetInt32(2);
                int dongianhap = reader.GetInt32(3);
                string lydo = reader.GetString(4);



                Chitietnhap ctn = new Chitietnhap();

                ctn.Manhap = manhap;
                ctn.Masp = masp;
                ctn.Soluong = soluong;
                ctn.Dongianhap = dongianhap;
                ctn.Lydonhap = lydo;



                dsctn.Add(ctn);

            }
            reader.Close();
            return dsctn;
        }
        public bool Themchitietnhap(Chitietnhap ctn)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Chitietnhap VALUES(@manhap,@masp,@soluong,@dongianhap,@lydo)";
            command.Connection = conn;

            command.Parameters.Add("@manhap", SqlDbType.Int).Value = ctn.Manhap;
            command.Parameters.Add("@masp", SqlDbType.Int).Value = ctn.Masp;
            command.Parameters.Add("@soluong", SqlDbType.Int).Value = ctn.Soluong;
            command.Parameters.Add("@dongianhap", SqlDbType.Int).Value = ctn.Dongianhap;
            command.Parameters.Add("@lydo", SqlDbType.NVarChar).Value = ctn.Lydonhap;
            
      

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Xoachitietnhap(int manhap)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Chitietnhap where Manhap = @manhap";
            command.Connection = conn;
            command.Parameters.Add("@manhap", SqlDbType.Int).Value = manhap;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        
    }
}
