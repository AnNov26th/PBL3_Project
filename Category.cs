using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PBL3_Project
{
    public class Category
    {
        [Key]
        public int category_id { get; set; }

        [Required]
        public string category_name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}