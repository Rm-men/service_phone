﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Guarantee
    {
        [MaxLength(10)]
        public string id_guarantee { get; set; }
        public int guarantee_period_on_in_month { get; set; }
        public string garranty_conditions { get; set; }
        public static void Add()
        {

        }
    }
}
