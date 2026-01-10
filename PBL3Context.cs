using Microsoft.EntityFrameworkCore;
using System.Linq; // Thêm cái này để dùng được hàm .Any()

namespace PBL3_Project
{
    public class PBL3Context : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<UserAccount> UserAccount { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ShopGiayDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public void SeedData()
        {
            if (!Category.Any())
            {
                Category.Add(new Category { category_name = "Sneaker" });
                SaveChanges();
            }
        }
    }
}