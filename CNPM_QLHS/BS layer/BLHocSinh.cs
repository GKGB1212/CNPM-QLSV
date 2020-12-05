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
    class BLHocSinh
    {
        DBmain db = null;
        public BLHocSinh()
        {
            db = new DBmain();
        }
        public DataSet loadData()
        {
            return db.ExecuteQueryDataSet("HienToanBoHocSinh", CommandType.StoredProcedure);
        }
        public DataSet loadAllStudent()
        {
            return db.ExecuteQueryDataSet("HienToanBoLop", CommandType.StoredProcedure);
        }
        //load class theo namhoc
        public DataSet loadStudent(int idLop)
        {
            SqlParameter IdLop = new SqlParameter("@idLop", idLop);
            List<SqlParameter> loadstudent = new List<SqlParameter>();
            loadstudent.Add(IdLop);
            return db.ExecuteQueryDataSet("DanhSachHocSinhTheoLop", CommandType.StoredProcedure, loadstudent);
        }
        public bool CapNhapHocSinh(int maHS,String tenHS, int namSinh, String gioiTinh, String danToc, String diaChi,String hoTenCha,int namSinhCha, String ngheNghiepCha, String hotenMe, int namSinhMe,String ngheNghiepMe,int maLop)
        {
            SqlParameter MaHS = new SqlParameter("@maHS", maHS);
            SqlParameter TenHS = new SqlParameter("@tenHS", tenHS);
            SqlParameter NamSinh = new SqlParameter("@namSinh", namSinh);
            SqlParameter GioiTinh = new SqlParameter("@gioiTinh", gioiTinh);
            SqlParameter DanToc = new SqlParameter("@danToc", danToc);
            SqlParameter DiaChi = new SqlParameter("@diaChi", diaChi);
            SqlParameter HoTenCha = new SqlParameter("@hoTenCha", hoTenCha);
            SqlParameter NamSinhCha = new SqlParameter("@namSinhCha", namSinhCha);
            SqlParameter NghenghiepCha = new SqlParameter("@ngheNghiepCha", ngheNghiepCha);
            SqlParameter HotenMe = new SqlParameter("@hotenMe", hotenMe);
            SqlParameter NamSinhMe = new SqlParameter("@namSinhMe", namSinhMe);
            SqlParameter NgheNghiepMe = new SqlParameter("@ngheNghiepMe", ngheNghiepMe);
            SqlParameter MaLop = new SqlParameter("@maLop", maLop);
            List<SqlParameter> loadstudent = new List<SqlParameter>();
            loadstudent.Add(MaHS);
            loadstudent.Add(TenHS);
            loadstudent.Add(NamSinh);
            loadstudent.Add(GioiTinh);
            loadstudent.Add(DanToc);
            loadstudent.Add(DiaChi);
            loadstudent.Add(HoTenCha);
            loadstudent.Add(NamSinhCha);
            loadstudent.Add(NghenghiepCha);
            loadstudent.Add(HotenMe);
            loadstudent.Add(NamSinhMe);
            loadstudent.Add(NgheNghiepMe);
            loadstudent.Add(MaLop);
            return db.MyExecuteNonQuery("CapNhapHocSinh", CommandType.StoredProcedure, loadstudent);
        }
        //thêm học sinh
        public bool ThemHocSinh(String tenHS, int namSinh, String gioiTinh, String danToc, String diaChi, String hoTenCha, int namSinhCha, String ngheNghiepCha, String hotenMe, int namSinhMe, String ngheNghiepMe, int maLop)
        {
            SqlParameter TenHS = new SqlParameter("@tenHS", tenHS);
            SqlParameter NamSinh = new SqlParameter("@namSinh", namSinh);
            SqlParameter GioiTinh = new SqlParameter("@gioiTinh", gioiTinh);
            SqlParameter DanToc = new SqlParameter("@danToc", danToc);
            SqlParameter DiaChi = new SqlParameter("@diaChi", diaChi);
            SqlParameter HoTenCha = new SqlParameter("@hoTenCha", hoTenCha);
            SqlParameter NamSinhCha = new SqlParameter("@namSinhCha", namSinhCha);
            SqlParameter NghenghiepCha = new SqlParameter("@ngheNghiepCha", ngheNghiepCha);
            SqlParameter HotenMe = new SqlParameter("@hotenMe", hotenMe);
            SqlParameter NamSinhMe = new SqlParameter("@namSinhMe", namSinhMe);
            SqlParameter NgheNghiepMe = new SqlParameter("@ngheNghiepMe", ngheNghiepMe);
            SqlParameter MaLop = new SqlParameter("@maLop", maLop);
            List<SqlParameter> addstudent = new List<SqlParameter>();
            addstudent.Add(TenHS);
            addstudent.Add(NamSinh);
            addstudent.Add(GioiTinh);
            addstudent.Add(DanToc);
            addstudent.Add(DiaChi);
            addstudent.Add(HoTenCha);
            addstudent.Add(NamSinhCha);
            addstudent.Add(NghenghiepCha);
            addstudent.Add(HotenMe);
            addstudent.Add(NamSinhMe);
            addstudent.Add(NgheNghiepMe);
            addstudent.Add(MaLop);
            return db.MyExecuteNonQuery("ThemHocSinh", CommandType.StoredProcedure, addstudent);
        }
    }
}
