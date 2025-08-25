using QuanLy_DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_BLL
{
    public class ThanhToanLuongNhanVien_BL
    {
        private ThanhToanLuongNhanVien_DL thanhToanLuongNhanVien_DL;

        public ThanhToanLuongNhanVien_BL()
        {
            thanhToanLuongNhanVien_DL = new ThanhToanLuongNhanVien_DL();
        }

        public List<NhanVien2B> LayDanhSachNhanVien()
        {
            try
            {
                return thanhToanLuongNhanVien_DL.LayDanhSachNhanVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<LuongNhanVien> LayDanhSachLuongNhanVien()
        {
            try
            {
                return thanhToanLuongNhanVien_DL.LayDanhLuongNhanVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void ThemHoacCapNhatLuong(LuongNhanVien luongNV)
        {
            try
            {
                thanhToanLuongNhanVien_DL.ThemHoacCapNhatLuong(luongNV);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void CapNhatLuongNhanVien(LuongNhanVien luongNV)
        {
            try
            {
                thanhToanLuongNhanVien_DL.CapNhatLuongNhanVien(luongNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void XoaLuongNhanVien(string maHoaDon)
        {
            try
            {
                thanhToanLuongNhanVien_DL.XoaLuongNhanVien(maHoaDon);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<LuongNhanVien> TimKiemLuongNhanVien(string keyword, bool timTheoMa)
        {
            try
            {
                return thanhToanLuongNhanVien_DL.TimKiemLuongNhanVien(keyword, timTheoMa);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<LuongNhanVien> GetLuongThangNam(int thang, int nam)
        {
            return thanhToanLuongNhanVien_DL.LayLuongTheoThangNam(thang, nam);
        }
    }
}
