using System;
using System.Collections.Generic;

namespace SalesServicesSoftwareModule.Models.Entities
{
    public partial class User
    {
        public User()
        {
            FavoriteUserProducts = new HashSet<FavoriteUserProduct>();
            UserProducts = new HashSet<UserProduct>();
            UserServices = new HashSet<UserService>();
        }

        public int Id { get; set; }
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime DateOfRegister { get; set; }
        public int NumberOfPurchases { get; set; }
        public int NumberOfServices { get; set; }

        public virtual Role Role { get; set; } = null!;
        public virtual ICollection<FavoriteUserProduct> FavoriteUserProducts { get; set; }
        public virtual ICollection<UserProduct> UserProducts { get; set; }
        public virtual ICollection<UserService> UserServices { get; set; }
    }
}
