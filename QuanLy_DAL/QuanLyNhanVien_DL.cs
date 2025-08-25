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
    public class QuanLyNhanVien_DL : DataProvider
    {
        public List<NhanVien> LayDanhSachNhanVien()
        {
            string manv, tennv, gioitinh, ngaysinh, diachi,  sodienthoai;
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql = "SELECT * FROM NhanVien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    manv = reader[0].ToString();
                    tennv = reader[1].ToString();
                    gioitinh = reader[2].ToString();
                    ngaysinh = reader[3].ToString();
                    diachi = reader[4].ToString();
                    sodienthoai = reader[5].ToString();

                    NhanVien nhanVien = new NhanVien(manv, tennv, gioitinh, ngaysinh, diachi,  sodienthoai);
                    nhanViens.Add(nhanVien);
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

        public int ThemNhanVien(NhanVien nv)
        {
            string sql = "uspThemNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@manv", nv.manv));
            parameters.Add(new SqlParameter("@tennv", nv.tennv));
            parameters.Add(new SqlParameter("@gioitinh", nv.gioitinh));
            parameters.Add(new SqlParameter("@ngaysinh", DateTime.Parse(nv.ngaysinh)));
            parameters.Add(new SqlParameter("@diachi", nv.diachi));
            parameters.Add(new SqlParameter("@sodienthoai", nv.sodienthoai));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        public int XoaNhanVien(string manv)
        {
            string sql = "uspXoaNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@manv", manv));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CapNhapNhanVien(NhanVien nv)
        {
            string sql = "uspCapNhapNhanVien";
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@manv", nv.manv));
            parameters.Add(new SqlParameter("@tennv", nv.tennv));
            parameters.Add(new SqlParameter("@gioitinh", nv.gioitinh));
            parameters.Add(new SqlParameter("@ngaysinh", DateTime.Parse(nv.ngaysinh)));
            parameters.Add(new SqlParameter("@diachi", nv.diachi));
            parameters.Add(new SqlParameter("@sodienthoai", nv.sodienthoai));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<NhanVien> TimKiemNhanVien(string keyword, bool timTheoMa)
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            string sql;
            if (timTheoMa)
                sql = "SELECT * FROM NhanVien WHERE manv LIKE @keyword";
            else
                sql = "SELECT * FROM NhanVien WHERE tennv LIKE @keyword";

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    NhanVien nv = new NhanVien(
                        reader["manv"].ToString(),
                        reader["tennv"].ToString(),
                        reader["gioitinh"].ToString(),
                        reader["ngaysinh"].ToString(),
                        reader["diachi"].ToString(),
                        reader["sodienthoai"].ToString()
                    );
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
    }
}
