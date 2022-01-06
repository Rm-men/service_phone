using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Order_status 
    {
        [MaxLength (10)]
        public string id_order_status { get; set; }
        [Required]  public string description_order_status { get; set; }
    }
}
