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
    { //------------название класса\таблицы+ то же саоме
        public DbSet<Client> Clients { get; set; }
        public DbSet<Component> Components{ get; set; }
        public DbSet<Employee_of_company> Employee_Of_Companies { get; set; }
        public DbSet<Employye_type> Employye_Types { get; set; }
        public DbSet<Guarantee> Guarantees { get; set; }
        public DbSet<List_of_goods> List_Of_Goods { get; set; }
        public DbSet<List_of_supported_models> List_Of_Supported_Models { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Order_delivery> Order_Deliveries { get; set; }
        public DbSet<Order_status> Order_Statuses { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Phone_model> Phone_Models { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Position_in_check> Position_In_Checks { get; set; }
        public DbSet<Pushare_agreement> Pushare_Agreements { get; set; }
        public DbSet<Responsible_of_employee> Responsible_Of_Employees { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Supplied_goods> Supplied_Goods { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Supply> Supply_es { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //подключение к бд, указать свое
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=sale_phones;Username=postgres;Password=123");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //местные кнострейнты
            modelBuilder.Entity<Client>().HasIndex(s => s.client_phone).IsUnique();
        }
    }
}

    
