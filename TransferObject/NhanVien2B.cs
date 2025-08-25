using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public  class NhanVien2B
    {
        public string manv { get; set; }

        public string tennv { get; set; }

        public NhanVien2B(string maNV, string tenNV)
        {
            this.manv = maNV;
            this.tennv = tenNV;
        }
    }
}
