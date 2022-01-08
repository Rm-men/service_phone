using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Configuration;
using System.Collections.Generic;

namespace TestConection
{
    

    class Program
    {
        public static void Add()
        {
            using (ApplicationContext ac = new ApplicationContext())
            {
                Teacher t1 = new Teacher { Name = "Дмитрий", Surname = "Первыйх", Age = 30, Subject = "Информатика" };
                Student s1 = new Student { Name = "Даниил", Surname = "Вторинский", Age = 20, Grade = 1 };
                Student s2 = new Student { Name = "Андрей", Surname = "Третьев", Age = 20, Grade = 1 };
                t1.Students.Add(s1);
                t1.Students.Add(s1);
                ac.Teachers.AddRange(t1);
                ac.SaveChanges();
            } //Dispose автоматом
        }
        public static void Read()
        {
            using (ApplicationContext ac = new ApplicationContext())
            {
                List<Teacher> teachers = ac.Teachers.ToList();
                foreach (Teacher t  in teachers)
                {
                    Console.WriteLine($""+t);
                }
            } 
        }
        static void Main(string[] args)
        {
            Add();
        }
 
        public class ApplicationContext : DbContext
        {
            public DbSet<Student> Students { get; set; } //навагационные свойства, через которые будет взаимодействие с дб
            public DbSet<Teacher> Teachers { get; set; }


            public ApplicationContext()
            {
                //Database.EnsureCreated();
            }
            public ApplicationContext(DbContextOptions<ApplicationContext> options)
                : base(options)
            {
                //Database.EnsureCreated();
            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {

                if (!optionsBuilder.IsConfigured)
                {
                    //string consting = ConfigurationManager.AppSettings["ConnectionString"];
                    //optionsBuilder.UseNpgsql(""+consting);
                    optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=exp;Username=postgres;Password=123");
                    optionsBuilder.EnableSensitiveDataLogging();
                    /*
                    Add-Migration Init - инициализация миграций
                    Remove-Migration
                    Update-Database - применение миграций
                    */

                }

            }
        }
    }
}
