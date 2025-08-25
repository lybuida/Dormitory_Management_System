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
using QuanLy_BLL;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyNhanVien : Form
    {
        private QuanLyNhanVien_BL quanLyNhanVien_BL;
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            quanLyNhanVien_BL = new QuanLyNhanVien_BL();
        }

        private void LoadNhanViens()
        {
            try
            {
                dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void GBtnThem_Click(object sender, EventArgs e)
        {
            FrmThemNhanVien frmThemNhanVien = new FrmThemNhanVien();
            DialogResult result = frmThemNhanVien.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadNhanViens();
            }
        }

        private void GBtnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimkiem.Text.Trim();
                bool timTheoMa = rbTktheoma.Checked;

                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu ô tìm kiếm trống, load lại toàn bộ danh sách
                    dgvNhanvien.DataSource = quanLyNhanVien_BL.LayDanhSachNhanVien();
                    return;
                }

                // Gọi BLL để tìm kiếm
                List<NhanVien> ketQua = quanLyNhanVien_BL.TimKiemNhanVien(keyword, timTheoMa);

                // Hiển thị kết quả lên DataGridView
                dgvNhanvien.DataSource = ketQua;

                if (ketQua.Count == 0)
                    MessageBox.Show("Không tìm thấy nhân viên phù hợp!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadNhanViens();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý cả nút Xóa và Sửa
            if (e.RowIndex >= 0)
            {
                // Xử lý nút Sửa (Column2 là cột sửa)
                if (e.ColumnIndex == 1) // Giả sử Column2 là cột thứ 6
                {
                    // Lấy dữ liệu từ hàng được chọn
                    DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];
                    NhanVien nv = new NhanVien(
                        row.Cells["manv"].Value.ToString(),
                        row.Cells["tennv"].Value.ToString(),
                        row.Cells["gioitinh"].Value.ToString(),
                        row.Cells["ngaysinh"].Value.ToString(),
                        row.Cells["diachi"].Value.ToString(),
                        row.Cells["sodienthoai"].Value.ToString()
                    );

                    // Mở form sửa và truyền dữ liệu
                    FrmSuaNhanVien frmSua = new FrmSuaNhanVien(nv);
                    if (frmSua.ShowDialog() == DialogResult.OK)
                    {
                        LoadNhanViens(); // Cập nhật lại DataGridView
                    }
                }
                // Xử lý nút Xóa (giữ nguyên phần xử lý xóa đã có)
                else if (e.ColumnIndex == 0)
                {
                    // Lấy mã nhân viên từ hàng được chọn
                    string manv = dgvNhanvien.Rows[e.RowIndex].Cells["manv"].Value.ToString();

                    // Xác nhận xóa
                    DialogResult result = MessageBox.Show(
                        "Bạn có chắc chắn muốn xóa nhân viên này?",
                        "Xác nhận xóa",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            int rowsAffected = quanLyNhanVien_BL.XoaNhanVien(manv);
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa nhân viên thành công!");
                                LoadNhanViens(); // Tải lại danh sách
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân viên để xóa!");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                        }
                    }
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
