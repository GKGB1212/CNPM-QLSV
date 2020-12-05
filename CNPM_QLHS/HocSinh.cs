using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using CNPM_QLHS.BS_layer;

namespace CNPM_QLHS
{
    public partial class HocSinh : Form
    {
        public HocSinh()
        {
            InitializeComponent();
        }
        DataTable dtHocSinh = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        BLHocSinh dbHS = new BLHocSinh();
        public int ktrquyen;
        void ResetText()
        {
            dgvHocSinh.ClearSelection();
            txtMaHocSinh.ResetText();
            txtTenHocSinh.ResetText();
            txtNamSinh.ResetText();
            txtDanToc.ResetText();
            txt_timkiem.ResetText();
            txtDiaChi.ResetText();
            txtTenBo.ResetText();
            txtNamSinhBo.ResetText();
            txtNgheNghiepBo.ResetText();
            txtTenMe.ResetText();
            txtNamSinhMe.ResetText();
            txtNgheNghiepMe.ResetText();
            txtNamSinhBo.ResetText();
            txtNgheNghiepBo.ResetText();
            txtTenMe.ResetText();
        }
        void LoadData()
        {
            try
            {
                dtHocSinh = new DataTable();
                dtHocSinh.Clear();
                DataSet ds = dbHS.loadData();
                dtHocSinh = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvHocSinh.DataSource = dtHocSinh;
                ResetText();
                dgvHocSinh.Columns["maHS"].HeaderText = "Mã học sinh";
                dgvHocSinh.Columns["tenHS"].HeaderText = "Tên học sinh";
                dgvHocSinh.Columns["namSinh"].HeaderText = "Năm sinh";
                dgvHocSinh.Columns["gioiTinh"].HeaderText = "Giới tính";
                dgvHocSinh.Columns["danToc"].HeaderText = "Dân tộc";
                dgvHocSinh.Columns["diaChi"].HeaderText = "Địa chỉ";
                dgvHocSinh.Columns["hoTenCha"].HeaderText = "Tên cha";
                dgvHocSinh.Columns["namSinhCha"].HeaderText = "Năm sinh";
                dgvHocSinh.Columns["ngheNghiepCha"].HeaderText = "Nghề nghiệp cha";
                dgvHocSinh.Columns["hotenMe"].HeaderText = "Tên mẹ";
                dgvHocSinh.Columns["namSinhMe"].HeaderText = "Năm sinh";
                dgvHocSinh.Columns["ngheNghiepMe"].HeaderText = "Nghề nghiệp";
                dgvHocSinh.Columns["namSinhMe"].HeaderText = "Năm sinh";
                dgvHocSinh.Columns["maLop"].HeaderText = "Mã lớp";
                dgvHocSinh.Columns[0].Width = 35;
                dgvHocSinh.Columns[1].Width = 90;
                dgvHocSinh.Columns[2].Width = 35;
                dgvHocSinh.Columns[3].Width = 35;
                dgvHocSinh.Columns[4].Width = 40;
                dgvHocSinh.Columns[5].Width = 60;
                dgvHocSinh.Columns[6].Width = 90;
                dgvHocSinh.Columns[7].Width = 35;
                dgvHocSinh.Columns[8].Width = 90;
                dgvHocSinh.Columns[9].Width = 90;
                dgvHocSinh.Columns[10].Width = 35;
                dgvHocSinh.Columns[11].Width = 90;
                dgvHocSinh.Columns[12].Width = 35;
                dgvHocSinh.Columns[13].Width = 35;
                panel4.Enabled = false;
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void HocSinh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_CNPMDataSet1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLSV_CNPMDataSet1.Lop);
            LoadData();

        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHocSinh.CurrentCell.RowIndex;
            this.txtMaHocSinh.Text = dgvHocSinh.Rows[r].Cells[0].Value.ToString();
            this.txtTenHocSinh.Text = dgvHocSinh.Rows[r].Cells[1].Value.ToString();
            this.txtNamSinh.Text = dgvHocSinh.Rows[r].Cells[2].Value.ToString();
            if (dgvHocSinh.Rows[r].Cells[3].Value.ToString() == "M")
                this.cbxGioitinh.SelectedIndex = 0;
            if (dgvHocSinh.Rows[r].Cells[3].Value.ToString() == "F")
                this.cbxGioitinh.SelectedIndex = 1;
            this.txtDanToc.Text = dgvHocSinh.Rows[r].Cells[4].Value.ToString();
            this.txtDiaChi.Text = dgvHocSinh.Rows[r].Cells[5].Value.ToString();
            this.txtTenBo.Text = dgvHocSinh.Rows[r].Cells[6].Value.ToString();
            this.txtNamSinhBo.Text = dgvHocSinh.Rows[r].Cells[7].Value.ToString();
            this.txtNgheNghiepBo.Text = dgvHocSinh.Rows[r].Cells[8].Value.ToString();
            this.txtTenMe.Text = dgvHocSinh.Rows[r].Cells[9].Value.ToString();
            this.txtNamSinhMe.Text = dgvHocSinh.Rows[r].Cells[10].Value.ToString();
            this.txtNgheNghiepMe.Text = dgvHocSinh.Rows[r].Cells[11].Value.ToString();
            this.cbxHocLop.Text = dgvHocSinh.Rows[r].Cells[12].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHocSinh.TextLength != 0)
            {
                panel4.Enabled = true;
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
            else
                MessageBox.Show("Vui lòng chọn học sinh để sửa!");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtTenHocSinh.TextLength==0||txtDanToc.TextLength==0||txtNamSinh.TextLength==0)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin về tên học sinh, dân tộc và năm sinh !!!");
            }
            else if(Them)
            {
                String temp = "M";
                if (cbxGioitinh.SelectedItem.Equals("Nữ"))
                    temp = "F";
                dbHS.ThemHocSinh(txtTenHocSinh.Text, int.Parse(txtNamSinh.Text), temp, txtDanToc.Text, txtDiaChi.Text, txtTenBo.Text, int.Parse(txtNamSinhBo.Text), txtNgheNghiepBo.Text, txtTenMe.Text, int.Parse(txtNamSinhMe.Text), txtNgheNghiepMe.Text, int.Parse(cbxHocLop.Text));
                LoadData();
                Them = false;
            }
            else
            {
                String temp = "M";
                if (cbxGioitinh.SelectedItem.Equals("Nữ"))
                    temp = "F";
                dbHS.CapNhapHocSinh(int.Parse(txtMaHocSinh.Text), txtTenHocSinh.Text, int.Parse(txtNamSinh.Text), temp, txtDanToc.Text, txtDiaChi.Text, txtTenBo.Text, int.Parse(txtNamSinhBo.Text), txtNgheNghiepBo.Text, txtTenMe.Text, int.Parse(txtNamSinhMe.Text), txtNgheNghiepMe.Text, int.Parse(cbxHocLop.Text));
                LoadData();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            panel4.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            ResetText();
        }
    }
}
