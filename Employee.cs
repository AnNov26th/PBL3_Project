using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project
{
    [Table("Employee")] // Ánh xạ class này với bảng Employee trong SQL
    public class Employee
    {
        [Key] 
        public int employee_id { get; set; }

        [Required]
        public string full_name { get; set; }

        public string position { get; set; } // Ví dụ: Manager, Staff

        // Nếu bạn muốn lưu Tài khoản/Mật khẩu chung vào đây (không dùng bảng User_Account), 
        // bạn cần thêm cột vào SQL. 
        // Còn nếu dùng đúng DB hiện tại, thông tin đó sẽ nằm ở class UserAccount bên dưới.
    }
}