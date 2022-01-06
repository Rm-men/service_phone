using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supplier //+
    {
        [MaxLength(25)]
        public string id_supplier { get; set; }
        [Required]
        [MaxLength(25)]
        public string name { get; set; }
        [Required]
        public string adress { get; set; }
    }
}
