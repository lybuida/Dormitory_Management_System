namespace QuanLyKyTucXa_main
{
    partial class FrmBaoCaoLuongNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnVeBieuDo = new Guna.UI2.WinForms.Guna2Button();
            this.btnXuatExcel = new Guna.UI2.WinForms.Guna2Button();
            this.dgvBaoCaoLuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.maluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongcoban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phucap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thuongphat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaythanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart12 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart12)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 30;
            this.guna2CustomGradientPanel2.Controls.Add(this.dateTimePicker1);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnVeBieuDo);
            this.guna2CustomGradientPanel2.Controls.Add(this.btnXuatExcel);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(75, 118);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1444, 100);
            this.guna2CustomGradientPanel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = true;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.Location = new System.Drawing.Point(1031, 25);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2025, 5, 12, 20, 36, 7, 358);
            // 
            // btnVeBieuDo
            // 
            this.btnVeBieuDo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVeBieuDo.BorderRadius = 15;
            this.btnVeBieuDo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVeBieuDo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVeBieuDo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVeBieuDo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVeBieuDo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVeBieuDo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeBieuDo.ForeColor = System.Drawing.Color.White;
            this.btnVeBieuDo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnVeBieuDo.Location = new System.Drawing.Point(620, 25);
            this.btnVeBieuDo.Name = "btnVeBieuDo";
            this.btnVeBieuDo.Size = new System.Drawing.Size(180, 50);
            this.btnVeBieuDo.TabIndex = 6;
            this.btnVeBieuDo.Text = "Vẽ Biểu Đồ";
            this.btnVeBieuDo.Click += new System.EventHandler(this.btnVeBieuDo_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuatExcel.BorderRadius = 15;
            this.btnXuatExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatExcel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXuatExcel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.ForeColor = System.Drawing.Color.White;
            this.btnXuatExcel.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXuatExcel.Location = new System.Drawing.Point(3, 25);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(180, 50);
            this.btnXuatExcel.TabIndex = 5;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // dgvBaoCaoLuong
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoLuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBaoCaoLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvBaoCaoLuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBaoCaoLuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBaoCaoLuong.ColumnHeadersHeight = 50;
            this.dgvBaoCaoLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maluong,
            this.manv,
            this.tennv,
            this.thang,
            this.luongcoban,
            this.phucap,
            this.thuongphat,
            this.ngaythanhtoan,
            this.tongluong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCaoLuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBaoCaoLuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoLuong.Location = new System.Drawing.Point(75, 224);
            this.dgvBaoCaoLuong.Name = "dgvBaoCaoLuong";
            this.dgvBaoCaoLuong.RowHeadersVisible = false;
            this.dgvBaoCaoLuong.RowHeadersWidth = 51;
            this.dgvBaoCaoLuong.RowTemplate.Height = 24;
            this.dgvBaoCaoLuong.Size = new System.Drawing.Size(614, 550);
            this.dgvBaoCaoLuong.TabIndex = 2;
            this.dgvBaoCaoLuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoLuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBaoCaoLuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoLuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoLuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBaoCaoLuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoLuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBaoCaoLuong.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvBaoCaoLuong.ThemeStyle.ReadOnly = false;
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBaoCaoLuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // maluong
            // 
            this.maluong.DataPropertyName = "maluong";
            this.maluong.HeaderText = "Mã Lương";
            this.maluong.MinimumWidth = 6;
            this.maluong.Name = "maluong";
            this.maluong.Width = 72;
            // 
            // manv
            // 
            this.manv.DataPropertyName = "manv";
            this.manv.HeaderText = "Mã Nhân Viên";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.Width = 74;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "tennv";
            this.tennv.HeaderText = "Tên Nhân Viên";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.Width = 73;
            // 
            // thang
            // 
            this.thang.DataPropertyName = "thang";
            this.thang.HeaderText = "Tháng";
            this.thang.MinimumWidth = 6;
            this.thang.Name = "thang";
            this.thang.Width = 73;
            // 
            // luongcoban
            // 
            this.luongcoban.DataPropertyName = "luongcoban";
            this.luongcoban.HeaderText = "Lương Cơ Bản";
            this.luongcoban.MinimumWidth = 6;
            this.luongcoban.Name = "luongcoban";
            this.luongcoban.Width = 74;
            // 
            // phucap
            // 
            this.phucap.DataPropertyName = "phucap";
            this.phucap.HeaderText = "Phụ Cấp";
            this.phucap.MinimumWidth = 6;
            this.phucap.Name = "phucap";
            this.phucap.Width = 72;
            // 
            // thuongphat
            // 
            this.thuongphat.DataPropertyName = "thuongphat";
            this.thuongphat.HeaderText = "Thưởng Phạt";
            this.thuongphat.MinimumWidth = 6;
            this.thuongphat.Name = "thuongphat";
            this.thuongphat.Width = 73;
            // 
            // ngaythanhtoan
            // 
            this.ngaythanhtoan.DataPropertyName = "ngaythanhtoan";
            this.ngaythanhtoan.HeaderText = "Ngày Thanh Toán";
            this.ngaythanhtoan.MinimumWidth = 6;
            this.ngaythanhtoan.Name = "ngaythanhtoan";
            this.ngaythanhtoan.Width = 74;
            // 
            // tongluong
            // 
            this.tongluong.DataPropertyName = "tongluong";
            this.tongluong.HeaderText = "Tổng Lương";
            this.tongluong.MinimumWidth = 6;
            this.tongluong.Name = "tongluong";
            this.tongluong.Width = 73;
            // 
            // chart12
            // 
            chartArea1.Name = "ChartArea1";
            this.chart12.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart12.Legends.Add(legend1);
            this.chart12.Location = new System.Drawing.Point(695, 224);
            this.chart12.Name = "chart12";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Tổng lương";
            this.chart12.Series.Add(series1);
            this.chart12.Size = new System.Drawing.Size(824, 550);
            this.chart12.TabIndex = 3;
            this.chart12.Text = "chart1";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(75, 12);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1444, 100);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(156)))), ((int)(((byte)(184)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(433, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO LƯƠNG NHÂN VIÊN";
            // 
            // FrmBaoCaoLuongNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1566, 794);
            this.Controls.Add(this.chart12);
            this.Controls.Add(this.dgvBaoCaoLuong);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FrmBaoCaoLuongNhanVien";
            this.Text = "Báo cáo lương nhân viên";
            this.Load += new System.EventHandler(this.FrmBaoCaoLuongNhanVien_Load);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart12)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button btnVeBieuDo;
        private Guna.UI2.WinForms.Guna2Button btnXuatExcel;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBaoCaoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn luongcoban;
        private System.Windows.Forms.DataGridViewTextBoxColumn phucap;
        private System.Windows.Forms.DataGridViewTextBoxColumn thuongphat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaythanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongluong;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart12;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
    }
}