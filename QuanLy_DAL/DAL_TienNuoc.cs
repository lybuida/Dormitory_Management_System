using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_TienNuoc : DataProvider
    {
        public List<TienNuoc> SelectTienNuoc()
        {
            List<TienNuoc> list = new List<TienNuoc>();
            string sql = "SELECT * FROM TienNuoc";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    TienNuoc tn = new TienNuoc
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sokhoitieuthu = Convert.ToInt32(reader["sokhoitieuthu"]),
                        Tongtien = Convert.ToSingle(reader["tongtien"]),
                        Trangthai = reader["trangthai"].ToString()
                    };
                    list.Add(tn);
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

        public int SelectSoKhoi(string mahoadon)
        {
            string sql = "SELECT sokhoitieuthu FROM TienNuoc WHERE mahoadon = @mahoadon";
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
                           FROM TienNuoc 
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

        public TienNuoc SelectHoaDonKeTiep(string maphong, DateTime ngaylap)
        {
            string sql = @"SELECT TOP 1 * 
                           FROM TienNuoc 
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
                    return new TienNuoc
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sokhoitieuthu = Convert.ToInt32(reader["sokhoitieuthu"]),
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

        public int SelectChiSoCu(string maphong)
        {
            string sql = @"SELECT chisocu
                           FROM TienNuoc
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

        public void UpdateTrangThai(string mahoadon, string trangthai)
        {
            string sql = @"UPDATE TienNuoc SET trangthai = @trangthai WHERE mahoadon = @mahoadon";
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

        public void InsertTienNuoc(TienNuoc tn)
        {
            string sql = @"INSERT INTO TienNuoc (maphong, ngaylap, chisocu, chisomoi, sokhoitieuthu, tongtien, trangthai) 
                           VALUES (@maphong, @ngaylap, @chisocu, @chisomoi, @sokhoitieuthu, @tongtien, @trangthai)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", tn.Maphong);
                cmd.Parameters.AddWithValue("@ngaylap", tn.Ngaylap);
                cmd.Parameters.AddWithValue("@chisocu", tn.Chisocu);
                cmd.Parameters.AddWithValue("@chisomoi", tn.Chisomoi);
                cmd.Parameters.AddWithValue("@sokhoitieuthu", tn.Sokhoitieuthu);
                cmd.Parameters.AddWithValue("@tongtien", tn.Tongtien);
                cmd.Parameters.AddWithValue("@trangthai", tn.Trangthai);
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

        public void UpdateTienNuoc(TienNuoc tn)
        {
            string sql = @"UPDATE TienNuoc 
                           SET maphong=@maphong, ngaylap=@ngaylap, chisocu=@chisocu, chisomoi=@chisomoi, 
                               sokhoitieuthu=@sokhoitieuthu, tongtien=@tongtien, trangthai=@trangthai 
                           WHERE mahoadon=@mahoadon";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", tn.Maphong);
                cmd.Parameters.AddWithValue("@ngaylap", tn.Ngaylap);
                cmd.Parameters.AddWithValue("@chisocu", tn.Chisocu);
                cmd.Parameters.AddWithValue("@chisomoi", tn.Chisomoi);
                cmd.Parameters.AddWithValue("@sokhoitieuthu", tn.Sokhoitieuthu);
                cmd.Parameters.AddWithValue("@tongtien", tn.Tongtien);
                cmd.Parameters.AddWithValue("@trangthai", tn.Trangthai);
                cmd.Parameters.AddWithValue("@mahoadon", tn.Mahoadon);
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

        public void DeleteTienNuoc(string mahoadon)
        {
            string sql = "DELETE FROM TienNuoc WHERE mahoadon = @mahoadon";
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

        public List<TienNuoc> SearchTienNuoc(string keyword, string truong)
        {
            List<TienNuoc> list = new List<TienNuoc>();
            string sql = $"SELECT * FROM TienNuoc WHERE {truong} LIKE @keyword";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TienNuoc tn = new TienNuoc
                    {
                        Mahoadon = Convert.ToInt32(reader["mahoadon"]),
                        Maphong = reader["maphong"].ToString(),
                        Ngaylap = Convert.ToDateTime(reader["ngaylap"]),
                        Chisocu = Convert.ToInt32(reader["chisocu"]),
                        Chisomoi = Convert.ToInt32(reader["chisomoi"]),
                        Sokhoitieuthu = Convert.ToInt32(reader["sokhoitieuthu"]),
                        Tongtien = Convert.ToSingle(reader["tongtien"]),
                        Trangthai = reader["trangthai"].ToString()
                    };
                    list.Add(tn);
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

        public bool CheckExistsTienNuoc(string maphong, DateTime ngaylap)
        {
            string sql = "SELECT COUNT(*) FROM TienNuoc WHERE Maphong = @maphong AND CONVERT(DATE, Ngaylap) = @ngaylap";
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
