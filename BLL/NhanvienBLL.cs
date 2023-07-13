using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanvienBLL
    {
        NhanvienDAL nvda = new NhanvienDAL();
        public List<Nhanvien> laytoanbonhanvien()
        {
            return nvda.laytoanbonhanvien();
        }
        public bool xoanhanvien(int ma)
        {
            return nvda.Xoanhanvien(ma);
        }
        public bool Themnhanvien(Nhanvien nv)
        {
            return nvda.Themnhanvien(nv);
        }
        public bool suanhanvien(Nhanvien nv)
        {
            return nvda.suanhanvien(nv);
        }
        public bool timkiemnhanvien(int ma)
        {
            return nvda.timkiemnhanvien(ma);
        }





    }
}
