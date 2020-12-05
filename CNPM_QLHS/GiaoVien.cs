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
using System.IO;
using System.Drawing.Imaging;

namespace CNPM_QLHS
{
    public partial class GiaoVien : Form
    {
        public GiaoVien()
        {
            InitializeComponent();
        }
        DataTable dtGiaoVien= new DataTable();
        bool Them;
        BLGiaoVien dbGV = new BLGiaoVien();
        public string ma, ten, khoa;
        // Lấy thứ tự record hiện hành
        int r;
        //tạo 1 bảng chứa các lớp đang chủ nhiệm
        DataTable dtChuNhiem = new DataTable();
        //tạo 1 bảng chứa các môn đang dạy
        DataTable dtCacMonDangDay = new DataTable();


        public int ktrquyen;


        void LoadData()
        {
            try
            {
                dtGiaoVien.Clear();
                DataSet ds = dbGV.loadGV();
                dtGiaoVien = ds.Tables[0];
                dgvGiaoVien.ClearSelection();
                // Đưa dữ liệu lên DataGridView   
                dgvGiaoVien.DataSource = dtGiaoVien;
                dgvGiaoVien.ClearSelection();
                dgvGiaoVien.Columns["maGV"].HeaderText = "Mã giáo viên";
                dgvGiaoVien.Columns["tenGV"].HeaderText = "Tên giáo viên";
                dgvGiaoVien.Columns["namSinh"].HeaderText = "Năm sinh";
                dgvGiaoVien.Columns["diaChi"].HeaderText = "Địa chỉ";
                dgvGiaoVien.Columns["sdt"].HeaderText = "Số điện thoại";
                dgvGiaoVien.Columns["idTK"].HeaderText = "Taif khoản đăng nhập";
                txtMaGiaoVien.ResetText();
                txtTenGiaoVien.ResetText();
                txtSoDienThoai.ResetText();
                txtNamSinh.ResetText();
                txtDiaChi.ResetText();
                panel3.Enabled = false;
                if (ktrquyen == 0)
                {
                    btnXoa.Enabled = false;
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    panel1.Enabled = false;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không load được các giáo viên, gặp lỗi!");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            panel3.Enabled = true;
            panel2.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string err = "";
            try
            {
                // Lấy thứ tự record hiện hành
                r = dgvGiaoVien.CurrentCell.RowIndex;
                // lấy mã giáo viên
                string maGV = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                // Hiện thông báo xác nhận việc xóa mẫu tin
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chuyển giáo viên về trạng thái nghỉ ?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    //dbGV.XoaGiangVien(ref err, strGiangVien);
                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    if (err.Length == 0)
                    {
                        MessageBox.Show("Đã xóa xong!");
                    }
                    else
                    {
                        MessageBox.Show("Đã bị lỗi không xóa được");
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
            this.txtMaGiaoVien.Text = dgvGiaoVien.Rows[0].Cells[0].Value.ToString();
            this.txtTenGiaoVien.Text = dgvGiaoVien.Rows[0].Cells[1].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnReload.Enabled = true;
            panel3.Enabled = false;
            panel2.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

        }

        private void GiaoVien_Load(object sender, EventArgs e)
        {
            LoadData();
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
                    dtGiaoVien.Clear();
                    DataSet ds = dbGV.TimGV(txt_timkiem.Text);
                    dtGiaoVien = ds.Tables[0];
                    // Đưa dữ liệu lên DataGridView   
                    dgvGiaoVien.DataSource = dtGiaoVien;
                    // Thay đổi độ rộng cột
                    dgvGiaoVien.AutoResizeColumns();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không lấy được nội dung giáo viên !");
                }
            }
        }
        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgvGiaoVien.CurrentCell.RowIndex;
            this.txtMaGiaoVien.Text = dgvGiaoVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenGiaoVien.Text = dgvGiaoVien.Rows[r].Cells[1].Value.ToString();
            this.txtNamSinh.Text = dgvGiaoVien.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text = dgvGiaoVien.Rows[r].Cells[3].Value.ToString();
            this.txtSoDienThoai.Text = dgvGiaoVien.Rows[r].Cells[4].Value.ToString();

            ///////////////
            dtCacMonDangDay.Clear();
            DataSet ds = dbGV.loadmondangday(int.Parse(dgvGiaoVien.Rows[r].Cells[0].Value.ToString()));
            dtCacMonDangDay = ds.Tables[0];
            dgvCacmondangday.ClearSelection();
            // Đưa dữ liệu lên DataGridView   
            dgvCacmondangday.DataSource = dtCacMonDangDay;
            dgvCacmondangday.ClearSelection();
            dgvCacmondangday.Columns["tenMH"].HeaderText = "Tên môn";
            ///////////////
            dtChuNhiem.Clear();
            DataSet ds1 = dbGV.loadlop(int.Parse(dgvGiaoVien.Rows[r].Cells[0].Value.ToString()));
            dtChuNhiem = ds1.Tables[0];
            dgvLopChuNhiem.ClearSelection();
            // Đưa dữ liệu lên DataGridView   
            dgvLopChuNhiem.DataSource = dtChuNhiem;
            dgvLopChuNhiem.ClearSelection();
            dgvLopChuNhiem.Columns["maLop"].HeaderText = "Lớp";
        }

    }
}
