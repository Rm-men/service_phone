using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Product //+
    {
        public uint Id_product { get; set; }

        [Required] public decimal Price { get; set; }

        [Required] public uint Count { get; set; } 
    }
}
