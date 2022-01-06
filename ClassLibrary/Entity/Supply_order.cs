using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Supply_order
    {
        public uint id_supply_order { get; set; }

        [Required] public DateTime date_supl_order { get; set; }

        [Required] public virtual Employee_of_company Employee_Of_Company { get; set; }

    }
}
