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
    class BLGiaoVien
    {
        DBmain db = null;
        public BLGiaoVien()
        {
            db = new DBmain();
        }
        public DataSet loadGV()
        {
            return db.ExecuteQueryDataSet("select * from GiaoVien", CommandType.Text);
        }
        //load các lớp đang làm chủ nhiệm
        public DataSet loadlop(int maGVCN)
        {
            return db.ExecuteQueryDataSet("select maLop from Lop where maGVCN="+maGVCN+";", CommandType.Text);
        }
        //load các môn đang dạy
        public DataSet loadmondangday(int maGV)
        {
            return db.ExecuteQueryDataSet("select tenMH from DayMon inner join MonHoc on DayMon.maMH=MonHoc.maMH where maGV=" + maGV + ";", CommandType.Text);
        }
        public DataSet Kiemtradadaymonnayhaychua(string MaGV, string MaMH)
        {
            return db.ExecuteQueryDataSet("select count(MaGV) from Day Where MaGV='" + MaGV + "' and MaMH='" + MaMH + "'", CommandType.Text);
        }
        public DataSet LayMon(string MaGV)
        {
            return db.ExecuteQueryDataSet("select TenMH from Day, MonHoc where MaGV='" + MaGV + "' and Day.MaMH=MonHoc.MaMH", CommandType.Text);
        }
        public bool ThemMon(string MaGV, string MaMH, ref string err)
        {
            string sqlString = "Insert Into Day Values(" + "'" + MaGV + "','" + MaMH + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        /*public bool addGV(string TenGV, ref string err)
        {
            string sqlString = "Insert Into GiangVien Values(" + "'" + MaGV + "',N'" + TenGV + "','" + MaKhoa + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool disableGV(ref string err, string maGV)
        {
            string sqlString = "Delete From Day Where MaGV='" + MaGV + "' Delete From GiangVien Where MaGV='" + MaGV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }*/
        public bool CapNhatGiangVien(string MaGV, string TenGV, string MaKhoa, ref string err)
        {
            string sqlString = "Update GiangVien Set TenGV=N'" + TenGV + "',MaKhoa='" + MaKhoa + "' Where MaGV='" + MaGV + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimGV(string tukhoa)
        {
            return db.ExecuteQueryDataSet(@"select * from GiangVien where MaGV like '%" + tukhoa + "%' or TenGV like N'%" + tukhoa + "%'", CommandType.Text);
        }
    }
}
