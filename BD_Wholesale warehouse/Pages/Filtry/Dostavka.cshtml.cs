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
    public class Dostavka : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Dostavka(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Warehouse> Warehouse { get; set; }
        public Warehouse Warehouse3 { get; set; }
        public async Task<IActionResult> OnGetAsync(string? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Warehouse3 = await _context.Warehouse.FirstOrDefaultAsync(m => m.Delivery_method == id);

            if (Warehouse3 == null)
            {
                return NotFound();
            }
            Warehouse = await _context.Warehouse.Where(m => m.Delivery_method == Warehouse3.Delivery_method).ToListAsync();
            return Page();
        }
    }
}
