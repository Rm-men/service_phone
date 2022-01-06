using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    class List_of_goods //+
    {
        [MaxLength(15)]
        public string id_list_of_goods { get; set; }
        [MaxLength(25)][Required]
        public string id_goods { get; set; } 
    }
}
