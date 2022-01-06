using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Pushare_agreement 
    {
        public uint id_pushare_agreement { get; set; }

        [Required] public virtual Shop name_store { get; set; }

        [Required] public virtual Client Client { get; set; }

        [Required] public decimal All_cost { get; set; } 

        [Required] public DateTime Pushare_agreement_date { get; set; }

        [Required] public virtual Order Order { get; set; }

        [Required] public bool paid { get; set; }

    }
}
