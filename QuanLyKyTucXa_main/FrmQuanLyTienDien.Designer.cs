using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyTienDien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheott = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLammoi = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCapnhap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cbTrangthai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dtpNgaylap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbMaphong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtChisomoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTiendien = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXuatPDF = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMahoadon = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.dgvTiendien = new System.Windows.Forms.DataGridView();
            this.mahoadon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisocu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chisomoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sodientieuthu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).BeginInit();
            this.SuspendLayout();
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(19, 19);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(181, 23);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã phòng";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            // 
            // rbTktheott
            // 
            this.rbTktheott.AutoSize = true;
            this.rbTktheott.Location = new System.Drawing.Point(19, 42);
            this.rbTktheott.Name = "rbTktheott";
            this.rbTktheott.Size = new System.Drawing.Size(178, 23);
            this.rbTktheott.TabIndex = 1;
            this.rbTktheott.TabStop = true;
            this.rbTktheott.Text = "Tìm kiếm theo trạng thái";
            this.rbTktheott.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTktheott);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(706, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 155);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimkiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTimkiem.ForeColor = System.Drawing.Color.White;
            this.btnTimkiem.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_search_100;
            this.btnTimkiem.ImageSize = new System.Drawing.Size(30, 30);
            this.btnTimkiem.Location = new System.Drawing.Point(179, 98);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnTimkiem.Size = new System.Drawing.Size(36, 36);
            this.btnTimkiem.TabIndex = 46;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderRadius = 18;
            this.txtTimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimkiem.DefaultText = "";
            this.txtTimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTimkiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimkiem.Location = new System.Drawing.Point(12, 98);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(161, 36);
            this.txtTimkiem.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(323, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Trạng thái";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(16, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Ngày lập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(323, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Tiền điện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(323, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 37;
            this.label4.Text = "Chỉ số mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Mã phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnCapnhap);
            this.panel1.Location = new System.Drawing.Point(50, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 69);
            this.panel1.TabIndex = 44;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.BackgroundImage = global::QuanLyKyTucXa_main.Properties.Resources.icons8_plus_100__1_2;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(31, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnThem.Size = new System.Drawing.Size(63, 59);
            this.btnThem.TabIndex = 46;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QuanLyKyTucXa_main.Properties.Resources.icons8_trash_can_100;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(309, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnXoa.Size = new System.Drawing.Size(63, 59);
            this.btnXoa.TabIndex = 48;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.BackgroundImage = global::QuanLyKyTucXa_main.Properties.Resources.icons8_synchronize_100__1_;
            this.btnLammoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLammoi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLammoi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLammoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLammoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLammoi.FillColor = System.Drawing.Color.Transparent;
            this.btnLammoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLammoi.ForeColor = System.Drawing.Color.White;
            this.btnLammoi.Location = new System.Drawing.Point(449, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLammoi.Size = new System.Drawing.Size(63, 59);
            this.btnLammoi.TabIndex = 48;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // btnCapnhap
            // 
            this.btnCapnhap.BackColor = System.Drawing.Color.White;
            this.btnCapnhap.BackgroundImage = global::QuanLyKyTucXa_main.Properties.Resources.icons8_done_100;
            this.btnCapnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCapnhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapnhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapnhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapnhap.FillColor = System.Drawing.Color.Transparent;
            this.btnCapnhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapnhap.ForeColor = System.Drawing.Color.White;
            this.btnCapnhap.Location = new System.Drawing.Point(171, 3);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCapnhap.Size = new System.Drawing.Size(63, 59);
            this.btnCapnhap.TabIndex = 47;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cbTrangthai
            // 
            this.cbTrangthai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangthai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbTrangthai.BorderRadius = 18;
            this.cbTrangthai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangthai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangthai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangthai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangthai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTrangthai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbTrangthai.ItemHeight = 30;
            this.cbTrangthai.Location = new System.Drawing.Point(416, 141);
            this.cbTrangthai.Name = "cbTrangthai";
            this.cbTrangthai.Size = new System.Drawing.Size(161, 36);
            this.cbTrangthai.TabIndex = 49;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // dtpNgaylap
            // 
            this.dtpNgaylap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dtpNgaylap.BorderRadius = 18;
            this.dtpNgaylap.BorderThickness = 1;
            this.dtpNgaylap.Checked = true;
            this.dtpNgaylap.FillColor = System.Drawing.Color.White;
            this.dtpNgaylap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaylap.Location = new System.Drawing.Point(106, 141);
            this.dtpNgaylap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgaylap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgaylap.Name = "dtpNgaylap";
            this.dtpNgaylap.Size = new System.Drawing.Size(161, 36);
            this.dtpNgaylap.TabIndex = 50;
            this.dtpNgaylap.Value = new System.DateTime(2025, 4, 30, 16, 14, 33, 152);
            // 
            // cbMaphong
            // 
            this.cbMaphong.BackColor = System.Drawing.Color.Transparent;
            this.cbMaphong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbMaphong.BorderRadius = 18;
            this.cbMaphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaphong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbMaphong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbMaphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbMaphong.ItemHeight = 30;
            this.cbMaphong.Location = new System.Drawing.Point(106, 74);
            this.cbMaphong.Name = "cbMaphong";
            this.cbMaphong.Size = new System.Drawing.Size(161, 36);
            this.cbMaphong.TabIndex = 51;
            // 
            // txtChisomoi
            // 
            this.txtChisomoi.BorderRadius = 18;
            this.txtChisomoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChisomoi.DefaultText = "";
            this.txtChisomoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChisomoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChisomoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChisomoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChisomoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChisomoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtChisomoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtChisomoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChisomoi.Location = new System.Drawing.Point(416, 10);
            this.txtChisomoi.Name = "txtChisomoi";
            this.txtChisomoi.PlaceholderText = "";
            this.txtChisomoi.SelectedText = "";
            this.txtChisomoi.Size = new System.Drawing.Size(161, 36);
            this.txtChisomoi.TabIndex = 52;
            // 
            // txtTiendien
            // 
            this.txtTiendien.BorderRadius = 18;
            this.txtTiendien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTiendien.DefaultText = "";
            this.txtTiendien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTiendien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTiendien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiendien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTiendien.Enabled = false;
            this.txtTiendien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiendien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTiendien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTiendien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTiendien.Location = new System.Drawing.Point(416, 74);
            this.txtTiendien.Name = "txtTiendien";
            this.txtTiendien.PlaceholderText = "3.000đ/số";
            this.txtTiendien.SelectedText = "";
            this.txtTiendien.Size = new System.Drawing.Size(161, 36);
            this.txtTiendien.TabIndex = 53;
            // 
            // btnXuatPDF
            // 
            this.btnXuatPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatPDF.BorderRadius = 18;
            this.btnXuatPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXuatPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXuatPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXuatPDF.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.btnXuatPDF.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnXuatPDF.ForeColor = System.Drawing.Color.White;
            this.btnXuatPDF.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_bill_100;
            this.btnXuatPDF.ImageSize = new System.Drawing.Size(30, 30);
            this.btnXuatPDF.Location = new System.Drawing.Point(706, 465);
            this.btnXuatPDF.Name = "btnXuatPDF";
            this.btnXuatPDF.Size = new System.Drawing.Size(161, 60);
            this.btnXuatPDF.TabIndex = 54;
            this.btnXuatPDF.Text = "Xuất hóa đơn";
            this.btnXuatPDF.Click += new System.EventHandler(this.btnXuatPDF_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.dgvTiendien;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMahoadon);
            this.panel2.Controls.Add(this.cbMaphong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTiendien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtChisomoi);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpNgaylap);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbTrangthai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(32, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 193);
            this.panel2.TabIndex = 55;
            // 
            // txtMahoadon
            // 
            this.txtMahoadon.BorderRadius = 18;
            this.txtMahoadon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMahoadon.DefaultText = "";
            this.txtMahoadon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMahoadon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMahoadon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMahoadon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMahoadon.Enabled = false;
            this.txtMahoadon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMahoadon.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMahoadon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMahoadon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMahoadon.Location = new System.Drawing.Point(106, 10);
            this.txtMahoadon.Name = "txtMahoadon";
            this.txtMahoadon.PlaceholderText = "";
            this.txtMahoadon.SelectedText = "";
            this.txtMahoadon.Size = new System.Drawing.Size(161, 36);
            this.txtMahoadon.TabIndex = 54;
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThanhtoan.BorderRadius = 18;
            this.btnThanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhtoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.btnThanhtoan.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnThanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnThanhtoan.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_pay_100;
            this.btnThanhtoan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThanhtoan.Location = new System.Drawing.Point(706, 350);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.Size = new System.Drawing.Size(161, 60);
            this.btnThanhtoan.TabIndex = 45;
            this.btnThanhtoan.Text = "Thanh toán";
            this.btnThanhtoan.Click += new System.EventHandler(this.btnThanhtoan_Click);
            // 
            // dgvTiendien
            // 
            this.dgvTiendien.AllowUserToResizeRows = false;
            this.dgvTiendien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTiendien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiendien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTiendien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTiendien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTiendien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTiendien.ColumnHeadersHeight = 62;
            this.dgvTiendien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahoadon,
            this.maphong,
            this.ngaylap,
            this.chisocu,
            this.chisomoi,
            this.sodientieuthu,
            this.tongtien,
            this.trangthai});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTiendien.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTiendien.EnableHeadersVisualStyles = false;
            this.dgvTiendien.Location = new System.Drawing.Point(50, 339);
            this.dgvTiendien.Name = "dgvTiendien";
            this.dgvTiendien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTiendien.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTiendien.RowHeadersVisible = false;
            this.dgvTiendien.RowHeadersWidth = 62;
            this.dgvTiendien.RowTemplate.Height = 28;
            this.dgvTiendien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiendien.Size = new System.Drawing.Size(559, 230);
            this.dgvTiendien.TabIndex = 63;
            this.dgvTiendien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiendien_CellClick);
            // 
            // mahoadon
            // 
            this.mahoadon.DataPropertyName = "mahoadon";
            this.mahoadon.HeaderText = "Mã hóa đơn";
            this.mahoadon.MinimumWidth = 8;
            this.mahoadon.Name = "mahoadon";
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 8;
            this.maphong.Name = "maphong";
            // 
            // ngaylap
            // 
            this.ngaylap.DataPropertyName = "ngaylap";
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.MinimumWidth = 8;
            this.ngaylap.Name = "ngaylap";
            // 
            // chisocu
            // 
            this.chisocu.DataPropertyName = "chisocu";
            this.chisocu.HeaderText = "Chỉ số cũ";
            this.chisocu.MinimumWidth = 8;
            this.chisocu.Name = "chisocu";
            // 
            // chisomoi
            // 
            this.chisomoi.DataPropertyName = "chisomoi";
            this.chisomoi.HeaderText = "Chỉ số mới";
            this.chisomoi.MinimumWidth = 8;
            this.chisomoi.Name = "chisomoi";
            // 
            // sodientieuthu
            // 
            this.sodientieuthu.DataPropertyName = "sodientieuthu";
            this.sodientieuthu.HeaderText = "Lượng điện tiêu thụ";
            this.sodientieuthu.Name = "sodientieuthu";
            // 
            // tongtien
            // 
            this.tongtien.DataPropertyName = "tongtien";
            this.tongtien.HeaderText = "Tổng tiền";
            this.tongtien.Name = "tongtien";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // FrmQuanLyTienDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(236)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(952, 581);
            this.Controls.Add(this.dgvTiendien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXuatPDF);
            this.Controls.Add(this.btnThanhtoan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQuanLyTienDien";
            this.Text = "Quản Lý Tiền Điện";
            this.Load += new System.EventHandler(this.FrmQuanLyTienDien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiendien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbTktheoma;
        private System.Windows.Forms.RadioButton rbTktheott;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnCapnhap;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnLammoi;
        private Guna.UI2.WinForms.Guna2Button btnThanhtoan;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimkiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbTrangthai;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgaylap;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaphong;
        private Guna.UI2.WinForms.Guna2TextBox txtChisomoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTiendien;
        private Guna.UI2.WinForms.Guna2Button btnXuatPDF;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMahoadon;
        private DataGridView dgvTiendien;
        private DataGridViewTextBoxColumn mahoadon;
        private DataGridViewTextBoxColumn maphong;
        private DataGridViewTextBoxColumn ngaylap;
        private DataGridViewTextBoxColumn chisocu;
        private DataGridViewTextBoxColumn chisomoi;
        private DataGridViewTextBoxColumn sodientieuthu;
        private DataGridViewTextBoxColumn tongtien;
        private DataGridViewTextBoxColumn trangthai;
    }
}