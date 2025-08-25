using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Web.UI.WebControls;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyTienDien : Form
    {
        public FrmQuanLyTienDien()
        {
            InitializeComponent();
        }

        QuanLy_BLL.BLL_TienDien bll = new QuanLy_BLL.BLL_TienDien();
        QuanLy_BLL.BLL_Phong bllPhong = new QuanLy_BLL.BLL_Phong();

        private void FrmQuanLyTienDien_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadTienDien();
            ClearInputs();
            LoadTrangThaiComboBox();
        }

        private void LoadTrangThaiComboBox()
        {
            cbTrangthai.Items.Clear();
            cbTrangthai.Items.Add("Chưa thanh toán");
            cbTrangthai.Items.Add("Đã thanh toán");
        }


        private void LoadPhong()
        {
            cbMaphong.DataSource = bllPhong.GetAllPhong();
            cbMaphong.DisplayMember = "Maphong";
            cbMaphong.ValueMember = "Maphong";
            cbMaphong.SelectedIndex = -1;
        }

        private void LoadTienDien()
        {
            dgvTiendien.DataSource = bll.GetAllTienDien();
            dgvTiendien.AutoGenerateColumns = true;
            dgvTiendien.ReadOnly = true;
        }

        private float tinhTienDien(int sodien)
        {
            float tongTien = 0;
            float chiSo = 3000;
            tongTien += chiSo * sodien;

            return tongTien;
        }

        private void ClearInputs()
        {
            txtMahoadon.Enabled = true;
            txtMahoadon.Clear();
            txtMahoadon.Enabled = false;

            cbMaphong.SelectedIndex = -1;
            dtpNgaylap.Value = DateTime.Now;
            txtChisomoi.Clear();
            cbTrangthai.SelectedIndex = -1;

            txtTiendien.Enabled = true;
            txtTiendien.Clear();
            txtTiendien.Enabled = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            FrmQuanLyTienDien_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtChisomoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập chỉ số mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtChisomoi.Text, out int chisomoi) || chisomoi <= 0)
                {
                    MessageBox.Show("Chỉ số mới phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(cbMaphong.Text) || string.IsNullOrEmpty(cbTrangthai.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (bll.ExistsTienDien(cbMaphong.Text, dtpNgaylap.Value))
                {
                    MessageBox.Show($"Đã tồn tại hóa đơn điện của phòng {cbMaphong.Text.Trim()} trong ngày {dtpNgaylap.Value.ToShortDateString()}",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy chỉ số cũ từ hóa đơn gần nhất
                int chisocu = bll.GetChiSoMoiGanNhat(cbMaphong.Text);

                if (chisomoi <= chisocu)
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sodien = chisomoi - chisocu;
                float tongtien = tinhTienDien(sodien);

                TienDien td = new TienDien
                {
                    Maphong = cbMaphong.Text,
                    Ngaylap = dtpNgaylap.Value,
                    Chisocu = chisocu,
                    Chisomoi = chisomoi,
                    Sodientieuthu = sodien,
                    Tongtien = tongtien,
                    Trangthai = cbTrangthai.Text
                };

                bll.InsertTienDien(td);

                // Sau khi thêm hóa đơn mới, kiểm tra hóa đơn kế tiếp (nếu có)
                TienDien hoaDonKeTiep = bll.GetHoaDonKeTiep(cbMaphong.Text, dtpNgaylap.Value);
                if (hoaDonKeTiep != null)
                {
                    hoaDonKeTiep.Chisocu = chisomoi; // lấy chisomoi mới vừa thêm/cập nhật
                    hoaDonKeTiep.Sodientieuthu = hoaDonKeTiep.Chisomoi - hoaDonKeTiep.Chisocu;
                    hoaDonKeTiep.Tongtien = tinhTienDien(hoaDonKeTiep.Sodientieuthu);

                    bll.UpdateTienDien(hoaDonKeTiep);
                }

                MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTiendien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMahoadon.Text = dgvTiendien.Rows[vitri].Cells[0].Value.ToString();
                cbMaphong.Text = dgvTiendien.Rows[vitri].Cells[1].Value.ToString();
                dtpNgaylap.Text = dgvTiendien.Rows[vitri].Cells[2].Value.ToString();
                decimal tienDien = Convert.ToDecimal(dgvTiendien.Rows[vitri].Cells[6].Value);
                txtTiendien.Text = tienDien.ToString("#,##0") + " VNĐ";
                //  txtChisomoi.Text = dgvTiendien.Rows[vitri].Cells[5].Value.ToString();
                cbTrangthai.Text = dgvTiendien.Rows[vitri].Cells[7].Value.ToString();
                if (cbTrangthai.Text == "Chưa thanh toán")
                    btnThanhtoan.Enabled = true;
                else
                    btnThanhtoan.Enabled = false;
                //if (cbTrangthai.Text == "Đã thanh toán")
                //btnThanhtoan.Enabled = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtMahoadon.Text))
                {
                    MessageBox.Show("Vui lòng chọn hóa đơn cần cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtChisomoi.Text))
                {
                    MessageBox.Show("Vui lòng nhập chỉ số mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtChisomoi.Text, out int chisomoi) || chisomoi <= 0)
                {
                    MessageBox.Show("Chỉ số mới phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string trangthai = cbTrangthai.Text;
                if (trangthai == "Đã thanh toán" || trangthai == "Hoàn thành")
                {
                    MessageBox.Show("Không thể chỉnh sửa hóa đơn đã thanh toán hoặc hoàn thành.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int mahoadon = int.Parse(txtMahoadon.Text);
                int chisocu = int.Parse(dgvTiendien.SelectedRows[0].Cells["chisocu"].Value.ToString());

                if (chisomoi <= chisocu)
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sodientieuthu = chisomoi - chisocu;
                float tongtien = tinhTienDien(sodientieuthu);

                TienDien td = new TienDien
                {
                    Mahoadon = mahoadon,
                    Maphong = cbMaphong.Text,
                    Ngaylap = dtpNgaylap.Value,
                    Chisocu = chisocu,
                    Chisomoi = chisomoi,
                    Sodientieuthu = sodientieuthu,
                    Tongtien = tongtien,
                    Trangthai = cbTrangthai.Text
                };

                bll.UpdateTienDien(td);

                // Sau khi thêm hóa đơn hoặc cập nhật hóa đơn hiện tại
                TienDien hoaDonKeTiep = bll.GetHoaDonKeTiep(cbMaphong.Text, dtpNgaylap.Value);
                if (hoaDonKeTiep != null)
                {
                    hoaDonKeTiep.Chisocu = chisomoi;
                    hoaDonKeTiep.Sodientieuthu = hoaDonKeTiep.Chisomoi - hoaDonKeTiep.Chisocu;
                    hoaDonKeTiep.Tongtien = tinhTienDien(hoaDonKeTiep.Sodientieuthu);

                    bll.UpdateTienDien(hoaDonKeTiep);
                }

                MessageBox.Show("Cập nhật hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMahoadon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                int sodien = bll.GetSoDien(txtMahoadon.Text);

                bll.DeleteTienDien(txtMahoadon.Text);
                LoadTienDien();
                btnLammoi_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        //private void rbTktheoma_CheckedChanged(object sender, EventArgs e)
        //{
        //    cbMaphong.Enabled = true;
        //    dtpNgaylap.Enabled = false;
        //    txtChisomoi.Enabled = false;
        //    cbTrangthai.Enabled = false;
        //}

        //private void rbTktheott_CheckedChanged(object sender, EventArgs e)
        //{
        //    cbMaphong.Enabled = false;
        //    dtpNgaylap.Enabled = false;
        //    txtChisomoi.Enabled = false;
        //    cbTrangthai.Enabled = true;
        //}

        private void btnInhoadon_Click(object sender, EventArgs e)
        {
            bll.UpdateTrangThai(txtMahoadon.Text, "Hoàn thành");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (rbTktheoma.Checked)
            {
                if (txtTimkiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã phòng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendien.DataSource = bll.SearchTienDien(txtTimkiem.Text, "maphong");
            }
            else if (rbTktheott.Checked)
            {
                if (txtTimkiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn trạng thái tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiendien.DataSource = bll.SearchTienDien(txtTimkiem.Text, "trangthai");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tiêu chí tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            bll.UpdateTrangThai(txtMahoadon.Text, "Đã thanh toán");
            MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmQuanLyTienDien_Load(sender, e);
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            if (dgvTiendien.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvTiendien.SelectedRows[0];

            // Tạo tài liệu PDF
            Document doc = new Document(PageSize.A4);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HoaDonTienDien.pdf");
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Load font DejaVu hỗ trợ tiếng Việt
            string fontPath = Path.Combine(Application.StartupPath, @"DejaVuSans.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            doc.Open();
            doc.Add(new Paragraph("HÓA ĐƠN TIỀN ĐIỆN", new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph("Mã hóa đơn: " + row.Cells["mahoadon"].Value, font));
            doc.Add(new Paragraph("Mã phòng: " + row.Cells["maphong"].Value, font));
            doc.Add(new Paragraph("Ngày lập: " + row.Cells["ngaylap"].Value, font));
            doc.Add(new Paragraph("Chỉ số cũ: " + row.Cells["chisocu"].Value, font));
            doc.Add(new Paragraph("Chỉ số mới: " + row.Cells["chisomoi"].Value, font));
            doc.Add(new Paragraph("Số điện tiêu thụ: " + row.Cells["sodientieuthu"].Value, font));
            doc.Add(new Paragraph("Tổng tiền: " + row.Cells["tongtien"].Value + " VND", font));
            doc.Add(new Paragraph("Trạng thái: " + row.Cells["trangthai"].Value, font));
            doc.Close();

            MessageBox.Show("Đã xuất hóa đơn ra Desktop!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
