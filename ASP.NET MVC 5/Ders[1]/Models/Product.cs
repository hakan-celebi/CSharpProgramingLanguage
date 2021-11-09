using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ders_1_.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Pay { get; set; }
        public int CategoryID { get; set; }
        [DisplayFormat(DataFormatString = "{0: dd.MM.yyyy}")]
        public DateTime CreatedDate { get; set; }
        public virtual Category Category { get; set; }
    }
}