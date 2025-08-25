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
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyKyTucXa_main
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }
        ThongKeTienDien_BL thongkedBL = new ThongKeTienDien_BL();
        ThongKeLuongNuoc_BL thongkenBL = new ThongKeLuongNuoc_BL();
        ThongKe_BL thongKeHeThongBL = new ThongKe_BL();

        private void FrmHome_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";

            var thongKe = thongKeHeThongBL.LayThongKe();
            lblSLsinhvien.Text = thongKe.SoLuongSinhVien.ToString();
            lblSLphong.Text = thongKe.SoLuongPhong.ToString();
            lblSLThietB.Text = thongKe.SoLuongThietBi.ToString();

        }

        private void btnThongKeDien_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(dateTimePicker1.Text);
            fillchart_thang(nam);
        }
        private void fillchart_thang(int nam)
        {
            // Xóa dữ liệu cũ
            chart1.Series.Clear();

            // Thiết lập trục
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Lượng tiêu thụ";
            chart1.ChartAreas["ChartArea1"].AxisX.Maximum = 12;
            chart1.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;

            // --- Series 1: Lượng điện ---
            Series dienSeries = new Series("Lượng điện");
            dienSeries.ChartType = SeriesChartType.Column;
            dienSeries.Color = Color.DeepSkyBlue;

            var dsDien = thongkedBL.LayLuongDienCacThang(nam);
            foreach (var item in dsDien)
            {
                dienSeries.Points.AddXY(item.Thang, item.SoDienTieuThu);
            }

            chart1.Series.Add(dienSeries);

            // --- Series 2: Lượng nước ---
            Series nuocSeries = new Series("Lượng nước");
            nuocSeries.ChartType = SeriesChartType.Column;
            nuocSeries.Color = Color.LightGreen;

            var dsNuoc = thongkenBL.LayLuongNuocCacThang(nam);
            foreach (var item in dsNuoc)
            {
                nuocSeries.Points.AddXY(item.Thang, item.SoKhoiTieuThu);
            }

            chart1.Series.Add(nuocSeries);
        }

    }
}
