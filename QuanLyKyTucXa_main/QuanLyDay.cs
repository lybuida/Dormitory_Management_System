using QuanLy_BLL;
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
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyDay: Form
    {
        private QuanLyDay_BL quanLyDay_BL;

        public FrmQuanLyDay()
        {
            InitializeComponent();
            quanLyDay_BL = new QuanLyDay_BL();
        }

        private void FrmQuanLyDay_Load(object sender, EventArgs e)
        {
            // Load danh sách dãy
            dgvDay.DataSource = quanLyDay_BL.LayDanhSachDay();

            // Load danh sách nhân viên vào ComboBox
            List<NhanVien> nhanViens = quanLyDay_BL.LayDanhSachNhanVien();
            cbQuanly.DataSource = nhanViens;
            cbQuanly.DisplayMember = "tennv";
            cbQuanly.ValueMember = "manv";

            //Load dữ liệu vào combobox
            LoadTrangThaiCombobox();
            LoadGioiTinhdayCombobox();
        }

        private void LoadTrangThaiCombobox()
        {
            cbTrangthai.Items.Clear();
            cbTrangthai.Items.Add("Đang hoạt động");
            cbTrangthai.Items.Add("Đang vệ sinh");
            cbTrangthai.Items.Add("Đang bảo trì");
        }

        private void LoadGioiTinhdayCombobox()
        {
            cbDaygioitinh.Items.Clear();
            cbDaygioitinh.Items.Add("Nam");
            cbDaygioitinh.Items.Add("Nữ");
        }

        private void GBtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDay.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dãy cần xóa!");
                return;
            }

            string maDay = txtMaday.Text.Trim();

            // Xác nhận xóa
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa dãy này?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool result = quanLyDay_BL.XoaDay(maDay);
                    if (result)
                    {
                        MessageBox.Show("Xóa dãy thành công!");
                        dgvDay.DataSource = quanLyDay_BL.LayDanhSachDay(); // Load lại danh sách
                        
                        // Xóa trắng các ô nhập
                        LamSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa dãy thất bại!");
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Lỗi khóa ngoại
                    {
                        MessageBox.Show("Không thể xóa dãy vì có phòng thuộc dãy này!");
                    }
                    else
                    {
                        MessageBox.Show("Lỗi database: " + ex.Message);
                    }
                }
            }
        }

        private void GBtnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(txtMaday.Text) ||
                string.IsNullOrEmpty(txtTenday.Text) ||
                cbQuanly.SelectedValue == null ||
                string.IsNullOrEmpty(cbTrangthai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // Tạo đối tượng Day từ dữ liệu nhập
                DayPhong updatedDay = new DayPhong(
                    txtMaday.Text.Trim(),
                    txtTenday.Text.Trim(),
                    cbQuanly.Text.Trim(), // Lấy mã NV từ ValueMember
                    cbTrangthai.Text.Trim(),
                    cbDaygioitinh.Text.Trim()
                );

                // Gọi BL để cập nhật vào database
                bool result = quanLyDay_BL.SuaDay(updatedDay);

                if (result)
                {
                    MessageBox.Show("Cập nhật dãy thành công!");
                    // Load lại DataGridView
                    dgvDay.DataSource = quanLyDay_BL.LayDanhSachDay();
                    // Xóa trắng các ô nhập
                    LamSach();
                }
                else
                {
                    MessageBox.Show("Cập nhật dãy thất bại!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi database: " + ex.Message);
            }
        }

        private void GBtnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập
            if (string.IsNullOrEmpty(txtMaday.Text) ||
                string.IsNullOrEmpty(txtTenday.Text) ||
                cbQuanly.SelectedValue == null ||
                string.IsNullOrEmpty(cbTrangthai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            try
            {
                // Tạo đối tượng Day từ dữ liệu nhập
                DayPhong newDay = new DayPhong(
                    txtMaday.Text.Trim(),
                    txtTenday.Text.Trim(),
                    cbQuanly.Text.Trim(), // Lấy mã NV từ ValueMember
                    cbTrangthai.Text.Trim(),
                    cbDaygioitinh.Text.Trim()
                );

                // Gọi BL để thêm vào database
                bool result = quanLyDay_BL.ThemDay(newDay);

                if (result)
                {
                    MessageBox.Show("Thêm dãy thành công!");
                    // Load lại DataGridView
                    dgvDay.DataSource = quanLyDay_BL.LayDanhSachDay();
                    // Xóa trắng các ô nhập
                    LamSach();
                }
                else
                {
                    MessageBox.Show("Thêm dãy thất bại!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi database: " + ex.Message);
            }
        }

        private void GBtnDongg_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LamSach()
        {
            txtMaday.Clear();
            txtTenday.Clear();
            cbQuanly.SelectedIndex = -1;
            cbTrangthai.SelectedIndex = -1;
            cbDaygioitinh.SelectedIndex = -1;
        }

        private void GBtnLamsach_Click(object sender, EventArgs e)
        {
            LamSach();
        }

        private void dgvDay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDay.Rows[e.RowIndex];
                txtMaday.Text = row.Cells["maday"].Value.ToString();
                txtTenday.Text = row.Cells["tenday"].Value.ToString();
                cbQuanly.Text = row.Cells["quanly"].Value.ToString(); // Giả sử ComboBox bind ValueMember là manv
                cbTrangthai.Text = row.Cells["trangthai"].Value.ToString();
                cbDaygioitinh.Text = row.Cells["daygioitinh"].Value.ToString();
            }
        }
    }
}
