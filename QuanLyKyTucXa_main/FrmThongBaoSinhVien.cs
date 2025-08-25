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

namespace QuanLyKyTucXa_main
{
    public partial class FrmThongBaoSinhVien: Form
    {
        private ThongBaoGmail_BL thongBaoGmail_BL;
        public FrmThongBaoSinhVien()
        {
            InitializeComponent();
            thongBaoGmail_BL = new ThongBaoGmail_BL();
        }


        private void GBtnGuiemail_Click(object sender, EventArgs e)
        {
            string noidung = txtNoidungThongbao.Text.Trim();
            if (string.IsNullOrEmpty(noidung))
            {
                MessageBox.Show("Vui lòng nhập nội dung thông báo!");
                return;
            }

            try
            {
                thongBaoGmail_BL.GuiMailToanBo(noidung);
                MessageBox.Show("Đã gửi thông báo đến tất cả sinh viên!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gửi mail: " + ex.Message);
            }
        }

        private void GBtnDongg_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
