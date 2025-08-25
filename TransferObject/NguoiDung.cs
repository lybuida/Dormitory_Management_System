using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class NguoiDung
    {

        public string tendangnhap { get; set; }

        public string matkhau { get; set; }


        public NguoiDung(string tenDangNhap, string matKhau)
        {
            this.tendangnhap = tenDangNhap;
            this.matkhau = matKhau;
        }

    }
}
