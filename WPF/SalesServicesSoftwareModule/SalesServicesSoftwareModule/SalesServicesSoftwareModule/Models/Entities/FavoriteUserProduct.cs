using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class FavoriteUserProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateOfAdd { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
