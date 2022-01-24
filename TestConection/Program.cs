using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ClassLibrary;
using System.Collections.Generic;


#nullable disable

namespace TestConection
{

    class Program
    {
        private static ApplicationContext db2 = Context.Db2;

        static void Main(string[] args)
        {
            /*
            List<Client> cl_sp = db2.Clients.ToList();
            Console.WriteLine("Список объектов:");
            //Client cl1 = new Client { Email = "1gagaga@mail.da", Family = "Пупкин", Name = "Вася" };
            //cl_sp.Add(cl1);
            //db.Clients.Add(cl1);
            //cl_sp[0].Name = "Y";
            foreach (Client c in cl_sp)
            {
                Console.WriteLine($"{c.Name}");
            }
            db2.SaveChanges();
            */

            //using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                
                Console.WriteLine("Введите логин:");
                string log = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string pasw = Console.ReadLine();
                EmployeeOfCompany employee = EmployeeOfCompany.GetEmployee(log, pasw);
                if (employee != null)
                {
                    Console.WriteLine($"Вы - " + employee.Name);
                }
                else Console.WriteLine($"Введен не правильный логин или пароль");
                
                /*
                List<ClientInfo> cl = Client.GetClientInfo("89091234567");
                Console.WriteLine(cl);
                    db.SaveChanges();
                }
                
                */

         
            }
            Console.ReadKey();
        }
    }

}
