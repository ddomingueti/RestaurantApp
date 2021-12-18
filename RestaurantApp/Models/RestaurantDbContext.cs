using Microsoft.EntityFrameworkCore;
using RestaurantApp.Models;

namespace RestaurantApp.Models
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base (options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<ClientUser> ClientUsers { get; set; }
        public DbSet<User> UserList { get; set; }

    }
}
