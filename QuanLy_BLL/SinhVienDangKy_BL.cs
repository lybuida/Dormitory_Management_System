using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Luôn thêm 3 đứa này
using QuanLy_DAL;
using TransferObject;
using System.Data.SqlClient;

namespace QuanLy_BLL
{
    public class SinhVienDangKy_BL
    {
        private SinhVienDangKy_DL sinhVienDangKy_DL;

        public SinhVienDangKy_BL()
        {
            sinhVienDangKy_DL = new SinhVienDangKy_DL();
        }

        public bool ThemSinhVienDangKy(SinhVienDangKy sv)
        {
            return sinhVienDangKy_DL.ThemSinhVienDangKy(sv);
        }

        public bool KiemTraTrungMa(string maSV)
        {
            return sinhVienDangKy_DL.KiemTraTrungMa(maSV);
        }
    }
}
