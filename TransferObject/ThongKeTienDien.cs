using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ThongKeTienDien
    {
        public int Nam { get; set; }
        public int Thang { get; set; }
        public float SoDienTieuThu { get; set; }

        public ThongKeTienDien(int nam, int thang, float soDienTieuThu)
        {
            Nam = nam;
            Thang = thang;
            SoDienTieuThu = soDienTieuThu;
        }

        public ThongKeTienDien() { }
    }
}
