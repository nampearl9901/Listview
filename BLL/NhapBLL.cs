using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhapBLL
    {
        NhapDALL nda = new NhapDALL();
        public List<Nhap> laytoanbonhap()
        {
            return nda.laytoanbonhap();
        }
        public bool Themnhap(Nhap n)
        {
            return nda.Themnhap(n);
        }
        public bool xoanhap(int maxuat)
        {
            return nda.Xoanhap(maxuat);
        }
    }
}
