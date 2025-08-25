using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_TienDien : DataProvider
    {
        public List<TienDien> SelectTienDien()
        {
            List<TienDien> list = new List<TienDien>();
            string sql = "SELECT * FROM TienDien";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    TienDien td = new TienDien
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sodientieuthu = Convert.ToInt32(reader["sodientieuthu"]),
                        Tongtien = Convert.ToSingle(reader["tongtien"]),
                        Trangthai = reader["trangthai"].ToString()
                    };
                    list.Add(td);
                }
                reader.Close();
                return list;
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

        public int SelectSoDien(string mahoadon)
        {
            string sql = "SELECT sodientieuthu FROM TienDien WHERE mahoadon = @mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
                object result = cmd.ExecuteScalar();
                return Convert.ToInt32(result);
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

        public int SelectChiSoMoiGanNhat(string maphong)
        {
            string sql = @"SELECT TOP 1 chisomoi 
                           FROM TienDien 
                           WHERE maphong = @maphong 
                           ORDER BY ngaylap DESC, mahoadon DESC";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
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

        public int SelectChiSoCu(string maphong)
        {
            string sql = @"SELECT chisocu 
                           FROM TienDien 
                           WHERE maphong = '" + maphong + "'";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
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

        public TienDien SelectHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            string sql = @"SELECT TOP 1 * 
                           FROM TienDien 
                           WHERE maphong = @maphong AND ngaylap > @ngaylap 
                           ORDER BY ngaylap ASC";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
                cmd.Parameters.AddWithValue("@ngaylap", ngaylap);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new TienDien
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sodientieuthu = Convert.ToInt32(reader["sodientieuthu"]),
                        Tongtien = Convert.ToSingle(reader["tongtien"]),
                        Trangthai = reader["trangthai"].ToString()
                    };
                }
                reader.Close();
                return null;
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

        public void InsertTienDien(TienDien td)
        {
            string sql = @"INSERT INTO TienDien (maphong, ngaylap, chisocu, chisomoi, sodientieuthu, tongtien, trangthai) 
                           VALUES (@maphong, @ngaylap, @chisocu, @chisomoi, @sodientieuthu, @tongtien, @trangthai)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", td.Maphong);
                cmd.Parameters.AddWithValue("@ngaylap", td.Ngaylap);
                cmd.Parameters.AddWithValue("@chisocu", td.Chisocu);
                cmd.Parameters.AddWithValue("@chisomoi", td.Chisomoi);
                cmd.Parameters.AddWithValue("@sodientieuthu", td.Sodientieuthu);
                cmd.Parameters.AddWithValue("@tongtien", td.Tongtien);
                cmd.Parameters.AddWithValue("@trangthai", td.Trangthai);
                cmd.ExecuteNonQuery();
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

        public void UpdateTienDien(TienDien td)
        {
            string sql = @"UPDATE TienDien SET 
                           maphong=@maphong, ngaylap=@ngaylap, chisocu=@chisocu, chisomoi=@chisomoi, 
                           sodientieuthu=@sodientieuthu, tongtien=@tongtien, trangthai=@trangthai 
                           WHERE mahoadon=@mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", td.Maphong);
                cmd.Parameters.AddWithValue("@ngaylap", td.Ngaylap);
                cmd.Parameters.AddWithValue("@chisocu", td.Chisocu);
                cmd.Parameters.AddWithValue("@chisomoi", td.Chisomoi);
                cmd.Parameters.AddWithValue("@sodientieuthu", td.Sodientieuthu);
                cmd.Parameters.AddWithValue("@tongtien", td.Tongtien);
                cmd.Parameters.AddWithValue("@trangthai", td.Trangthai);
                cmd.Parameters.AddWithValue("@mahoadon", td.Mahoadon);
                cmd.ExecuteNonQuery();
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

        public void DeleteTienDien(string mahoadon)
        {
            string sql = "DELETE FROM TienDien WHERE mahoadon = @mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
                cmd.ExecuteNonQuery();
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

        public void UpdateTrangThai(string mahoadon, string trangthai)
        {
            string sql = @"UPDATE TienDien SET trangthai = @trangthai WHERE mahoadon = @mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@trangthai", trangthai);
                cmd.Parameters.AddWithValue("@mahoadon", mahoadon);
                cmd.ExecuteNonQuery();
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

        public List<TienDien> SearchTienDien(string keyword, string truong)
        {
            List<TienDien> list = new List<TienDien>();
            string sql = $"SELECT * FROM TienDien WHERE {truong} LIKE @keyword";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TienDien td = new TienDien
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sodientieuthu = Convert.ToInt32(reader["sodientieuthu"]),
                        Tongtien = Convert.ToSingle(reader["tongtien"]),
                        Trangthai = reader["trangthai"].ToString()
                    };
                    list.Add(td);
                }
                reader.Close();
                return list;
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

        public bool CheckExistsTienDien(string maphong, DateTime ngaylap)
        {
            string sql = "SELECT COUNT(*) FROM TienDien WHERE Maphong = @maphong AND CONVERT(DATE, Ngaylap) = @ngaylap";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@maphong", maphong),
                new SqlParameter("@ngaylap", ngaylap.Date)
            };
            int count = (int)MyExecuteScalar(sql, CommandType.Text, parameters);
            return count > 0;
        }
    }
}
