using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BD_Wholesale_warehouse.Pages.ZP
{
    public class IndexModel : PageModel
    {
        private readonly BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext _context;

        public IndexModel(BD_Wholesale_warehouse.Data.BD_Wholesale_warehouseContext context)
        {
            _context = context;
        }
        public List<SelectListItem> Staff2 { get; set; }
        public List<SelectListItem> ProductType { get; set; }
        public List<SelectListItem> Postavwiki1 { get; set; }
        public List<SelectListItem> Zakaz4iki1 { get; set; }
        public List<SelectListItem> Dostavka1 { get; set; }

        public IActionResult OnGet()
        {
            Staff2 = _context.Positions.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Job_title
            }).ToList();

            ProductType = _context.Product_type.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name
            }).ToList();

            Postavwiki1 = _context.Suppliers.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name
            }).ToList();

            Zakaz4iki1 = _context.Customers.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name
            }).ToList();

            Dostavka1 = _context.Warehouse.Select(p =>
            new SelectListItem
            {
                Value = p.Delivery_method.ToString(),
                Text = p.ProductID.ToString()
            }).ToList();

            return Page();
        }

    }
}