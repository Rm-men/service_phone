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
        [MaxLength(25)]
        public string id_position { get; set; } 
        [Required]
        public int id_pushare_agreement { get; set; } 
        [MaxLength(15)][Required]
        public string id_list_of_goods { get; set; } 
        [Required]
        public uint count_staf { get; set; } 

    }
}
