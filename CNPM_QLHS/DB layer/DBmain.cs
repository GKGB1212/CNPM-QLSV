using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace CNPM_QLHS.DB_layer
{
    class DBmain
    {
        string ConnStr = @"Data Source=DESKTOP-L9FILE2\SQLEXPRESS;Initial Catalog=QLSV_CNPM;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public DBmain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            comm.Parameters.Clear();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, List<SqlParameter> param)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            comm.Parameters.Clear();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }
        
        //lấy 1 table có parameter truyền vào
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strSQL"></param>
        /// <param name="ct"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, List<SqlParameter> param)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            foreach (SqlParameter p in param)
                comm.Parameters.Add(p);
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
            }

            finally
            {
                conn.Close();
            }

            return f;
        }

        public string FindOneValue(string strSQL, CommandType ct, SqlParameter parameter)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.Parameters.Clear();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.Add(parameter);
            try
            {
                da = new SqlDataAdapter(comm);
                DataTable ds = new DataTable();
                da.Fill(ds);
                if (ds.Rows.Count == 0) return null;
                else
                    return ds.Rows[0][0].ToString();
            }
            catch (SqlException ex)
            {
                return null;
            }

            finally
            {
                conn.Close();
            }
        }

        /// <summary>
        /// Đưa vào một list các biến và chuỗi các @bien tạo thanh list <sqlparameter>
        /// </summary>
        /// <param name="array"></param>
        /// <param name="vars"></param>
        /// <returns></returns>
        public List<SqlParameter> turntoListParam(ArrayList array, string[] vars)
        {
            List<SqlParameter> list = new List<SqlParameter>();

            for (int i = 0; i < vars.Length; i++)
            {
                SqlParameter parameter = new SqlParameter(vars[i], array[i]);
                list.Add(parameter);
            }

            return list;
        }
    }
}
