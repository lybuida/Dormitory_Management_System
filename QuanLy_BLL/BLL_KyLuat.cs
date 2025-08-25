using System;
using System.Collections.Generic;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class BLL_KyLuat
    {
        private DAL_KyLuat dal = new DAL_KyLuat();

        public List<KyLuat> GetAllKyLuat()
        {
            return dal.SelectKyLuat();
        }

        public bool InsertKyLuat(KyLuat kl)
        {
            try
            {
                dal.InsertKyLuat(kl);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateKyLuat(KyLuat kl)
        {
            //if (!dal.ExistsKyLuat(kl.MaKyLuat))
            //    return false;

            try
            {
                dal.UpdateKyLuat(kl);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteKyLuat(int makyluat)
        {
            //if (!dal.ExistsKyLuat(makyluat))
            //    return false;

            try
            {
                dal.DeleteKyLuat(makyluat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<KyLuat> SearchKyLuat(string keyword, string field)
        {
            return dal.SearchKyLuat(keyword, field);
        }
    }
}
