using System.Collections.Generic;
using System.Linq;
using QuanLy_BLL;

namespace QuanLy_Assistant
{
    public class FAQService
    {
        private readonly Dictionary<string, string> faqDatabase;
        private readonly BLL_Phong bllPhong = new BLL_Phong();
        private readonly QuanLySinhVien_BL bllSinhVien = new QuanLySinhVien_BL();

        public FAQService()
        {
            faqDatabase = new Dictionary<string, string>
            {
                // phòng
                { "thêm phòng", "Vào mục Quản lý phòng, nhập thông tin đầy đủ và nhấn Thêm để tạo phòng mới." },
                { "chỉnh sửa thông tin phòng", "Nhấn chọn phòng mà bạn muốn chỉnh sửa, chỉnh sửa thông tin tại các ô, sau đó nhấn 'Cập nhập'." },
                { "số sinh viên hiện tại và tối đa", "Số sinh viên hiện tại là số lượng đang ở. Số tối đa là giới hạn sinh viên cho phép." },
                { "phòng trống là gì", "Phòng trống là phòng còn chỗ chưa đủ số sinh viên tối đa." },
                { "tìm phòng nhanh", "Sử dụng khung tìm kiếm, chọn trường phù hợp (Mã phòng, Tên phòng, Mã dãy) để tìm kiếm nhanh." },
                //chi
                { "thêm sinh viên", "Bạn vào mục 'Quản lý sinh viên', chọn Thêm mới và điền đầy đủ thông tin." },
                { "thêm nhân viên", "Bạn vào mục 'Quản lý nhân viên', nhấn nút Thêm mới và điền đầy đủ thông tin nhân viên." },
                { "xóa nhân viên", "Bạn vào mục 'Quản lý nhân viên', chọn nhân viên cần xóa và nhấn nút Xóa." },
                { "sửa thông tin nhân viên", "Bạn vào mục 'Quản lý nhân viên', chọn nhân viên và nhấn nút Chỉnh sửa." },
                { "xem lương nhân viên", "Bạn vào mục 'Quản lý lương', chọn nhân viên và xem chi tiết bảng lương theo tháng." },
                { "tính lương", "Lương được tính tự động dựa trên lương cơ bản, phụ cấp và thưởng/phạt. Vào mục 'Lương nhân viên' để xem chi tiết." },
                { "thêm dãy phòng", "Bạn vào mục 'Quản lý dãy phòng', nhấn Thêm mới và điền thông tin dãy phòng." },
                { "sửa dãy phòng", "Bạn vào mục 'Quản lý dãy phòng', chọn dãy phòng và nhấn Chỉnh sửa." },
                { "xem dãy phòng", "Danh sách dãy phòng được hiển thị trong mục 'Quản lý dãy phòng'." },
                { "duyệt đăng ký sinh viên", "Bạn vào mục 'Sinh viên đăng ký', chọn sinh viên và nhấn Duyệt để thêm vào phòng." },
                { "xem sinh viên đăng ký", "Danh sách sinh viên đăng ký được hiển thị trong mục 'Sinh viên đăng ký'." },
                { "tìm sinh viên", "Bạn vào mục 'Quản lý sinh viên', sử dụng chức năng tìm kiếm theo tên hoặc mã sinh viên." },
                { "xem vi phạm sinh viên", "Bạn vào mục 'Kỷ luật' để xem lịch sử vi phạm của sinh viên." },
                { "phân công quản lý dãy", "Bạn vào mục 'Quản lý dãy phòng', chọn dãy và cập nhật thông tin người quản lý." },
                { "thống kê lương", "Vào mục 'Báo cáo lương' để xem tổng hợp lương theo tháng/năm." },
                { "đổi quản lý dãy", "Bạn vào mục 'Quản lý dãy phòng', chọn dãy và cập nhật trường 'Quản lý'." },
            };
        }

        public string GetAnswer(string question)
        {
            if (string.IsNullOrWhiteSpace(question))
                return "Vui lòng nhập nội dung câu hỏi.";

            question = question.ToLower();

            // Kiểm tra các câu hỏi thống kê động
            string statisticAnswer = GetStatisticAnswer(question);
            if (!string.IsNullOrEmpty(statisticAnswer))
                return statisticAnswer;

            // Nếu không phải câu hỏi động, tìm trong FAQ tĩnh
            foreach (var faq in faqDatabase)
            {
                if (question.Contains(faq.Key))
                    return faq.Value;
            }

            return "Xin lỗi, tôi chưa có câu trả lời cho câu hỏi này. Vui lòng liên hệ bộ phận quản lý.";
        }

        private string GetStatisticAnswer(string question)
        {
            if (question.Contains("phòng trống"))
            {
                int phongTrong = bllPhong.GetPhongTrong().Count;
                return $"Hiện tại có {phongTrong} phòng trống.";
            }
            else if (question.Contains("tổng số phòng"))
            {
                int tongPhong = bllPhong.GetAllPhong().Count;
                return $"Ký túc xá có tổng cộng {tongPhong} phòng.";
            }
            else if (question.Contains("phòng vip"))
            {
                int phongVip = bllPhong.CountPhongTheoXepLoai("Vip");
                return $"Ký túc xá hiện có {phongVip} phòng Vip.";
            }
            else if (question.Contains("phòng nam"))
            {
                int phongNam = bllPhong.CountPhongTheoLoai("Nam");
                return $"Có {phongNam} phòng Nam trong ký túc xá.";
            }
            return null;
        }
    }
}
