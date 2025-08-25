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
    public class QuanLySinhVien_BL
    {
        private QuanLySinhVien_DL quanLySinhVien_DAL;

        public QuanLySinhVien_BL()
        {
            quanLySinhVien_DAL = new QuanLySinhVien_DL();
        }

        public List<SinhVien> LayDanhSachSinhVien()
        {
            try
            {
                return quanLySinhVien_DAL.LayDanhSachSinhVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            try
            {
                return quanLySinhVien_DAL.ThemSinhVien(sv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool CapNhatSinhVien(SinhVien sv)
        {
            try
            {
                return quanLySinhVien_DAL.CapNhatSinhVien(sv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool XoaSinhVien(string masv)
        {
            try
            {
                return quanLySinhVien_DAL.XoaSinhVien(masv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<SinhVien> TimKiemSinhVien(string keyword, KieuTimKiem kieuTimKiem)
        {
            try
            {
                return quanLySinhVien_DAL.TimKiemSinhVien(keyword, kieuTimKiem);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public List<SinhVien> TimKiemSinhVien(string keyword, bool timTheoMa)
        //{
        //    try
        //    {
        //        return quanLySinhVien_DAL.TimKiemSinhVien(keyword, timTheoMa);
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<string> SelectMaSinhVien()
        {
            return quanLySinhVien_DAL.SelectMaSinhVien();
        }
    }
}
