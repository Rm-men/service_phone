using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Phone //+
    {
        [MaxLength(17)]
        public string imei { get; set; }
        [MaxLength(25)][Required]
        public string id_phone_model { get; set; }
    }
}
