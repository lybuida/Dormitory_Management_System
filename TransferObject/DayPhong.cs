using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class DayPhong
    {
        public string maday { get; set; }
        public string tenday { get; set; }
        public string quanly { get; set; }
        public string trangthai { get; set; }

        public string daygioitinh { get; set; } 
        public DayPhong(string maDay, string tenDay, string quanLy, string trangThai, string dayGioiTinh)
        {
            maday = maDay;
            tenday = tenDay;
            quanly = quanLy;
            trangthai = trangThai;
            daygioitinh = dayGioiTinh;
        }
    }
}
