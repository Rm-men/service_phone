using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary.Entity
{
    public class Client
    {

        public uint id_client { get; set; }
        [Required] [MaxLength(25)] public string name { get; set; }
        [Required] [MaxLength(45)] public string family { get; set; }
        [MaxLength(45)] public string patronomic { get; set; }
        [Required] [MaxLength(15)] public string phone { get; set; }
        [Required] [MaxLength(255)] public string email { get; set; }

        public static void Add_order()
        {

        }
        public static void Pay_order()
        {

        }
        public static void Get_fio()
        {

        }

    }
}
