using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Phone
    {
        [MaxLength(17)] public string imei { get; set; }

        [Required] public virtual Phone_model Phone_Model { get; set; }
    }
}
