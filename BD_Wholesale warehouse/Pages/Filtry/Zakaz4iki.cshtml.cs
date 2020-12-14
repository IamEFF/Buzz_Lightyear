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
    public class Zakaz4iki : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Zakaz4iki(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Customers> Customers { get; set; }
        public Customers Customers1 { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Customers1 = await _context.Customers.FirstOrDefaultAsync(m => m.ID == id);

            if (Customers1 == null)
            {
                return NotFound();
            }
            Customers = await _context.Customers.Where(m => m.CustomerID == Customers1.ID).ToListAsync();

            return Page();
        }
    }
}
