using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_Wholesale_warehouse.Data;
using BD_Wholesale_warehouse.Models;

namespace BD_Wholesale_warehouse.Pages.Product1
{
    public class IndexModel : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public IndexModel(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }
        public IList<Product_type> Product_type { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
            Product_type = await _context.Product_type.ToListAsync();
        }
    }
}
