using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class ThongKe_DAL : DataProvider
    {
        public ThongKeSL LayDuLieuThongKe()
        {
            ThongKeSL dto = new ThongKeSL();

            dto.SoLuongSinhVien = (int)MyExecuteScalar("SELECT COUNT(*) FROM SinhVien", CommandType.Text);
            dto.SoLuongPhong = (int)MyExecuteScalar("SELECT COUNT(*) FROM Phong", CommandType.Text);
            dto.SoLuongThietBi = (int)MyExecuteScalar("SELECT COUNT(*) FROM ThietBi", CommandType.Text);

            return dto;
        }
    }
}
