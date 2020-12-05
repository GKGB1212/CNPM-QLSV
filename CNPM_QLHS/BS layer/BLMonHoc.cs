using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CNPM_QLHS.DB_layer;

namespace CNPM_QLHS.BS_layer
{
    class BLMonHoc
    {
        DBmain db = null;
        public BLMonHoc()
        {
            db = new DBmain();
        }
        public DataSet loadMH()
        {
            return db.ExecuteQueryDataSet("loadMH", CommandType.StoredProcedure);
        }
        public DataSet loadGVdayMon(int maMH)//hien gv theo mon day
        {
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            List<SqlParameter> idMH = new List<SqlParameter>();
            idMH.Add(MaMH);
            return db.ExecuteQueryDataSet("loadGVdayMon", CommandType.StoredProcedure,idMH);
        }
        public bool themMon(String tenMH)
        {
            SqlParameter TenMH = new SqlParameter("@tenMH", tenMH);
            List<SqlParameter> nameMH = new List<SqlParameter>();
            nameMH.Add(TenMH);
            return db.MyExecuteNonQuery("themMon", CommandType.StoredProcedure, nameMH);
        }
        public bool suaMon(int maMH,String tenMH)
        {
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            SqlParameter TenMH = new SqlParameter("@tenMH", tenMH);
            List<SqlParameter> MH = new List<SqlParameter>();
            MH.Add(MaMH);
            MH.Add(TenMH);
            return db.MyExecuteNonQuery("suaMon", CommandType.StoredProcedure, MH);
        }
        public bool themGVDayMH(int maGV,int maMH)
        {
            SqlParameter MaGV = new SqlParameter("@maGV", maGV);
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            List<SqlParameter> MH = new List<SqlParameter>();
            MH.Add(MaGV);
            MH.Add(MaMH);
            return db.MyExecuteNonQuery("themGVDayMH", CommandType.StoredProcedure, MH);
        }
        /*
        public bool ThemMon(string MaMon, string TenMon, ref string err)
        {
            string sqlString = "Insert Into MonHoc Values(" + "'" + MaMon + "',N'" + TenMon + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaMon(ref string err, string MaMon)
        {
            string sqlString = "Delete From MonHoc Where MaMH='" + MaMon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatMon(string MaMon, string TenMon, ref string err)
        {
            string sqlString = "Update MonHoc Set TenMH=N'" + TenMon + "' Where MaMH='" + MaMon + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimMon(string tukhoa)
        {
            return db.ExecuteQueryDataSet(@"select * from MonHoc where MaMH like '%" + tukhoa + "%' or TenMH like N'%" + tukhoa + "%'", CommandType.Text);
        }*/
    }
}
