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
    public class sanphamDAL:DataacessDAL
    {
        List<Sanpham> dssp = new List<Sanpham>();
        public List<Sanpham> laytoanbosanpham()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Sanpham";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                String ten = reader.GetString(1);
                String loai = reader.GetString(2);
                String hang = reader.GetString(3);
                
                Sanpham sp = new Sanpham();
                sp.Masp = ma;
                sp.Tensp = ten;
                sp.Loai = loai;
                sp.Hangsx = hang;
            
                dssp.Add(sp);

            }    
            reader.Close();
            return dssp;
        }
        public bool Xoasanpham(int ma)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            
           command.CommandText = "delete from Sanpham where Masp = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }
        public bool Themsanpham(Sanpham sp)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "insert into Sanpham values(@ma,@ten,@loai,@hang)";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = sp.Masp;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sp.Tensp;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = sp.Loai;
            command.Parameters.Add("@hang", SqlDbType.NVarChar).Value = sp.Hangsx;
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool suasanpham(Sanpham sp)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "update Sanpham set Tensp=@ten,Loai=@loai,Hangsx=@hang where Masp=@ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = sp.Masp;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = sp.Tensp;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = sp.Loai;
            command.Parameters.Add("@hang", SqlDbType.NVarChar).Value = sp.Hangsx;
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

    }
}
