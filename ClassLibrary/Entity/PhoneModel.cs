using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class PhoneModel 
    {
        public PhoneModel()
        {
            ListOfSupportedModels = new HashSet<ListOfSupportedModel>();
            Phones = new HashSet<Phone>();
        }

        public string IdPhoneModel { get; set; }
        public string NameModel { get; set; }
        public string Specifications { get; set; }
        public string GuaranteePhoneModel { get; set; }
        public string Manufacturer { get; set; }
        public int? IdProduct { get; set; }

        public virtual Guarantee GuaranteePhoneModelNavigation { get; set; }
        public virtual Manufacturer ManufacturerNavigation { get; set; }
        public virtual ICollection<ListOfSupportedModel> ListOfSupportedModels { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
