using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Pushare_agreement //+
    {
        public uint id_pushare_agreement { get; set; }
        [MaxLength(25)] [Required]
        public string name_store { get; set; }
        [Required]
        public uint id_client { get; set; }
        [Required]
        public double all_cost   { get; set; } //ДНЕЬГИ,ДЕНЬГИ
        [Required]
        public DateTime pushare_agreement_date { get; set; }
        [Required]
        public uint id_order  { get; set; }
        [Required]
        public bool paid { get; set; }
    }
}
