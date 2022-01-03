using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entity
{
    class List_of_supported_models
    {
        public ICollection<Phone_model> Phone_models { get; set; } //это многие ко многим?
    }
}
