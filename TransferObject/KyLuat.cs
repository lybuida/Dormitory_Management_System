using System;

namespace TransferObject
{
    public class KyLuat
    {
        public int MaKyLuat { get; set; }
        public string MaSV { get; set; }
        public string KyLuatNoiDung { get; set; }
        public DateTime NgayKyLuat { get; set; }
        public float TienPhat { get; set; }

        // Constructor đầy đủ
        public KyLuat(int maKyLuat, string maSV, string kyLuatNoiDung, DateTime ngayKyLuat, float tienPhat)
        {
            MaKyLuat = maKyLuat;
            MaSV = maSV;
            KyLuatNoiDung = kyLuatNoiDung;
            NgayKyLuat = ngayKyLuat;
            TienPhat = tienPhat;
        }

        public KyLuat(string maSV, string kyLuatNoiDung, DateTime ngayKyLuat, float tienPhat)
        {
            MaSV = maSV;
            KyLuatNoiDung = kyLuatNoiDung;
            NgayKyLuat = ngayKyLuat;
            TienPhat = tienPhat;
        }

        // Constructor mặc định
        public KyLuat()
        {
        }
    }
}
