using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ClassLibrary.Entity
{
    public class Order_delivery
    {
        public uint id_order_delivery { get; set; }

        [Required] public DateTime time_delivery_start { get; set; }

        [Required] public DateTime time_delivery_compleate { get; set; }

        [Required] public virtual Order Order { get; set; }

        [Required] public virtual Employee_of_company Employee_Of_Company { get; set; }
    }
}
