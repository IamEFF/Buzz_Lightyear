using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Wholesale_warehouse.Models
{
    public class Product
    {
        public long ID { get; set; }

        [Display(Name = "Код товара")]
        public long Product_ID { get; set; }

        [Display(Name = "Тип товара")]
        public DbSet <Product_type> Product_type_ID { get; set; }
        [Display(Name = "Код типа товара")]
        public long Product_typeID { get; set; }
        [Display(Name = "Производитель")]
        public string Manufacturer { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Условия хранения")]
        public string Storage_conditions { get; set; }

        [Display(Name = "Упаковка")]
        public string Packaging { get; set; }

        [Display(Name = "Срок годности")]
        public DateTime Shelf_life { get; set; }

    }
}
