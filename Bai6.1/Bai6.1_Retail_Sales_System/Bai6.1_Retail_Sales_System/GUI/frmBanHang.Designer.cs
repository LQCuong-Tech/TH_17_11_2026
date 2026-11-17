namespace Bai6._1_Retail_Sales_System.GUI
{
    partial class frmBanHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grpThongTinChung = new System.Windows.Forms.GroupBox();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.grpChonSanPham = new System.Windows.Forms.GroupBox();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSanPham = new System.Windows.Forms.Label();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.pnlThanhToan = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblDiemTichLuy = new System.Windows.Forms.Label();
            this.lblTitleDiem = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblTitleTongTien = new System.Windows.Forms.Label();
            this.grpThongTinChung.SuspendLayout();
            this.grpChonSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.pnlThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(920, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "LẬP HÓA ĐƠN BÁN HÀNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpThongTinChung
            // 
            this.grpThongTinChung.Controls.Add(this.cboKhachHang);
            this.grpThongTinChung.Controls.Add(this.lblKhachHang);
            this.grpThongTinChung.Controls.Add(this.cboNhanVien);
            this.grpThongTinChung.Controls.Add(this.lblNhanVien);
            this.grpThongTinChung.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpThongTinChung.Location = new System.Drawing.Point(15, 52);
            this.grpThongTinChung.Name = "grpThongTinChung";
            this.grpThongTinChung.Size = new System.Drawing.Size(890, 65);
            this.grpThongTinChung.TabIndex = 1;
            this.grpThongTinChung.TabStop = false;
            this.grpThongTinChung.Text = "Thông tin giao dịch";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(565, 26);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(305, 25);
            this.cboKhachHang.TabIndex = 3;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(475, 29);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(82, 17);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(135, 26);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(280, 25);
            this.cboNhanVien.TabIndex = 1;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(18, 29);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(111, 17);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "Nhân viên lập HĐ:";
            // 
            // grpChonSanPham
            // 
            this.grpChonSanPham.Controls.Add(this.btnThemVaoGio);
            this.grpChonSanPham.Controls.Add(this.numSoLuong);
            this.grpChonSanPham.Controls.Add(this.lblSoLuong);
            this.grpChonSanPham.Controls.Add(this.cboSanPham);
            this.grpChonSanPham.Controls.Add(this.lblSanPham);
            this.grpChonSanPham.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpChonSanPham.Location = new System.Drawing.Point(15, 125);
            this.grpChonSanPham.Name = "grpChonSanPham";
            this.grpChonSanPham.Size = new System.Drawing.Size(890, 68);
            this.grpChonSanPham.TabIndex = 2;
            this.grpChonSanPham.TabStop = false;
            this.grpChonSanPham.Text = "Chọn hàng hóa";
            // 
            // btnThemVaoGio
            // 
            this.btnThemVaoGio.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(705, 24);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(165, 32);
            this.btnThemVaoGio.TabIndex = 4;
            this.btnThemVaoGio.Text = "+ Thêm vào giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;
            this.btnThemVaoGio.Click += new System.EventHandler(this.btnThemVaoGio_Click);
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(565, 27);
            this.numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.numSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(100, 25);
            this.numSoLuong.TabIndex = 3;
            this.numSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(490, 30);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(67, 17);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // cboSanPham
            // 
            this.cboSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(135, 27);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(330, 25);
            this.cboSanPham.TabIndex = 1;
            // 
            // lblSanPham
            // 
            this.lblSanPham.AutoSize = true;
            this.lblSanPham.Location = new System.Drawing.Point(18, 30);
            this.lblSanPham.Name = "lblSanPham";
            this.lblSanPham.Size = new System.Drawing.Size(73, 17);
            this.lblSanPham.TabIndex = 0;
            this.lblSanPham.Text = "Sản phẩm:";
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Location = new System.Drawing.Point(15, 205);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(890, 250);
            this.dgvGioHang.TabIndex = 3;
            // 
            // pnlThanhToan
            // 
            this.pnlThanhToan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThanhToan.Controls.Add(this.btnThanhToan);
            this.pnlThanhToan.Controls.Add(this.lblDiemTichLuy);
            this.pnlThanhToan.Controls.Add(this.lblTitleDiem);
            this.pnlThanhToan.Controls.Add(this.lblTongTien);
            this.pnlThanhToan.Controls.Add(this.lblTitleTongTien);
            this.pnlThanhToan.Location = new System.Drawing.Point(15, 468);
            this.pnlThanhToan.Name = "pnlThanhToan";
            this.pnlThanhToan.Size = new System.Drawing.Size(890, 75);
            this.pnlThanhToan.TabIndex = 4;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(685, 14);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(185, 45);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "THANH TOÁN";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblDiemTichLuy
            // 
            this.lblDiemTichLuy.AutoSize = true;
            this.lblDiemTichLuy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblDiemTichLuy.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDiemTichLuy.Location = new System.Drawing.Point(520, 27);
            this.lblDiemTichLuy.Name = "lblDiemTichLuy";
            this.lblDiemTichLuy.Size = new System.Drawing.Size(69, 20);
            this.lblDiemTichLuy.TabIndex = 3;
            this.lblDiemTichLuy.Text = "+0 điểm";
            // 
            // lblTitleDiem
            // 
            this.lblTitleDiem.AutoSize = true;
            this.lblTitleDiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTitleDiem.Location = new System.Drawing.Point(395, 28);
            this.lblTitleDiem.Name = "lblTitleDiem";
            this.lblTitleDiem.Size = new System.Drawing.Size(119, 19);
            this.lblTitleDiem.TabIndex = 2;
            this.lblTitleDiem.Text = "Điểm cộng thêm:";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.ForeColor = System.Drawing.Color.Crimson;
            this.lblTongTien.Location = new System.Drawing.Point(125, 22);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(72, 25);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "0 VNĐ";
            // 
            // lblTitleTongTien
            // 
            this.lblTitleTongTien.AutoSize = true;
            this.lblTitleTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitleTongTien.Location = new System.Drawing.Point(18, 26);
            this.lblTitleTongTien.Name = "lblTitleTongTien";
            this.lblTitleTongTien.Size = new System.Drawing.Size(96, 20);
            this.lblTitleTongTien.TabIndex = 0;
            this.lblTitleTongTien.Text = "TỔNG TIỀN:";
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 560);
            this.Controls.Add(this.pnlThanhToan);
            this.Controls.Add(this.dgvGioHang);
            this.Controls.Add(this.grpChonSanPham);
            this.Controls.Add(this.grpThongTinChung);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng & Lập Hóa đơn";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.grpThongTinChung.ResumeLayout(false);
            this.grpThongTinChung.PerformLayout();
            this.grpChonSanPham.ResumeLayout(false);
            this.grpChonSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.pnlThanhToan.ResumeLayout(false);
            this.pnlThanhToan.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grpThongTinChung;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.GroupBox grpChonSanPham;
        private System.Windows.Forms.Label lblSanPham;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.Panel pnlThanhToan;
        private System.Windows.Forms.Label lblTitleTongTien;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblTitleDiem;
        private System.Windows.Forms.Label lblDiemTichLuy;
        private System.Windows.Forms.Button btnThanhToan;
    }
}