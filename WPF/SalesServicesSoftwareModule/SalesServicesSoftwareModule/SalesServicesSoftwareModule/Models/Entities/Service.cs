using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models.Entities
{
    internal class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal CostPerHour { get; set; }
        public DateTime DateOfAdd { get; set; }
    }
}
