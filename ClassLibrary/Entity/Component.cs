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
        [MaxLength(25)] public string Id_component { get; set; }

        [Required] [MaxLength(20)] public string Type_c { get; set; }

        [Required] public uint Counts { get; set; }

        [Required] [MaxLength(40)]  public string Name { get; set; }

        public virtual Guarantee Guarantee { get; set; }

        [Required] public virtual Manufacturer Manufacturer { get; set; }

        [Required] public virtual Product Product { get; set; }

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
