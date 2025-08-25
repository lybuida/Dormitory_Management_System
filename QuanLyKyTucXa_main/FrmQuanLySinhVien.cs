using QuanLy_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLySinhVien : Form
    {
        private QuanLySinhVien_BL quanLySinhVien_BLL;
        public FrmQuanLySinhVien()
        {
            InitializeComponent();
            quanLySinhVien_BLL = new QuanLySinhVien_BL();
        }

        private void FrmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            dgvSinhVien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();

            BLL_Phong mpBL = new BLL_Phong(); 
            cbMaphong.DataSource = mpBL.GetMaPhong();
            cbMaphong.DropDownStyle = ComboBoxStyle.DropDownList;
            txtMasv.ReadOnly = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTensv.Text))
                    throw new Exception("Tên SV không được trống");
                if (string.IsNullOrEmpty(txtEmail.Text))
                    throw new Exception("Tên SV không được trống");

                // Tạo đối tượng nhân viên
                SinhVien sv = new SinhVien(
                    //txtMasv.Text,
                    txtTensv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtQuequan.Text,
                    txtEmail.Text,
                    cbKhoa.Text,
                    txtLop.Text,
                    cbLoaiuutien.Text,
                    cbMaphong.Text
                );


                // Gọi BLL để thêm
                bool result = quanLySinhVien_BLL.ThemSinhVien(sv);


                if (result)
                {
                    MessageBox.Show("Thêm thành công!");
                    // Cập nhật lại DataGridView
                    dgvSinhVien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();

                    // Xóa trắng các ô nhập
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        // Phương thức xóa trắng control
        private void ClearControls()
        {
            txtMasv.Clear();
            txtTensv.Clear();
            cbGioitinh.SelectedIndex = -1;
            dtpNgaysinh.Value = DateTime.Now;
            txtQuequan.Clear();
            txtEmail.Clear(); 
            cbKhoa.SelectedIndex = -1;
            cbKhoa.Text = "";
            txtLop.Clear();
            cbLoaiuutien.SelectedIndex = -1;
            cbMaphong.SelectedIndex = -1;


        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimkiem.Text.Trim();


                if (string.IsNullOrEmpty(keyword))
                {
                    // Nếu ô tìm kiếm trống, load lại toàn bộ danh sách
                    dgvSinhVien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    return;
                }


                // Xác định kiểu tìm kiếm dựa trên RadioButton
                KieuTimKiem kieuTimKiem;
                if (rbTktheoma.Checked)
                    kieuTimKiem = KieuTimKiem.TheoMaSV;
                else if (rbTktheoten.Checked)
                    kieuTimKiem = KieuTimKiem.TheoTenSV;
                else if (rbTkTheoMaphong.Checked)
                    kieuTimKiem = KieuTimKiem.TheoMaPhong;
                else
                    throw new Exception("Vui lòng chọn kiểu tìm kiếm!");

                // Gọi BLL để tìm kiếm
                List<SinhVien> ketQua = quanLySinhVien_BLL.TimKiemSinhVien(keyword, kieuTimKiem);

                // Hiển thị kết quả lên DataGridView
                dgvSinhVien.DataSource = ketQua;


                if (ketQua.Count == 0)
                    MessageBox.Show("Không tìm thấy sinh viên nào!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvSinhVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMasv.Text = row.Cells["masv"].Value.ToString();
                txtMasv.ReadOnly = true;
                txtTensv.Text = row.Cells["tensv"].Value.ToString();
                cbGioitinh.Text = row.Cells["gioitinh"].Value.ToString();
                dtpNgaysinh.Value = DateTime.Parse(row.Cells["ngaysinh"].Value.ToString());
                txtQuequan.Text = row.Cells["quequan"].Value.ToString();
                txtEmail.Text = row.Cells["email"].Value.ToString();
                cbKhoa.Text = row.Cells["khoa"].Value.ToString();
                txtLop.Text = row.Cells["lop"].Value.ToString();
                cbLoaiuutien.Text = row.Cells["loaiuutien"].Value.ToString();
                
                cbMaphong.SelectedItem = row.Cells["maphong"].Value.ToString();
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMasv.Text))
                    throw new Exception("Vui lòng chọn sinh viên cần sửa!");



                // Tạo đối tượng sinh viên với dữ liệu mới
                SinhVien sv = new SinhVien(
                    txtMasv.Text,
                    txtTensv.Text,
                    cbGioitinh.Text,
                    dtpNgaysinh.Value.ToString("yyyy-MM-dd"),
                    txtQuequan.Text,
                    txtEmail.Text,
                    cbKhoa.Text,
                    txtLop.Text,
                    cbLoaiuutien.Text,
                    cbMaphong.Text
                );

                // Gọi BLL cập nhật
                bool result = quanLySinhVien_BLL.CapNhatSinhVien(sv);

                if (result)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    dgvSinhVien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoas_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtMasv.Text))
                    throw new Exception("Vui lòng chọn sinh viên cần xóa!");

                // Xác nhận xóa
                DialogResult confirm = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa sinh viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo
                );

                if (confirm != DialogResult.Yes) return;

                // Gọi BLL để xóa
                bool result = quanLySinhVien_BLL.XoaSinhVien(txtMasv.Text);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                    dgvSinhVien.DataSource = quanLySinhVien_BLL.LayDanhSachSinhVien();
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Khởi tạo Excel
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

            // Lấy Sheet đầu tiên
            Microsoft.Office.Interop.Excel._Worksheet worksheet = (Microsoft.Office.Interop.Excel._Worksheet)workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;

            // Ghi tiêu đề cột từ DataGridView
            for (int i = 0; i < dgvSinhVien.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvSinhVien.Columns[i].HeaderText;
            }

            // Ghi dữ liệu từ DataGridView
            int rowExcel = 2; // bắt đầu từ dòng 2 vì dòng 1 là tiêu đề
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.IsNewRow) continue;

                for (int col = 0; col < dgvSinhVien.Columns.Count; col++)
                {
                    object value = row.Cells[col].Value;
                    worksheet.Cells[rowExcel, col + 1] = value?.ToString() ?? "";
                }

                rowExcel++;
            }

            // Định dạng: in đậm, màu đỏ, căn giữa dòng tiêu đề
            string endColumn = ((char)('A' + dgvSinhVien.Columns.Count - 1)).ToString(); // Ví dụ: G
            worksheet.Range[$"A1", $"{endColumn}1"].Font.Bold = true;
            worksheet.Range[$"A1", $"{endColumn}1"].Font.ColorIndex = 3;
            worksheet.Range[$"A1", $"{endColumn}1"].HorizontalAlignment = 3;

            // Font toàn bảng và viền
            worksheet.Range[$"A1", $"{endColumn}{rowExcel - 1}"].Font.Name = "Times New Roman";
            worksheet.Range[$"A1", $"{endColumn}{rowExcel - 1}"].Borders.LineStyle = 1;

            // Tự động điều chỉnh độ rộng cột
            worksheet.Columns.AutoFit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            FrmQuanLySinhVien_Load(sender, e);
            ClearControls();
        }
    }
}

