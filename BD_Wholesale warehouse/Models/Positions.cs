using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Wholesale_warehouse.Models
{
    public class Positions
    {
         public long ID { get; set; }

         [Display(Name = "Код должности")]
         public long PositionID { get; set; }

         [Display(Name ="Наименование должности")]
         public string Job_title { get; set; }

        [Display(Name = "Оклад")]
         public int Salary { get; set; }
        [Display(Name ="Обязанности")]

        public string Duties { get; set; }
        [Display(Name ="Требования")]
        public string Demands { get; set; }
    }
}
