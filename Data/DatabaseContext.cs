using Microsoft.EntityFrameworkCore;
using Team_Mars_Backend.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Mars_Backend.Data_Admin.Entity_Admin;

namespace Team_Mars_Backend.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<VendorTable> vendorDetails { get; set; }
        public DbSet<AdminTable> adminDetails { get; set; }
        public DbSet<FuelTable> fuelDetails { get; set; }
        public DbSet<Order> orderDetails { get; set; }
    }
}
