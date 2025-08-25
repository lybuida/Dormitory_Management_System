namespace QuanLyKyTucXa_main
{
    partial class FrmDangNhap
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GcbShowpassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.BtnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.GBtnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(484, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // GcbShowpassword
            // 
            this.GcbShowpassword.AutoSize = true;
            this.GcbShowpassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GcbShowpassword.CheckedState.BorderRadius = 0;
            this.GcbShowpassword.CheckedState.BorderThickness = 0;
            this.GcbShowpassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GcbShowpassword.Location = new System.Drawing.Point(624, 253);
            this.GcbShowpassword.Name = "GcbShowpassword";
            this.GcbShowpassword.Size = new System.Drawing.Size(125, 20);
            this.GcbShowpassword.TabIndex = 15;
            this.GcbShowpassword.Text = "Show Password";
            this.GcbShowpassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GcbShowpassword.UncheckedState.BorderRadius = 0;
            this.GcbShowpassword.UncheckedState.BorderThickness = 0;
            this.GcbShowpassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GcbShowpassword.CheckedChanged += new System.EventHandler(this.GcbShowpassword_CheckedChanged);
            // 
            // BtnThoat
            // 
            this.BtnThoat.BorderRadius = 20;
            this.BtnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnThoat.ForeColor = System.Drawing.Color.White;
            this.BtnThoat.Location = new System.Drawing.Point(605, 332);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(144, 53);
            this.BtnThoat.TabIndex = 14;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đăng nhập tài khoản";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(487, 203);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.PasswordChar = '*';
            this.txtMatkhau.Size = new System.Drawing.Size(262, 28);
            this.txtMatkhau.TabIndex = 11;
            this.txtMatkhau.Text = "admin";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(487, 131);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(262, 28);
            this.txtTaikhoan.TabIndex = 12;
            this.txtTaikhoan.Text = "admin";
            // 
            // GBtnThoat
            // 
            this.GBtnThoat.BorderRadius = 20;
            this.GBtnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GBtnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GBtnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GBtnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GBtnThoat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GBtnThoat.ForeColor = System.Drawing.Color.White;
            this.GBtnThoat.Location = new System.Drawing.Point(426, 332);
            this.GBtnThoat.Name = "GBtnThoat";
            this.GBtnThoat.Size = new System.Drawing.Size(144, 53);
            this.GBtnThoat.TabIndex = 10;
            this.GBtnThoat.Text = "Đăng nhập";
            this.GBtnThoat.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.GBtnThoat.Click += new System.EventHandler(this.GBtnDangnhap_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(10)))), ((int)(((byte)(143)))));
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(379, 424);
            this.guna2Panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(10)))), ((int)(((byte)(143)))));
            this.pictureBox1.Image = global::QuanLyKyTucXa_main.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(91, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(22, 198);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(434, 47);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Hệ Thống Quản Lý Ký Túc Xá";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pictureBox2.Image = global::QuanLyKyTucXa_main.Properties.Resources.username;
            this.pictureBox2.Location = new System.Drawing.Point(426, 126);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253)))));
            this.pictureBox3.Image = global::QuanLyKyTucXa_main.Properties.Resources.key;
            this.pictureBox3.Location = new System.Drawing.Point(426, 198);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(802, 424);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.GcbShowpassword);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GBtnThoat);
            this.Controls.Add(this.BtnThoat);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button GBtnThoat;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BtnThoat;
        private Guna.UI2.WinForms.Guna2CheckBox GcbShowpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
