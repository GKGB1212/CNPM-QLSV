namespace CNPM_QLHS
{
    partial class BangDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMon = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaHS = new System.Windows.Forms.TextBox();
            this.dgvBangDiem = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.qLSV_CNPMDataSet1 = new CNPM_QLHS.QLSV_CNPMDataSet1();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopTableAdapter = new CNPM_QLHS.QLSV_CNPMDataSet1TableAdapters.LopTableAdapter();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new CNPM_QLHS.QLSV_CNPMDataSet1TableAdapters.MonHocTableAdapter();
            this.btnTimTheoMaHS = new System.Windows.Forms.Button();
            this.btnTimTheoLop = new System.Windows.Forms.Button();
            this.btnTimTheoMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_CNPMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLop
            // 
            this.cmbLop.DataSource = this.lopBindingSource;
            this.cmbLop.DisplayMember = "MaLop";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(20, 57);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(350, 37);
            this.cmbLop.TabIndex = 66;
            this.cmbLop.ValueMember = "MaLop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 65;
            this.label4.Text = "Lớp học";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1039F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 47);
            this.label1.TabIndex = 68;
            this.label1.Text = "QUẢN LÝ BẢNG ĐIỂM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 69;
            this.label2.Text = "Môn học:";
            // 
            // cmbMon
            // 
            this.cmbMon.DataSource = this.monHocBindingSource;
            this.cmbMon.DisplayMember = "tenMH";
            this.cmbMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbMon.FormattingEnabled = true;
            this.cmbMon.Location = new System.Drawing.Point(20, 190);
            this.cmbMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMon.Name = "cmbMon";
            this.cmbMon.Size = new System.Drawing.Size(350, 37);
            this.cmbMon.TabIndex = 70;
            this.cmbMon.ValueMember = "maMH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.883117F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 22);
            this.label3.TabIndex = 71;
            this.label3.Text = "Tìm theo mã học sinh:";
            // 
            // txtmaHS
            // 
            this.txtmaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txtmaHS.Location = new System.Drawing.Point(20, 333);
            this.txtmaHS.Name = "txtmaHS";
            this.txtmaHS.Size = new System.Drawing.Size(350, 37);
            this.txtmaHS.TabIndex = 72;
            // 
            // dgvBangDiem
            // 
            this.dgvBangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiem.Location = new System.Drawing.Point(446, 141);
            this.dgvBangDiem.Name = "dgvBangDiem";
            this.dgvBangDiem.RowHeadersWidth = 62;
            this.dgvBangDiem.RowTemplate.Height = 28;
            this.dgvBangDiem.Size = new System.Drawing.Size(1179, 727);
            this.dgvBangDiem.TabIndex = 73;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btnThem);
            this.flowLayoutPanel1.Controls.Add(this.btnSua);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 562);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 73);
            this.flowLayoutPanel1.TabIndex = 74;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(188)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(4, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(167, 49);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(221)))), ((int)(((byte)(188)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(179, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(162, 49);
            this.btnSua.TabIndex = 47;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTim.Location = new System.Drawing.Point(20, 423);
            this.btnTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(171, 50);
            this.btnTim.TabIndex = 75;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnTimTheoMon);
            this.panel1.Controls.Add(this.btnTimTheoLop);
            this.panel1.Controls.Add(this.btnTimTheoMaHS);
            this.panel1.Controls.Add(this.cmbLop);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.btnTim);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbMon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtmaHS);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 727);
            this.panel1.TabIndex = 76;
            // 
            // qLSV_CNPMDataSet1
            // 
            this.qLSV_CNPMDataSet1.DataSetName = "QLSV_CNPMDataSet1";
            this.qLSV_CNPMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLSV_CNPMDataSet1;
            // 
            // lopTableAdapter
            // 
            this.lopTableAdapter.ClearBeforeFill = true;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLSV_CNPMDataSet1;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // btnTimTheoMaHS
            // 
            this.btnTimTheoMaHS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimTheoMaHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoMaHS.Location = new System.Drawing.Point(199, 423);
            this.btnTimTheoMaHS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoMaHS.Name = "btnTimTheoMaHS";
            this.btnTimTheoMaHS.Size = new System.Drawing.Size(171, 50);
            this.btnTimTheoMaHS.TabIndex = 76;
            this.btnTimTheoMaHS.Text = "Tìm theo mã học sinh";
            this.btnTimTheoMaHS.UseVisualStyleBackColor = false;
            this.btnTimTheoMaHS.Click += new System.EventHandler(this.btnTimTheoMaHS_Click);
            // 
            // btnTimTheoLop
            // 
            this.btnTimTheoLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimTheoLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoLop.Location = new System.Drawing.Point(20, 483);
            this.btnTimTheoLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoLop.Name = "btnTimTheoLop";
            this.btnTimTheoLop.Size = new System.Drawing.Size(171, 50);
            this.btnTimTheoLop.TabIndex = 77;
            this.btnTimTheoLop.Text = "Tìm theo lớp";
            this.btnTimTheoLop.UseVisualStyleBackColor = false;
            this.btnTimTheoLop.Click += new System.EventHandler(this.btnTimTheoLop_Click);
            // 
            // btnTimTheoMon
            // 
            this.btnTimTheoMon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimTheoMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoMon.Location = new System.Drawing.Point(199, 483);
            this.btnTimTheoMon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimTheoMon.Name = "btnTimTheoMon";
            this.btnTimTheoMon.Size = new System.Drawing.Size(171, 50);
            this.btnTimTheoMon.TabIndex = 78;
            this.btnTimTheoMon.Text = "Tìm theo môn";
            this.btnTimTheoMon.UseVisualStyleBackColor = false;
            this.btnTimTheoMon.Click += new System.EventHandler(this.btnTimTheoMon_Click);
            // 
            // BangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvBangDiem);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BangDiem";
            this.Text = "BangDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.BangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiem)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLSV_CNPMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaHS;
        private System.Windows.Forms.DataGridView dgvBangDiem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Panel panel1;
        private QLSV_CNPMDataSet1 qLSV_CNPMDataSet1;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLSV_CNPMDataSet1TableAdapters.LopTableAdapter lopTableAdapter;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLSV_CNPMDataSet1TableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.Button btnTimTheoMon;
        private System.Windows.Forms.Button btnTimTheoLop;
        private System.Windows.Forms.Button btnTimTheoMaHS;
    }
}