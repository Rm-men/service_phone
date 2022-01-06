using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClassLibrary.Entity
{
    class Order_delivery //+
    {
        public uint id_order_delivery { get; set; }
        [Required]
        public DateTime time_delivery_start { get; set; }
        [Required]
        public DateTime time_delivery_compleate { get; set; }
        [Required]
        public uint id_order { get; set; }
        [Required]
        [MaxLength(8)]
        public string id_employee  { get; set; }
    }
}
