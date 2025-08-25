using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using QuanLy_DAL;

namespace QuanLy_BLL
{
    public class DanhSachDangKy_BL
    {
        private DanhSachDangKy_DL danhSachDangKyDL;

        public DanhSachDangKy_BL()
        {
            danhSachDangKyDL = new DanhSachDangKy_DL();
        }

        public List<SinhVienDangKy> LayDSSinhVienDangKy()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVienDangKy();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public List<SinhVien> LayDSSinhVien()
        {
            try
            {
                return danhSachDangKyDL.LayDSSinhVien();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void XepPhongTuDong(List<SinhVienDangKy> dsDangKy)
        {

            // Nhóm sinh viên theo giới tính
            var clusterGroups = new Dictionary<string, List<SinhVienDangKy>>();
            foreach (var sv in dsDangKy)
            {
                string key = sv.gioitinh; // Chỉ lấy giới tính
                if (!clusterGroups.ContainsKey(key))
                    clusterGroups[key] = new List<SinhVienDangKy>();
                clusterGroups[key].Add(sv);
            }

            var sinhVienKhongXepDuoc = new List<SinhVienDangKy>();

            foreach (var cluster in clusterGroups)
            {
                // Lấy phòng theo giới tính và tình trạng
                var phongTrong = danhSachDangKyDL.LayPhongTheoDieuKien(
                    cluster.Key, // Giới tính
                    "Thiếu"       // Tình trạng
                );

                foreach (var sv in cluster.Value)
                {
                    bool daXep = false;
                    foreach (var phong in phongTrong)
                    {
                        int soSVHienTai = danhSachDangKyDL.LaySoSVHienTai(phong.Maphong);
                        if (soSVHienTai < phong.Sosvtoida)
                        {
                            ThemSinhVienVaoPhong(sv, phong);
                            daXep = true;
                            break;
                        }
                    }
                    if (!daXep) sinhVienKhongXepDuoc.Add(sv);
                }
            }
        }

        private void ThemSinhVienVaoPhong(SinhVienDangKy sv, Phong phong)
        {
            // Chuyển sinh viên từ đăng ký sang danh sách chính thức
            var sinhVien = new SinhVien(
                sv.masvdky, sv.tensv, sv.gioitinh, sv.ngaysinh,
                sv.quequan, sv.email, sv.khoa, sv.lop, sv.loaiuutien, phong.Maphong
            );

            // Cập nhật CSDL
            danhSachDangKyDL.ThemSinhVien(sinhVien);
            danhSachDangKyDL.XoaSinhVienDangKy(sv.masvdky);
            danhSachDangKyDL.CapNhatSoSV(phong.Maphong); // Cập nhật số SV và tình trạng phòng
        }

        public bool XoaTatCaSinhVienDangKy()
        {
            try
            {
                return danhSachDangKyDL.XoaTatCaSinhVienDangKy();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
