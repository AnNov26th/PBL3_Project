using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3_Project
{
    public class Category
    {
        [Key]
        public int category_id { get; set; } // Khớp với cột category_id

        [Required]
        public string category_name { get; set; } // Khớp với cột category_name

        // Mối quan hệ 1-N: Một danh mục có nhiều sản phẩm
        public virtual ICollection<Product> Products { get; set; }
    }
}