using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // BẮT BUỘC có dòng này để dùng Data Annotations

namespace quan_li_sv
{
    // 1. Lớp Lớp Học
    public class LopHoc
    {
        [Required(ErrorMessage = "Mã lớp không được để trống.")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống.")]
        public string TenLop { get; set; }

        public override string ToString()
        {
            return TenLop;
        }
    }

    // 2. Lớp Sinh Viên
    public class SinhVien
    {
        [Required(ErrorMessage = "Mã sinh viên không được để trống.")]
        [RegularExpression(@"^SV\d{6}$", ErrorMessage = "Mã sinh viên phải có dạng SVxxxxxx (VD: SV000123).")]
        public string MaSV { get; set; }

        [Required(ErrorMessage = "Họ và tên không được để trống.")]
        [StringLength(100, ErrorMessage = "Họ tên không vượt quá 100 ký tự.")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống.")]
        public DateTime NgaySinh { get; set; }

        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public string GioiTinh { get; set; }

        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Địa chỉ Email không hợp lệ.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Số điện thoại không được để trống.")]
        [RegularExpression(@"^\d{10,11}$", ErrorMessage = "Số điện thoại phải từ 10 đến 11 chữ số.")]
        public string DienThoai { get; set; }

        [Range(0.0, 10.0, ErrorMessage = "Điểm phải từ 0 đến 10.")]
        public double Diem { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn lớp học.")]
        public string MaLop { get; set; }

        [Required(ErrorMessage = "Trạng thái không được để trống.")]
        public string TrangThai { get; set; }
    }

    // 3. Phương thức kiểm tra Validate
    public static class ModelValidator
    {
        public static bool ValidateObject<T>(T obj, out string errorMessage)
        {
            var context = new ValidationContext(obj, null, null);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(obj, context, results, true);

            if (!isValid)
            {
                errorMessage = results[0].ErrorMessage;
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}