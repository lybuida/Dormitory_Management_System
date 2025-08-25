using System;
using System.Data;
using TransferObject;
using QuanLy_DAL;
using System.Collections.Generic;

namespace QuanLy_BLL
{
    public class BLL_TienNuoc
    {
        private DAL_TienNuoc dal = new DAL_TienNuoc();

        public List<TienNuoc> GetAllTienNuoc()
        {
            return dal.SelectTienNuoc();
        }

        public int GetSoKhoi(string mahoadon)
        {
            return dal.SelectSoKhoi(mahoadon);
        }

        public int GetChiSoMoiGanNhat(string maphong)
        {
            return dal.SelectChiSoMoiGanNhat(maphong);
        }

        public int GetChiSoCu(string maphong)
        {
            return dal.SelectChiSoCu(maphong);
        }

        public TienNuoc GetHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            return dal.SelectHoaDonKeTiep(maphong, ngaylap);
        }

        public bool InsertTienNuoc(TienNuoc tn)
        {
            try
            {
                dal.InsertTienNuoc(tn);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateTienNuoc(TienNuoc tn)
        {
            try
            {
                dal.UpdateTienNuoc(tn);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteTienNuoc(string mahoadon)
        {
            try
            {
                dal.DeleteTienNuoc(mahoadon);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateTrangThai(string mahoadon, string trangthai)
        {
            dal.UpdateTrangThai(mahoadon, trangthai);
        }

        public List<TienNuoc> SearchTienNuoc(string keyword, string truong)
        {
            return dal.SearchTienNuoc(keyword, truong);
        }

        public bool ExistsTienNuoc(string maphong, DateTime ngaylap)
        {
            return dal.CheckExistsTienNuoc(maphong, ngaylap);
        }

    }
}
