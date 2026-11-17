using Bai6._1_Retail_Sales_System.BUS;
using Bai6._1_Retail_Sales_System.DTO;
using System;
using System.Windows.Forms;

namespace Bai6._1_Retail_Sales_System.GUI
{
    public partial class frmSanPham : Form
    {
        private readonly SanPhamBUS _spBUS = new SanPhamBUS();

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvSanPham.DataSource = _spBUS.LayTatCa();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells["MaSP"].Value?.ToString();
                txtTenSP.Text = row.Cells["TenSP"].Value?.ToString();
                txtGiaBan.Text = row.Cells["GiaBan"].Value?.ToString();
                txtSoLuongTon.Text = row.Cells["SoLuongTon"].Value?.ToString();
                txtMaSP.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = decimal.Parse(txtGiaBan.Text),
                    SoLuongTon = int.Parse(txtSoLuongTon.Text)
                };
                if (_spBUS.ThemSanPham(sp))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!");
                    LoadData();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtMaSP.Text.Trim(),
                    TenSP = txtTenSP.Text.Trim(),
                    GiaBan = decimal.Parse(txtGiaBan.Text),
                    SoLuongTon = int.Parse(txtSoLuongTon.Text)
                };
                if (_spBUS.CapNhatSanPham(sp))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSP.Text)) return;
            if (MessageBox.Show("Xác nhận xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    if (_spBUS.XoaSanPham(txtMaSP.Text.Trim()))
                    {
                        LoadData();
                        LamMoiForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (sản phẩm đã phát sinh hóa đơn): " + ex.Message);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = _spBUS.TimKiem(txtTimKiem.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
            LoadData();
        }

        private void LamMoiForm()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtGiaBan.Clear();
            txtSoLuongTon.Clear();
            txtTimKiem.Clear();
            txtMaSP.Enabled = true;
        }
    }
}