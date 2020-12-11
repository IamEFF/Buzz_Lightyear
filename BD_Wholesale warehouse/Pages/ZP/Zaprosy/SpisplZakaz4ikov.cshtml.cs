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
    public class SpisplZakaz4ikov : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public SpisplZakaz4ikov(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get; set; }
        public IList<Product> Product { get; set; }
        public async Task OnGetAsync()
        {
            Customers = await _context.Customers.ToListAsync();
            Product = await _context.Product.ToListAsync();
        }
    }
}
