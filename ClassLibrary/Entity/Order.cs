using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    class Order_ 
    {
        public uint id_order { get; set; }
        [Required] 
        public string order_date { get; set; }
        [Required]
        public string phone_number { get; set; }
        [MaxLength(255)]
        public string address { get; set; }
        [Required]
        public uint id_client { get; set; }
        [Required]
        public string id_order_status { get; set; }


    }
}
