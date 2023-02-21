using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class Status
    {
        public Status()
        {
            UserProducts = new HashSet<UserProduct>();
            UserServices = new HashSet<UserService>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<UserService> UserServices { get; set; }
    }
}
