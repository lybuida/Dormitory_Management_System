# Dormitory Management System (Quản lý Ký túc xá)

Ứng dụng quản lý ký túc xá được xây dựng nhằm hỗ trợ nhà trường/ban quản lý trong việc:
- Quản lý thông tin sinh viên, phòng ở.
- Quản lý hợp đồng, hóa đơn điện/nước, thu phí.
- Quản lý nhân sự, kỷ luật, và báo cáo thống kê.

Dự án được phát triển trong khuôn khổ học phần môn học Lập trình Cơ sở Dữ liệu tại trường Đại học mở TPHCM.


## 🚀 Tính năng chính
- **Quản lý phòng:** thêm/sửa/xóa phòng, phân loại theo loại phòng (thường, VIP), số lượng tối đa.
- **Quản lý sinh viên:** hồ sơ, nhận/trả phòng, lịch sử ở, tình trạng kỷ luật.
- **Quản lý hợp đồng & phí:** lập hợp đồng thuê, tính phí điện/nước, xuất hóa đơn.
- **Thống kê báo cáo:** báo cáo số lượng sinh viên, phòng trống, doanh thu theo tháng.
- **Quản lý nhân sự:** thêm/sửa/xóa cán bộ quản lý ký túc xá.

---

## 🛠 Công nghệ sử dụng
- **Ngôn ngữ:** C# (.NET Framework / WinForms)
- **CSDL:** Microsoft SQL Server (2019/2022 Express hoặc LocalDB)
- **ADO.NET:** kết nối & thao tác dữ liệu
- **Mô hình:** 3 lớp (Presentation/UI – Business Logic Layer – Data Access Layer)

---

## 🏗 Kiến trúc phần mềm
- Presentation Layer (WinForms): Quản lý giao diện, nhập liệu, xử lý sự kiện người dùng
- Business Logic Layer (BLL): Xử lý logic nghiệp vụ (tính tiền phòng, xác thực hợp đồng, kiểm tra sức chứa phòng)
- Data Access Layer (DAL): Giao tiếp với SQL Server, thực thi Stored Procedures, CRUD
- Database (SQL Server): Các bảng: SinhVien, Phong, HopDong, HoaDon, NhanVien, KyLuat, ...

---

## 📂 Cấu trúc thư mục
QuanLyKyTucXa_main/
- QuanLyKyTucXa_GUI/ # Giao diện WinForms
- QuanLy.BLL/ # Business Logic Layer
- QuanLy.DAL/ # Data Access Layer
- TransferObject/ # Data Transfer Objects
- scripts/ # Script SQL tạo & seed dữ liệu
- docs/ # Báo cáo, ERD, DFD, UML
- README.md
- .gitignore

---

## ⚙️ Hướng dẫn cài đặt & chạy

### 1) Yêu cầu môi trường
- Visual Studio 2022 trở lên (cài workload **.NET desktop development**).
- SQL Server 2019/2022 + SSMS.
- .NET Framework [phiên bản bạn dùng].

### 2) Tạo cơ sở dữ liệu
- Mở **SQL Server Management Studio (SSMS)**.
- Chạy script trong `scripts/scriptKTX_new.sql` để tạo DB.
- Chạy `scripts/Myscript.sql` để tạo các Store Procedure.

### 3) Cấu hình chuỗi kết nối
- Mở `App.config` (hoặc file config chính).
- Sửa `connectionString` theo server name của bạn:
<connectionStrings>
  <add name="DormitoryDb"
       connectionString="Server=localhost\SQLEXPRESS;Database=DormitoryDB;Trusted_Connection=True;"
       providerName="System.Data.SqlClient" />
</connectionStrings>

### 4) Build & Run
- Mở solution DormitoryManagementSystem.sln bằng Visual Studio.
- Chuột phải project UI → chọn Set as Startup Project.
- Nhấn Ctrl + F5 để chạy.

