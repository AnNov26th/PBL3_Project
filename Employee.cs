using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project
{
    [Table("Employee")]
    public class Employee
    {
        [Key] 
        public int employee_id { get; set; }

        [Required]
        public string full_name { get; set; }

        public string position { get; set; }
    }
}