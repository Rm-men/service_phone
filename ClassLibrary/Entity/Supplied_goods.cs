using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supplied_goods //+
    {
        [MaxLength(25)]
        public string id_supplied_goods { get; set; }
        [MaxLength(35)]
        [Required]
        public string name_store { get; set; }
        [Required]
        public uint id_supply  { get; set; }
    }
}
