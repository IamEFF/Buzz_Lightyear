﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Wholesale_warehouse.Models
{
    public class Customers
    {
        public long ID { get; set; }

        [Display(Name = "Код заказчика")]
        public long CustomerID { get; set; }

        [Display(Name = "Наименование")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        public string Addres { get; set; }

        [Display(Name = "Телефон")]
        public int Phone_number { get; set; }

        [Display(Name = "Потребляемый товар 1")]
        public DbSet<Product> Product_ID1 { get; set; }

        [Display(Name = "Код потребляемого товара 1")]
        public long ProductID1 { get; set; }

        [Display(Name = "Потребляемый товар 2")]
        public DbSet<Product> Product_ID2 { get; set; }

        [Display(Name = "Код потребляемого товара 2")]
        public long ProductID2 { get; set; }

        [Display(Name = "Потребляемый товар 3")]
        public DbSet<Product> Product_ID3 { get; set; }

        [Display(Name = "Код потребляемого товара 3")]
        public long ProductID3 { get; set; }
    }
}
