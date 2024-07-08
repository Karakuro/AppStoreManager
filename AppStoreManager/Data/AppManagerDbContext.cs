using AppStoreManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppStoreManager.Data
{
    public class AppManagerDbContext(DbContextOptions<AppManagerDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Category> categories = new List<Category>()
            {
                new Category() { CategoryId = 1, Name = "Game" },
                new Category() { CategoryId = 2, Name = "Social" },
                new Category() { CategoryId = 3, Name = "Messaging" }
            };

            modelBuilder.Entity<Category>().HasData(categories);

            List<AppCatalogue> apps = new List<AppCatalogue>()
            {
                new AppCatalogue() { AppCatalogueId = 1, CategoryId = 1, Title = "Clash of Clans", Description = "Brutto", Price = 0 },
                new AppCatalogue() { AppCatalogueId = 2, CategoryId = 1, Title = "Minecraft", Description = "Bello", Price = 6.50 },
                new AppCatalogue() { AppCatalogueId = 3, CategoryId = 2, Title = "Instagram", Description = "Vecchio", Price = 0 },
                new AppCatalogue() { AppCatalogueId = 4, CategoryId = 2, Title = "TikTok", Description = "Nuovo", Price = 0 },
                new AppCatalogue() { AppCatalogueId = 5, CategoryId = 3, Title = "Whatsapp", Description = "Vecchissimo", Price = 0 },
                new AppCatalogue() { AppCatalogueId = 6, CategoryId = 3, Title = "Telegram", Description = "Russo", Price = 0 }
            };
            modelBuilder.Entity<AppCatalogue>().HasData(apps);
        }

        public DbSet<StoreUser> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppCatalogue> AppCatalogues { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PayMethod> PayMethods { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
