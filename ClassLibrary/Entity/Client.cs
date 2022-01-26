﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class Client : A_Human
    {
        public Client()
        {
            Orders = new HashSet<Order>();
            PushareAgreements = new HashSet<PushareAgreement>();
        }

        public int IdClient { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<PushareAgreement> PushareAgreements { get; set; }
    }
}
