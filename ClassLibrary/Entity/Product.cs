using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class Product
    {
        public string IdProduct { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int? Counts { get; set; }
    }
}
