using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM_QLHS.BS_layer;

namespace CNPM_QLHS
{
    public partial class MonHoc : Form
    {
        public MonHoc()
        {
            InitializeComponent();
        }
        DataTable dtMon = null;         // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu  
        DataTable dtGV = null;
        bool Them;
        string err;
        BLMonHoc dbM = new BLMonHoc();
        public int ktrquyen;
        void LoadData()
        {
            try
            {
                dtMon = new DataTable();
                dtMon.Clear();
                DataSet dtM = dbM.loadMH();
                dtMon = dtM.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvMon.DataSource = dtMon;
                dgvMon.ClearSelection();
                dgvMon.Columns["maMH"].HeaderText = "Mã môn học";
                dgvMon.Columns["tenMH"].HeaderText = "Tên môn học";
                txtTen.Enabled = false;
                txtMa.Enabled = false;
                txtMa.ResetText();
                txtTen.ResetText();
                dgvMon.Columns[0].Width = 100;
                dgvMon.Columns[1].Width = 320;
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Khoa. Lỗi rồi!!!");
            }
        }
        void LoadDataGV(int idMH)
        {
            try
            {
                dtGV = new DataTable();
                dtGV.Clear();
                DataSet ds = dbM.loadGVdayMon(idMH);
                dtGV = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvGV.DataSource = dtGV;
                // Thay đổi độ rộng cột
                dgvGV.ClearSelection();
                dgvGV.Columns["maGV"].HeaderText = "Mã giáo viên";
                dgvGV.Columns["tenGV"].HeaderText = "Tên giáo viên";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
}
        private void MonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_CNPMDataSet1.GiaoVien' table. You can move, or remove it, as needed.
            this.giaoVienTableAdapter.Fill(this.qLSV_CNPMDataSet1.GiaoVien);
            LoadData();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void dgvMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMon.CurrentCell.RowIndex;
            this.txtMa.Text = dgvMon.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgvMon.Rows[r].Cells[1].Value.ToString();
            LoadDataGV(int.Parse(dgvMon.Rows[r].Cells[0].Value.ToString()));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            Them = true;
            txtMa.ResetText();
            txtTen.ResetText();
            txtTen.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            if((txtMa.TextLength==0))
            {
                MessageBox.Show("Vui lòng chọn môn trước khi chỉnh sửa!!!");
            }    
            btn_Huy.Enabled = true;
            btn_Luu.Enabled = true;
            Them = false;
            txtTen.Enabled = true;

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(txtTen.TextLength==0)
            {
                MessageBox.Show("Vui lòng nhập tên môn học trước khi lưu!!!");
            }
            else
            {
                if (Them)
                {
                    dbM.themMon(txtTen.Text);
                    LoadData();
                    btnSua.Enabled = true;
                }
                else
                {
                    dbM.suaMon(int.Parse(txtMa.Text), txtTen.Text);
                    LoadData();
                    btnThem.Enabled = true;
                }
                btn_Huy.Enabled = false;
                btn_Luu.Enabled = false;
            }
        }

        private void btn_themGV_Click(object sender, EventArgs e)
        {
            if(txtMa.TextLength==0)
            {
                MessageBox.Show("Chọn môn trước khi thêm giáo viên!!!");
            }    
            else
            {
                int r = dgvMon.CurrentCell.RowIndex;
                dbM.themGVDayMH(int.Parse(cbxGV.SelectedValue.ToString()), int.Parse(txtMa.Text.ToString()));
                LoadDataGV(int.Parse(dgvMon.Rows[r].Cells[0].Value.ToString()));
            }
        }


    }
}
