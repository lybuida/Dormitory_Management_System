using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class SinhVienDangKy
    {
        public string masvdky { get; set; }

        public string tensv { get; set; }

        public string gioitinh { get; set; }

        public string ngaysinh { get; set; }

        public string quequan { get; set; }
        public string email { get; set; }

        public string khoa { get; set; }

        public string lop { get; set; }

        public string loaiuutien { get; set; }

        public SinhVienDangKy(string maSVĐKy, string tenSV, string gioiTinh, string ngaySinh, string queQuan, string eMail,
            string Khoa, string Lop, string loaiUuTien)
        {
            this.masvdky = maSVĐKy;
            this.tensv = tenSV;
            this.gioitinh = gioiTinh;
            this.ngaysinh = ngaySinh;
            this.quequan = queQuan;
            this.email = eMail;
            this.khoa = Khoa;
            this.lop = Lop;
            this.loaiuutien = loaiUuTien;
        }
    }
}
