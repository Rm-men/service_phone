using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supplied_goods
    {
        [MaxLength(25)] public string id_supplied_goods { get; set; }

        [Required] public virtual Shop Shop { get; set; }
        
        [Required] public virtual Supply Supply { get; set; }
    }
}
