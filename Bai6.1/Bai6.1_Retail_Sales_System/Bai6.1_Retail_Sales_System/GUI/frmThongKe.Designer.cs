namespace Bai6._1_Retail_Sales_System.GUI
{
    partial class frmThongKe
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
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.dtpNgayThongKe = new System.Windows.Forms.DateTimePicker();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.grpDoanhThu = new System.Windows.Forms.GroupBox();
            this.lblDoanhThuThang = new System.Windows.Forms.Label();
            this.lblTitleThang = new System.Windows.Forms.Label();
            this.lblDoanhThuNgay = new System.Windows.Forms.Label();
            this.lblTitleNgay = new System.Windows.Forms.Label();
            this.lblTop5 = new System.Windows.Forms.Label();
            this.dgvTop5SanPham = new System.Windows.Forms.DataGridView();
            this.grpDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTieuDe.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTieuDe.Location = new System.Drawing.Point(0, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(780, 45);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "BÁO CÁO DOANH THU & TOP SẢN PHẨM BÁN CHẠY";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChonNgay.Location = new System.Drawing.Point(20, 62);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(113, 19);
            this.lblChonNgay.TabIndex = 1;
            this.lblChonNgay.Text = "Chọn mốc ngày:";
            // 
            // dtpNgayThongKe
            // 
            this.dtpNgayThongKe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgayThongKe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayThongKe.Location = new System.Drawing.Point(140, 58);
            this.dtpNgayThongKe.Name = "dtpNgayThongKe";
            this.dtpNgayThongKe.Size = new System.Drawing.Size(160, 25);
            this.dtpNgayThongKe.TabIndex = 2;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXemBaoCao.Location = new System.Drawing.Point(320, 56);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(140, 30);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem thống kê";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // grpDoanhThu
            // 
            this.grpDoanhThu.Controls.Add(this.lblDoanhThuThang);
            this.grpDoanhThu.Controls.Add(this.lblTitleThang);
            this.grpDoanhThu.Controls.Add(this.lblDoanhThuNgay);
            this.grpDoanhThu.Controls.Add(this.lblTitleNgay);
            this.grpDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.grpDoanhThu.Location = new System.Drawing.Point(20, 100);
            this.grpDoanhThu.Name = "grpDoanhThu";
            this.grpDoanhThu.Size = new System.Drawing.Size(740, 85);
            this.grpDoanhThu.TabIndex = 4;
            this.grpDoanhThu.TabStop = false;
            this.grpDoanhThu.Text = "Tổng hợp doanh thu (ExecuteScalar)";
            // 
            // lblDoanhThuThang
            // 
            this.lblDoanhThuThang.AutoSize = true;
            this.lblDoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThang.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblDoanhThuThang.Location = new System.Drawing.Point(515, 35);
            this.lblDoanhThuThang.Name = "lblDoanhThuThang";
            this.lblDoanhThuThang.Size = new System.Drawing.Size(72, 25);
            this.lblDoanhThuThang.TabIndex = 3;
            this.lblDoanhThuThang.Text = "0 VNĐ";
            // 
            // lblTitleThang
            // 
            this.lblTitleThang.AutoSize = true;
            this.lblTitleThang.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTitleThang.Location = new System.Drawing.Point(375, 38);
            this.lblTitleThang.Name = "lblTitleThang";
            this.lblTitleThang.Size = new System.Drawing.Size(136, 19);
            this.lblTitleThang.TabIndex = 2;
            this.lblTitleThang.Text = "Doanh thu tháng:";
            // 
            // lblDoanhThuNgay
            // 
            this.lblDoanhThuNgay.AutoSize = true;
            this.lblDoanhThuNgay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuNgay.ForeColor = System.Drawing.Color.Crimson;
            this.lblDoanhThuNgay.Location = new System.Drawing.Point(155, 35);
            this.lblDoanhThuNgay.Name = "lblDoanhThuNgay";
            this.lblDoanhThuNgay.Size = new System.Drawing.Size(72, 25);
            this.lblDoanhThuNgay.TabIndex = 1;
            this.lblDoanhThuNgay.Text = "0 VNĐ";
            // 
            // lblTitleNgay
            // 
            this.lblTitleNgay.AutoSize = true;
            this.lblTitleNgay.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblTitleNgay.Location = new System.Drawing.Point(20, 38);
            this.lblTitleNgay.Name = "lblTitleNgay";
            this.lblTitleNgay.Size = new System.Drawing.Size(128, 19);
            this.lblTitleNgay.TabIndex = 0;
            this.lblTitleNgay.Text = "Doanh thu ngày:";
            // 
            // lblTop5
            // 
            this.lblTop5.AutoSize = true;
            this.lblTop5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblTop5.Location = new System.Drawing.Point(20, 200);
            this.lblTop5.Name = "lblTop5";
            this.lblTop5.Size = new System.Drawing.Size(293, 19);
            this.lblTop5.TabIndex = 5;
            this.lblTop5.Text = "TOP 5 SẢN PHẨM BÁN CHẠY NHẤT";
            // 
            // dgvTop5SanPham
            // 
            this.dgvTop5SanPham.AllowUserToAddRows = false;
            this.dgvTop5SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop5SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvTop5SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5SanPham.Location = new System.Drawing.Point(20, 228);
            this.dgvTop5SanPham.Name = "dgvTop5SanPham";
            this.dgvTop5SanPham.ReadOnly = true;
            this.dgvTop5SanPham.Size = new System.Drawing.Size(740, 220);
            this.dgvTop5SanPham.TabIndex = 6;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 470);
            this.Controls.Add(this.dgvTop5SanPham);
            this.Controls.Add(this.lblTop5);
            this.Controls.Add(this.grpDoanhThu);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.dtpNgayThongKe);
            this.Controls.Add(this.lblChonNgay);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo & Thống kê";
            this.Load += new System.EventHandler(this.btnXemBaoCao_Click);
            this.grpDoanhThu.ResumeLayout(false);
            this.grpDoanhThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.DateTimePicker dtpNgayThongKe;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.GroupBox grpDoanhThu;
        private System.Windows.Forms.Label lblTitleNgay;
        private System.Windows.Forms.Label lblDoanhThuNgay;
        private System.Windows.Forms.Label lblTitleThang;
        private System.Windows.Forms.Label lblDoanhThuThang;
        private System.Windows.Forms.Label lblTop5;
        private System.Windows.Forms.DataGridView dgvTop5SanPham;
    }
}