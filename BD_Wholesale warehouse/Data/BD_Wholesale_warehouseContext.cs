using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_Wholesale_warehouse.Models;

namespace BD_Wholesale_warehouse.Data
{
    public class BD_Wholesale_warehouseContext : DbContext
    {
        public BD_Wholesale_warehouseContext (DbContextOptions<BD_Wholesale_warehouseContext> options)
            : base(options)
        {
        }

        public DbSet<BD_Wholesale_warehouse.Models.Staff> Staff { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Customers> Customers { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Product> Product { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Positions> Positions { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Product_type> Product_type { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Suppliers> Suppliers { get; set; }

        public DbSet<BD_Wholesale_warehouse.Models.Warehouse> Warehouse { get; set; }
    }
}
