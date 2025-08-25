using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TransferObject;

namespace QuanLy_DAL
{
    public class DAL_KyLuat : DataProvider
    {
        public List<KyLuat> SelectKyLuat()
        {
            List<KyLuat> kyluatList = new List<KyLuat>();
            string sql = "SELECT * FROM KyLuat";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    KyLuat kl = new KyLuat
                    {
                        MaKyLuat = Convert.ToInt32(reader["makyluat"]),
                        MaSV = reader["masv"].ToString(),
                        KyLuatNoiDung = reader["kyluat"].ToString(),
                        NgayKyLuat = Convert.ToDateTime(reader["ngaykyluat"]),
                        TienPhat = Convert.ToSingle(reader["tienphat"])
                    };
                    kyluatList.Add(kl);
                }
                reader.Close();
                return kyluatList;
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

        public bool InsertKyLuat(KyLuat kl)
        {
            string sql = @"INSERT INTO KyLuat (masv, kyluat, ngaykyluat, tienphat) 
                           VALUES (@masv, @kyluat, @ngaykyluat, @tienphat)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@masv", kl.MaSV),
                new SqlParameter("@kyluat", kl.KyLuatNoiDung),
                new SqlParameter("@ngaykyluat", kl.NgayKyLuat),
                new SqlParameter("@tienphat", kl.TienPhat)
            };
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool UpdateKyLuat(KyLuat kl)
        {
            string sql = @"UPDATE KyLuat SET 
                            masv = @masv, 
                            kyluat = @kyluat, 
                            ngaykyluat = @ngaykyluat, 
                            tienphat = @tienphat 
                           WHERE makyluat = @makyluat";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@masv", kl.MaSV),
                new SqlParameter("@kyluat", kl.KyLuatNoiDung),
                new SqlParameter("@ngaykyluat", kl.NgayKyLuat),
                new SqlParameter("@tienphat", kl.TienPhat),
                new SqlParameter("@makyluat", kl.MaKyLuat)
            };
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public bool DeleteKyLuat(int makyluat)
        {
            string sql = @"DELETE FROM KyLuat WHERE makyluat = @makyluat";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@makyluat", makyluat)
            };
            try
            {
                return MyExecuteNonQuery(sql, CommandType.Text, parameters) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        //public bool ExistsKyLuat(int makyluat)
        //{
        //    string sql = @"SELECT COUNT(*) FROM KyLuat WHERE makyluat = @makyluat";
        //    try
        //    {
        //        List<SqlParameter> parameters = new List<SqlParameter>
        //        {
        //            new SqlParameter("@makyluat", makyluat)
        //        };
        //        object result = MyExecuteScalar(sql, CommandType.Text);
        //        return Convert.ToInt32(result) > 0;
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw ex;
        //    }
        //}

        public List<KyLuat> SearchKyLuat(string keyword, string field)
        {
            List<KyLuat> kyluatList = new List<KyLuat>();
            string sql = $"SELECT * FROM KyLuat WHERE {field} LIKE @keyword";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    KyLuat kl = new KyLuat
                    {
                        MaKyLuat = Convert.ToInt32(reader["makyluat"]),
                        MaSV = reader["masv"].ToString(),
                        KyLuatNoiDung = reader["kyluat"].ToString(),
                        NgayKyLuat = Convert.ToDateTime(reader["ngaykyluat"]),
                        TienPhat = Convert.ToSingle(reader["tienphat"])
                    };
                    kyluatList.Add(kl);
                }
                reader.Close();
                return kyluatList;
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
