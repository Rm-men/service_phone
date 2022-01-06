using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supply //+
    {
        public uint id_supply { get; set; } 
        [Required]
        public uint id_supply_order { get; set; }  
        [Required][MaxLength(15)]
        public string id_supplier { get; set; }  
        [Required]
        public DateTime date_supply { get; set; } 
        [Required]
        public double price_supply { get; set; } 
        public string description_supply { get; set; } 
    }
}
