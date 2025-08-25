using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace QuanLy_DAL
{
    public class DataProvider
    {
        public SqlConnection cn;

        public DataProvider()
        {
            //Link của chi, mn đổi cái khác nha
            //string cnStr = "Data Source=DESKTOP-8862V4F\\LEGIANG2;Initial Catalog=QuanLyKyTucXa;Integrated Security=True;TrustServerCertificate=True";
            string cnStr = "Data Source=DESKTOP-AA20CEC\\LITTLETEETH;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";

            //string cnStr = "Data Source=LAPTOP-MAMQ0DB1\\LION;Initial Catalog=QuanLyKyTucXa;Integrated Security=True";
            //string cnStr = "Data Source=DESKTOP-8862V4F\\LEGIANG2;Initial Catalog=QuanLyKyTucXa;Integrated Security=True;Trust Server Certificate=True";
            cn = new SqlConnection(cnStr);
        }

        public void Connect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void DisConnect()
        {
            try
            {
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public object MyExecuteScalar(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (parameters != null)
                {
                    foreach (var p in parameters)
                        cmd.Parameters.Add(p);
                }
                return cmd.ExecuteScalar();
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

        public SqlDataReader MyExecuteReader(string sql, CommandType type)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                return (cmd.ExecuteReader());
            }
            catch (SqlException ex)
            {
                throw ex;
            }

        }

        //public int ExecuteNonQuery(string sql, CommandType commandType, SqlParameter[] parameters = null)
        //{
        //    try
        //    {
        //        Connect();
        //        using (SqlCommand cmd = new SqlCommand(sql, cn ))
        //        {
        //            cmd.CommandType = commandType;
        //            if (parameters != null)
        //                cmd.Parameters.AddRange(parameters);

        //            return cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Lỗi thực thi ExecuteNonQuery: " + ex.Message);
        //    }
        //    finally
        //    {
        //        DisConnect();
        //    }
        //}
        public int MyExecuteNonQuery(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                        cmd.Parameters.Add(parameter);
                }

                return cmd.ExecuteNonQuery();
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
