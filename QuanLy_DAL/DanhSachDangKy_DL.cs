using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using System.Data.SqlClient;
using System.Data;

namespace QuanLy_DAL
{
    public class DanhSachDangKy_DL : DataProvider
    {
        // Tải Danh sách lên để chờ duyệt
        public List<SinhVienDangKy> LayDSSinhVienDangKy()
        {
            string masvdky, tensv, gioitinh, ngaysinh, quequan, email, khoa, lop, loaiuutien;
            List<SinhVienDangKy> sinhVienDangKys = new List<SinhVienDangKy>();
            string sql = "SELECT * FROM SinhVienDangKy";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    masvdky = reader[0].ToString();
                    tensv = reader[1].ToString();
                    gioitinh = reader[2].ToString();
                    ngaysinh = reader[3].ToString();
                    quequan = reader[4].ToString();
                    email = reader[5].ToString();
                    khoa = reader[6].ToString();
                    lop = reader[7].ToString();
                    loaiuutien = reader[8].ToString();

                    SinhVienDangKy sinhVienDangKy = new SinhVienDangKy(masvdky, tensv, gioitinh, ngaysinh, quequan, email, khoa, lop, loaiuutien);
                    sinhVienDangKys.Add(sinhVienDangKy);
                }
                reader.Close();
                return sinhVienDangKys;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        // Tải danh sách sinh viên đăng đã được duyệt rồi
        public List<SinhVien> LayDSSinhVien()
        {
            string masv, tensv, gioitinh, ngaysinh, quequan, email, khoa, lop, loaiuutien, maphong;
            List<SinhVien> sinhViens = new List<SinhVien>();
            string sql = "SELECT * FROM SinhVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    masv = reader[0].ToString();
                    tensv = reader[1].ToString();
                    gioitinh = reader[2].ToString();
                    ngaysinh = reader[3].ToString();
                    quequan = reader[4].ToString();
                    email = reader[5].ToString();
                    khoa = reader[6].ToString();
                    lop = reader[7].ToString();
                    loaiuutien = reader[8].ToString();
                    maphong = reader[9].ToString();

                    SinhVien sinhVien = new SinhVien(masv, tensv, gioitinh, ngaysinh, quequan, email, khoa, lop, loaiuutien, maphong);
                    sinhViens.Add(sinhVien);
                }
                reader.Close();
                return sinhViens;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public bool CapNhatSinhVienDangKy(SinhVienDangKy sv)
        {
            string sql = @"UPDATE SinhVienDangKy 
                   SET tensv = @tensv, 
                       gioitinh = @gioitinh, 
                       ngaysinh = @ngaysinh, 
                       quequan = @quequan, 
                       email = @email,
                       khoa = @khoa, 
                       lop = @lop, 
                       loaiuutien = @loaiuutien 
                   WHERE masvdky = @masvdky";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masvdky", sv.masvdky);
                cmd.Parameters.AddWithValue("@tensv", sv.tensv);
                cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                cmd.Parameters.AddWithValue("@quequan", sv.quequan);
                cmd.Parameters.AddWithValue("@email", sv.email);
                cmd.Parameters.AddWithValue("@khoa", sv.khoa);
                cmd.Parameters.AddWithValue("@lop", sv.lop);
                cmd.Parameters.AddWithValue("@loaiuutien", sv.loaiuutien);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public void ThemSinhVien(SinhVien sv)
        {
            string sql = @"INSERT INTO SinhVien 
                        VALUES (@masv, @tensv, @gioitinh, @ngaysinh, 
                                @quequan, @email, @khoa, @lop, 
                                @loaiuutien, @maphong)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masv", sv.masv);
                cmd.Parameters.AddWithValue("@tensv", sv.tensv);
                cmd.Parameters.AddWithValue("@gioitinh", sv.gioitinh);
                cmd.Parameters.AddWithValue("@ngaysinh", sv.ngaysinh);
                cmd.Parameters.AddWithValue("@quequan", sv.quequan);
                cmd.Parameters.AddWithValue("@email", sv.email);
                cmd.Parameters.AddWithValue("@khoa", sv.khoa);
                cmd.Parameters.AddWithValue("@lop", sv.lop);
                cmd.Parameters.AddWithValue("@loaiuutien", sv.loaiuutien);
                cmd.Parameters.AddWithValue("@maphong", sv.maphong);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }

        public void XoaSinhVienDangKy(string masvdky)
        {
            string sql = "DELETE FROM SinhVienDangKy WHERE masvdky = @masvdky";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@masvdky", masvdky);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }

        public List<Phong> LayPhongTheoDieuKien(string gioiTinh, string tinhTrang)
        {
            List<Phong> phongs = new List<Phong>();
            string sql = @"SELECT * FROM Phong 
                 WHERE loaiphong = @gioiTinh 
                   AND tinhtrang = @tinhTrang";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@gioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    
                    Phong phong = new Phong(
                        reader["maphong"].ToString(),
                        reader["tenphong"].ToString(),
                        reader["sosv"].ToString(),
                        reader["sosvtoida"].ToString(),
                        reader["tinhtrang"].ToString(),
                        reader["loaiphong"].ToString(),
                        reader["xeploai"].ToString(),
                        reader["day"].ToString()
                    );
                    phongs.Add(phong);
                }
                reader.Close();
                return phongs;
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }

        public void CapNhatSoSV(string maPhong)
        {
            string sql = @"UPDATE Phong 
                   SET sosv = sosv + 1,
                       tinhtrang = CASE 
                          WHEN (sosv + 1) >= sosvtoida THEN N'Đủ'
                          ELSE N'Thiếu' END
                   WHERE maphong = @maPhong";
            try
            {
                DataProvider provider = new DataProvider();
                provider.Connect();
                SqlCommand cmd = new SqlCommand(sql, provider.cn);
                cmd.Parameters.AddWithValue("@maPhong", maPhong);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }

        public int LaySoSVHienTai(string maPhong)
        {
            string sql = "SELECT sosv FROM Phong WHERE maphong = @maPhong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maPhong", maPhong);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }

        public bool XoaTatCaSinhVienDangKy()
        {
            string sql = "DELETE FROM SinhVienDangKy";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                int rowsAffected = cmd.ExecuteNonQuery();
                return rowsAffected > 0;
            }
            catch (SqlException ex) { throw ex; }
            finally { DisConnect(); }
        }
    }
}