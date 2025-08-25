using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class SinhVien
    {
        public string masv { get; set; }
        public string tensv { get; set; }
        public string gioitinh { get; set; }
        public string ngaysinh { get; set; }
        public string quequan { get; set; }
        public string email { get; set; }
        public string khoa { get; set; }
        public string lop { get; set; }
        public string loaiuutien { get; set; }
        public string maphong { get; set; }
        public SinhVien(string maSV, string tenSV, string gioiTinh, string ngaySinh,
            string queQuan, string eMail, string Khoa, string Lop, string loaiUuTien, string maPhong)
        {
            this.masv = maSV;
            this.tensv = tenSV;
            this.gioitinh = gioiTinh;
            this.ngaysinh = ngaySinh;
            this.quequan = queQuan;
            this.email = eMail;
            this.khoa = Khoa;
            this.lop = Lop;
            this.loaiuutien = loaiUuTien;
            this.maphong = maPhong;
        }
        public SinhVien(string tenSV, string gioiTinh, string ngaySinh,
           string queQuan, string eMail, string Khoa, string Lop, string loaiUuTien, string maPhong)
        {
            this.tensv = tenSV;
            this.gioitinh = gioiTinh;
            this.ngaysinh = ngaySinh;
            this.quequan = queQuan;
            this.email = eMail;
            this.khoa = Khoa;
            this.lop = Lop;
            this.loaiuutien = loaiUuTien;
            this.maphong = maPhong;
        }

    }
    public enum KieuTimKiem
    {
        TheoMaSV,
        TheoTenSV,
        TheoMaPhong
    }
}
