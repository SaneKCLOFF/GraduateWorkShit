using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models.Entities
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int CountInStock { get; set; }
        public int Discount { get; set; }
        public DateTime DateOfAdd { get; set; }
    }
}
