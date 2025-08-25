using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;


namespace QuanLy_DAL
{
    public class SinhVienDangKy_DL : DataProvider
    {
        public bool KiemTraTrungMa(string maSV)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SinhVienDangKy WHERE masvdky = @masvdky", cn);
                cmd.Parameters.AddWithValue("@masvdky", maSV);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        // Thêm phương thức này
        public bool ThemSinhVienDangKy(SinhVienDangKy sv)
        {
            try
            {
                Connect(); // Mở kết nối từ lớp cha DataProvider
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO SinhVienDangKy (masvdky, tensv, gioitinh, ngaysinh, quequan, email, khoa, lop, loaiuutien) " +
                    "VALUES (@masvdky, @tensv, @gioitinh, @ngaysinh, @quequan, @email, @khoa, @lop, @loaiuutien)",
                    cn // Sử dụng kết nối từ DataProvider
                );

                // Thêm các tham số
                cmd.Parameters.AddWithValue("@masvdky", sv.masvdky);
                cmd.Parameters.AddWithValue("@tensv", sv.tensv);
                cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                cmd.Parameters.AddWithValue("@quequan", sv.quequan);
                cmd.Parameters.AddWithValue("@email", sv.email);
                cmd.Parameters.AddWithValue("@khoa", sv.khoa);
                cmd.Parameters.AddWithValue("@lop", sv.lop);
                cmd.Parameters.AddWithValue("@loaiuutien", sv.loaiuutien);

                // Thực thi và trả về kết quả
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect(); // Đóng kết nối từ DataProvider
            }
        }
    }
}
