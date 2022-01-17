

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Entity;


namespace ClassLibrary
{
    public class ApplicationContext : DbContext
    { 
        public DbSet<Client> Clients { get; set; }
        public DbSet<Component> Components{ get; set; }
        public DbSet<Employee_of_company> Employee_Of_Companies { get; set; }
        public DbSet<Employye_type> Employye_Types { get; set; }
        public DbSet<Guarantee> Guarantees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<List_of_supported_models> List_Of_Supported_Models { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Order_delivery> Order_Deliveries { get; set; }
        public DbSet<Order_status> Order_Statuses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Phone_model> Phone_Models { get; set; }
        public DbSet<Position_in_order> Position_In_Order { get; set; }
        public DbSet<Pushare_agreement> Pushare_Agreements { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Supplied_product> Supplied_products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supplys { get; set; }
        public DbSet<Supply_order> Supply_Orders { get; set; }
        public ApplicationContext()
        {
            //Database.EnsureCreated();
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Не забыть прописать
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_password).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_login).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.id_employment_contract).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.passport_nubmer).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.passport_serial).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_phone_number).IsUnique();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                //string consting = ConfigurationManager.AppSettings["ConnectionString"];
                //optionsBuilder.UseNpgsql(""+consting);
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sopct;Username=postgres;Password=123");
                optionsBuilder.EnableSensitiveDataLogging();
                optionsBuilder.UseLazyLoadingProxies();
                //Add-Migration Init - инициализация миграций
                //Remove-Migration
                //Update-Database - применение миграций
                //scaffold - dbcontext "host=localhost;port=5432;database=sopct;username=postgres;password=123" npgsql.entityframeworkcore.postgresql
                // - tables "author", "book", "author_book"
                // npgsql.entityframeworkcore.postgresql
            }

        }

        public static DbContextOptions<ApplicationContext> GetDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sopct;Username=postgres;Password=123").Options;
        }
    }
}


