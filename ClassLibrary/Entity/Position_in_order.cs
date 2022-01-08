using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Position_in_order
    {
        
        public uint id_position { get; set; } 

        [Required] public virtual Pushare_agreement Pushare_Agreement{ get; set; } 

        [Required] public virtual Product Product { get; set; } 

        [Required] public uint count_staf { get; set; } 

    }
}
