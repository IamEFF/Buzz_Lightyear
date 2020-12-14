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
    public class Postavwiki : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Postavwiki(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Suppliers> Suppliers { get; set; }
        public Suppliers Suppliers1 { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Suppliers1 = await _context.Suppliers.FirstOrDefaultAsync(m => m.ID == id);

            if (Suppliers1 == null)
            {
                return NotFound();
            }
            Suppliers = await _context.Suppliers.Where(m => m.SupplierID == Suppliers1.ID).ToListAsync();
          
            return Page();
        }
    }
}
