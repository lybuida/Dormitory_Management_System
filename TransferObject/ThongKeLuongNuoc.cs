using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class ThongKeLuongNuoc
    {
        public int Nam { get; set; }
        public int Thang { get; set; }
        public float SoKhoiTieuThu { get; set; }

        public ThongKeLuongNuoc(int nam, int thang, float soNuoc)
        {
            Nam = nam;
            Thang = thang;
            SoKhoiTieuThu = soNuoc;
        }
    }

}
