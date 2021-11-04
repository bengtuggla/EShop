using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC_Eshop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public DateTimeOffset OrderDate { get; set; }
        public string OurReference { get; set; }
        public string Status { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
