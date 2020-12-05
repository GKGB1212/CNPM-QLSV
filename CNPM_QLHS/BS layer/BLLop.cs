using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CNPM_QLHS.DB_layer;

namespace CNPM_QLHS.BS_layer
{
    class BLLop
    {
        DBmain db = null;
        public BLLop()
        {
            db = new DBmain();
        }
        public DataSet loadAllClass()
        {
            return db.ExecuteQueryDataSet("HienToanBoLop", CommandType.StoredProcedure);
        }
        //load class theo namhoc
        public DataSet loadClass(int namHoc)
        {
            SqlParameter NamHoc = new SqlParameter("@namHoc", namHoc);
            List<SqlParameter> loadclass = new List<SqlParameter>();
            loadclass.Add(NamHoc);
            return db.ExecuteQueryDataSet("HienLopTheoNam", CommandType.StoredProcedure, loadclass);
        }
        //lấy si so cua lop
        public String SiSo(int idLop)
        {
            SqlParameter IdLop = new SqlParameter("@idLop", idLop);
            return db.FindOneValue("LaySiSoLop", CommandType.StoredProcedure, IdLop);
        }
        public bool addClass(int namHoc,int maGVCN, ref string err)
        {
            string sqlString = "INSERT INTO TEN_BANG(namHoc,maGVCN) VALUES(" + namHoc + ", " + maGVCN + ");";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
