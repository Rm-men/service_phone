using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    public class Supply
    {
        public ulong id_supply { get; set; }

        //private string supply_date { get; set; }
        public double supply_price { get; set; }
        public string supply_descr { get; set; }
    }
}
