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
using QuanLy_BLL;

namespace QuanLyKyTucXa_main
{
    public partial class DanhSachNhanVien : Form
    {
        private ThanhToanLuongNhanVien_BL thanhToanLuongNhanVien_BL;
        private FrmThanhToanLuongNhanVien frmThanhToan;
        // Thêm các thuộc tính public để lưu thông tin

        public DanhSachNhanVien(FrmThanhToanLuongNhanVien frm)
        {
            InitializeComponent();
            thanhToanLuongNhanVien_BL = new ThanhToanLuongNhanVien_BL();

            this.frmThanhToan = frm;
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNhanvien.DataSource = thanhToanLuongNhanVien_BL.LayDanhSachNhanVien();
        }

        private void dgvDSNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvDSNhanvien.Columns["Column1"].Index)
            {
                string manv = dgvDSNhanvien.Rows[e.RowIndex].Cells["maNhanVien"].Value.ToString();
                string tennv = dgvDSNhanvien.Rows[e.RowIndex].Cells["tenNhanVien"].Value.ToString();

                frmThanhToan.SetNhanVien(manv, tennv);
                this.Close(); // Đóng form sau khi chọn
            }
        }

        private void GBtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
