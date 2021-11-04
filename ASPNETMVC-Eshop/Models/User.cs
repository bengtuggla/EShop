using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC_Eshop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
