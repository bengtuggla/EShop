using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EShop.Models
{
    public class OrderCreateModel
    {
        public string Email { get; set; }
        public string OurReference { get; set; }
        public string Status { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }



    }
}
