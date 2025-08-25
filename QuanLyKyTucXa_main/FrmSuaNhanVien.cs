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
    public partial class FrmSuaNhanVien: Form
    {
        private NhanVien nhanVien;
        private QuanLyNhanVien_BL quanLyNV_BL = new QuanLyNhanVien_BL();

        public FrmSuaNhanVien(NhanVien nv)
        {
            InitializeComponent();
            this.nhanVien = nv;

            // Đổ dữ liệu vào controls
            txtManv.Text = nv.manv;
            txtTennv.Text = nv.tennv;
            cbGioitinh.Text = nv.gioitinh;
            dtpNgaysinh.Value = DateTime.Parse(nv.ngaysinh);
            txtDiachi.Text = nv.diachi;
            txtSodienthoai.Text = nv.sodienthoai;
        }


        private void GBtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật thông tin từ controls
                nhanVien.tennv = txtTennv.Text;
                nhanVien.gioitinh = cbGioitinh.Text;
                nhanVien.ngaysinh = dtpNgaysinh.Value.ToShortDateString();
                nhanVien.diachi = txtDiachi.Text;
                nhanVien.sodienthoai = txtSodienthoai.Text;

                // Gọi BLL để cập nhật
                int result = quanLyNV_BL.CapNhapNhanVien(nhanVien);

                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void GBtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
