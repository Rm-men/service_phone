using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class List_of_supported_models 
    {
        [MaxLength(5)] public string id_list_of_sup_models { get; set; }

        [MaxLength(25)] [Required] public string list_supmodel_name { get; set; } 

        [Required] public virtual Component Component { get; set; }
        
        [Required] public virtual Phone_model Phone_Model { get; set; } 
    }
}
