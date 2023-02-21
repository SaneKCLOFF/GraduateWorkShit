using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class Product
    {
        public Product()
        {
            FavoriteUserProducts = new HashSet<FavoriteUserProduct>();
            UserProducts = new HashSet<UserProduct>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Picture { get; set; } = null!;
        public string? Description { get; set; }
        public decimal Cost { get; set; }
        public int CountInStock { get; set; }
        public int Discount { get; set; }
        public DateTime DateOfAdd { get; set; }

        public virtual ProductCategory? Category { get; set; }
        public virtual ICollection<FavoriteUserProduct> FavoriteUserProducts { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
    }
}
