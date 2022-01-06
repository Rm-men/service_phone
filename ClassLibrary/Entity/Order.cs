using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Order  
    {
        public uint id_order { get; set; }

        [Required] 
        public DateTime order_date { get; set; }

        [Required]
        public string phone_number { get; set; }

        [MaxLength(255)]
        public string address { get; set; }

        [Required]
        public virtual Client Client { get; set; }

        [Required]
        public virtual Order_status Order_status { get; set; }

        public void GetInfo()
        {

        }

    }
}
