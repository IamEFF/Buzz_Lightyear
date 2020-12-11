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
    public class SpisokTovarov : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public SpisokTovarov(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }
        public IList<Product_type> Product_type { get; set; }
        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
            Product_type = await _context.Product_type.ToListAsync();
        }
    }
}
