use QuanLyKyTucXa
go

--Thong Ke TienDien
CREATE PROCEDURE sp_LuongDienTheoThang
    @nam INT,
    @thang INT
AS
BEGIN
    SELECT ISNULL(SUM(sodientieuthu), 0) AS TongSoDien
    FROM TienDien
    WHERE YEAR(ngaylap) = @nam AND MONTH(ngaylap) = @thang
END
GO


--QuanLySinhVien

-- 1. Lấy tất cả sinh viên
CREATE PROCEDURE sp_LayTatCaSinhVien
AS
BEGIN
    SELECT * FROM SinhVien
END
GO

-- 2. Thêm sinh viên
CREATE PROCEDURE sp_ThemSinhVien
    @MaSV NVARCHAR(10),
    @HoTen NVARCHAR(50),
    @GioiTinh NVARCHAR(5),
    @NgaySinh DATE,
    @QueQuan NVARCHAR(100),
    @Khoa NVARCHAR(50),
    @Lop NVARCHAR(50),
    @LoaiUuTien NVARCHAR(50),
    @MaPhong NVARCHAR(10)
AS
BEGIN
    INSERT INTO SinhVien(masv, tensv, gioitinh, ngaysinh, quequan, khoa, lop, loaiuutien, maphong)
    VALUES (@MaSV, @HoTen, @GioiTinh, @NgaySinh, @QueQuan, @Khoa, @Lop, @LoaiUuTien, @MaPhong)
END
GO

-- Sửa stored procedure: tự động sinh mã sinh viên
CREATE PROCEDURE sp_ThemSinhVienMoi 
    @HoTen NVARCHAR(50),
    @GioiTinh NVARCHAR(5),
    @NgaySinh DATE,
    @QueQuan NVARCHAR(100),
    @Email nvarchar(100),
    @Khoa NVARCHAR(50),
    @Lop NVARCHAR(50),
    @LoaiUuTien NVARCHAR(50),
    @MaPhong NVARCHAR(10)
AS
BEGIN
    DECLARE @MaMoi NVARCHAR(10)

    -- Sinh mã mới dạng SV001, SV002...
    SELECT @MaMoi = 'sv' + RIGHT('00' + CAST(
        ISNULL(MAX(CAST(SUBSTRING(masv, 3, 10) AS INT)) + 1, 1) AS VARCHAR), 2)
FROM SinhVien

    -- Thêm sinh viên
    INSERT INTO SinhVien(masv, tensv, gioitinh, ngaysinh, quequan,email, khoa, lop, loaiuutien, maphong)
    VALUES (@MaMoi, @HoTen, @GioiTinh, @NgaySinh, @QueQuan,@Email, @Khoa, @Lop, @LoaiUuTien, @MaPhong)
END
GO

-- 3. Cập nhật sinh viên

CREATE PROCEDURE sp_SuaSinhVien
    @MaSV NVARCHAR(10),
    @HoTen NVARCHAR(50),
    @GioiTinh NVARCHAR(5),
    @NgaySinh DATE,
    @QueQuan NVARCHAR(100),
    @Email NVARCHAR(100),
    @Khoa NVARCHAR(50),
    @Lop NVARCHAR(50),
    @LoaiUuTien NVARCHAR(50),
    @MaPhong NVARCHAR(10)
AS
BEGIN
    UPDATE SinhVien
    SET tensv = @HoTen,
        gioitinh = @GioiTinh,
        ngaysinh = @NgaySinh,
        quequan = @QueQuan,
        email = @Email,
        khoa = @Khoa,
        lop = @Lop,
        loaiuutien = @LoaiUuTien,
        maphong = @MaPhong
    WHERE masv = @MaSV
END
GO

-- 4. Xóa sinh viên
CREATE PROCEDURE sp_XoaSinhVien
    @MaSV NVARCHAR(10)
AS
BEGIN
    DELETE FROM SinhVien WHERE masv = @MaSV
END
GO

-- 5. Tìm kiếm theo mã sinh viên
CREATE PROCEDURE sp_TimKiemSinhVien_TheoMa
    @TuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT * FROM SinhVien WHERE masv LIKE '%' + @TuKhoa + '%'
END
GO

-- 6. Tìm kiếm theo tên sinh viên
CREATE PROCEDURE sp_TimKiemSinhVien_TheoTen
    @TuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT * FROM SinhVien WHERE tensv LIKE '%' + @TuKhoa + '%'
END
GO

-- 7. Tìm kiếm theo mã phòng
CREATE PROCEDURE sp_TimKiemSinhVien_TheoPhong
    @TuKhoa NVARCHAR(50)
AS
BEGIN
    SELECT * FROM SinhVien WHERE maphong LIKE '%' + @TuKhoa + '%'
END
GO

/* Quản lý Nhân viên */
/* Thêm nhân viên */
CREATE PROC uspThemNhanVien
	@manv nchar(10),
	@tennv nvarchar (50),
	@gioitinh nvarchar (10),
	@ngaysinh date,
	@diachi nvarchar(50),
	@sodienthoai nchar(15)
AS
BEGIN
	INSERT INTO NhanVien (maNV, tenNV, gioiTinh, ngaySinh, diaChi, soDienThoai) 
	VALUES(@manv, @tennv, @gioitinh, @ngaysinh, @diachi, @sodienthoai);
END
GO
/* Xóa nhân viên */
CREATE PROC uspXoaNhanVien
    @manv nchar(10)
AS
BEGIN
    DELETE FROM NhanVien WHERE maNV = @manv;
END
GO
/* Cập nhập nhân viên */
CREATE PROC uspCapNhapNhanVien
    @manv nchar(10),
    @tennv nvarchar(50),
    @gioitinh nvarchar(10),
    @ngaysinh date,
    @diachi nvarchar(50),
    @sodienthoai nchar(15)
AS
BEGIN
    UPDATE NhanVien 
    SET 
        tenNV = @tennv,
        gioiTinh = @gioitinh,
        ngaySinh = @ngaysinh,
        diaChi = @diachi,
        soDienThoai = @sodienthoai
    WHERE maNV = @manv;
END
GO

