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

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyTienNuoc : Form
    {
        public FrmQuanLyTienNuoc()
        {
            InitializeComponent();
        }


        QuanLy_BLL.BLL_TienNuoc bll = new QuanLy_BLL.BLL_TienNuoc();
        QuanLy_BLL.BLL_Phong bllPhong = new QuanLy_BLL.BLL_Phong();

        private void FrmQuanLyTienNuoc_Load(object sender, EventArgs e)
        {
            LoadPhong();
            LoadTienNuoc();
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

        private void LoadTienNuoc()
        {
            dgvTiennuoc.DataSource = bll.GetAllTienNuoc();
            dgvTiennuoc.AutoGenerateColumns = true;
            dgvTiennuoc.ReadOnly = true;
        }

        private float tinhTienNuoc(int sokhoi)
        {
            float tongTien = 0;
            float chiSo = 22000;
            tongTien += chiSo * sokhoi;

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

            txtTiennuoc.Enabled = true;
            txtTiennuoc.Clear();
            txtTiennuoc.Enabled = false;
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            FrmQuanLyTienNuoc_Load(sender, e);
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

                if (bll.ExistsTienNuoc(cbMaphong.Text, dtpNgaylap.Value))
                {
                    MessageBox.Show($"Đã tồn tại hóa đơn nước của phòng {cbMaphong.Text.Trim()} trong ngày {dtpNgaylap.Value.ToShortDateString()}",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy chỉ số nước cũ từ hóa đơn gần nhất
                int chisocu = bll.GetChiSoMoiGanNhat(cbMaphong.Text);

                if (chisomoi <= chisocu)
                {
                    MessageBox.Show("Chỉ số mới phải lớn hơn chỉ số cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sokhoi = chisomoi - chisocu;
                float tongtien = tinhTienNuoc(sokhoi);

                TienNuoc tn = new TienNuoc
                {
                    Maphong = cbMaphong.Text,
                    Ngaylap = dtpNgaylap.Value,
                    Chisocu = chisocu,
                    Chisomoi = chisomoi,
                    Sokhoitieuthu = sokhoi,
                    Tongtien = tongtien,
                    Trangthai = cbTrangthai.Text
                };

                bll.InsertTienNuoc(tn);

                // Sau khi thêm hóa đơn mới, kiểm tra hóa đơn nước kế tiếp (nếu có)
                TienNuoc hoaDonKeTiep = bll.GetHoaDonKeTiep(cbMaphong.Text, dtpNgaylap.Value);
                if (hoaDonKeTiep != null)
                {
                    hoaDonKeTiep.Chisocu = chisomoi; // lấy chisomoi mới vừa thêm/cập nhật
                    hoaDonKeTiep.Sokhoitieuthu = hoaDonKeTiep.Chisomoi - hoaDonKeTiep.Chisocu;
                    hoaDonKeTiep.Tongtien = tinhTienNuoc(hoaDonKeTiep.Sokhoitieuthu);

                    bll.UpdateTienNuoc(hoaDonKeTiep);
                }

                MessageBox.Show("Thêm hóa đơn nước thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLammoi_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTiennuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMahoadon.Text = dgvTiennuoc.Rows[vitri].Cells[0].Value.ToString();
                cbMaphong.Text = dgvTiennuoc.Rows[vitri].Cells[1].Value.ToString();
                dtpNgaylap.Text = dgvTiennuoc.Rows[vitri].Cells[2].Value.ToString();
                //  txtChisomoi.Text = dgvTiendien.Rows[vitri].Cells[5].Value.ToString();
               // txtTiennuoc.Text = dgvTiennuoc.Rows[vitri].Cells[6].Value.ToString();
                decimal tienDien = Convert.ToDecimal(dgvTiennuoc.Rows[vitri].Cells[6].Value);
                txtTiennuoc.Text = tienDien.ToString("#,##0") + " VNĐ";
                cbTrangthai.Text = dgvTiennuoc.Rows[vitri].Cells[7].Value.ToString();
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
                    MessageBox.Show("Vui lòng nhập số khối mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtChisomoi.Text, out int chisomoi) || chisomoi <= 0)
                {
                    MessageBox.Show("Số khối mới phải là số nguyên dương", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string trangthai = cbTrangthai.Text;
                if (trangthai == "Đã thanh toán" || trangthai == "Hoàn thành")
                {
                    MessageBox.Show("Không thể chỉnh sửa hóa đơn đã thanh toán hoặc hoàn thành.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int mahoadon = int.Parse(txtMahoadon.Text);
                int chisocu = int.Parse(dgvTiennuoc.SelectedRows[0].Cells["chisocu"].Value.ToString());

                if (chisomoi <= chisocu)
                {
                    MessageBox.Show("Số khối mới phải lớn hơn số khối cũ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int sokhoitieuthu = chisomoi - chisocu;
                float tongtien = tinhTienNuoc(sokhoitieuthu);

                //Cập nhật hóa đơn hiện tại
                TienNuoc tn = new TienNuoc
                {
                    Mahoadon = mahoadon,
                    Maphong = cbMaphong.Text,
                    Ngaylap = dtpNgaylap.Value,
                    Chisocu = chisocu,
                    Chisomoi = chisomoi,
                    Sokhoitieuthu = sokhoitieuthu,
                    Tongtien = tongtien,
                    Trangthai = cbTrangthai.Text
                };

                bll.UpdateTienNuoc(tn);

                // Sau khi cập nhật hóa đơn này, chỉnh hóa đơn kế tiếp
                TienNuoc hoaDonKeTiep = bll.GetHoaDonKeTiep(cbMaphong.Text, dtpNgaylap.Value);
                if (hoaDonKeTiep != null)
                {
                    hoaDonKeTiep.Chisocu = chisomoi;
                    hoaDonKeTiep.Sokhoitieuthu = hoaDonKeTiep.Chisomoi - hoaDonKeTiep.Chisocu;
                    hoaDonKeTiep.Tongtien = tinhTienNuoc(hoaDonKeTiep.Sokhoitieuthu);

                    bll.UpdateTienNuoc(hoaDonKeTiep);
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
                int sokhoi = bll.GetSoKhoi(txtMahoadon.Text);

                bll.DeleteTienNuoc(txtMahoadon.Text);
                LoadTienNuoc();
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
                dgvTiennuoc.DataSource = bll.SearchTienNuoc(txtTimkiem.Text, "maphong");
            }
            else if (rbTktheott.Checked)
            {
                if (txtTimkiem.Text == "")
                {
                    MessageBox.Show("Bạn chưa chọn trạng thái tìm kiếm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                dgvTiennuoc.DataSource = bll.SearchTienNuoc(txtTimkiem.Text, "trangthai");
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
            FrmQuanLyTienNuoc_Load(sender, e);
        }

        private void btnXuatPDF_Click(object sender, EventArgs e)
        {
            if (dgvTiennuoc.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xuất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridViewRow row = dgvTiennuoc.SelectedRows[0];

            // Tạo tài liệu PDF
            Document doc = new Document(PageSize.A4);
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "HoaDonTienNuoc.pdf");
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));

            // Load font DejaVu hỗ trợ tiếng Việt
            string fontPath = Path.Combine(Application.StartupPath, @"DejaVuSans.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            doc.Open();
            doc.Add(new Paragraph("HÓA ĐƠN TIỀN NƯỚC", new iTextSharp.text.Font(bf, 16, iTextSharp.text.Font.BOLD)));
            doc.Add(new Paragraph("Mã hóa đơn: " + row.Cells["mahoadon"].Value, font));
            doc.Add(new Paragraph("Mã phòng: " + row.Cells["maphong"].Value, font));
            doc.Add(new Paragraph("Ngày lập: " + row.Cells["ngaylap"].Value, font));
            doc.Add(new Paragraph("Chỉ số cũ: " + row.Cells["chisocu"].Value, font));
            doc.Add(new Paragraph("Chỉ số mới: " + row.Cells["chisomoi"].Value, font));
            doc.Add(new Paragraph("Số khối tiêu thụ: " + row.Cells["sokhoitieuthu"].Value, font));
            doc.Add(new Paragraph("Tổng tiền: " + row.Cells["tongtien"].Value + " VND", font));
            doc.Add(new Paragraph("Trạng thái: " + row.Cells["trangthai"].Value, font));
            doc.Close();

            MessageBox.Show("Đã xuất hóa đơn ra Desktop!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
