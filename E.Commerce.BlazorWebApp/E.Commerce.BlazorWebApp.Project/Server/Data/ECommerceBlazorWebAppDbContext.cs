using Microsoft.EntityFrameworkCore;
using E.Commerce.BlazorWebApp.Project.Shared.Models;

namespace E.Commerce.BlazorWebApp.Project.Server.Data
{
    public class ECommerceBlazorWebAppDbContext : DbContext
    {
        public ECommerceBlazorWebAppDbContext(DbContextOptions<ECommerceBlazorWebAppDbContext> options) : base (options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
