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
    public class SpisokPostavwikov : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public SpisokPostavwikov(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Suppliers> Suppliers { get; set; }
        public IList<Product> Product { get; set; }
        public async Task OnGetAsync()
        {
            Suppliers = await _context.Suppliers.ToListAsync();
            Product = await _context.Product.ToListAsync();
        }
    }
}
