using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC_Eshop.Models
{
    public class UserAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AddressId { get; set; }

        public virtual Address Address { get; set; }
        public virtual User User { get; set; }
    }
}
