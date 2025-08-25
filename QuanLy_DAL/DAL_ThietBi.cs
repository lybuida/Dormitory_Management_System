using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_ThietBi : DataProvider
    {
        public List<ThietBi> GetAllThietBi()
        {
            List<ThietBi> thietbiList = new List<ThietBi>();
            string sql = "SELECT * FROM ThietBi";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    ThietBi thietbi = new ThietBi(
                        Convert.ToInt32(reader["mathietbi"]),
                        reader["maphong"].ToString(),
                        reader["tenthietbi"].ToString(),
                        Convert.ToInt32(reader["soluong"]),
                        reader["tinhtrang"].ToString()
                    );
                    thietbiList.Add(thietbi);
                }
                reader.Close();
                return thietbiList;
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

        public List<ThietBi> GetThietBiTheoPhong(string maphong)
        {
            List<ThietBi> thietbiList = new List<ThietBi>();
            string sql = "SELECT * FROM ThietBi WHERE maphong = @maphong";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maphong", maphong);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ThietBi thietbi = new ThietBi(
                        Convert.ToInt32(reader["mathietbi"]),
                        reader["maphong"].ToString(),
                        reader["tenthietbi"].ToString(),
                        Convert.ToInt32(reader["soluong"]),
                        reader["tinhtrang"].ToString()
                    );
                    thietbiList.Add(thietbi);
                }
                reader.Close();
                return thietbiList;
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

        public bool InsertThietBi(ThietBi tb)
        {
            string sql = @"INSERT INTO ThietBi (maphong, tenthietbi, soluong, tinhtrang)
                           VALUES (@maphong, @tentb, @soluong, @tinhtrang)";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@maphong", tb.Maphong),
                    new SqlParameter("@tentb", tb.Tenthietbi),
                    new SqlParameter("@soluong", tb.Soluong),
                    new SqlParameter("@tinhtrang", tb.Tinhtrang)
                };
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
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

        public bool UpdateThietBi(ThietBi tb)
        {
            string sql = @"UPDATE ThietBi 
                           SET soluong = @soluong, tinhtrang = @tinhtrang, tenthietbi = @tentb
                           WHERE mathietbi = @mathietbi";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@mathietbi", tb.Mathietbi),
                    new SqlParameter("@tentb", tb.Tenthietbi),
                    new SqlParameter("@soluong", tb.Soluong),
                    new SqlParameter("@tinhtrang", tb.Tinhtrang)
                };
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
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

        public bool DeleteThietBi(string mathietbi)
        {
            string sql = "DELETE FROM ThietBi WHERE mathietbi = @mathietbi";
            try
            {
                List<SqlParameter> parameters = new List<SqlParameter>
                {
                    new SqlParameter("@mathietbi", mathietbi)
                };
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
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
