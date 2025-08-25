using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Luôn thêm 3 đứa này
using QuanLy_DAL;
using TransferObject;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy_BLL
{
    public class QuanLyDay_BL
    {
        private QuanLyDay_DL quanLyDay_DL;

        public QuanLyDay_BL()
        {
            quanLyDay_DL = new QuanLyDay_DL();
        }

        public List<DayPhong> LayDanhSachDay()
        {
            try
            {
                return quanLyDay_DL.LayDanhSachDay();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<NhanVien> LayDanhSachNhanVien()
        {
            try
            {
                return quanLyDay_DL.LayDanhSachNhanVien();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool ThemDay(DayPhong day)
        {
            try
            {
                return quanLyDay_DL.ThemDay(day);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool SuaDay(DayPhong day)
        {
            try
            {
                return quanLyDay_DL.SuaDay(day);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool XoaDay(string maDay)
        {
            try
            {
                return quanLyDay_DL.XoaDay(maDay);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
