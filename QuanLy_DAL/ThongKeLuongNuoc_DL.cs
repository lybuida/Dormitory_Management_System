using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLy_DAL
{
    public class ThongKeLuongNuoc_DL : DataProvider
    {
        public float LayLuongNuocTieuThuTheoThang(int nam, int thang)
        {
            float soNuoc = 0;
            try
            {
                Connect();
                string sql = @"
                    SELECT ISNULL(SUM(sokhoitieuthu), 0)
                    FROM TienNuoc
                    WHERE YEAR(ngaylap) = @nam AND MONTH(ngaylap) = @thang
                ";

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nam", nam);
                cmd.Parameters.AddWithValue("@thang", thang);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                    soNuoc = Convert.ToSingle(result);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy xuất dữ liệu nước: " + ex.Message);
            }
            finally
            {
                DisConnect();
            }
            return soNuoc;
        }
    }
}
