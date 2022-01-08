using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supplied_product
    {
        //[Required]
        public virtual Shop Shop { get; set; }
        
        //[Required] 
        public virtual Supply Supply { get; set; }
        //[Required]
        public virtual Product Product { get; set; } 

        [Required] public uint Count { get; set; }

        [Required] public decimal Price { get; set; } 

    }
}
