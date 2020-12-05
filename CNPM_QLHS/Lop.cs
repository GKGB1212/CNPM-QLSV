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
    public partial class Lop : Form
    {
        public Lop()
        {
            InitializeComponent();
        }
        DataTable dtLop = null;
        DataTable dtHocSinh = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        BLLop dbL = new BLLop();
        BLHocSinh dbHS = new BLHocSinh();
        public int ktrquyen;
        void LoadData()
        {
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();
                DataSet ds = dbL.loadAllClass();
                dtLop = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvLop.DataSource = dtLop;
                // Thay đổi độ rộng cột
                dgvLop.AutoResizeColumns();
                dgvLop.ClearSelection();
                txtMaGV.ResetText();
                txtMaLop.ResetText();
                txtSiSo.ResetText();
                txtTenGV.ResetText();
                txt_timkiem.ResetText();
                dgvLop.Columns["maLop"].HeaderText = "Mã Lớp";
                dgvLop.Columns["maGVCN"].HeaderText = "Mã GVCN";
                dgvLop.Columns["tenGV"].HeaderText = "Tên GVCN";
                dgvLop.Columns[0].Width = 35;
                dgvLop.Columns[1].Width = 40;
                dgvLop.Columns[2].Width = 90;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_CNPMDataSet.Namhoc' table. You can move, or remove it, as needed.
            this.namhocTableAdapter.Fill(this.qLSV_CNPMDataSet.Namhoc);
            LoadData();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            this.txtMaLop.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
            this.txtMaGV.Text = dgvLop.Rows[r].Cells[1].Value.ToString();
            this.txtTenGV.Text = dgvLop.Rows[r].Cells[2].Value.ToString();
            String siso = dbL.SiSo(int.Parse(dgvLop.Rows[r].Cells[0].Value.ToString()));
            if(siso!=null)
            {
                this.txtSiSo.Text = siso;
            }
            else
            {
                this.txtSiSo.Text = "0";
            }
           // this.txtSiSo.Text = dgvLop.Rows[r].Cells[3].Value.ToString();
            try
            {
                dtHocSinh = new DataTable();
                dtHocSinh.Clear();
                DataSet ds = dbHS.loadStudent(int.Parse(dgvLop.Rows[r].Cells[0].Value.ToString()));
                dtHocSinh = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvHocSinh.DataSource = dtHocSinh;
                // Thay đổi độ rộng cột
                dgvHocSinh.AutoResizeColumns();
                dgvHocSinh.ClearSelection();
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
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void cbxNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();
                DataSet ds = dbL.loadClass(int.Parse(cbxNamHoc.Text));
                dtLop = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvLop.DataSource = dtLop;
                // Thay đổi độ rộng cột
                dgvLop.AutoResizeColumns();
                dgvLop.ClearSelection();
                txtMaGV.ResetText();
                txtMaLop.ResetText();
                txtSiSo.ResetText();
                txtTenGV.ResetText();
                txt_timkiem.ResetText();
                dgvLop.Columns["maLop"].HeaderText = "Mã Lớp";
                dgvLop.Columns["maGVCN"].HeaderText = "Mã GVCN";
                dgvLop.Columns["tenGV"].HeaderText = "Tên GVCN";
                dgvLop.Columns[0].Width = 35;
                dgvLop.Columns[1].Width = 40;
                dgvLop.Columns[2].Width = 90;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }
    }
}
















/*
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
using cuoiki.BS_Layer;

namespace cuoiki
{
    public partial class Lop : Form
    {
        public Lop(Menuchinh a)
        {
            InitializeComponent();
            ktrquyen = a.ktrquyen;
        }
        DataTable dtLop = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        BLLop dbL = new BLLop();
        public int ktrquyen;
        void LoadData()
        {
            //this.WindowState = FormWindowState.Maximized;
            try
            {
                dtLop = new DataTable();
                dtLop.Clear();

                DataSet ds = dbL.LayLop();
                dtLop = ds.Tables[0];

                // Đưa dữ liệu lên DataGridView   
                dgvLop.DataSource = dtLop;
                // Thay đổi độ rộng cột
                dgvLop.AutoResizeColumns();
                dgvLop.ClearSelection();
                txtMa.ResetText();
                txtTen.ResetText();
                txt_timkiem.ResetText();
                dgvLop.Columns["MaLop"].HeaderText = "Mã Lớp";
                dgvLop.Columns["TenLop"].HeaderText = "Tên Lớp";
                dgvLop.Columns["MaKhoa"].HeaderText = "Thuộc khoa";
                dgvLop.Columns[0].Width = 75;
                dgvLop.Columns[1].Width = 285;
                dgvLop.Columns[2].Width = 80;
                if (ktrquyen == 0)
                {
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            LoadData();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

        }
        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLop.CurrentCell.RowIndex;
            this.txtMa.Text = dgvLop.Rows[r].Cells[0].Value.ToString();
            this.txtTen.Text = dgvLop.Rows[r].Cells[1].Value.ToString();
            this.cmbKhoa.Text = dgvLop.Rows[r].Cells[2].Value.ToString();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            txt_timkiem.Enabled = false;
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            cmbKhoa.Enabled = true;
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMa.ResetText();
            this.txtTen.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btn_Luu.Enabled = true;
            this.btn_Huy.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            btn_reload.Enabled = false;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtMa.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMa.Text.Length == 0)
            {
                MessageBox.Show("Chưa chọn lớp!");
            }
            else
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btn_reload.Enabled = false;
                btn_Luu.Enabled = true;
                btn_Huy.Enabled = true;
                txtMa.Enabled = false;
                txtTen.Enabled = true;
                cmbKhoa.Enabled = true;
                txt_timkiem.Enabled = false;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string err = "";
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    BLLop blLop = new BLLop();
                    blLop.ThemLop(txtMa.Text.ToString(), txtTen.Text.ToString(), cmbKhoa.Text.ToString(), ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm lớp " + txtTen.Text);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                BLLop blLop = new BLLop();
                blLop.CapNhatLop(this.txtMa.Text.ToString(), this.txtTen.Text.ToString(), cmbKhoa.Text.ToString(), ref err);

                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btn_reload.Enabled = true;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txt_timkiem.Enabled = true;
            cmbKhoa.Enabled = false;
            btn_Huy.Enabled = false;
            btn_Luu.Enabled = false;
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btn_Huy.Enabled = false;
            btn_Luu.Enabled = false;
            btn_reload.Enabled = true;
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            cmbKhoa.Enabled = false;
            txt_timkiem.Enabled = true;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvLop.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strMaLop = dgvLop.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc chắn xóa lớp " + strMaLop + " không ?\nLưu ý: Nếu có lớp thuộc khoa này phải chuyển lớp qua khoa khác rồi mới xóa được", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbL.XoaLop(ref err, strMaLop);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    if (err.Length == 0)
                    {
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Lớp này có sinh viên, chuyển sinh viên qua lớp khác trước khi xóa lớp!");
                        err.Remove(0);
                    }
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            this.txtMa.Text = dgvLop.Rows[0].Cells[0].Value.ToString();
            this.txtTen.Text = dgvLop.Rows[0].Cells[1].Value.ToString();
        }

        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (txt_timkiem.Text.Length == 0)
            {
                LoadData();
            }
            else
            {
                try
                {
                    dtLop = new DataTable();
                    dtLop.Clear();
                    DataSet ds = dbL.TimLop(txt_timkiem.Text);
                    dtLop = ds.Tables[0];
                    // Đưa dữ liệu lên DataGridView   
                    dgvLop.DataSource = dtLop;
                    // Thay đổi độ rộng cột
                    dgvLop.AutoResizeColumns();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung trong table Lớp. Lỗi rồi!!!");
                }
            }
        }
    }
}
*/