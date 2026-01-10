using Microsoft.EntityFrameworkCore;

namespace PBL3_Project
{
    public class PBL3Context : DbContext
    {
        // Tên DbSet nên đặt số nhiều (Categories, Products) 
        // để phân biệt với tên Class (Category, Product)
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Database=ShopGiayDB để kết nối đúng vào db bro vừa tạo, không vào master nữa
            optionsBuilder.UseSqlServer(@"Server=MSI\SQLEXPRESS;Database=ShopGiayDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public void SeedData()
        {
            // Sửa lại theo tên mới: LoaiGiays -> Categories
            if (!Category.Any())
            {
                Category.Add(new Category { category_name = "Sneaker" });
                SaveChanges();
            }
        }
    }
}