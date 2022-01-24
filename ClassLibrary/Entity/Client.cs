using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace ClassLibrary
{
    public partial class Client
    {
        private static ApplicationContext db = Context.Db;
        public Client()
        {
            Orders = new HashSet<Order>();
            PushareAgreements = new HashSet<PushareAgreement>();
        }

        public int IdClient { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PushareAgreement> PushareAgreements { get; set; }
        public static List<ClientInfo> GetClientInfo(string Telefon) //Клиент не связан с адресом. В листе хранится клиент с разными адресами
        {
            return (from c in db.Clients
                    where c.Phone == Telefon
                    select new ClientInfo()
                    {
                        IdClient = c.IdClient,
                        Family = c.Family,
                        Name = c.Name,
                        Patronymic = c.Patronymic,
                        Email = c.Email
                    }).ToList();
        }
        public class ClientInfo
        {
            public int IdClient { get; set; }
            public string Name { get; set; }
            public string Family { get; set; }
            public string Patronymic { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }
    }
}
