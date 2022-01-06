using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Employye_type //+
    {
        [MaxLength(15)]
        public string id_employee_type { get; set; }
        public string responsible_description { get; set; }

    }
}
