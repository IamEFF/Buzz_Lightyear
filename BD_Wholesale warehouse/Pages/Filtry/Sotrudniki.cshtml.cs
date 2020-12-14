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
    public class Sotrudniki : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public Sotrudniki(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }
        public Positions Positions { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Positions = await _context.Positions.FirstOrDefaultAsync(m => m.ID == id);

            if (Positions == null)
            {
                return NotFound();
            }
            Staff = await _context.Staff.Where(m => m.PositionID == Positions.ID).ToListAsync();
            return Page();
        }
    }
}
