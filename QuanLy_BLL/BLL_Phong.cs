using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using QuanLy_DAL;
using TransferObject;

namespace QuanLy_BLL
{
    public class BLL_Phong
    {
        private DAL_Phong dal = new DAL_Phong();

        public List<Phong> GetAllPhong()
        {
            return dal.GetAllPhong();
        }

        public List<string> GetMaPhong()
        {
            return dal.GetMaPhong();
        }

        public List<Phong> GetPhongTrong()
        {
            return dal.GetPhongTrong();
        }

        public List<Phong> SearchPhong(string truong, string keyword)
        {
            return dal.SearchPhong(truong, keyword);
        }

        public bool InsertPhong(Phong phong, out string message)
        {
            try
            {
                phong.Tinhtrang = TinhTrangPhong(phong.Sosv, phong.Sosvtoida);
                if (dal.InsertPhong(phong))
                {
                    message = "Thêm phòng thành công.";
                    return true;
                }
                else
                {
                    message = "Thêm phòng thất bại.";
                    return false;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("PRIMARY KEY"))
                    message = "Mã phòng đã tồn tại.";
                else
                    message = ex.Message;
                return false;
            }
        }

        public bool UpdatePhong(Phong phong, out string message)
        {
            try
            {
                phong.Tinhtrang = TinhTrangPhong(phong.Sosv, phong.Sosvtoida);
                if (dal.UpdatePhong(phong))
                {
                    message = "Cập nhật phòng thành công.";
                    return true;
                }
                else
                {
                    message = "Cập nhật phòng thất bại.";
                    return false;
                }
            }
            catch (SqlException ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public bool DeletePhong(string maphong, out string message)
        {
            try
            {
                if (dal.DeletePhong(maphong))
                {
                    message = "Xóa phòng thành công.";
                    return true;
                }
                else
                {
                    message = "Xóa phòng thất bại.";
                    return false;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Khóa ngoại
                    message = "Không thể xóa phòng vì đang được sử dụng.";
                else
                    message = ex.Message;
                return false;
            }
        }

        public int CountPhongTheoXepLoai(string xeploai)
        {
            return dal.CountPhongTheoXepLoai(xeploai);
        }

        public int CountPhongTheoLoai(string loaiphong)
        {
            return dal.CountPhongTheoLoai(loaiphong);
        }

        private string TinhTrangPhong(int sosv, int sosvtoida)
        {
            return sosv < sosvtoida ? "Thiếu" : "Đủ";
        }
    }
}
