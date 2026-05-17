namespace QuanLyQuanCafe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpChung = new System.Windows.Forms.GroupBox();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.lblNgayBan = new System.Windows.Forms.Label();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.lblHinhThuc = new System.Windows.Forms.Label();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.grpHang = new System.Windows.Forms.GroupBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.cbMaHang = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnTinh = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblVND = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.ColGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colhoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coldongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpChung.SuspendLayout();
            this.grpHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(350, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(595, 72);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // grpChung
            // 
            this.grpChung.Controls.Add(this.lblMaHD);
            this.grpChung.Controls.Add(this.txtMaHD);
            this.grpChung.Controls.Add(this.lblNgayBan);
            this.grpChung.Controls.Add(this.dtpNgayBan);
            this.grpChung.Controls.Add(this.lblHinhThuc);
            this.grpChung.Controls.Add(this.cbHinhThuc);
            this.grpChung.Controls.Add(this.lblGhiChu);
            this.grpChung.Controls.Add(this.txtGhiChu);
            this.grpChung.Location = new System.Drawing.Point(12, 60);
            this.grpChung.Name = "grpChung";
            this.grpChung.Size = new System.Drawing.Size(960, 150);
            this.grpChung.TabIndex = 1;
            this.grpChung.TabStop = false;
            this.grpChung.Text = "Thông tin chung";
            // 
            // lblMaHD
            // 
            this.lblMaHD.Location = new System.Drawing.Point(20, 35);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(134, 23);
            this.lblMaHD.TabIndex = 0;
            this.lblMaHD.Text = "Mã hóa đơn:";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(160, 30);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(240, 31);
            this.txtMaHD.TabIndex = 1;
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.Location = new System.Drawing.Point(20, 75);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(114, 28);
            this.lblNgayBan.TabIndex = 2;
            this.lblNgayBan.Text = "Ngày bán:";
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(160, 72);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(240, 31);
            this.dtpNgayBan.TabIndex = 3;
            this.dtpNgayBan.ValueChanged += new System.EventHandler(this.dtpNgayBan_ValueChanged);
            // 
            // lblHinhThuc
            // 
            this.lblHinhThuc.Location = new System.Drawing.Point(20, 115);
            this.lblHinhThuc.Name = "lblHinhThuc";
            this.lblHinhThuc.Size = new System.Drawing.Size(114, 23);
            this.lblHinhThuc.TabIndex = 4;
            this.lblHinhThuc.Text = "Hình thức:";
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.Items.AddRange(new object[] {
            "Tại chỗ",
            "Mang đi"});
            this.cbHinhThuc.Location = new System.Drawing.Point(160, 112);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(240, 33);
            this.cbHinhThuc.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Location = new System.Drawing.Point(440, 115);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(100, 23);
            this.lblGhiChu.TabIndex = 6;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(560, 112);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(350, 31);
            this.txtGhiChu.TabIndex = 7;
            // 
            // grpHang
            // 
            this.grpHang.Controls.Add(this.lblMaHang);
            this.grpHang.Controls.Add(this.cbMaHang);
            this.grpHang.Controls.Add(this.lblDonGia);
            this.grpHang.Controls.Add(this.txtDonGia);
            this.grpHang.Location = new System.Drawing.Point(12, 220);
            this.grpHang.Name = "grpHang";
            this.grpHang.Size = new System.Drawing.Size(960, 90);
            this.grpHang.TabIndex = 2;
            this.grpHang.TabStop = false;
            this.grpHang.Text = "Thông tin các mặt hàng";
            // 
            // lblMaHang
            // 
            this.lblMaHang.Location = new System.Drawing.Point(20, 40);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(114, 28);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã hàng:";
            this.lblMaHang.Click += new System.EventHandler(this.lblMaHang_Click);
            // 
            // cbMaHang
            // 
            this.cbMaHang.Items.AddRange(new object[] {
            "Cafe Đen",
            "Cafe Sữa",
            "Bạc Xỉu",
            "Trà Đào Cam Sả",
            "Trà Thạch Vải"});
            this.cbMaHang.Location = new System.Drawing.Point(150, 37);
            this.cbMaHang.Name = "cbMaHang";
            this.cbMaHang.Size = new System.Drawing.Size(180, 33);
            this.cbMaHang.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Location = new System.Drawing.Point(450, 37);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(100, 28);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(560, 37);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(170, 31);
            this.txtDonGia.TabIndex = 5;
            // 
            // dgvData
            // 
            this.dgvData.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvData.ColumnHeadersHeight = 46;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColGhiChu,
            this.Colhoadon,
            this.Colmahang,
            this.Coldongia});
            this.dgvData.Location = new System.Drawing.Point(12, 316);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 82;
            this.dgvData.Size = new System.Drawing.Size(960, 235);
            this.dgvData.TabIndex = 3;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(591, 583);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(85, 35);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Location = new System.Drawing.Point(682, 583);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(112, 28);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(800, 585);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(120, 31);
            this.txtTongTien.TabIndex = 6;
            // 
            // lblVND
            // 
            this.lblVND.Location = new System.Drawing.Point(930, 588);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(100, 23);
            this.lblVND.TabIndex = 7;
            this.lblVND.Text = "VND";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(80, 640);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 40);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 640);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 40);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(770, 640);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 40);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // ColGhiChu
            // 
            this.ColGhiChu.DataPropertyName = "ghiChu";
            this.ColGhiChu.HeaderText = "Ghi Chú";
            this.ColGhiChu.MinimumWidth = 10;
            this.ColGhiChu.Name = "ColGhiChu";
            this.ColGhiChu.Width = 200;
            // 
            // Colhoadon
            // 
            this.Colhoadon.DataPropertyName = "maHoaDon";
            this.Colhoadon.HeaderText = "Mã Hóa Đơn";
            this.Colhoadon.MinimumWidth = 10;
            this.Colhoadon.Name = "Colhoadon";
            this.Colhoadon.Width = 200;
            // 
            // Colmahang
            // 
            this.Colmahang.DataPropertyName = "maHang";
            this.Colmahang.HeaderText = "Tên Hàng";
            this.Colmahang.MinimumWidth = 10;
            this.Colmahang.Name = "Colmahang";
            this.Colmahang.Width = 200;
            // 
            // Coldongia
            // 
            this.Coldongia.DataPropertyName = "donGia";
            this.Coldongia.HeaderText = "Đơn Giá";
            this.Coldongia.MinimumWidth = 10;
            this.Coldongia.Name = "Coldongia";
            this.Coldongia.Width = 200;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpChung);
            this.Controls.Add(this.grpHang);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblVND);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.Name = "Form1";
            this.Text = "Quản Lý Hóa Đơn - Ngo Phuong Mai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpChung.ResumeLayout(false);
            this.grpChung.PerformLayout();
            this.grpHang.ResumeLayout(false);
            this.grpHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        // Khai báo biến (Chỉ được nằm ở đây, không được nằm trong Form1.cs)
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpChung;
        private System.Windows.Forms.Label lblMaHD;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label lblNgayBan;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        private System.Windows.Forms.Label lblHinhThuc;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.GroupBox grpHang;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.ComboBox cbMaHang;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colhoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coldongia;
    }
}


