using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3_Project
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }

        public string product_name { get; set; }

        public int? brand_id { get; set; }

        public int? category_id { get; set; }

        public decimal? base_price { get; set; }

        public string description { get; set; }

        // Navigation property để liên kết ngược lại Category
        [ForeignKey("category_id")]
        public virtual Category Category { get; set; }
    }
}