using System;

namespace TransferObject
{
    public class TienDien
    {
        public int Mahoadon { get; set; }
        public string Maphong { get; set; }
        public DateTime Ngaylap { get; set; }
        public int Chisocu { get; set; }
        public int Chisomoi { get; set; }
        public int Sodientieuthu { get; set; }
        public float Tongtien { get; set; }
        public string Trangthai { get; set; }

        public TienDien() { }

        public TienDien(int maHoaDon, string maPhong, DateTime ngayLap, int chiSoCu, int chiSoMoi, int soDien, float tongTien, string trangThai)
        {
            Mahoadon = maHoaDon;
            Maphong = maPhong;
            Ngaylap = ngayLap;
            Chisocu = chiSoCu;
            Chisomoi = chiSoMoi;
            Sodientieuthu = soDien;
            Tongtien = tongTien;
            Trangthai = trangThai;
        }
    }
}
