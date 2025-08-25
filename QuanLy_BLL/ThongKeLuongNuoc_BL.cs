using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class ThongKeLuongNuoc_BL
    {
        ThongKeLuongNuoc_DL dal = new ThongKeLuongNuoc_DL();

        public List<ThongKeLuongNuoc> LayLuongNuocCacThang(int nam)
        {
            List<ThongKeLuongNuoc> ds = new List<ThongKeLuongNuoc>();
            for (int thang = 1; thang <= 12; thang++)
            {
                float soNuoc = dal.LayLuongNuocTieuThuTheoThang(nam, thang);
                ds.Add(new ThongKeLuongNuoc(nam, thang, soNuoc));
            }
            return ds;
        }
    }
}
