using Microsoft.EntityFrameworkCore;
using SalesServicesSoftwareModule.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models
{
    internal class AppDbContext : DbContext
    {
        private const string ConnectionString
            = @"Server=LOCALHOST\SQLEXPRESS; Database=SalesServicesDataBase; Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(ConnectionString);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public  DbSet<User> Users { get; set; }
        public DbSet<UserFavoriteProduct> UserFavoriteProducts { get; set; }
        public DbSet<UserProductOrder> UserProductOrders { get; set; }
        public DbSet<UserServiceOrder> UserServiceOrders { get; set; }
    }
}
