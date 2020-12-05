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
    class BLBangDiem
    {
        DBmain db = null;
        public BLBangDiem()
        {
            db = new DBmain();
        }
        //load điểm theo mã học sinh
        public DataSet timDiemTheoMaHS(int maHS)
        {
            SqlParameter MaHS = new SqlParameter("@maHS", maHS);
            List<SqlParameter> HS = new List<SqlParameter>();
            HS.Add(MaHS);
            return db.ExecuteQueryDataSet("timDiemTheoMaHS", CommandType.StoredProcedure, HS);
        }
        public DataSet timDiemTheoMaLop(int maLop)
        {
            SqlParameter MaLop = new SqlParameter("@maLop", maLop);
            List<SqlParameter> BD = new List<SqlParameter>();
            BD.Add(MaLop);
            return db.ExecuteQueryDataSet("timDiemTheoMaLop", CommandType.StoredProcedure, BD);
        }
        public DataSet timDiemTheoMaMH(int maMH)
        {
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            List<SqlParameter> BD = new List<SqlParameter>();
            BD.Add(MaMH);
            return db.ExecuteQueryDataSet("timDiemTheoMaMH", CommandType.StoredProcedure, BD);
        }
        //load điểm theo mã lớp và mã môn
        public DataSet timDiemTheoMaLopMaMon(int maLop, int maMH)
        {
            SqlParameter MaLop = new SqlParameter("@maLop", maLop);
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            List<SqlParameter> BD = new List<SqlParameter>();
            BD.Add(MaLop);
            BD.Add(MaMH);
            return db.ExecuteQueryDataSet("timDiemTheoMaLopMaMon", CommandType.StoredProcedure, BD);
        }
        public DataSet timDiemTheoCa3(int maLop, int maMH,int maHS)
        {
            SqlParameter MaLop = new SqlParameter("@maLop", maLop);
            SqlParameter MaMH = new SqlParameter("@maMH", maMH);
            SqlParameter MaHS = new SqlParameter("@maHS", maHS);
            List<SqlParameter> BD = new List<SqlParameter>();
            BD.Add(MaLop);
            BD.Add(MaMH);
            BD.Add(MaHS);
            return db.ExecuteQueryDataSet("timDiemTheoCa3", CommandType.StoredProcedure, BD);
        }
    }
}
