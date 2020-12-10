using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BD_Wholesale_warehouse.Models
{
    public class Warehouse
    {
        public long ID { get; set; }

        [Display(Name = "Дата поступления")]
        public DateTime Receipt_date { get; set; }

        [Display(Name = "Дата заказа")]
        public DateTime Order_date { get; set; }

        [Display(Name = "Дата отправки")]
        public DateTime Departure_date { get; set; }

        [Display(Name = "Товар")]
        public DbSet<Product> Product_ID { get; set; }
        [Display(Name = "Код товара")]
        public long ProductID { get; set; }

        [Display(Name = "Поставщик")]
        public DbSet<Suppliers> Supplier_ID { get; set; }
        [Display(Name = "Код поставщика")]
        public long SupplierID { get; set; }

        [Display(Name = "Заказчик")]
        public DbSet<Customers> Customer_ID { get; set; }
        [Display(Name = "Код заказчика")]
        public long CustomerID { get; set; }

        [Display(Name = "Способ доставки")]
        public string Delivery_method { get; set; }

        [Display(Name = "Объем")]
        public int Volume { get; set; }

        [Display(Name = "Цена")]
        public int Price { get; set; }

        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff_ID { get; set; }
        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }
    }
}
