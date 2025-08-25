using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class ThongKe_BL
    {
        ThongKe_DAL dal = new ThongKe_DAL();

        public ThongKeSL LayThongKe()
        {
            return dal.LayDuLieuThongKe();
        }
    }
}
