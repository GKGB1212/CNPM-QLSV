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
    public partial class BangDiem : Form
    {
        public BangDiem()
        {
            InitializeComponent();
        }
        DataTable dtBangDiem = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        BLBangDiem dbBD = new BLBangDiem();
        void LoadData(int i)
        {
            try
            {
                dtBangDiem = new DataTable();
                dtBangDiem.Clear();
                DataSet ds = new DataSet();
                if (i == 1)
                {
                    ds = dbBD.timDiemTheoMaHS(int.Parse(txtmaHS.Text));
                }
                else if(i==2)
                {
                    ds = dbBD.timDiemTheoMaLopMaMon(int.Parse(cmbLop.SelectedValue.ToString()),int.Parse(cmbMon.SelectedValue.ToString()));
                }
                else if (i == 3)
                {
                    ds = dbBD.timDiemTheoCa3(int.Parse(cmbLop.SelectedValue.ToString()), int.Parse(cmbMon.SelectedValue.ToString()),int.Parse(txtmaHS.Text));
                }
                else if(i==4)
                {
                    ds = dbBD.timDiemTheoMaLop(int.Parse(cmbLop.SelectedValue.ToString()));
                }    
                else if(i==5)
                {
                    ds = dbBD.timDiemTheoMaMH(int.Parse(cmbMon.SelectedValue.ToString()));
                }    
                dtBangDiem = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView   
                dgvBangDiem.DataSource = dtBangDiem;
                ResetText();
                dgvBangDiem.Columns["maHS"].HeaderText = "Mã học sinh";
                dgvBangDiem.Columns["maMH"].HeaderText = "Mã môn học";
                dgvBangDiem.Columns["namHoc"].HeaderText = "Năm học";
                dgvBangDiem.Columns["diem15phutlan1"].HeaderText = "Điểm 15 phút 1";
                dgvBangDiem.Columns["diemMieng"].HeaderText = "Điểm miệng";
                dgvBangDiem.Columns["diem1tiet"].HeaderText = "Điểm 1 tiết";
                dgvBangDiem.Columns["diemThi"].HeaderText = "Điểm thi";
                dgvBangDiem.Columns["diemTongKet"].HeaderText = "Điểm tổng kết";
                /*dgvHocSinh.Columns[0].Width = 35;
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
                btnLuu.Enabled = false;*/
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Lop. Lỗi rồi!!!");
            }
        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLSV_CNPMDataSet1.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLSV_CNPMDataSet1.MonHoc);
            // TODO: This line of code loads data into the 'qLSV_CNPMDataSet1.Lop' table. You can move, or remove it, as needed.
            this.lopTableAdapter.Fill(this.qLSV_CNPMDataSet1.Lop);

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            //tim kiem không có mã học sinh
            if (txtmaHS.TextLength == 0)
            {
                LoadData(2);
            }
            else
            {
                LoadData(3);
            }
        }
        /// <summary>
        /// ////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTimTheoMaHS_Click(object sender, EventArgs e)
        {
            if(txtmaHS.TextLength==0)
            {
                MessageBox.Show("Vui lòng nhập mã học sinh trước khi tra cứu bằng mã học sinh!!!");
            }
            else
            {
                LoadData(1);
            }
        }

        private void btnTimTheoLop_Click(object sender, EventArgs e)
        {
            LoadData(4);
        }

        private void btnTimTheoMon_Click(object sender, EventArgs e)
        {
            LoadData(5);
        }
    }
}
