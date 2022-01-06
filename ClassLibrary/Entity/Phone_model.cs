using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Phone_model 
    {
        [MaxLength(25)]  public string Id_phone_model { get; set; }

        [Required][MaxLength(35)] public string Name_model { get; set; }

        [Required] public string Specifications { get; set; }

        [Required] public decimal Price_phone_model { get; set; }

        public virtual Guarantee Guarantee { get; set; }

        [Required] public virtual Manufacturer Manufacturer { get; set; }
    }
}
