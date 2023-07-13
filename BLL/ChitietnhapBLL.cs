using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChitietnhapBLL
    {
        ChitietnhapDALL ctnda = new ChitietnhapDALL();
        public List<Chitietnhap> laytoanbochitetnhap()
        {
            return ctnda.laytoanbochitietnhap();
        }
        public bool xoachitietnhap(int manhap)
        {
            return ctnda.Xoachitietnhap(manhap);
        }
        public bool Themchitietnhap(Chitietnhap ctn)
        {
            return ctnda.Themchitietnhap(ctn);
        }
        
    }
}
