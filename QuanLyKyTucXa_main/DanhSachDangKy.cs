using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_BLL;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class DanhSachDangKy : Form
    {
        private DanhSachDangKy_BL danhSachDangKy_BL;
        public DanhSachDangKy()
        {
            InitializeComponent();
            danhSachDangKy_BL = new DanhSachDangKy_BL();
        }

        

        private void DanhSachDangKy_Load(object sender, EventArgs e)
        {
            dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
            dgvSVDaDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVien();
        }

        

        private void GuiEmailThongBao(string emailNhan, string maPhong)
        {
            try
            {
                // Thông tin SMTP của Gmail
                string emailGui = "hethongktx@gmail.com"; // Thay bằng email của bạn
                string matKhau = "ytma rcuq qtnn pfrc"; // Mật khẩu ứng dụng (nếu dùng 2FA)

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(emailGui, matKhau)
                };

                // Tạo nội dung email
                var mail = new MailMessage(
                    from: emailGui,
                    to: emailNhan,
                    subject: "Thông báo xếp phòng Ký túc xá",
                    body: $@"
                Chào bạn,
                
                Bạn đã được xếp vào phòng {maPhong}.
                Vui lòng đến Ký túc xá để hoàn tất thủ tục.
                
                Trân trọng,
                Ban quản lý KTX"
                );

                // Gửi email
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi gửi email cho {emailNhan}: {ex.Message}");
            }
        }

        private void GBtnXepphong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách sinh viên chờ duyệt từ DataGridView
                var dsDangKy = (List<SinhVienDangKy>)dgvSVChoDuyet.DataSource;

                // Gọi nghiệp vụ xếp phòng
                danhSachDangKy_BL.XepPhongTuDong(dsDangKy);

                // Cập nhật lại DataGridView bằng cách tải lại dữ liệu từ CSDL
                var dsChoDuyetMoi = danhSachDangKy_BL.LayDSSinhVienDangKy();
                var dsDaDuyetMoi = danhSachDangKy_BL.LayDSSinhVien();

                // Reset DataSource để DataGridView cập nhật
                dgvSVChoDuyet.DataSource = null;
                dgvSVChoDuyet.DataSource = dsChoDuyetMoi;

                dgvSVDaDuyet.DataSource = null;
                dgvSVDaDuyet.DataSource = dsDaDuyetMoi;

                MessageBox.Show("Xếp phòng thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                // Luôn cập nhật DataGridView dù có lỗi hay không
                dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
                dgvSVDaDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVien();
            }
        }


        // Fix code lại đoạn này nhé
        private void GBtnGuiemail_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách sinh viên đã duyệt từ DataGridView
                var dsDaDuyet = (List<SinhVien>)dgvSVDaDuyet.DataSource;

                if (dsDaDuyet == null || dsDaDuyet.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên nào được duyệt để gửi email!");
                    return;
                }

                // Gửi email hàng loạt
                foreach (var sv in dsDaDuyet)
                {
                    GuiEmailThongBao(sv.email, sv.maphong);
                }

                MessageBox.Show("Đã gửi email thông báo thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email: " + ex.Message);
            }
        }

        private void GBtnGuimailSVkhxepphong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy danh sách sinh viên chưa được xếp phòng từ DataGridView
                var dsKhongXepDuoc = (List<SinhVienDangKy>)dgvSVChoDuyet.DataSource;

                if (dsKhongXepDuoc == null || dsKhongXepDuoc.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên nào chưa được xếp phòng!");
                    return;
                }

                // Gửi email hàng loạt
                foreach (var sv in dsKhongXepDuoc)
                {
                    GuiEmailThongBaoKhongXepDuoc(sv.email);
                }

                MessageBox.Show("Đã gửi email thông báo cho sinh viên chưa xếp phòng!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi gửi email: " + ex.Message);
            }
        }

        private void GuiEmailThongBaoKhongXepDuoc(string emailNhan)
        {
            try
            {
                // Thông tin SMTP của Gmail
                string emailGui = "hethongktx@gmail.com";
                string matKhau = "ytma rcuq qtnn pfrc";

                var client = new SmtpClient("smtp.gmail.com", 587)
                {
                    EnableSsl = true,
                    Credentials = new NetworkCredential(emailGui, matKhau)
                };

                // Tạo nội dung email
                var mail = new MailMessage(
                    from: emailGui,
                    to: emailNhan,
                    subject: "Thông báo từ Ký túc xá",
                    body: $@"
                    Chào bạn,

                    Hiện tại chúng tôi chưa thể xếp phòng cho bạn do hết phòng trống. 
                    Vui lòng liên hệ ban quản lý KTX để biết thêm chi tiết.

                    Trân trọng,
                    Ban quản lý KTX"
                );

                // Gửi email
                client.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi gửi email cho {emailNhan}: {ex.Message}");
            }
        }

        private void GBtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa toàn bộ sinh viên đăng ký?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    bool success = danhSachDangKy_BL.XoaTatCaSinhVienDangKy();

                    if (success)
                    {
                        // Cập nhật DataSource thay vì xóa trực tiếp các dòng
                        dgvSVChoDuyet.DataSource = null;
                        dgvSVChoDuyet.DataSource = danhSachDangKy_BL.LayDSSinhVienDangKy();
                        MessageBox.Show("Đã xóa toàn bộ sinh viên đăng ký!");
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu để xóa!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }
    }
}
