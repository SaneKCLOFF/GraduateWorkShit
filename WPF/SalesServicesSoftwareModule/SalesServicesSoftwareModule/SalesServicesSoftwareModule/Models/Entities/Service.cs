using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class Service
    {
        public Service()
        {
            UserServices = new HashSet<UserService>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public decimal CostPerHour { get; set; }
        public DateTime DateOfAdd { get; set; }

        public virtual ICollection<UserService> UserServices { get; set; }
    }
}
