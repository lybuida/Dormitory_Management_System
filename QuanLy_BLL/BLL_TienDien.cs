using System;
using System.Collections.Generic;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class BLL_TienDien
    {
        private DAL_TienDien dal = new DAL_TienDien();

        public List<TienDien> GetAllTienDien()
        {
            return dal.SelectTienDien();
        }

        public int GetSoDien(string mahoadon)
        {
            return dal.SelectSoDien(mahoadon);
        }

        public int GetChiSoMoiGanNhat(string maphong)
        {
            return dal.SelectChiSoMoiGanNhat(maphong);
        }

        public int GetChiSoCu(string maphong)
        {
            return dal.SelectChiSoCu(maphong);
        }

        public TienDien GetHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            return dal.SelectHoaDonKeTiep(maphong, ngaylap);
        }

        public bool InsertTienDien(TienDien td)
        {
            try
            {
                dal.InsertTienDien(td);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateTienDien(TienDien td)
        {
            try
            {
                dal.UpdateTienDien(td);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteTienDien(string mahoadon)
        {
            try
            {
                dal.DeleteTienDien(mahoadon);
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

        public List<TienDien> SearchTienDien(string keyword, string truong)
        {
            return dal.SearchTienDien(keyword, truong);
        }

        public bool ExistsTienDien(string maphong, DateTime ngaylap)
        {
            return dal.CheckExistsTienDien(maphong, ngaylap);
        }
    }
}
