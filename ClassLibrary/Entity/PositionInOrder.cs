using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class PositionInOrder
    {
        public string IdPosition { get; set; }
        public int IdPushareAgreement { get; set; }
        public int? IdProduct { get; set; }
        public int? CountStaf { get; set; }

        public virtual PushareAgreement IdPushareAgreementNavigation { get; set; }
    }
}
