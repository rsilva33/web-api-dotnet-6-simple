
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Context {
    public class ApplicationDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Product>()
                .Property(p => p.Description).HasMaxLength(500).IsRequired(false);
            builder.Entity<Product>()
                .Property(p => p.Name).HasMaxLength(120).IsRequired();
            builder.Entity<Product>()
                .Property(p => p.Code).HasMaxLength(20).IsRequired();
            builder.Entity<Category>()
                .ToTable("Categories");
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        //     => options.UseSqlServer(
        //             "Server=localhost;Database=Products;User Id=sa;Password=@Sql2019;MultipleActiveResultSets=true;Encrypt=YES;TrustServerCertificate=YES"
        //     );
    }
}
