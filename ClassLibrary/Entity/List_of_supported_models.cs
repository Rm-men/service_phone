using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    class List_of_supported_models //+
    {
        [MaxLength(5)]
        public string id_list_of_sup_models { get; set; }
        [MaxLength(25)]
        public string list_supmodel_name { get; set; } 
        [MaxLength(25)]
        public string id_component { get; set; }
        [MaxLength(25)]
        public string id_phone_model { get; set; } 
    }
}
