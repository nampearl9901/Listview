using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


using DTO;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace DALL
{
    public class NhanvienDAL: DataacessDAL
    {
        List<Nhanvien> dsnv = new List<Nhanvien>();
        public List<Nhanvien> laytoanbonhanvien()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Nhanvien";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int ma = reader.GetInt32(0);
                String ten = reader.GetString(1);
                DateTime ngaysinh = reader.GetDateTime(2);
                String diachi = reader.GetString(3);
                int sdt = reader.GetInt32(4);
                int cmnd = reader.GetInt32(5);
                String nguyenquan = reader.GetString(6);
                DateTime ngayvao = reader.GetDateTime(7);
                String gioitinh = reader.GetString(8);
                String chucvu = reader.GetString(9);
                int tienluong = reader.GetInt32(10);


                Nhanvien nv = new Nhanvien();


                nv.Manv = ma;
                nv.Tennv = ten;
                nv.Ngaysinh = ngaysinh;
                nv.Diachi = diachi;
                nv.Sodienthoai = sdt;
                nv.SoCMTND = cmnd;
                nv.Nguyenquan = nguyenquan;
                nv.Ngayvao = ngayvao;
                nv.Gioitinh = gioitinh;
                nv.Chucvu = chucvu;
                nv.TienLuong = tienluong;
                dsnv.Add(nv);

            }
            reader.Close();
            return dsnv;

        }
        public bool Themnhanvien(Nhanvien nv)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Nhanvien VALUES(@ma,@ten,@ngaysinh,@diachi,@sdt,@cmnd,@nguyenquan,@ngayvao,@gioitinh,@chucvu,@tienluong)";
            command.Connection = conn;

            command.Parameters.Add("@ma", SqlDbType.Int).Value = nv.Manv;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nv.Tennv;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nv.Ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nv.Diachi;
            command.Parameters.Add("@sdt", SqlDbType.Int).Value = nv.Sodienthoai;
            command.Parameters.Add("@cmnd", SqlDbType.Int).Value = nv.SoCMTND;
            command.Parameters.Add("@nguyenquan", SqlDbType.NVarChar).Value = nv.Nguyenquan;
            command.Parameters.Add("@ngayvao", SqlDbType.DateTime).Value = nv.Ngayvao;
            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = nv.Gioitinh;
            command.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = nv.Chucvu;
            command.Parameters.Add("@tienluong", SqlDbType.Int).Value = nv.TienLuong;

            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool Xoanhanvien(int ma)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "delete from Nhanvien where Manv = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            int kq = command.ExecuteNonQuery();
            return kq > 0;
        }

        public bool timkiemnhanvien(int ma)
        {
           
                 Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = " SELECT* FROM Nhanvien WHERE Manv = @ma";
            command.Connection = conn;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = ma;
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

        public bool suanhanvien(Nhanvien nv)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "update Nhanvien set Tennv=@ten,Ngaysinh=@ngaysinh,Diachi=@diachi,Sodienthoai=@sdt,SoCMTND=@cmnd,Nguyenquan=@nguyenquan,Ngayvao=@ngayvao,Gioitinh=@gioitinh,Chucvu=@chucvu,Tienluong=@tienluong where Manv=@ma";
            command.Connection = conn;
     
            command.Parameters.Add("@ma", SqlDbType.Int).Value = nv.Manv;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nv.Tennv;
            command.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nv.Ngaysinh;
            command.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nv.Diachi;
            command.Parameters.Add("@sdt", SqlDbType.Int).Value = nv.Sodienthoai;
            command.Parameters.Add("@cmnd", SqlDbType.Int).Value = nv.SoCMTND;
            command.Parameters.Add("@nguyenquan", SqlDbType.NVarChar).Value = nv.Nguyenquan;
            command.Parameters.Add("@ngayvao", SqlDbType.DateTime).Value = nv.Ngayvao;
            command.Parameters.Add("@gioitinh", SqlDbType.NChar).Value = nv.Gioitinh;
            command.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = nv.Chucvu;
            command.Parameters.Add("@tienluong", SqlDbType.Int).Value = nv.TienLuong;
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }

       



    }
}
