using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EShop.Models
{
    public class UserCreateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
      /*  public string AddressLine { get; set; }
        public short HouseNr { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }*/


    }
}
