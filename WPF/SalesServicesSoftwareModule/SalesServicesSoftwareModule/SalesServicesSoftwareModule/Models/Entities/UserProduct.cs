using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class UserProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime? DateOfCompletion { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Status Status { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
