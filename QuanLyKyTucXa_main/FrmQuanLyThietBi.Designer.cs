namespace QuanLyKyTucXa_main
{
    partial class FrmQuanLyThietBi
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMathietbi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTinhtrang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenthietbi = new Guna.UI2.WinForms.Guna2TextBox();
            this.numericUpDownSoluong = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMaphong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnThem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnXoa = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnLammoi = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnCapnhap = new Guna.UI2.WinForms.Guna2CircleButton();
            this.dgvThietbi = new System.Windows.Forms.DataGridView();
            this.mathietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthietbi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietbi)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(12, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tình trạng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên thiết bị";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtMathietbi);
            this.panel2.Controls.Add(this.txtTinhtrang);
            this.panel2.Controls.Add(this.txtTenthietbi);
            this.panel2.Controls.Add(this.numericUpDownSoluong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbMaphong);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(18, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 349);
            this.panel2.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Mã thiết bị";
            // 
            // txtMathietbi
            // 
            this.txtMathietbi.BorderRadius = 18;
            this.txtMathietbi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMathietbi.DefaultText = "";
            this.txtMathietbi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMathietbi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMathietbi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMathietbi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMathietbi.Enabled = false;
            this.txtMathietbi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMathietbi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMathietbi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMathietbi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMathietbi.Location = new System.Drawing.Point(110, 3);
            this.txtMathietbi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMathietbi.Name = "txtMathietbi";
            this.txtMathietbi.PlaceholderText = "";
            this.txtMathietbi.SelectedText = "";
            this.txtMathietbi.Size = new System.Drawing.Size(161, 36);
            this.txtMathietbi.TabIndex = 55;
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
            this.txtTinhtrang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTinhtrang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTinhtrang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTinhtrang.Location = new System.Drawing.Point(110, 301);
            this.txtTinhtrang.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTinhtrang.Name = "txtTinhtrang";
            this.txtTinhtrang.PlaceholderText = "";
            this.txtTinhtrang.SelectedText = "";
            this.txtTinhtrang.Size = new System.Drawing.Size(161, 36);
            this.txtTinhtrang.TabIndex = 53;
            // 
            // txtTenthietbi
            // 
            this.txtTenthietbi.BorderRadius = 18;
            this.txtTenthietbi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenthietbi.DefaultText = "";
            this.txtTenthietbi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenthietbi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenthietbi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenthietbi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenthietbi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenthietbi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTenthietbi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenthietbi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenthietbi.Location = new System.Drawing.Point(110, 148);
            this.txtTenthietbi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenthietbi.Name = "txtTenthietbi";
            this.txtTenthietbi.PlaceholderText = "";
            this.txtTenthietbi.SelectedText = "";
            this.txtTenthietbi.Size = new System.Drawing.Size(161, 36);
            this.txtTenthietbi.TabIndex = 53;
            // 
            // numericUpDownSoluong
            // 
            this.numericUpDownSoluong.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDownSoluong.BorderRadius = 18;
            this.numericUpDownSoluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDownSoluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numericUpDownSoluong.Location = new System.Drawing.Point(110, 227);
            this.numericUpDownSoluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numericUpDownSoluong.Name = "numericUpDownSoluong";
            this.numericUpDownSoluong.Size = new System.Drawing.Size(161, 36);
            this.numericUpDownSoluong.TabIndex = 56;
            this.numericUpDownSoluong.UpDownButtonFillColor = System.Drawing.Color.OliveDrab;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(13, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mã phòng";
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
            this.cbMaphong.Location = new System.Drawing.Point(110, 77);
            this.cbMaphong.Name = "cbMaphong";
            this.cbMaphong.Size = new System.Drawing.Size(161, 36);
            this.cbMaphong.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnThem);
            this.panel3.Controls.Add(this.btnXoa);
            this.panel3.Controls.Add(this.btnLammoi);
            this.panel3.Controls.Add(this.btnCapnhap);
            this.panel3.Location = new System.Drawing.Point(358, 310);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 69);
            this.panel3.TabIndex = 45;
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
            this.btnCapnhap.Location = new System.Drawing.Point(171, 3);
            this.btnCapnhap.Name = "btnCapnhap";
            this.btnCapnhap.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnCapnhap.Size = new System.Drawing.Size(63, 59);
            this.btnCapnhap.TabIndex = 47;
            this.btnCapnhap.Click += new System.EventHandler(this.btnCapnhap_Click);
            // 
            // dgvThietbi
            // 
            this.dgvThietbi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvThietbi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvThietbi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvThietbi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.OliveDrab;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(105)))), ((int)(((byte)(148)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThietbi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThietbi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThietbi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mathietbi,
            this.maphong,
            this.tenthietbi,
            this.soluong,
            this.tinhtrang});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(247)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvThietbi.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvThietbi.EnableHeadersVisualStyles = false;
            this.dgvThietbi.GridColor = System.Drawing.Color.LightGray;
            this.dgvThietbi.Location = new System.Drawing.Point(358, 42);
            this.dgvThietbi.Name = "dgvThietbi";
            this.dgvThietbi.RowHeadersVisible = false;
            this.dgvThietbi.RowHeadersWidth = 51;
            this.dgvThietbi.Size = new System.Drawing.Size(566, 262);
            this.dgvThietbi.TabIndex = 46;
            this.dgvThietbi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThietbi_CellClick);
            // 
            // mathietbi
            // 
            this.mathietbi.DataPropertyName = "mathietbi";
            this.mathietbi.HeaderText = "Mã thiết bị";
            this.mathietbi.MinimumWidth = 6;
            this.mathietbi.Name = "mathietbi";
            this.mathietbi.Width = 150;
            // 
            // maphong
            // 
            this.maphong.DataPropertyName = "maphong";
            this.maphong.FillWeight = 0.6093457F;
            this.maphong.HeaderText = "Mã phòng";
            this.maphong.MinimumWidth = 6;
            this.maphong.Name = "maphong";
            this.maphong.Width = 150;
            // 
            // tenthietbi
            // 
            this.tenthietbi.DataPropertyName = "tenthietbi";
            this.tenthietbi.FillWeight = 2.249508F;
            this.tenthietbi.HeaderText = "Tên thiết bị";
            this.tenthietbi.MinimumWidth = 6;
            this.tenthietbi.Name = "tenthietbi";
            this.tenthietbi.Width = 150;
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.FillWeight = 4.481539F;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.MinimumWidth = 6;
            this.soluong.Name = "soluong";
            this.soluong.Width = 130;
            // 
            // tinhtrang
            // 
            this.tinhtrang.DataPropertyName = "tinhtrang";
            this.tinhtrang.FillWeight = 9.014637F;
            this.tinhtrang.HeaderText = "Tình trạng";
            this.tinhtrang.MinimumWidth = 6;
            this.tinhtrang.Name = "tinhtrang";
            this.tinhtrang.Width = 150;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel3;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this.dgvThietbi;
            // 
            // FrmQuanLyThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(237)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(947, 617);
            this.Controls.Add(this.dgvThietbi);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FrmQuanLyThietBi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thiết Bị";
            this.Load += new System.EventHandler(this.FrmQuanLyThietBi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoluong)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThietbi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cbMaphong;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDownSoluong;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2CircleButton btnThem;
        private Guna.UI2.WinForms.Guna2CircleButton btnXoa;
        private Guna.UI2.WinForms.Guna2CircleButton btnLammoi;
        private Guna.UI2.WinForms.Guna2CircleButton btnCapnhap;
        private System.Windows.Forms.DataGridView dgvThietbi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenthietbi;
        private Guna.UI2.WinForms.Guna2TextBox txtTinhtrang;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn mathietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthietbi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrang;
    }
}