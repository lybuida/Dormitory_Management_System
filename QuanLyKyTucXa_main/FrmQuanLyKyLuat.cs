using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLy_BLL;
using TransferObject;
using static System.Net.Mime.MediaTypeNames;


namespace QuanLyKyTucXa_main
{
    public partial class FrmQuanLyKyLuat : Form
    {
        public FrmQuanLyKyLuat()
        {
            InitializeComponent();
        }


        BLL_KyLuat bll = new QuanLy_BLL.BLL_KyLuat();
        QuanLySinhVien_BL bllSv = new QuanLy_BLL.QuanLySinhVien_BL();

        private void FrmQuanLyKyLuat_Load(object sender, EventArgs e)
        {
            LoadMasv();
            dgvKyluat.DataSource = bll.GetAllKyLuat();
            dgvKyluat.ReadOnly = true;
        }

        private void LoadMasv()
        {
            cbMasv.DataSource = bllSv.SelectMaSinhVien();
            cbMasv.DisplayMember = "masv";
            cbMasv.SelectedIndex = -1;
        }
        private void ClearBox()
        {
            txtMakyluat.Enabled = true;
            txtMakyluat.Clear();
            txtMakyluat.Enabled = false;

            cbMasv.SelectedIndex = -1;
            txtKyluat.Clear();
            dtpNgaykyluat.Value = DateTime.Now;
            txtTienphat.Clear();
            rbMasv.Checked = false;
            rbKyluat.Checked = false;
            txtTimkiem.Clear();
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            FrmQuanLyKyLuat_Load(sender, e);
            ClearBox();
        }

        private bool ValidateInput()
        {
            if (cbMasv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtKyluat.Text))
            {
                MessageBox.Show("Vui lòng nhập nội dung kỷ luật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!float.TryParse(txtTienphat.Text, out float tienphat) || tienphat < 0)
            {
                MessageBox.Show("Tiền phạt phải là số dương", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            KyLuat kl = new KyLuat(cbMasv.Text, txtKyluat.Text, dtpNgaykyluat.Value, float.Parse(txtTienphat.Text));
            bool result = bll.InsertKyLuat(kl);

            if (result)
                MessageBox.Show("Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnLammoi_Click(sender, e);
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMakyluat.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInput()) return;

            KyLuat kl = new KyLuat(int.Parse(txtMakyluat.Text), cbMasv.Text, txtKyluat.Text, dtpNgaykyluat.Value, float.Parse(txtTienphat.Text));
            bool result = bll.UpdateKyLuat(kl);

            if (result)
                MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Sửa thất bại hoặc không tồn tại mã kỷ luật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnLammoi_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMakyluat.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                bool result = bll.DeleteKyLuat(int.Parse(txtMakyluat.Text));
                if (result)
                    MessageBox.Show("Đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Xóa thất bại hoặc không tồn tại mã kỷ luật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnLammoi_Click(sender, e);
            }
        }


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (rbMasv.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sinh viên để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvKyluat.DataSource = bll.SearchKyLuat(txtTimkiem.Text, "masv");
            }
            else if (rbKyluat.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
                {
                    MessageBox.Show("Vui lòng nhập nội dung kỷ luật để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                dgvKyluat.DataSource = bll.SearchKyLuat(txtTimkiem.Text, "kyluat");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn trường tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (string.IsNullOrWhiteSpace(txtTimkiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập trường tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dgvKyluat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dgvKyluat.Rows.Count)
            {
                txtMakyluat.Text = dgvKyluat.Rows[index].Cells[0].Value?.ToString();
                cbMasv.Text = dgvKyluat.Rows[index].Cells[1].Value?.ToString();
                txtKyluat.Text = dgvKyluat.Rows[index].Cells[2].Value?.ToString();
                dtpNgaykyluat.Text = dgvKyluat.Rows[index].Cells[3].Value.ToString();
                txtTienphat.Text = dgvKyluat.Rows[index].Cells[4].Value?.ToString();
            }
        }

        private void rbMasv_CheckedChanged(object sender, EventArgs e)
        {
            cbMasv.Enabled = rbMasv.Checked;
            txtKyluat.Enabled = !rbMasv.Checked;
            txtMakyluat.Enabled = false;
            dtpNgaykyluat.Enabled = false;
            txtTienphat.Enabled = false;
        }

        private void rbKyluat_CheckedChanged(object sender, EventArgs e)
        {
            txtKyluat.Enabled = rbKyluat.Checked;
            cbMasv.Enabled = !rbKyluat.Checked;
            txtMakyluat.Enabled = false;
            dtpNgaykyluat.Enabled = false;
            txtTienphat.Enabled = false;
        }
    }
}

