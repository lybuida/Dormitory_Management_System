using System;

namespace TransferObject
{
    public class TienNuoc
    {
        public int Mahoadon { get; set; }
        public string Maphong { get; set; }
        public DateTime Ngaylap { get; set; }
        public int Chisocu { get; set; }
        public int Chisomoi { get; set; }
        public int Sokhoitieuthu { get; set; }
        public float Tongtien { get; set; }
        public string Trangthai { get; set; }

        public TienNuoc() { }

        public TienNuoc(int maHoaDon, string maPhong, DateTime ngayLap, int chiSoCu, int chiSoMoi, int soKhoi, float tongTien, string trangThai)
        {
            Mahoadon = maHoaDon;
            Maphong = maPhong;
            Ngaylap = ngayLap;
            Chisocu = chiSoCu;
            Chisomoi = chiSoMoi;
            Sokhoitieuthu = soKhoi;
            Tongtien = tongTien;
            Trangthai = trangThai;
        }
    }
}
