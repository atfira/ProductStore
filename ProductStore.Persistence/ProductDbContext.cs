using Microsoft.EntityFrameworkCore;
using ProductStore.Domain;

namespace ProductStore.Persistence
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options)
           : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            var categoryGuid = Guid.Parse("{EFBCE6FB-3A20-487A-8983-10DE14206AD7}");
            var productGuid = Guid.Parse("{0B832726-8ED7-46EF-8FBC-39C5904D7F5D}");
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = categoryGuid,
                Name = "Detectors and Sensors"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = productGuid,
                Name = "Resideo RCHW3610WF1001/N Wi-Fi Water Leak Detector",
                Desciption = "At the first signs of leaks, freezes, or excess humidity, the Wi-Fi Water Leak & Freeze Detector can alert your smartphone.\r\nNotification includes mobile & audible alerts – messages can alert you or your family/friends wherever you are, while audible alerts sound when you are at home.\r\nConnects to standard Home Wi-Fi directly – no need for an extra hub.\r\nTemperature & humidity sensing – Detect low temperatures that can lead to frozen pipes, and humidity that could damage valuables.",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51xitGzq7pL.__AC_SX300_SY300_QL70_FMwebp_.jpg",
                CategoryId = categoryGuid
            });

        }
    }

}