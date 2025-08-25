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
    public class QuanLyNguoiDung_DL : DataProvider
    {
        // Tải Danh sách lên
        public List<QuanLyNguoiDung> LayDanhSachNguoiDung()
        {
            string manguoidung, tendangnhap, matkhau;
            List<QuanLyNguoiDung> qlNguoiDungs = new List<QuanLyNguoiDung>();
            string sql = "SELECT * FROM NguoiDung";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    manguoidung = reader[0].ToString();
                    tendangnhap = reader[1].ToString();
                    matkhau = reader[2].ToString();

                    QuanLyNguoiDung qlNguoiDung = new QuanLyNguoiDung(manguoidung, tendangnhap, matkhau);
                    qlNguoiDungs.Add(qlNguoiDung);
                }
                reader.Close();
                return qlNguoiDungs;
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

        public bool ThemNguoiDung(QuanLyNguoiDung quanLyNguoiDung)
        {
            string sql = "INSERT INTO NguoiDung (tendangnhap, matkhau) VALUES (@tendangnhap, @matkhau)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tendangnhap", quanLyNguoiDung.tendangnhap);
                cmd.Parameters.AddWithValue("@matkhau", quanLyNguoiDung.matkhau);
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
        public bool SuaNguoiDung(QuanLyNguoiDung quanLyNguoiDung)
        {
            string sql = "UPDATE NguoiDung SET tendangnhap = @tendangnhap, matkhau = @matkhau WHERE manguoidung = @manguoidung";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tendangnhap", quanLyNguoiDung.tendangnhap);
                cmd.Parameters.AddWithValue("@matkhau", quanLyNguoiDung.matkhau);
                cmd.Parameters.AddWithValue("@manguoidung", quanLyNguoiDung.manguoidung);
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

        public bool XoaNguoiDung(string manguoidung)
        {
            string sql = "DELETE FROM NguoiDung WHERE manguoidung = @manguoidung";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@manguoidung", manguoidung);
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

        public List<QuanLyNguoiDung> TimKiemNguoiDung(string keyword, bool timTheoMa)
        {
            List<QuanLyNguoiDung> quanLyNguoiDungs = new List<QuanLyNguoiDung>();
            string sql;
            if (timTheoMa)
                sql = "SELECT * FROM NguoiDung WHERE manguoidung LIKE @keyword";
            else
                sql = "SELECT * FROM NguoiDung WHERE tendangnhap LIKE @keyword";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    QuanLyNguoiDung nd = new QuanLyNguoiDung(
                        reader["manguoidung"].ToString(),
                        reader["tendangnhap"].ToString(),
                        reader["matkhau"].ToString()
                    );
                    quanLyNguoiDungs.Add(nd);
                }
                reader.Close();
                return quanLyNguoiDungs;
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
