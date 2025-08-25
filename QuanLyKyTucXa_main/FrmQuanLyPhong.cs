using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using QuanLy_BLL;
using TransferObject;

namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyPhong : Form
    {
        private BLL_Phong bllPhong = new BLL_Phong();
        private QuanLyDay_BL bllDay = new QuanLyDay_BL();

        public FrmQuanLyPhong()
        {
            InitializeComponent();
        }

        private void FrmQuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadDayComboBox();
            LoadPhongData();
            LoadLoaiPhongComboBox();
            LoadXepLoaiComboBox();
        }

        private void LoadDayComboBox()
        {
            var dayList = bllDay.LayDanhSachDay();
            cbDay.DataSource = dayList;
            cbDay.ValueMember = "maday";
            //cbDay.DisplayMember = "tenday";
            cbDay.SelectedIndex = -1;
        }

        private void LoadPhongData()
        {
            var list = bllPhong.GetAllPhong();
            dgvPhong.DataSource = list;
            dgvPhong.AutoGenerateColumns = true;
            dgvPhong.ReadOnly = true;
        }

        private void LoadLoaiPhongComboBox()
        {
            cbLoaiphong.Items.Clear();
            cbLoaiphong.Items.Add("Nam");
            cbLoaiphong.Items.Add("Nữ");
        }

        private void LoadXepLoaiComboBox()
        {
            cbXeploai.Items.Clear();
            cbXeploai.Items.Add("Thường");
            cbXeploai.Items.Add("Vip");
        }

        private void ClearInputs()
        {
            txtMaphong.Clear();
            txtMaphong.Enabled = true;

            txtTenphong.Clear();

            txtSosvhientai.Enabled = true;
            txtSosvhientai.Clear();
            txtSosvhientai.Enabled = false;

            txtSosvtoida.Clear();

            txtTinhtrang.Enabled = true;
            txtTinhtrang.Clear();
            txtTinhtrang.Enabled = false;

            cbLoaiphong.SelectedIndex = -1;
            cbXeploai.SelectedIndex = -1;
            LoadDayComboBox();
            txtTimkiem.Clear();
            checkBox1.Checked = false;
            rbTktheoma.Checked = rbTktheoten.Checked = rbTktheomaday.Checked = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadPhongData();
            ClearInputs();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            Phong phong = new Phong(
                txtMaphong.Text.Trim(),
                txtTenphong.Text.Trim(),
                0,
                int.Parse(txtSosvtoida.Text.Trim()),
                cbLoaiphong.Text.Trim(),
                cbXeploai.Text.Trim(),
                cbDay.Text.Trim()
            );

            string message;
            bool result = bllPhong.InsertPhong(phong, out message);
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result) btnLamMoi_Click(sender, e);
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            int sosv = int.TryParse(txtSosvhientai.Text.Trim(), out sosv) ? sosv : 0;

            Phong phong = new Phong(
                txtMaphong.Text.Trim(),
                txtTenphong.Text.Trim(),
                sosv,
                int.Parse(txtSosvtoida.Text.Trim()),
                cbLoaiphong.Text.Trim(),
                cbXeploai.Text.Trim(),
                cbDay.Text.Trim()
            );

            string message;
            bool result = bllPhong.UpdatePhong(phong, out message);
            MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result) btnLamMoi_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaphong.Text)) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn xoá phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message;
                bool result = bllPhong.DeletePhong(txtMaphong.Text.Trim(), out message);
                MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result) btnLamMoi_Click(sender, e);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string truong = "";
            if (rbTktheoma.Checked) truong = "maphong";
            else if (rbTktheoten.Checked) truong = "tenphong";
            else if (rbTktheomaday.Checked) truong = "day";

            if (string.IsNullOrEmpty(truong))
            {
                MessageBox.Show("Vui lòng chọn trường tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = bllPhong.SearchPhong(truong, txtTimkiem.Text.Trim());
            dgvPhong.DataSource = list;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dgvPhong.DataSource = bllPhong.GetPhongTrong();
            else
                LoadPhongData();
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var phong = (Phong)dgvPhong.Rows[e.RowIndex].DataBoundItem;
                txtMaphong.Text = phong.Maphong;
                txtMaphong.Enabled = false;
                txtTenphong.Text = phong.Tenphong;
                txtSosvhientai.Text = phong.Sosv.ToString();
                txtSosvtoida.Text = phong.Sosvtoida.ToString();
                txtTinhtrang.Text = phong.Tinhtrang;
                cbLoaiphong.Text = phong.Loaiphong;
                cbXeploai.Text = phong.Xeploai;
                cbDay.Text = phong.Day;
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMaphong.Text) || string.IsNullOrWhiteSpace(txtTenphong.Text) ||
                string.IsNullOrWhiteSpace(txtSosvtoida.Text) || string.IsNullOrWhiteSpace(cbLoaiphong.Text) ||
                string.IsNullOrWhiteSpace(cbXeploai.Text) || string.IsNullOrWhiteSpace(cbDay.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void chatBotControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
