using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETMVC_Eshop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<SubCategory> SubCategories { get; set; }
    }
}
