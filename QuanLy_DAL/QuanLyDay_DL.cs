using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace QuanLy_DAL
{
    public class QuanLyDay_DL: DataProvider
    {
        // Tải Danh sách lên để chờ duyệt
        public List<DayPhong> LayDanhSachDay()
        {
            string maday, tenday, quanly, trangthai, daygioitinh;
            List<DayPhong> dayPhongs = new List<DayPhong>();
            string sql = "SELECT * FROM Day";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    maday = reader[0].ToString();
                    tenday = reader[1].ToString();
                    quanly = reader[2].ToString();
                    trangthai = reader[3].ToString();
                    daygioitinh = reader[4].ToString();

                    DayPhong dayPhong = new DayPhong(maday, tenday, quanly, trangthai, daygioitinh);
                    dayPhongs.Add(dayPhong);
                }
                reader.Close();
                return dayPhongs;
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

        // Lấy Dữ liệu Nhân viên
        public List<NhanVien> LayDanhSachNhanVien()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT manv, tennv FROM NhanVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    string manv = reader[0].ToString();
                    string tennv = reader[1].ToString();
                    NhanVien nv = new NhanVien(manv, tennv, "", "", "", "");
                    nhanViens.Add(nv);
                }
                reader.Close();
                return nhanViens;
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

        public bool ThemDay(DayPhong dayPhong)
        {
            string sql = "INSERT INTO Day(maday, tenday, quanly, trangthai, daygioitinh) VALUES(@ma, @ten, @ql, @tt, @dgt)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@ma", dayPhong.maday);
                cmd.Parameters.AddWithValue("@ten", dayPhong.tenday);
                cmd.Parameters.AddWithValue("@ql", dayPhong.quanly);
                cmd.Parameters.AddWithValue("@tt", dayPhong.trangthai);
                cmd.Parameters.AddWithValue("@dgt", dayPhong.daygioitinh);

                int result = cmd.ExecuteNonQuery();
                return result > 0;
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

        public bool SuaDay(DayPhong dayPhong)
        {
            string sql = "UPDATE Day SET tenday = @ten, quanly = @ql, trangthai = @tt, daygioitinh = @dgt WHERE maday = @ma";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@ma", dayPhong.maday);
                cmd.Parameters.AddWithValue("@ten", dayPhong.tenday);
                cmd.Parameters.AddWithValue("@ql", dayPhong.quanly);
                cmd.Parameters.AddWithValue("@tt", dayPhong.trangthai);
                cmd.Parameters.AddWithValue("@dgt", dayPhong.daygioitinh);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
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
        public bool XoaDay(string maDay)
        {
            string sql = "DELETE FROM Day WHERE maday = @ma";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@ma", maDay);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
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
    }
}
