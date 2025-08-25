using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyKyTucXa_main
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        


        private void openChildForm(Form childForm, Size size, Point point)
        {
           
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //thay doi title
            lblTitle.Text = childForm.Text;
            lblTitle.AutoSize = true;

            // Đảm bảo không bị giới hạn chiều rộng
            lblTitle.MaximumSize = new Size(panel2.Width, 0); // nếu cần
            lblTitle.Left = (panel2.Width - lblTitle.PreferredWidth) / 2;

            //ly them chatbot 
            chatBotControl1.BringToFront();
            btnToggleChatBot.BringToFront();
        }


        bool menuNSExpand = false;
        private void timeMenuNhanSu_Tick(object sender, EventArgs e)
        {
            if (menuNSExpand == false)
            {
                menuNhanSu.Height += 10;
                if (menuNhanSu.Height >= 155)
                {
                    timeMenuNhanSu.Stop();
                    menuNSExpand = true;
                }
            }
            else
            {
                menuNhanSu.Height -= 10;
                if (menuNhanSu.Height <= 45)
                {
                    timeMenuNhanSu.Stop();
                    menuNSExpand = false;
                }
            }
        }
        //QLNS
        private void guna2Button21_Click(object sender, EventArgs e)
        {
            timeMenuNhanSu.Start();
        }


        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNhanVien(), new Size(192, 26), new Point(325, 15));
        }
        private void btnLuongNV_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThanhToanLuongNhanVien(), new Size(192, 26), new Point(325, 15));

        }
        private void btnQlSV_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLySinhVien(), new Size(180, 26), new Point(325, 15));
        }
        private void btnNguoiDung_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyNguoiDung(), new Size(192, 26), new Point(325, 15));
        }


        //Home
        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            chatBotControl1.Visible = false; //ly 

            
        }

        

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            uc.BringToFront();

            lblTitle.Text = "Trang chủ";
        }

        //QLDV
        private void timeMenuDichVu_Tick(object sender, EventArgs e)
        {
            if (menuNSExpand == false)
            {
                menuDV.Height += 10;
                if (menuDV.Height >= 110)
                {
                    timeMenuDichVu.Stop();
                    menuNSExpand = true;
                }
            }
            else
            {
                menuDV.Height -= 10;
                if (menuDV.Height <= 41)
                {
                    timeMenuDichVu.Stop();
                    menuNSExpand = false;
                }
            }

        }

        private void btnQLDichVu_Click(object sender, EventArgs e)
        {
            timeMenuDichVu.Start();
        }

        private void btnTienDien_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTienDien(), new Size(129, 26), new Point(308, 15));
        }

        private void btnTienNuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyTienNuoc(), new Size(129, 26), new Point(308, 15));
        }
        //CSVC
        private void timeMenuCSVC_Tick(object sender, EventArgs e)
        {
            if (menuNSExpand == false)
            {
                menuCSVC.Height += 10;
                if (menuCSVC.Height >= 142)
                {
                    timeMenuCSVC.Stop();
                    menuNSExpand = true;
                }
            }
            else
            {
                menuCSVC.Height -= 10;
                if (menuCSVC.Height <= 41)
                {
                    timeMenuCSVC.Stop();
                    menuNSExpand = false;
                }
            }
        }

        private void btnQlCSVC_Click(object sender, EventArgs e)
        {
            timeMenuCSVC.Start();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyDay(), new Size(129, 26), new Point(308, 15));
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyPhong(), new Size(129, 26), new Point(308, 15));
        }

        private void btnThietBi_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyThietBi(), new Size(129, 26), new Point(308, 15));
        }

        private void btnKyLuat_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmQuanLyKyLuat(), new Size(129, 26), new Point(308, 15));
        }

        private void picGuiMail_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmThongBaoSinhVien(), new Size(129, 26), new Point(308, 15));
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide(); // Ẩn tạm FrmMainMenu đi trước
            FrmDangNhap dangNhap = new FrmDangNhap();
            dangNhap.ShowDialog(); // Chờ đăng nhập xong
            this.Close(); // Đóng hẳn FrmMainMenu sau
        }

//QUẢN LÝ ĐĂNG KÝ PHÒNG
        private void timeMenuDangKy_Tick(object sender, EventArgs e)
        {
            if (menuNSExpand == false)
            {
                menuDK.Height += 10;
                if (menuDK.Height >= 115)
                {
                    timeMenuDangKy.Stop();
                    menuNSExpand = true;
                }
            }
            else
            {
                menuDK.Height -= 10;
                if (menuDK.Height <= 41)
                {
                    timeMenuDangKy.Stop();
                    menuNSExpand = false;
                }
            }
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            timeMenuDangKy.Start();
            openChildForm(new FrmQuanLySinhVien(), new Size(180, 26), new Point(325, 15));

        }
        private void btnDangKyPhongs_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmDangKyPhong(), new Size(192, 26), new Point(325, 15));
        }

        private void btnDSDangKys_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhSachDangKy(), new Size(192, 26), new Point(325, 15));
        }


        private void btnToggleChatBot_Click(object sender, EventArgs e)
        {
            chatBotControl1.Visible = !chatBotControl1.Visible;
        }

        private void timeMenuTK_Tick(object sender, EventArgs e)
        {
            if (menuNSExpand == false)
            {
                menuTK.Height += 10;
                if (menuTK.Height >= 100)
                {
                    timeMenuTK.Stop();
                    menuNSExpand = true;
                }
            }
            else
            {
                menuTK.Height -= 10;
                if (menuTK.Height <= 41)
                {
                    timeMenuTK.Stop();
                    menuNSExpand = false;
                }
            }
        }
        private void btnThongKes_Click(object sender, EventArgs e)
        {
            timeMenuTK.Start();
            openChildForm(new FrmHome(), new Size(192, 26), new Point(325, 15));
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmBaoCaoLuongNhanVien(), new Size(192, 26), new Point(325, 15));
        }
    }
}
