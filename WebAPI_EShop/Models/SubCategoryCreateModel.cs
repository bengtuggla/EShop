using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_EShop.Models
{
    public class SubCategoryCreateModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
