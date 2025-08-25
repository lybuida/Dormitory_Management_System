using QuanLy_BLL;
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

namespace QuanLyKyTucXa_main
{
    public delegate void SendMessage(String value);
    public partial class FrmQuanLyThietBi : Form
    {
        public FrmQuanLyThietBi()
        {
            InitializeComponent();
        }

        QuanLy_BLL.BLL_ThietBi bll = new QuanLy_BLL.BLL_ThietBi();
        QuanLy_BLL.BLL_Phong bllPhong = new QuanLy_BLL.BLL_Phong();

        //  public string maphongnhan = "";

        private void FrmQuanLyThietBi_Load(object sender, EventArgs e)
        {
            dgvThietbi.DataSource = bll.GetAllThietBi();
            dgvThietbi.ReadOnly = true;
            LoadPhongData();
            //txtMaphong.Text = maphongnhan;
            // dgvThietbi.DataSource = bll.GetThietBiTheoPhong(txtMaphong.Text);
        }

        private void LoadPhongData()
        {
            var phongList = bllPhong.GetAllPhong();
            cbMaphong.DataSource = phongList;
            cbMaphong.ValueMember = "maphong";
            cbMaphong.SelectedIndex = -1;
        }

        private void ClearBox()
        {
            txtMathietbi.Enabled = true;
            txtMathietbi.Clear();
            txtMathietbi.Enabled = false;

            cbMaphong.SelectedIndex = -1;
            cbMaphong.Enabled = true;

            txtTenthietbi.Clear();

            numericUpDownSoluong.Value = 0;
            txtTinhtrang.Clear();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            FrmQuanLyThietBi_Load(sender, e);
            ClearBox();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbMaphong.Text) || string.IsNullOrWhiteSpace(txtTenthietbi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (numericUpDownSoluong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ThietBi tb = new ThietBi(
                cbMaphong.Text.Trim(),
                txtTenthietbi.Text.Trim(),
                (int)numericUpDownSoluong.Value,
                txtTinhtrang.Text.Trim()
            );

            string error;
            if (!bll.InsertThietBi(tb, out error))
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thêm thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }


        private void dgvThietbi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = e.RowIndex;
            if (vitri >= 0)
            {
                txtMathietbi.Text = dgvThietbi.Rows[vitri].Cells["mathietbi"].Value.ToString();
                cbMaphong.Text = dgvThietbi.Rows[vitri].Cells["maphong"].Value.ToString();
                cbMaphong.Enabled = false;
                txtTenthietbi.Text = dgvThietbi.Rows[vitri].Cells["tenthietbi"].Value.ToString();
                // txtTenthietbi.Enabled = false;
                numericUpDownSoluong.Value = Decimal.Parse(dgvThietbi.Rows[vitri].Cells["soluong"].Value.ToString());
                txtTinhtrang.Text = dgvThietbi.Rows[vitri].Cells["tinhtrang"].Value.ToString();
            }
        }

        private void btnCapnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbMaphong.Text) || string.IsNullOrEmpty(txtTenthietbi.Text))
            {
                MessageBox.Show("Vui lòng chọn thiết bị cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownSoluong.Value <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ThietBi tb = new ThietBi(
                int.Parse(txtMathietbi.Text),
                cbMaphong.Text.Trim(),
                txtTenthietbi.Text.Trim(),
                (int)numericUpDownSoluong.Value,
                txtTinhtrang.Text.Trim()
            );

            string error;
            if (!bll.UpdateThietBi(tb, out error))
            {
                MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Cập nhật thiết bị thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnLamMoi_Click(sender, e);
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbMaphong.Text == "" || txtTenthietbi.Text == "")
            {
                MessageBox.Show("Vui lòng chọn 1 dòng để xóa",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                bll.DeleteThietBi(txtMathietbi.Text);
                btnLamMoi_Click(sender, e);
            }
            else if (dlr == DialogResult.No)
                return;
        }

        //Kéo giao diện
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
