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
using System.Data.SqlClient;
using System.Security.Principal;

namespace QuanLyKyTucXa_main
{
    public partial class FrmDangNhap : Form
    {
        private DangNhap_BL dangnhapBL;
        public FrmDangNhap()
        {
            InitializeComponent();
            dangnhapBL = new DangNhap_BL();
        }

        private void GBtnDangnhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTaikhoan.Text.Trim();
            string matKhau = txtMatkhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NguoiDung nguoiDung = dangnhapBL.KiemTraDangNhap(tenDangNhap, matKhau);

            if (nguoiDung != null)
            {
                this.Hide();
                FrmMain frmMainMenu = new FrmMain();
                frmMainMenu.ShowDialog();

                //FrmAdmin frmAdmin = new FrmAdmin();
                //frmAdmin.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GcbShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            txtMatkhau.PasswordChar = GcbShowpassword.Checked ? '\0' : '*';
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }  
}