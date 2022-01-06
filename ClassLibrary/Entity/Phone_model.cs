using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Phone_model //+
    {
        [MaxLength(25)]
        public string id_phone_model { get; set; }
        [Required][MaxLength(35)]
        public string name_model { get; set; }
        [Required]
        public string specifications { get; set; }
        public double price_phone_model { get; set; } //ДЕНЬГИ,ДЕНЬГИ
        [MaxLength(15)]
        public string guarantee_phone_model { get; set; }
        [Required]
        [MaxLength(25)]
        public string manufacturer { get; set; }
    }
}
