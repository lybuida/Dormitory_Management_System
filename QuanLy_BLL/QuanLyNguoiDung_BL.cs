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
    public class QuanLyNguoiDung_BL
    {
        private QuanLyNguoiDung_DL quanLyNguoiDung_DL;
        public QuanLyNguoiDung_BL()
        {
            quanLyNguoiDung_DL = new QuanLyNguoiDung_DL();
        }
        public List<QuanLyNguoiDung> LayDanhSachNguoiDung()
        {
            try
            {
                return quanLyNguoiDung_DL.LayDanhSachNguoiDung();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool ThemNguoiDung(QuanLyNguoiDung quanLyNguoiDung)
        {
            try
            {
                return quanLyNguoiDung_DL.ThemNguoiDung(quanLyNguoiDung);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool SuaNguoiDung(QuanLyNguoiDung quanLyNguoiDung)
        {
            try
            {
                return quanLyNguoiDung_DL.SuaNguoiDung(quanLyNguoiDung);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool XoaNguoiDung(string manguoidung)
        {
            try
            {
                return quanLyNguoiDung_DL.XoaNguoiDung(manguoidung);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<QuanLyNguoiDung> TimKiemNguoiDung(string keyword, bool timTheoMa)
        {
            try
            {
                return quanLyNguoiDung_DL.TimKiemNguoiDung(keyword, timTheoMa);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
