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
    public partial class FrmThemNhanVien: Form
    {
        private QuanLyNhanVien_BL quanLyNhanVien_BL;
        public FrmThemNhanVien()
        {
            InitializeComponent();
            quanLyNhanVien_BL = new QuanLyNhanVien_BL();
        }


        private void FrmThemNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void GBtnLuu_Click(object sender, EventArgs e)
        {
            string maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDienThoai;
            maNV = txtManv.Text;
            tenNV = txtTennv.Text.Trim();
            gioiTinh = cbGioitinh.Text.Trim();
            ngaySinh = dtpNgaysinh.Text.Trim();
            diaChi = txtDiachi.Text.Trim();
            soDienThoai = txtSodienthoai.Text.Trim();

            NhanVien nhanVien = new NhanVien(maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDienThoai);

            try
            {
                int numOfRows = quanLyNhanVien_BL.ThemNhanVien(nhanVien);
                // MessageBox.Show("So dong da them: " + numOfRows.ToString());

                if (numOfRows > 0)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Cancel;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GBtnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
