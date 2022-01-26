using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class Component
    {
        public Component()
        {
            ListOfSupportedModels = new HashSet<ListOfSupportedModel>();
        }

        public string IdComponent { get; set; }
        public string TypeC { get; set; }
        public int? Сounts { get; set; }
        public string Name { get; set; }
        public string IdGuarantee { get; set; }
        public string Manufacturer { get; set; }
        public int? IdProduct { get; set; }

        public virtual Guarantee IdGuaranteeNavigation { get; set; }
        public virtual Manufacturer ManufacturerNavigation { get; set; }
        public virtual ICollection<ListOfSupportedModel> ListOfSupportedModels { get; set; }
    }
}
