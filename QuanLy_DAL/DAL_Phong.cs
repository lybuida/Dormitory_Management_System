using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_Phong : DataProvider
    {
        public List<Phong> GetAllPhong()
        {
            List<Phong> phongList = new List<Phong>();
            string sql = "SELECT * FROM Phong";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Phong phong = new Phong(
                        reader["maphong"].ToString(),
                        reader["tenphong"].ToString(),
                        Convert.ToInt32(reader["sosv"]),
                        Convert.ToInt32(reader["sosvtoida"]),
                        reader["loaiphong"].ToString(),
                        reader["xeploai"].ToString(),
                        reader["day"].ToString()
                    )
                    {
                        Tinhtrang = reader["tinhtrang"].ToString()
                    };
                    phongList.Add(phong);
                }
                reader.Close();
                return phongList;
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

        public List<string> GetMaPhong()
        {
            List<string> list = new List<string>();
            string sql = "SELECT maphong FROM Phong";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    list.Add(reader["maphong"].ToString());
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

        public List<Phong> GetPhongTrong()
        {
            List<Phong> list = new List<Phong>();
            string sql = "SELECT * FROM Phong WHERE tinhtrang = N'Thiếu'";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    Phong phong = new Phong(
                        reader["maphong"].ToString(),
                        reader["tenphong"].ToString(),
                        Convert.ToInt32(reader["sosv"]),
                        Convert.ToInt32(reader["sosvtoida"]),
                        reader["loaiphong"].ToString(),
                        reader["xeploai"].ToString(),
                        reader["day"].ToString()
                    )
                    {
                        Tinhtrang = reader["tinhtrang"].ToString()
                    };
                    list.Add(phong);
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

        public List<Phong> SearchPhong(string truong, string keyword)
        {
            List<Phong> list = new List<Phong>();
            string sql = $"SELECT * FROM Phong WHERE {truong} LIKE @keyword";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Phong phong = new Phong(
                        reader["maphong"].ToString(),
                        reader["tenphong"].ToString(),
                        Convert.ToInt32(reader["sosv"]),
                        Convert.ToInt32(reader["sosvtoida"]),
                        reader["loaiphong"].ToString(),
                        reader["xeploai"].ToString(),
                        reader["day"].ToString()
                    )
                    {
                        Tinhtrang = reader["tinhtrang"].ToString()
                    };
                    list.Add(phong);
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

        public bool InsertPhong(Phong phong)
        {
            string sql = "INSERT INTO Phong(maphong, tenphong, sosv, sosvtoida, tinhtrang, loaiphong, xeploai, day) " +
                         "VALUES(@maphong, @tenphong, @sosv, @sosvtoida, @tinhtrang, @loaiphong, @xeploai, @day)";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", phong.Maphong);
                cmd.Parameters.AddWithValue("@tenphong", phong.Tenphong);
                cmd.Parameters.AddWithValue("@sosv", phong.Sosv);
                cmd.Parameters.AddWithValue("@sosvtoida", phong.Sosvtoida);
                cmd.Parameters.AddWithValue("@tinhtrang", phong.Tinhtrang);
                cmd.Parameters.AddWithValue("@loaiphong", phong.Loaiphong);
                cmd.Parameters.AddWithValue("@xeploai", phong.Xeploai);
                cmd.Parameters.AddWithValue("@day", phong.Day);
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

        public bool UpdatePhong(Phong phong)
        {
            string sql = "UPDATE Phong SET tenphong = @tenphong, sosvtoida = @sosvtoida, tinhtrang = @tinhtrang, " +
                         "loaiphong = @loaiphong, xeploai = @xeploai, day = @day WHERE maphong = @maphong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@tenphong", phong.Tenphong);
                cmd.Parameters.AddWithValue("@sosvtoida", phong.Sosvtoida);
                cmd.Parameters.AddWithValue("@tinhtrang", phong.Tinhtrang);
                cmd.Parameters.AddWithValue("@loaiphong", phong.Loaiphong);
                cmd.Parameters.AddWithValue("@xeploai", phong.Xeploai);
                cmd.Parameters.AddWithValue("@day", phong.Day);
                cmd.Parameters.AddWithValue("@maphong", phong.Maphong);
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

        public bool DeletePhong(string maphong)
        {
            string sql = "DELETE FROM Phong WHERE maphong = @maphong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@maphong", maphong);
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

        public int CountPhongTheoXepLoai(string xeploai)
        {
            string sql = "SELECT COUNT(*) FROM Phong WHERE xeploai = @xeploai";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@xeploai", xeploai);
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

        public int CountPhongTheoLoai(string loaiphong)
        {
            string sql = "SELECT COUNT(*) FROM Phong WHERE loaiphong = @loaiphong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.Parameters.AddWithValue("@loaiphong", loaiphong);
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
    }
}
