using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_Wholesale_warehouse.Data;
using BD_Wholesale_warehouse.Models;

namespace BD_Wholesale_warehouse.Pages.ZP.Zaprosy
{
    public class Zakazy : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Zakazy(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get; set; }
        public IList<Product> Product { get; set; }
        public IList<Suppliers> Suppliers { get; set; }
        public IList<Staff> Staff { get; set; }
        public IList<Warehouse> Warehouse { get; set; }
        public async Task OnGetAsync()
        {
            Customers = await _context.Customers.ToListAsync();
            Product = await _context.Product.ToListAsync();
            Suppliers = await _context.Suppliers.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
            Warehouse = await _context.Warehouse.ToListAsync();
        }
    }
}
