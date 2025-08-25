using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class QuanLyNguoiDung
    {
        public string manguoidung { get; set; }
        public string tendangnhap { get; set; }
        public string matkhau { get; set; }


        public QuanLyNguoiDung(string maNguoiDung, string tenDangNhap, string matKhau)
        {
            this.manguoidung = maNguoiDung;
            this.tendangnhap = tenDangNhap;
            this.matkhau = matKhau;
        }
    }
}
