using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhacungcapBLL
    {
        NhacungcapDALL nccda = new NhacungcapDALL();
        public List<Nhacungcap> laytoanbonhacungcap()
        {
            return nccda.laytoanbonhacungcap();
        }
        public bool Themnhacungcap(Nhacungcap ncc)
        {
            return nccda.Themnhacungcap(ncc);
        }
        public bool suanhacungcap(Nhacungcap ncc)
        {
            return nccda.suanhacungcap(ncc);
        }
    }
}
