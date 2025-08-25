using QuanLy_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_BLL
{
    public class ThongKeTienDien_BL
    {
        ThongKeTienDien_DL dal = new ThongKeTienDien_DL();

        public List<ThongKeTienDien> LayLuongDienCacThang(int nam)
        {
            List<ThongKeTienDien> ds = new List<ThongKeTienDien>();
            for (int thang = 1; thang <= 12; thang++)
            {
                float soDien = dal.LayLuongDienTieuThuTheoThang(nam, thang);
                ds.Add(new ThongKeTienDien(nam, thang, soDien));
            }
            return ds;
        }
    }
}
