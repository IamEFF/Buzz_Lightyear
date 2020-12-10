using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Wholesale_warehouse.Models
{
    public class Product_type
    {
        public long ID { get; set; }

        [Display(Name = "Код типа товаров")]
        public long Product_type_ID { get; set; }

        
        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; } 

        [Display(Name = "Особенности")]
        public string Features { get; set; }
    }
}
