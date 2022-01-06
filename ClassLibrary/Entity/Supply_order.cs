using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary
{
    class Supply_order //+
    {
        public uint id_supply_order { get; set; }
        public DateTime date_supl_order { get; set; }
        [MaxLength(10)]
        public string id_employee { get; set; }

    }
}
