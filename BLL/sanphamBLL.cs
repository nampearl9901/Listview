using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DALL;


namespace BLL
{
    public class sanphamBLL
    {
        sanphamDAL spda = new sanphamDAL();
        public List<Sanpham> laytoanbosanpham()
        {
            return spda.laytoanbosanpham();
        }

        public bool xoasanpham(int ma)
        {
            return spda.Xoasanpham(ma);
        }
        public bool Themsanpham(Sanpham sp)
        {
            return spda.Themsanpham(sp);
        }
        public bool suasanpham(Sanpham sp)
        {
            return spda.suasanpham(sp);
        }

    }
}
