using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClassLibrary;


#nullable disable

namespace TestConection
{
    public partial class sopctContext : DbContext
    {
        class Program
        {
            static void Main(string[] args)
            {
                using (sopctContext db = new sopctContext())
                {
                    // получаем объекты из бд и выводим на консоль
                    var users = db.Clients.ToList();
                    Console.WriteLine("Список объектов:");
                    foreach (Client c in users)
                    {
                        Console.WriteLine($"{c.Name}");
                    }
                }
                Console.ReadKey();
            }
        }
        public sopctContext()
        {

        }

        public sopctContext(DbContextOptions<sopctContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Component> Components { get; set; }
        public virtual DbSet<EmployeeOfCompany> EmployeeOfCompanies { get; set; }
        public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
        public virtual DbSet<Guarantee> Guarantees { get; set; }
        public virtual DbSet<ListOfSupportedModel> ListOfSupportedModels { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDelivery> OrderDeliveries { get; set; }
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; }
        public virtual DbSet<Phone> Phones { get; set; }
        public virtual DbSet<PhoneModel> PhoneModels { get; set; }
        public virtual DbSet<PositionInOrder> PositionInOrders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<PushareAgreement> PushareAgreements { get; set; }
        public virtual DbSet<Shop> Shops { get; set; }
        public virtual DbSet<SuppliedProduct> SuppliedProducts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sopct;Username=postgres;Password=123");
            }
        }


        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
