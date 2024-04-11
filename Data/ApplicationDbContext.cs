using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore; 
using newINTEX.Models;
using System.Data;

namespace newINTEX.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<LineItem> LineItems => Set<LineItem>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductRecommendation> ProductRecommendations => Set<ProductRecommendation>();
        public DbSet<CustomerRecommendation> CustomerRecommendations => Set<CustomerRecommendation>();
    }
}
