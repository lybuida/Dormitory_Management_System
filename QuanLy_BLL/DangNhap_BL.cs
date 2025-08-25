using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLy_DAL;
using TransferObject;
using System.Data.SqlClient;
using System.Security.Principal;

namespace QuanLy_BLL
{
    public class DangNhap_BL
    {
        private DangNhap_DL dangnhapDL;

        public DangNhap_BL()
        {
            dangnhapDL = new DangNhap_DL();
        }

        public NguoiDung KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            return dangnhapDL.KiemTraDangNhap(tenDangNhap, matKhau);
        }
    }
}
