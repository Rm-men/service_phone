using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class EmployeeOfCompany
    {
        public EmployeeOfCompany()
        {
            OrderDeliveries = new HashSet<OrderDelivery>();
            SupplyOrders = new HashSet<SupplyOrder>();
        }

        public string IdEmployee { get; set; }
        public string IdEmploymentContract { get; set; }
        public decimal PassportSerial { get; set; }
        public decimal PassportNubmer { get; set; }
        public string Adres { get; set; }
        public string IdEmployeeType { get; set; }
        public string EmpPhoneNumber { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string NameStore { get; set; }
        public string EmpFamily { get; set; }
        public string EmpName { get; set; }
        public string EmpPatronymic { get; set; }
        public string EmpLogin { get; set; }
        public string EmpPassword { get; set; }

        public virtual EmployeeType IdEmployeeTypeNavigation { get; set; }
        public virtual Shop NameStoreNavigation { get; set; }
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        public virtual ICollection<SupplyOrder> SupplyOrders { get; set; }
    }
}
