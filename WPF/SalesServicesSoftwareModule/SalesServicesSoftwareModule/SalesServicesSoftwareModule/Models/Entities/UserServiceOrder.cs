using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models.Entities
{
    internal class UserServiceOrder
    {
        public int UserServiceOrderId { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public DateTime DateOfOrder { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; } = null!;
        public DateTime DateOfCompletion { get; set; }
    }
}
