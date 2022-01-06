using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{

    public class Component 
    {
        [MaxLength(25)] public string id_component { get; set; }

        [Required] [MaxLength(20)] public string type_c { get; set; }

        [Required] public uint сounts { get; set; }

        [Required]  public decimal price_c { get; set; } 

        [Required] [MaxLength(40)]  public string name { get; set; }

        public virtual Guarantee Guarantee { get; set; }

        [Required] public virtual Manufacturer Manufacturer { get; set; }

        public static void Add()
        {

        }
        public static void Delete()
        {

        }
        public static void Move()
        {

        }
        public static void Info()
        {

        }
    }
}
