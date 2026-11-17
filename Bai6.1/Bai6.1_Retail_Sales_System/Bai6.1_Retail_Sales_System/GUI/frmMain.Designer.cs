namespace Bai6._1_Retail_Sales_System.GUI
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(450, 75);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG\r\n& SIÊU THỊ MINI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBanHang
            // 
            this.btnBanHang.BackColor = System.Drawing.Color.SeaGreen;
            this.btnBanHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.ForeColor = System.Drawing.Color.White;
            this.btnBanHang.Location = new System.Drawing.Point(60, 95);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(330, 65);
            this.btnBanHang.TabIndex = 1;
            this.btnBanHang.Text = "BÁN HÀNG (Lập Hóa Đơn)";
            this.btnBanHang.UseVisualStyleBackColor = false;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSanPham.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSanPham.Location = new System.Drawing.Point(60, 180);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(330, 65);
            this.btnSanPham.TabIndex = 2;
            this.btnSanPham.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnSanPham.UseVisualStyleBackColor = false;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DarkOrange;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(60, 265);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(330, 65);
            this.btnThongKe.TabIndex = 3;
            this.btnThongKe.Text = "BÁO CÁO VÀ THỐNG KÊ";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 370);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.btnSanPham);
            this.Controls.Add(this.btnBanHang);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ - Retail Sales System";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnThongKe;
    }
}