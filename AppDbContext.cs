using Microsoft.EntityFrameworkCore;
using StoreManagmentSystem.Data.Models;

namespace StoreManagmentSystem.Data
{
    public class AppDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("DataSource=Main.db");
       public DbSet<Client> Klientet { get; set; }
       public DbSet<Product> Produktet { get; set; }

    }
}