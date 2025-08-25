using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class NhanVien
    {
        public string manv { get; set; }

        public string tennv { get; set; }

        public string gioitinh { get; set; }

        public string ngaysinh { get; set; }

        public string diachi { get; set; }

        public string sodienthoai { get; set; }


        public NhanVien(string maNV, string tenNV, string gioiTinh, string ngaySinh, string diaChi,  string soDienThoai)
        {
            this.manv = maNV;
            this.tennv = tenNV;
            this.gioitinh = gioiTinh;
            this.ngaysinh = ngaySinh;
            this.diachi = diaChi;
            this.sodienthoai = soDienThoai;
        }
    }
}
