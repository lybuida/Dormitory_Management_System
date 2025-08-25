using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class LuongNhanVien
    {
        public string maluong { get; set; }
        public string manv { get; set; }

        public string tennv { get; set; }

        public string thang { get; set; }

        public string luongcoban { get; set; }

        public string phucap { get; set; }

        public string thuongphat { get; set; }

        public string ngaythanhtoan { get; set; }

        public string tongluong { get; set; }


        public LuongNhanVien(string maLuong, string maNV, string tenNV, string Thang, string luongCoBan,
            string phuCap, string thuongPhat, string ngayThanhToan, string tongLuong)
        {
            this.maluong = maLuong;
            this.manv = maNV;
            this.tennv = tenNV;
            this.thang = Thang;
            this.luongcoban = luongCoBan;
            this.phucap = phuCap;
            this.thuongphat = thuongPhat;
            this.ngaythanhtoan = ngayThanhToan;
            this.tongluong = tongLuong;
        }
    }
}
