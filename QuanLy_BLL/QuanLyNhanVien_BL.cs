using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using QuanLy_DAL;
using System.Data.SqlClient;

namespace QuanLy_BLL
{
    public class QuanLyNhanVien_BL
    {
        private QuanLyNhanVien_DL quanLyNhanVien_DL;

        public QuanLyNhanVien_BL()
        {
            quanLyNhanVien_DL = new QuanLyNhanVien_DL();
        }

        public List<NhanVien> LayDanhSachNhanVien()
        {
            try
            {
                return quanLyNhanVien_DL.LayDanhSachNhanVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<NhanVien> TimKiemNhanVien(string keyword, bool timTheoMa)
        {
            try
            {
                return quanLyNhanVien_DL.TimKiemNhanVien(keyword, timTheoMa);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int ThemNhanVien(NhanVien nv)
        {
            try
            {
                return quanLyNhanVien_DL.ThemNhanVien(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int XoaNhanVien(string manv)
        {
            try
            {
                return quanLyNhanVien_DL.XoaNhanVien(manv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhapNhanVien(NhanVien nv)
        {
            try
            {
                return quanLyNhanVien_DL.CapNhapNhanVien(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
