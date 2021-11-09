using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ders_1_.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        
    }
}