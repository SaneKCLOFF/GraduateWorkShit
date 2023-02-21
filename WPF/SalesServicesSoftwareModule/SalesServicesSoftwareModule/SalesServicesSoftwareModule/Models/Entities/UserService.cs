using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class UserService
    {
        public int Id { get; set; }
        public int? ServiceId { get; set; }
        public int? UserId { get; set; }
        public DateTime DateOfOrder { get; set; }
        public int StatusId { get; set; }
        public DateTime? DateOfCompletion { get; set; }

        public virtual Service? Service { get; set; }
        public virtual Status Status { get; set; } = null!;
        public virtual User? User { get; set; }
    }
}
