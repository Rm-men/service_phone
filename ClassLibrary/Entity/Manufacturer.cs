using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClassLibrary.Entity
{
    public class Manufacturer
    {
        public string id_manufacturer { get; set; }
        [Required] [MaxLength(150)]
        public string name { get; set; }
    }
}
