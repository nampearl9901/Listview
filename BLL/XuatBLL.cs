using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class XuatBLL
    {
        XuatDALL xda = new XuatDALL();
        public List<Xuat> laytoanboxuat()
        {
            return xda.laytoanboxuat();
        }
        public bool Themxuat(Xuat x)
        {
            return xda.Themxuat(x);
        }
        public bool xoaxuat(int maxuat)
        {
            return xda.Xoaxuat(maxuat);
        }
    }
}
