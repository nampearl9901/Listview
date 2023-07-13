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
    public class NhacungcapDALL : DataacessDAL
         
    {
        List<Nhacungcap> dsncc = new List<Nhacungcap>();
        public List<Nhacungcap> laytoanbonhacungcap()
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Nhacungcap";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int mancc = reader.GetInt32(0);

                string tenncc = reader.GetString(1);
                string diachincc = reader.GetString(2);
                int sdtncc = reader.GetInt32(3);
                int sofax = reader.GetInt32(4);



                Nhacungcap ncc = new Nhacungcap();

                ncc.MaNCC = mancc;
                ncc.TenNCC = tenncc;
                ncc.DiaChi = diachincc;
                ncc.Sodienthoai = sdtncc;
                ncc.SoFax = sofax;


                dsncc.Add(ncc);

            }
            reader.Close();
            return dsncc;
        }
        public bool Themnhacungcap(Nhacungcap ncc)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "INSERT INTO Nhacungcap VALUES(@mancc,@tenncc,@diachincc,@sdtncc,@sofax)";
            command.Connection = conn;

            command.Parameters.Add("@mancc", SqlDbType.Int).Value = ncc.MaNCC;
            command.Parameters.Add("@tenncc", SqlDbType.NVarChar).Value = ncc.TenNCC;
            command.Parameters.Add("@diachincc", SqlDbType.NVarChar).Value = ncc.DiaChi;
            command.Parameters.Add("@sdtncc", SqlDbType.Int).Value = ncc.Sodienthoai;
                 command.Parameters.Add("@sofax", SqlDbType.Int).Value = ncc.SoFax;



            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
        public bool suanhacungcap(Nhacungcap ncc)
        {
            Moketnoi();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;

            command.CommandText = "update Nhacungcap set  TenNCC=@tenncc, Diachi=@diachincc,Sodienthoai=@sdtncc , SoFax=@sofax where MaNCC=@mancc";
            command.Connection = conn;

            command.Parameters.Add("@mancc", SqlDbType.Int).Value = ncc.MaNCC;
            command.Parameters.Add("@tenncc", SqlDbType.NVarChar).Value = ncc.TenNCC;
            command.Parameters.Add("@diachincc", SqlDbType.NVarChar).Value = ncc.DiaChi;
            command.Parameters.Add("@sdtncc", SqlDbType.Int).Value = ncc.Sodienthoai;
            command.Parameters.Add("@sofax", SqlDbType.Int).Value = ncc.SoFax;
            int kq = command.ExecuteNonQuery();
            return kq > 0;

        }
    }
}
