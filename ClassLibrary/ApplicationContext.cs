using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassLibrary.Entity;


namespace ClassLibrary
{
    class ApplicationContext : DbContext
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
        public DbSet<Supplied_goods> Supplied_Goods { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supplys { get; set; }
        public DbSet<Supply_order> Supply_Orders { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sale_phones;Username=postgres;Password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Не забыть прописать
            modelBuilder.Entity<Client>().HasIndex(p => p.phone).IsUnique();
            modelBuilder.Entity<Client>().HasIndex(p => p.email).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_password).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_login).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.id_employment_contract).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.passport_nubmer).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.passport_serial).IsUnique();
            modelBuilder.Entity<Employee_of_company>().HasIndex(p => p.emp_phone_number).IsUnique();
            modelBuilder.Entity<Manufacturer>().HasIndex(p => p.name).IsUnique();

        }
        public static DbContextOptions<ApplicationContext> GetDb()
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            return optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sale_phones;Username=postgres;Password=123").Options;
        }
    }
}

 
