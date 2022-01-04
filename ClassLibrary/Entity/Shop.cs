using System;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
  
    public class Shop
    {
        [MaxLength(35)]
        public string name_store { get; set; }
        [Required] public string address { get; set; }
    }

    
}
