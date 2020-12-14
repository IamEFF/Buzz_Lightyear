using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_Wholesale_warehouse.Data;
using BD_Wholesale_warehouse.Models;

namespace BD_Wholesale_warehouse.Pages.Filtry
{
    public class Tip_tovara : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Tip_tovara(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }
        public Product_type Product_Type { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Product_Type = await _context.Product_type.FirstOrDefaultAsync(m => m.ID == id);

            if (Product_Type == null)
            {
                return NotFound();
            }
            Product = await _context.Product.Where(m => m.Product_typeID == Product_Type.ID).ToListAsync();
            return Page();
        }
    }
}
