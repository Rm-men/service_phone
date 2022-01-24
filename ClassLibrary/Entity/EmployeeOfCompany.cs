using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace ClassLibrary
{
    public partial class EmployeeOfCompany
    {
        private static ApplicationContext db = Context.Db2;

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
        public string PhoneNumber { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public string NameStore { get; set; }
        public string Family { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public virtual EmployeeType IdEmployeeTypeNavigation { get; set; }
        public virtual Shop NameStoreNavigation { get; set; }
        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
        public virtual ICollection<SupplyOrder> SupplyOrders { get; set; }


        public static EmployeeOfCompany GetEmployee(string Login, string Password)
        {
            return db.EmployeeOfCompanies.Where(a => a.Login == Login && a.Password == Password).FirstOrDefault();
        }

    }
}
