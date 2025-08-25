using System.Drawing;
using System.Windows.Forms;

namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyPhong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosvtoida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xeploai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLammoi = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCapnhap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTktheomaday = new System.Windows.Forms.RadioButton();
            this.btnTimkiem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.txtTimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbTktheoma = new System.Windows.Forms.RadioButton();
            this.rbTktheoten = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbXeploai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbLoaiphong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTinhtrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSosvhientai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSosvtoida = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaphong = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBox1 = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPhong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPhong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhong.ColumnHeadersHeight = 62;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maphong,
            this.tenphong,
            this.sosv,
            this.sosvtoida,
            this.tinhtrang,
            this.loaiphong,
            this.xeploai,
            this.day});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhong.EnableHeadersVisualStyles = false;
            this.dgvPhong.Location = new System.Drawing.Point(34, 409);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhong.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 62;
            this.dgvPhong.RowTemplate.Height = 28;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(1019, 206);
            this.dgvPhong.TabIndex = 42;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 8;
            this.maphong.Name = "maphong";
            // 
            // tenphong
            // 
            this.tenphong.DataPropertyName = "tenphong";
            this.tenphong.HeaderText = "Tên phòng";
            this.tenphong.MinimumWidth = 8;
            this.tenphong.Name = "tenphong";
            // 
            // sosv
            // 
            this.sosv.DataPropertyName = "sosv";
            this.sosv.HeaderText = "Số sinh viên hiện tại";
            this.sosv.MinimumWidth = 8;
            this.sosv.Name = "sosv";
            // 
            // sosvtoida
            // 
            this.sosvtoida.DataPropertyName = "sosvtoida";
            this.sosvtoida.HeaderText = "Số sinh viên tối đa";
            this.sosvtoida.MinimumWidth = 8;
            this.sosvtoida.Name = "sosvtoida";
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 8;
            this.tinhtrang.Name = "tinhtrang";
            // 
            // loaiphong
            // 
            this.loaiphong.DataPropertyName = "loaiphong";
            this.loaiphong.HeaderText = "Loại phòng";
            this.loaiphong.MinimumWidth = 8;
            this.loaiphong.Name = "loaiphong";
            // 
            // xeploai
            // 
            this.xeploai.DataPropertyName = "xeploai";
            this.xeploai.HeaderText = "Xếp loại";
            this.xeploai.MinimumWidth = 8;
            this.xeploai.Name = "xeploai";
            // 
            // day
            // 
            this.day.DataPropertyName = "day";
            this.day.HeaderText = "Dãy";
            this.day.MinimumWidth = 8;
            this.day.Name = "day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(401, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Dãy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(401, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "Xếp loại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(401, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Tình trạng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(401, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "Loại phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(16, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Số sinh viên tối đa";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(16, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 19);
            this.label7.TabIndex = 22;
            this.label7.Text = "Số sinh viên hiện tại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(16, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã phòng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnLammoi);
            this.panel1.Controls.Add(this.btnCapnhap);
            this.panel1.Location = new System.Drawing.Point(34, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 69);
            this.panel1.TabIndex = 52;
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
            this.btnThem.Location = new System.Drawing.Point(26, 3);
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
            this.btnXoa.Location = new System.Drawing.Point(395, 3);
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
            this.btnLammoi.Location = new System.Drawing.Point(564, 3);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLammoi.Size = new System.Drawing.Size(63, 59);
            this.btnLammoi.TabIndex = 48;
            this.btnLammoi.Click += new System.EventHandler(this.btnLamMoi_Click);
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
            this.btnCapnhap.Location = new System.Drawing.Point(203, 3);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCapnhap.Size = new System.Drawing.Size(63, 59);
            this.btnCapnhap.TabIndex = 47;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbTktheomaday);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.rbTktheoma);
            this.groupBox1.Controls.Add(this.rbTktheoten);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.groupBox1.Location = new System.Drawing.Point(806, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 230);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTktheomaday
            // 
            this.rbTktheomaday.AutoSize = true;
            this.rbTktheomaday.Location = new System.Drawing.Point(19, 86);
            this.rbTktheomaday.Name = "rbTktheomaday";
            this.rbTktheomaday.Size = new System.Drawing.Size(163, 23);
            this.rbTktheomaday.TabIndex = 48;
            this.rbTktheomaday.TabStop = true;
            this.rbTktheomaday.Text = "Tìm kiếm theo mã dãy";
            this.rbTktheomaday.UseVisualStyleBackColor = true;
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
            this.btnTimkiem.Location = new System.Drawing.Point(184, 146);
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
            this.txtTimkiem.Location = new System.Drawing.Point(17, 146);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.PlaceholderText = "";
            this.txtTimkiem.SelectedText = "";
            this.txtTimkiem.Size = new System.Drawing.Size(161, 36);
            this.txtTimkiem.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Nhập thông tin tìm kiếm:";
            // 
            // rbTktheoma
            // 
            this.rbTktheoma.AutoSize = true;
            this.rbTktheoma.Location = new System.Drawing.Point(19, 28);
            this.rbTktheoma.Name = "rbTktheoma";
            this.rbTktheoma.Size = new System.Drawing.Size(181, 23);
            this.rbTktheoma.TabIndex = 0;
            this.rbTktheoma.TabStop = true;
            this.rbTktheoma.Text = "Tìm kiếm theo mã phòng";
            this.rbTktheoma.UseVisualStyleBackColor = true;
            // 
            // rbTktheoten
            // 
            this.rbTktheoten.AutoSize = true;
            this.rbTktheoten.Location = new System.Drawing.Point(19, 57);
            this.rbTktheoten.Name = "rbTktheoten";
            this.rbTktheoten.Size = new System.Drawing.Size(182, 23);
            this.rbTktheoten.TabIndex = 1;
            this.rbTktheoten.TabStop = true;
            this.rbTktheoten.Text = "Tìm kiếm theo tên phòng";
            this.rbTktheoten.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbDay);
            this.panel2.Controls.Add(this.cbXeploai);
            this.panel2.Controls.Add(this.cbLoaiphong);
            this.panel2.Controls.Add(this.txtTinhtrang);
            this.panel2.Controls.Add(this.txtSosvhientai);
            this.panel2.Controls.Add(this.txtSosvtoida);
            this.panel2.Controls.Add(this.txtTenphong);
            this.panel2.Controls.Add(this.txtMaphong);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(23, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(723, 280);
            this.panel2.TabIndex = 54;
            // 
            // cbDay
            // 
            this.cbDay.BackColor = System.Drawing.Color.Transparent;
            this.cbDay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbDay.BorderRadius = 18;
            this.cbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbDay.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbDay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbDay.ItemHeight = 30;
            this.cbDay.Location = new System.Drawing.Point(507, 223);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(161, 36);
            this.cbDay.TabIndex = 63;
            // 
            // cbXeploai
            // 
            this.cbXeploai.BackColor = System.Drawing.Color.Transparent;
            this.cbXeploai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbXeploai.BorderRadius = 18;
            this.cbXeploai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbXeploai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXeploai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbXeploai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbXeploai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbXeploai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbXeploai.ItemHeight = 30;
            this.cbXeploai.Location = new System.Drawing.Point(507, 146);
            this.cbXeploai.Name = "cbXeploai";
            this.cbXeploai.Size = new System.Drawing.Size(161, 36);
            this.cbXeploai.TabIndex = 62;
            // 
            // cbLoaiphong
            // 
            this.cbLoaiphong.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiphong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cbLoaiphong.BorderRadius = 18;
            this.cbLoaiphong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiphong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiphong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiphong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbLoaiphong.ItemHeight = 30;
            this.cbLoaiphong.Location = new System.Drawing.Point(507, 73);
            this.cbLoaiphong.Name = "cbLoaiphong";
            this.cbLoaiphong.Size = new System.Drawing.Size(161, 36);
            this.cbLoaiphong.TabIndex = 61;
            // 
            // txtTinhtrang
            // 
            this.txtTinhtrang.BorderRadius = 18;
            this.txtTinhtrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhtrang.DefaultText = "";
            this.txtTinhtrang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTinhtrang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTinhtrang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhtrang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTinhtrang.Enabled = false;
            this.txtTinhtrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTinhtrang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTinhtrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Location = new System.Drawing.Point(507, 6);
            this.txtTinhtrang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.PlaceholderText = "";
            this.txtTinhtrang.SelectedText = "";
            this.txtTinhtrang.Size = new System.Drawing.Size(161, 36);
            this.txtTinhtrang.TabIndex = 60;
            // 
            // txtSosvhientai
            // 
            this.txtSosvhientai.BorderRadius = 18;
            this.txtSosvhientai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSosvhientai.DefaultText = "";
            this.txtSosvhientai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSosvhientai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSosvhientai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSosvhientai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSosvhientai.Enabled = false;
            this.txtSosvhientai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSosvhientai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSosvhientai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSosvhientai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSosvhientai.Location = new System.Drawing.Point(167, 146);
            this.txtSosvhientai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSosvhientai.Name = "txtSosvhientai";
            this.txtSosvhientai.PlaceholderText = "";
            this.txtSosvhientai.SelectedText = "";
            this.txtSosvhientai.Size = new System.Drawing.Size(161, 36);
            this.txtSosvhientai.TabIndex = 59;
            // 
            // txtSosvtoida
            // 
            this.txtSosvtoida.BorderRadius = 18;
            this.txtSosvtoida.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSosvtoida.DefaultText = "";
            this.txtSosvtoida.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSosvtoida.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSosvtoida.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSosvtoida.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSosvtoida.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSosvtoida.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSosvtoida.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSosvtoida.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSosvtoida.Location = new System.Drawing.Point(167, 223);
            this.txtSosvtoida.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtSosvtoida.Name = "txtSosvtoida";
            this.txtSosvtoida.PlaceholderText = "";
            this.txtSosvtoida.SelectedText = "";
            this.txtSosvtoida.Size = new System.Drawing.Size(161, 36);
            this.txtSosvtoida.TabIndex = 55;
            // 
            // txtTenphong
            // 
            this.txtTenphong.BorderRadius = 18;
            this.txtTenphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenphong.DefaultText = "";
            this.txtTenphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenphong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenphong.Location = new System.Drawing.Point(167, 73);
            this.txtTenphong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.PlaceholderText = "";
            this.txtTenphong.SelectedText = "";
            this.txtTenphong.Size = new System.Drawing.Size(161, 36);
            this.txtTenphong.TabIndex = 54;
            // 
            // txtMaphong
            // 
            this.txtMaphong.BorderRadius = 18;
            this.txtMaphong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaphong.DefaultText = "";
            this.txtMaphong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaphong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaphong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaphong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaphong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaphong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMaphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaphong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaphong.Location = new System.Drawing.Point(167, 6);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.PlaceholderText = "";
            this.txtMaphong.SelectedText = "";
            this.txtMaphong.Size = new System.Drawing.Size(161, 36);
            this.txtMaphong.TabIndex = 53;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.CheckedState.BorderRadius = 0;
            this.checkBox1.CheckedState.BorderThickness = 0;
            this.checkBox1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox1.Location = new System.Drawing.Point(823, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 23);
            this.checkBox1.TabIndex = 55;
            this.checkBox1.Text = "Danh sách phòng còn trống";
            this.checkBox1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.UncheckedState.BorderRadius = 0;
            this.checkBox1.UncheckedState.BorderThickness = 0;
            this.checkBox1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.dgvPhong;
            // 
            // FrmQuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1083, 716);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhong);
            this.Name = "FrmQuanLyPhong";
            this.Text = "Quản Lý Phòng";
            this.Load += new System.EventHandler(this.FrmQuanLyPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DataGridViewTextBoxColumn maphong;
        private DataGridViewTextBoxColumn tenphong;
        private DataGridViewTextBoxColumn sosv;
        private DataGridViewTextBoxColumn sosvtoida;
        private DataGridViewTextBoxColumn tinhtrang;
        private DataGridViewTextBoxColumn loaiphong;
        private DataGridViewTextBoxColumn xeploai;
        private DataGridViewTextBoxColumn day;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnLammoi;
        private Guna.UI2.WinForms.Guna2CircleButton btnCapnhap;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnTimkiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimkiem;
        private Label label10;
        private RadioButton rbTktheoma;
        private RadioButton rbTktheoten;
        private RadioButton rbTktheomaday;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaphong;
        private Guna.UI2.WinForms.Guna2TextBox txtSosvtoida;
        private Guna.UI2.WinForms.Guna2TextBox txtTenphong;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhtrang;
        private Guna.UI2.WinForms.Guna2TextBox txtSosvhientai;
        private Guna.UI2.WinForms.Guna2ComboBox cbDay;
        private Guna.UI2.WinForms.Guna2ComboBox cbXeploai;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoaiphong;
        private Guna.UI2.WinForms.Guna2CheckBox checkBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        // private ChatBotControl chatBotControl1;
    }
}