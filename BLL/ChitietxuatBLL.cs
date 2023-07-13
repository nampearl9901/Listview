using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChitietxuatBLL
    {
        ChitietxuatDALL ctxda = new ChitietxuatDALL();
        public List<Chitietxuat> laytoanbochitetxuat()
        {
            return ctxda.laytoanbochitietxuat();
        }
        public bool xoachitietxuat(int maxuat)
        {
            return ctxda.Xoachitietxuat(maxuat);
        }
        public bool Themchitietxuat(Chitietxuat ctx)
        {
            return ctxda.Themchitietxuat(ctx);
        }
        
    }
}
