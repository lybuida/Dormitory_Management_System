using System;
using System.Data;
using TransferObject;
using QuanLy_DAL;
using System.Collections.Generic;

namespace QuanLy_BLL
{
    public class BLL_ThietBi
    {
        private DAL_ThietBi dal = new DAL_ThietBi();

        public List<ThietBi> GetAllThietBi()
        {
            return dal.GetAllThietBi();
        }

        public List<ThietBi> GetThietBiTheoPhong(string maphong)
        {
            return dal.GetThietBiTheoPhong(maphong);
        }

        public bool InsertThietBi(ThietBi tb, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(tb.Tenthietbi) || tb.Soluong <= 0)
            {
                error = "Bạn chưa điền tên thiết bị hoặc số lượng <= 0";
                return false;
            }

            return dal.InsertThietBi(tb);
        }

        public bool UpdateThietBi(ThietBi tb, out string error)
        {
            error = "";

            if (string.IsNullOrEmpty(tb.Maphong) || string.IsNullOrEmpty(tb.Tenthietbi))
            {
                error = "Thiếu mã phòng hoặc tên thiết bị";
                return false;
            }

            return dal.UpdateThietBi(tb);
        }

        public bool DeleteThietBi(string mathietbi)
        {
            return dal.DeleteThietBi(mathietbi);
        }

    }
}
