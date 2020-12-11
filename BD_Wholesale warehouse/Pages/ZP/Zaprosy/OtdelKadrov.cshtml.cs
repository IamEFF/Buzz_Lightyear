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
    public class OtdelKadrov : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public OtdelKadrov(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }
        public IList<Positions> Positions { get; set; }
        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            Positions = await _context.Positions.ToListAsync();
        }
    }
}
