using System;
using System.Collections.Generic;

#nullable disable

namespace ClassLibrary
{
    public partial class Product
    {
        public Product()
        {
            Components = new HashSet<Component>();
            PhoneModels = new HashSet<PhoneModel>();
            PositionInOrders = new HashSet<PositionInOrder>();
            SuppliedProducts = new HashSet<SuppliedProduct>();
        }

        public int IdProduct { get; set; }
        public decimal Price { get; set; }
        public int? Сounts { get; set; }

        public virtual ICollection<Component> Components { get; set; }
        public virtual ICollection<PhoneModel> PhoneModels { get; set; }
        public virtual ICollection<PositionInOrder> PositionInOrders { get; set; }
        public virtual ICollection<SuppliedProduct> SuppliedProducts { get; set; }
    }
}
