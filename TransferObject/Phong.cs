using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Phong
    {
        public string Maphong { get; set; }
        public string Tenphong { get; set; }
        public int Sosv { get; set; }
        public int Sosvtoida { get; set; }
        public string Tinhtrang { get; set; }
        public string Loaiphong { get; set; }
        public string Xeploai { get; set; }
        public string Day { get; set; }

        public Phong(string maphong, string tenphong, string sosv, string sosvtoida,
            string tinhtrang, string loaiphong, string xeploai, string day)
        {
            Maphong = maphong;
            Tenphong = tenphong;
            Sosv = int.Parse(sosv);
            Sosvtoida = int.Parse(sosvtoida);
            Tinhtrang = tinhtrang;
            Loaiphong = loaiphong;
            Xeploai = xeploai;
            Day = day;
        }

        public Phong(string maphong, string tenphong, int sosv, int sosvtoida,
            string tinhtrang, string loaiphong, string xeploai, string day)
        {
            Maphong = maphong;
            Tenphong = tenphong;
            Sosv = sosv;
            Sosvtoida = sosvtoida;
            Tinhtrang = tinhtrang;
            Loaiphong = loaiphong;
            Xeploai = xeploai;
            Day = day;
        }

        public Phong(string maphong, string tenphong, int sosv, int sosvtoida,
                     string loaiphong, string xeploai, string day)
        {
            Maphong = maphong;
            Tenphong = tenphong;
            Sosv = sosv;
            Sosvtoida = sosvtoida;
            Loaiphong = loaiphong;
            Xeploai = xeploai;
            Day = day;
        }

        public Phong(string maphong, string tenphong, string sosvtoida,
                     string loaiphong, string xeploai, string day)
        {
            Maphong = maphong;
            Tenphong = tenphong;
            Sosvtoida = int.Parse(sosvtoida);
            Loaiphong = loaiphong;
            Xeploai = xeploai;
            Day = day;
        }
    }
}