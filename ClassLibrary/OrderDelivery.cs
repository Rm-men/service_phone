using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class OrderDelivery
    {
        public int IdOrderDelivery { get; set; }
        public DateTime TimeDeliveryStart { get; set; }
        public DateTime? TimeDeliveryCompleate { get; set; }
        public int? IdOrder { get; set; }
        public string IdEmployee { get; set; }

        public virtual EmployeeOfCompany IdEmployeeNavigation { get; set; }
        public virtual Order IdOrderNavigation { get; set; }
    }
}
