namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyNguoiDung
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTendangnhap = new System.Windows.Forms.RadioButton();
            this.rbManv = new System.Windows.Forms.RadioButton();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvNguoidung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tendangnhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.GBtnLamsach = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnSua = new Guna.UI2.WinForms.Guna2Button();
            this.GBtnThem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.GBtnTimkiem = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel4 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel3.SuspendLayout();
            this.guna2CustomGradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(255)))), ((int)(((byte)(219)))));
            this.groupBox1.Controls.Add(this.rbTendangnhap);
            this.groupBox1.Controls.Add(this.rbManv);
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(70, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(323, 153);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm theo";
            // 
            // rbTendangnhap
            // 
            this.rbTendangnhap.AutoSize = true;
            this.rbTendangnhap.Location = new System.Drawing.Point(8, 66);
            this.rbTendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbTendangnhap.Name = "rbTendangnhap";
            this.rbTendangnhap.Size = new System.Drawing.Size(140, 24);
            this.rbTendangnhap.TabIndex = 1;
            this.rbTendangnhap.TabStop = true;
            this.rbTendangnhap.Text = "Tên đăng nhập";
            this.rbTendangnhap.UseVisualStyleBackColor = true;
            // 
            // rbManv
            // 
            this.rbManv.AutoSize = true;
            this.rbManv.Location = new System.Drawing.Point(7, 26);
            this.rbManv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbManv.Name = "rbManv";
            this.rbManv.Size = new System.Drawing.Size(129, 24);
            this.rbManv.TabIndex = 0;
            this.rbManv.TabStop = true;
            this.rbManv.Text = "Mã nhân viên";
            this.rbManv.UseVisualStyleBackColor = true;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiem.Location = new System.Drawing.Point(7, 106);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(284, 30);
            this.txtTimkiem.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(193, 59);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(160, 30);
            this.txtId.TabIndex = 40;
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(193, 170);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(160, 30);
            this.txtMatkhau.TabIndex = 42;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTendangnhap.Location = new System.Drawing.Point(193, 111);
            this.txtTendangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(160, 30);
            this.txtTendangnhap.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 22);
            this.label12.TabIndex = 51;
            this.label12.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(46, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 22);
            this.label9.TabIndex = 49;
            this.label9.Text = "Mật khẩu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tên đăng nhập";
            // 
            // dgvNguoidung
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvNguoidung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNguoidung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNguoidung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNguoidung.ColumnHeadersHeight = 30;
            this.dgvNguoidung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tendangnhap,
            this.matkhau});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNguoidung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNguoidung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNguoidung.Location = new System.Drawing.Point(147, 59);
            this.dgvNguoidung.Name = "dgvNguoidung";
            this.dgvNguoidung.RowHeadersVisible = false;
            this.dgvNguoidung.RowHeadersWidth = 51;
            this.dgvNguoidung.RowTemplate.Height = 24;
            this.dgvNguoidung.Size = new System.Drawing.Size(609, 352);
            this.dgvNguoidung.TabIndex = 52;
            this.dgvNguoidung.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNguoidung.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNguoidung.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNguoidung.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNguoidung.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNguoidung.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNguoidung.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNguoidung.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNguoidung.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvNguoidung.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNguoidung.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNguoidung.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvNguoidung.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvNguoidung.ThemeStyle.ReadOnly = false;
            this.dgvNguoidung.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNguoidung.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNguoidung.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNguoidung.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNguoidung.ThemeStyle.RowsStyle.Height = 24;
            this.dgvNguoidung.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNguoidung.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNguoidung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoidung_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "manguoidung";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            // 
            // tendangnhap
            // 
            this.tendangnhap.DataPropertyName = "tendangnhap";
            this.tendangnhap.HeaderText = "Tên đăng nhập";
            this.tendangnhap.MinimumWidth = 6;
            this.tendangnhap.Name = "tendangnhap";
            // 
            // matkhau
            // 
            this.matkhau.DataPropertyName = "matkhau";
            this.matkhau.HeaderText = "Mật khẩu";
            this.matkhau.MinimumWidth = 6;
            this.matkhau.Name = "matkhau";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderRadius = 30;
            this.guna2CustomGradientPanel1.Controls.Add(this.label11);
            this.guna2CustomGradientPanel1.Controls.Add(this.dgvNguoidung);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(713, 29);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(886, 419);
            this.guna2CustomGradientPanel1.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(347, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 25);
            this.label11.TabIndex = 61;
            this.label11.Text = "Danh sách Người Dùng";
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderRadius = 30;
            this.guna2CustomGradientPanel2.Controls.Add(this.GBtnLamsach);
            this.guna2CustomGradientPanel2.Controls.Add(this.GBtnXoa);
            this.guna2CustomGradientPanel2.Controls.Add(this.GBtnSua);
            this.guna2CustomGradientPanel2.Controls.Add(this.GBtnThem);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(775, 462);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(768, 150);
            this.guna2CustomGradientPanel2.TabIndex = 54;
            // 
            // GBtnLamsach
            // 
            this.GBtnLamsach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBtnLamsach.BorderRadius = 25;
            this.GBtnLamsach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnLamsach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnLamsach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnLamsach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnLamsach.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.GBtnLamsach.ForeColor = System.Drawing.Color.White;
            this.GBtnLamsach.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_synchronize_100__1_1;
            this.GBtnLamsach.ImageSize = new System.Drawing.Size(40, 40);
            this.GBtnLamsach.Location = new System.Drawing.Point(590, 44);
            this.GBtnLamsach.Name = "GBtnLamsach";
            this.GBtnLamsach.Size = new System.Drawing.Size(157, 68);
            this.GBtnLamsach.TabIndex = 79;
            this.GBtnLamsach.Text = "Làm sạch";
            this.GBtnLamsach.Click += new System.EventHandler(this.GBtnLamsach_Click);
            // 
            // GBtnXoa
            // 
            this.GBtnXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBtnXoa.BorderRadius = 25;
            this.GBtnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnXoa.ForeColor = System.Drawing.Color.White;
            this.GBtnXoa.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_delete_100__2_;
            this.GBtnXoa.ImageSize = new System.Drawing.Size(40, 40);
            this.GBtnXoa.Location = new System.Drawing.Point(400, 44);
            this.GBtnXoa.Name = "GBtnXoa";
            this.GBtnXoa.Size = new System.Drawing.Size(162, 68);
            this.GBtnXoa.TabIndex = 57;
            this.GBtnXoa.Text = "Xóa";
            this.GBtnXoa.Click += new System.EventHandler(this.GBtnXoa_Click);
            // 
            // GBtnSua
            // 
            this.GBtnSua.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBtnSua.BorderRadius = 25;
            this.GBtnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnSua.ForeColor = System.Drawing.Color.White;
            this.GBtnSua.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_edit_100;
            this.GBtnSua.ImageSize = new System.Drawing.Size(40, 40);
            this.GBtnSua.Location = new System.Drawing.Point(211, 44);
            this.GBtnSua.Name = "GBtnSua";
            this.GBtnSua.Size = new System.Drawing.Size(162, 68);
            this.GBtnSua.TabIndex = 56;
            this.GBtnSua.Text = "Sửa";
            this.GBtnSua.Click += new System.EventHandler(this.GBtnSua_Click);
            // 
            // GBtnThem
            // 
            this.GBtnThem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GBtnThem.BorderRadius = 25;
            this.GBtnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnThem.ForeColor = System.Drawing.Color.White;
            this.GBtnThem.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_plus_100__1_;
            this.GBtnThem.ImageSize = new System.Drawing.Size(40, 40);
            this.GBtnThem.Location = new System.Drawing.Point(20, 44);
            this.GBtnThem.Name = "GBtnThem";
            this.GBtnThem.Size = new System.Drawing.Size(162, 68);
            this.GBtnThem.TabIndex = 55;
            this.GBtnThem.Text = "Thêm";
            this.GBtnThem.Click += new System.EventHandler(this.GBtnThem_Click);
            // 
            // guna2CustomGradientPanel3
            // 
            this.guna2CustomGradientPanel3.BorderRadius = 25;
            this.guna2CustomGradientPanel3.Controls.Add(this.label10);
            this.guna2CustomGradientPanel3.Controls.Add(this.label9);
            this.guna2CustomGradientPanel3.Controls.Add(this.label12);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtTendangnhap);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtId);
            this.guna2CustomGradientPanel3.Controls.Add(this.txtMatkhau);
            this.guna2CustomGradientPanel3.Location = new System.Drawing.Point(206, 29);
            this.guna2CustomGradientPanel3.Name = "guna2CustomGradientPanel3";
            this.guna2CustomGradientPanel3.Size = new System.Drawing.Size(452, 249);
            this.guna2CustomGradientPanel3.TabIndex = 55;
            // 
            // GBtnTimkiem
            // 
            this.GBtnTimkiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnTimkiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnTimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnTimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnTimkiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBtnTimkiem.ForeColor = System.Drawing.Color.White;
            this.GBtnTimkiem.Image = global::QuanLyKyTucXa_main.Properties.Resources.icons8_search_100;
            this.GBtnTimkiem.ImageSize = new System.Drawing.Size(40, 40);
            this.GBtnTimkiem.Location = new System.Drawing.Point(70, 222);
            this.GBtnTimkiem.Name = "GBtnTimkiem";
            this.GBtnTimkiem.Size = new System.Drawing.Size(323, 45);
            this.GBtnTimkiem.TabIndex = 52;
            this.GBtnTimkiem.Text = "Tìm kiếm";
            this.GBtnTimkiem.Click += new System.EventHandler(this.GBtnTimkiem_Click);
            // 
            // guna2CustomGradientPanel4
            // 
            this.guna2CustomGradientPanel4.BorderRadius = 25;
            this.guna2CustomGradientPanel4.Controls.Add(this.GBtnTimkiem);
            this.guna2CustomGradientPanel4.Controls.Add(this.groupBox1);
            this.guna2CustomGradientPanel4.Location = new System.Drawing.Point(206, 307);
            this.guna2CustomGradientPanel4.Name = "guna2CustomGradientPanel4";
            this.guna2CustomGradientPanel4.Size = new System.Drawing.Size(452, 305);
            this.guna2CustomGradientPanel4.TabIndex = 56;
            // 
            // FrmQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(1761, 950);
            this.Controls.Add(this.guna2CustomGradientPanel4);
            this.Controls.Add(this.guna2CustomGradientPanel3);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "FrmQuanLyNguoiDung";
            this.Text = "FrmQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.FrmQuanLyNguoiDung_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoidung)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel3.ResumeLayout(false);
            this.guna2CustomGradientPanel3.PerformLayout();
            this.guna2CustomGradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.RadioButton rbTendangnhap;
        private System.Windows.Forms.RadioButton rbManv;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNguoidung;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tendangnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn matkhau;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button GBtnThem;
        private Guna.UI2.WinForms.Guna2Button GBtnSua;
        private Guna.UI2.WinForms.Guna2Button GBtnXoa;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel3;
        private Guna.UI2.WinForms.Guna2Button GBtnTimkiem;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel4;
        private Guna.UI2.WinForms.Guna2Button GBtnLamsach;
    }
}