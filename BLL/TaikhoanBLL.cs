using DALL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TaikhoanBLL
    {
        LoginDAL tkda = new LoginDAL();
        public List<login> laytaikhoan()
        {
            return tkda.laytaikhoan();
        }
        public bool Themtaikhoan(login lg)
        {
            return tkda.Themtaikhoan(lg);
        }


    }
}
