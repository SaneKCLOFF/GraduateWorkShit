using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesServicesSoftwareModule.Models.Entities
{
    internal class User
    {
        public int UserId { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; }= null!;
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfRegister { get; set; }
        public int CountOfPurchases { get; set; }
        public int CountOfServices { get; set; }
    }
}
