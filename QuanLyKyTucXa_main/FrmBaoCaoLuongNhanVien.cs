using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Guna.UI2.WinForms;
using Microsoft.Office.Interop.Excel;
using QuanLy_BLL;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;

namespace QuanLyKyTucXa_main
{
    public partial class FrmBaoCaoLuongNhanVien : Form
    {
        ThanhToanLuongNhanVien_BL bll = new ThanhToanLuongNhanVien_BL();

        public FrmBaoCaoLuongNhanVien()
        {
            InitializeComponent();
        }

        private void FrmBaoCaoLuongNhanVien_Load(object sender, EventArgs e)
        {
            dgvBaoCaoLuong.DataSource = bll.LayDanhSachLuongNhanVien();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
        }

        private void btnVeBieuDo_Click(object sender, EventArgs e)
        {
            int nam = dateTimePicker1.Value.Year;
            int thang = dateTimePicker1.Value.Month;
            FillChartLuong(thang, nam);
            
        }
        private void FillChartLuong(int thang, int nam)
        {
            chart12.Series.Clear();

            chart12.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart12.ChartAreas["ChartArea1"].AxisY.Title = "Tổng lương chi (VND)";
            chart12.ChartAreas["ChartArea1"].AxisX.Minimum = 1;
            chart12.ChartAreas["ChartArea1"].AxisX.Maximum = 12;
            chart12.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart12.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;

            Series luongSeries = new Series("Tổng lương");
            luongSeries.ChartType = SeriesChartType.Column;
            luongSeries.Color = Color.Orange;

            // Gọi BLL để lấy dữ liệu tổng lương từng tháng
            var dsLuong = bll.GetLuongThangNam(thang, nam);

            foreach (var item in dsLuong)
            {
                luongSeries.Points.AddXY(item.thang, item.tongluong);
            }

            chart12.Series.Add(luongSeries);
        }


        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu báo cáo Excel";
                saveFileDialog.FileName = "BaoCaoLuongNhanVien_" + DateTime.Now.ToString("yyyyMMdd") + ".xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                    Workbook workbook = excel.Workbooks.Add(Type.Missing);
                    Worksheet worksheet = (Worksheet)workbook.ActiveSheet;

                    // Tiêu đề báo cáo
                    excel.Cells[1, 1] = "BÁO CÁO LƯƠNG NHÂN VIÊN";
                    Range titleRange = worksheet.Range["A1", "I1"];
                    titleRange.Merge();
                    titleRange.Font.Bold = true;
                    titleRange.Font.Size = 16;
                    titleRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Thời gian xuất báo cáo
                    excel.Cells[2, 1] = "Ngày xuất: " + DateTime.Now.ToString("dd/MM/yyyy");
                    Range dateRange = worksheet.Range["A2", "I2"];
                    dateRange.Merge();
                    dateRange.Font.Italic = true;
                    dateRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    // Tiêu đề cột
                    for (int i = 0; i < dgvBaoCaoLuong.Columns.Count; i++)
                    {
                        excel.Cells[4, i + 1] = dgvBaoCaoLuong.Columns[i].HeaderText;
                    }

                    // Dữ liệu
                    for (int i = 0; i < dgvBaoCaoLuong.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgvBaoCaoLuong.Columns.Count; j++)
                        {
                            if (dgvBaoCaoLuong.Rows[i].Cells[j].Value != null)
                            {
                                excel.Cells[i + 5, j + 1] = dgvBaoCaoLuong.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                    }

                    // Định dạng
                    Range headerRange = worksheet.Range["A4", "I4"];
                    headerRange.Font.Bold = true;
                    headerRange.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightGray);

                    Range dataRange = worksheet.Range["A5", "I" + (dgvBaoCaoLuong.Rows.Count + 4)];
                    dataRange.Borders.LineStyle = XlLineStyle.xlContinuous;

                    // Tự động điều chỉnh độ rộng cột
                    worksheet.Columns.AutoFit();

                    // Lưu file
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excel.Quit();

                    MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}