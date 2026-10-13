using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practical6.Models
{
    public class Product
    {

        public int ProductId { get; set; } = 0;
        public string Name { get; set; }
        public string Description { get; set; }
        public  int Price { get; set; }
        public string Category { get; set; }
        public string Img { get; set; }

    }
}