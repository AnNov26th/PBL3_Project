using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project
{
    [Table("User_Account")]
    public class UserAccount
    {
        [Key]
        public int user_id { get; set; }

        public string username { get; set; }

        public string password_hash { get; set; }

        public string role { get; set; }

        public int? employee_id { get; set; }

        [ForeignKey("employee_id")]
        public virtual Employee Employee { get; set; }
    }
}