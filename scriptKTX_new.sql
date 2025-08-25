-- Tạo database
CREATE DATABASE QuanLyKyTucXa;
GO

USE QuanLyKyTucXa;
GO

-- Bảng Day
CREATE TABLE Day (
    maday NCHAR(10) PRIMARY KEY,
    tenday NVARCHAR(50),
    quanly NVARCHAR(50),
    trangthai NVARCHAR(50),
	daygioitinh NVARCHAR(50)
);

-- Bảng Phong
CREATE TABLE Phong (
    maphong NCHAR(10) PRIMARY KEY,
    tenphong NVARCHAR(50),
    sosv INT,
    sosvtoida INT,
    tinhtrang NVARCHAR(50),
    loaiphong NVARCHAR(50),
    xeploai NVARCHAR(50),
    day NCHAR(10),
    CONSTRAINT FK_Phong_Day FOREIGN KEY (day) REFERENCES Day(maday)
);

-- Bảng SinhVien
CREATE TABLE SinhVien (
    masv NCHAR(10) PRIMARY KEY,
    tensv NVARCHAR(50),
    gioitinh NVARCHAR(50),
    ngaysinh DATE,
    quequan NVARCHAR(50),
	email nchar(50) NULL,
    khoa NCHAR(10),
    lop NVARCHAR(50),
    loaiuutien NVARCHAR(50),
    maphong NCHAR(10),
    CONSTRAINT FK_SinhVien_Phong FOREIGN KEY (maphong) REFERENCES Phong(maphong)
);

-- Bảng SinhVienDangKy
CREATE TABLE SinhVienDangKy (
    masvdky NCHAR(10) PRIMARY KEY,
    tensv NVARCHAR(50),
    gioitinh NVARCHAR(50),
    ngaysinh DATE,
    quequan NVARCHAR(50),
	email nchar(50) NULL,
    khoa NCHAR(10),
    lop NVARCHAR(50),
    loaiuutien NVARCHAR(50)
);

-- Bảng ThietBi
CREATE TABLE ThietBi (
    MaThietBi INT PRIMARY KEY IDENTITY(1,1),
    Maphong NCHAR(10) NOT NULL,
    TenThietBi NVARCHAR(100) NOT NULL,
    SoLuong INT NOT NULL,
    TinhTrang NVARCHAR(100),
    CONSTRAINT FK_ThietBi_Phong FOREIGN KEY (Maphong) REFERENCES Phong(maphong)
);

-- Bảng TienDien
CREATE TABLE TienDien (
    mahoadon INT IDENTITY(1,1) PRIMARY KEY,
    maphong NCHAR(10),
    ngaylap DATE,
    chisocu INT,
    chisomoi INT,
    sodientieuthu INT,
    tongtien MONEY,
    trangthai NVARCHAR(50),
    CONSTRAINT FK_TienDien_Phong FOREIGN KEY (maphong) REFERENCES Phong(maphong)
);

-- Bảng TienNuoc
CREATE TABLE TienNuoc (
    mahoadon INT IDENTITY(1,1) PRIMARY KEY,
    maphong NCHAR(10),
    ngaylap DATE,
    chisocu INT,
    chisomoi INT,
    sokhoitieuthu INT,
    tongtien MONEY,
    trangthai NVARCHAR(50),
    CONSTRAINT FK_TienNuoc_Phong FOREIGN KEY (maphong) REFERENCES Phong(maphong)
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    manv NCHAR(10) PRIMARY KEY not null,
    tennv NVARCHAR(50) null,
    gioitinh NVARCHAR(10) NULL,
    ngaysinh DATE NULL,
    diachi NVARCHAR(50) NULL,
    sodienthoai NCHAR(15) NULL
);

-- Bảng LuongNhanVien
CREATE TABLE LuongNhanVien (
    maluong INT IDENTITY(1,1) PRIMARY KEY,
    manv NCHAR(10),
    tennv NVARCHAR(50),
	thang nvarchar(20) NULL,
    luongcoban FLOAT,
    phucap FLOAT,
    thuongphat FLOAT,
    ngaythanhtoan DATE NULL,
    tongluong FLOAT NULL,
    trangthai NCHAR(50) NULL,
    CONSTRAINT FK_LuongNhanVien_NhanVien FOREIGN KEY (manv) REFERENCES NhanVien(manv)
);

-- Bảng NguoiDung
CREATE TABLE NguoiDung (
    manguoidung INT IDENTITY(1,1) PRIMARY KEY,
    tendangnhap NCHAR(30),
    matkhau NCHAR(25),
);

-- Bảng KyLuat
CREATE TABLE KyLuat (
    makyluat INT IDENTITY(1,1) PRIMARY KEY,
    masv NCHAR(10),
    kyluat NVARCHAR(50),
    ngaykyluat DATE,
    tienphat MONEY,
    CONSTRAINT FK_KyLuat_SinhVien FOREIGN KEY (masv) REFERENCES SinhVien(masv)
);


-- DỮ LIỆU MẪU --

-- Dãy
INSERT INTO Day VALUES
(N'd1', N'Dãy 1', N'Thái Long', N'Đang hoạt động', N'Nam'),
(N'd2', N'Dãy 2', N'Thái Long', N'Đang hoạt động', N'Nữ');

-- Phòng
INSERT INTO Phong VALUES
(N'p101', N'Phòng 101', 4, 5, N'Thiếu', N'Nam', N'Thường', N'd1'),
(N'p102', N'Phòng 102', 5, 5, N'Đủ', N'Nam', N'Vip', N'd1'),
(N'p103', N'Phòng 103', 3, 5, N'Thiếu', N'Nữ', N'Thường', N'd2'),
(N'p104', N'Phòng 104', 1, 5, N'Thiếu', N'Nữ', N'Thường', N'd2'),
(N'p105', N'Phòng 105', 1, 5, N'Thiếu', N'Nữ', N'Thường', N'd2'),
(N'p106', N'Phòng 106', 1, 5, N'Thiếu', N'Nam', N'Thường', N'd1');

-- Sinh viên
INSERT INTO SinhVien VALUES
(N'sv01', N'Nguyễn Hùng', N'Nam', CAST(N'2021-05-26' AS Date), N'Hà Nội', 'hung@gmail.com' ,N'K21', N'CNTT1', N'Bình thường',N'p101'),
(N'sv02', N'Chung An', N'Nam', CAST(N'2000-05-26' AS Date), N'Hải Phòng', 'hung@gmail.com' ,N'K21', N'CNTT2', N'Bình thường',N'p101'),
(N'sv03', N'Trung Anh', N'Nam', CAST(N'2000-07-03' AS Date), N'Nam Định', 'hung@gmail.com' ,N'K21', N'CNTT3', N'Gia đình thương binh liệt sĩ', N'p102'),
(N'sv04', N'Khánh Ly', N'Nữ', CAST(N'2000-03-14' AS Date), N'Bình Thuận','hung@gmail.com' ,N'K21', N'CNTT3', N'Bình thường', N'p103'),
(N'sv05', N'Thu Lăng', N'Nữ', CAST(N'2000-03-15' AS Date), N'Bình Dương', 'hung@gmail.com' ,N'K21', N'CNTT2', N'Bình thường', N'p103'),
(N'sv06', N'Exodia', N'Nữ', CAST(N'2001-02-14' AS Date), N'Mexico', 'hung@gmail.com' ,N'K21', N'CNTT2', N'Du học sinh', N'p103'),
(N'sv08', N'Phúc Bồ', N'Nam', CAST(N'2000-06-02' AS Date), N'Tây Nguyên', 'hung@gmail.com' ,N'K21', N'KHMT1', N'Bình thường', N'p101'),
(N'sv09', N'Minh Quân', N'Nam', CAST(N'2000-06-02' AS Date), N'Hạ Long', 'hung@gmail.com' ,N'K21', N'CNTT1', N'Bình thường',  N'p101'),
(N'sv10', N'Lam Hồ', N'Nam', CAST(N'2000-06-02' AS Date), N'Cao Bằng','hung@gmail.com', N'K21',  N'KHMT2', N'Du học sinh', N'p102');


-- Sinh viên đăng ký
INSERT INTO SinhVienDangKy VALUES
(N'sv11', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chiiiconan@gmail.com' , N'K21', N'CNTT1', N'Bình thường'),
(N'sv12', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chiiiconan@gmail.com' , N'K22', N'CNTT2', N'Bình thường'),
(N'sv13', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chiiiconan@gmail.com' , N'K21', N'CNTT3', N'Bình thường'),
(N'sv14', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chiiiconan@gmail.com' , N'K23', N'HTTT1', N'Bình thường'),
(N'sv15', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com' , N'K24', N'HTTT2', N'Bình thường'),
(N'sv16', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com' , N'K22', N'KHMT1', N'Bình thường'),
(N'sv17', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com' , N'K24', N'KHMT2', N'Bình thường'),
(N'sv18', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com' , N'K23', N'CNTT1', N'Bình thường'),
(N'sv19', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com' , N'K22', N'CNTT3', N'Bình thường'),
(N'sv20', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com', N'K21', N'CNTT2', N'Bình thường'),
(N'sv21', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'chi.vtn.lly@gmail.com', N'K22', N'CNTT1', N'Bình thường'),
(N'sv22', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K23', N'CNTT2', N'Bình thường'),
(N'sv23', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K24', N'CNTT3', N'Bình thường'),
(N'sv24', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K23', N'CNTT1', N'Bình thường'),
(N'sv25', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K24', N'HTTT1', N'Bình thường'),
(N'sv26', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K21', N'CNTT1', N'Bình thường'),
(N'sv27', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K22', N'CNTT2', N'Bình thường'),
(N'sv28', N'Nguyễn Tiến', N'Nam', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K23', N'CNTT3', N'Bình thường'),
(N'sv29', N'Nguyễn Tiến', N'Nữ', CAST(N'2000-06-04' AS Date), N'Ninh Bình', 'huyenhannguyen2004@gmail.com', N'K24', N'KHMT2', N'Bình thường');

-- Thiết bị
INSERT INTO ThietBi (Maphong, TenThietBi, SoLuong, TinhTrang) VALUES 
('p101', N'Máy giặt', 1, N'Cũ'),
('p101', N'Máy giặt', 1, N'Mới'),
('p101', N'Quạt đứng', 2, N'Bình thường'),

('p102', N'Máy lạnh', 1, N'Hoạt động tốt'),
('p102', N'Bàn học', 3, N'Mới'),

('p103', N'Tủ quần áo', 2, N'Đã sơn lại'),
('p103', N'Quạt trần', 1, N'Hỏng nhẹ');

-- Tiền điện
INSERT INTO TienDien (maphong, ngaylap, chisocu, chisomoi, sodientieuthu, tongtien, trangthai) VALUES 
(N'p101', '2024-06-01', 20, 30, 10, 30000, N'Chưa thanh toán'),
(N'p102', '2024-06-01', 15, 25, 10, 30000, N'Đã thanh toán'),
(N'p103', '2023-06-01', 0, 10, 10, 30000, N'Chưa thanh toán');

-- Tiền nước
INSERT INTO TienNuoc (maphong, ngaylap, chisocu, chisomoi, sokhoitieuthu, tongtien, trangthai) VALUES
(N'p101', '2024-06-01', 10, 20, 10, 20000, N'Chưa thanh toán'),
(N'p102', '2024-06-01', 5, 15, 10, 20000, N'Đã thanh toán');

-- Nhân viên
INSERT INTO NhanVien (manv, tennv, gioitinh, ngaysinh, diachi, sodienthoai) VALUES
(N'nv01', N'Phạm Hiếu', N'Nam', '2000-05-16', N'Hà Nội', N'091131213'),
(N'nv02', N'Thái Long', N'Nam', '2001-05-18', N'Hải Phòng', N'09122134');

-- Lương nhân viên


-- Người dùng
INSERT INTO NguoiDung (tendangnhap, matkhau) VALUES
( N'admin', N'admin'),
( N'long', N'long');

-- Kỷ luật
INSERT INTO KyLuat (masv, kyluat, ngaykyluat, tienphat) VALUES
(N'sv01', N'Dập cầu dao ký túc xá', '2021-06-01', 100000),
(N'sv02', N'Đánh nhau', '2021-05-31', 50000);
