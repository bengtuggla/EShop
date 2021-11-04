using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC_Eshop.Models
{
    public class Address
    {

        public int Id { get; set; }
        public string AddressLine { get; set; }
        public short? HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<UserAddress> UserAddresses { get; set; }
    }
}
