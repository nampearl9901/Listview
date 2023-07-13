using System;
using Microsoft.SqlServer.Server;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Nhanvien
    {
        public int Manv { get; set; }
        public string Tennv { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Diachi { get; set; }
        public int Sodienthoai { get; set; }
        public int SoCMTND { get; set; }
        public string Nguyenquan { get; set; }
        public DateTime Ngayvao { get; set; }
        public string Gioitinh { get; set; }

        public string Chucvu { get; set; }

        public int TienLuong { get; set; }
    }
}
