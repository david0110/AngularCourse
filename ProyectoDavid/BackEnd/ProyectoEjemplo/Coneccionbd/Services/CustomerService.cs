using Coneccionbd.Models;
using Npgsql.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coneccionbd.Services
{
    internal class CustomerService
    {
        public void ShowAll()
        {
            var db = new ReciplastkContext();
            var customerList = db.Customers.ToList(); // .ToList(); = consultar en la tabla
            Console.Write("| Id ");
            Console.Write("| Nit ");
            Console.Write("| Name ");
            Console.Write("| Last Name ");
            Console.Write("| Adress |");
            Console.WriteLine("");
            
            foreach (var item in customerList)
            {
                
                Console.WriteLine("");
                Console.Write("| " + item.Customerid + "  "); 
                Console.Write("| "+item.Nit + "  ");
                Console.Write("| "+item.Name + " ");
                Console.Write("| "+item.Lastname + " " );
                Console.Write("| "+item.Address + "| ");
                Console.WriteLine(" ");
            }

        }

        public void CreateCustomer()
        {
            var db = new ReciplastkContext();
            var model = new Customer();

            Console.WriteLine("");
            Console.Write("Escriba por favor estos datos:  ");
            Console.Write("| Nit ");
            Console.Write("| Name ");
            Console.Write("| Last Name ");
            Console.Write("| Adress |");
            Console.WriteLine("");
            do
            {
                Console.Write("Nit: ");
                model.Nit = Console.ReadLine();
                Console.Write("Name: ");
                model.Name = Console.ReadLine();
                Console.Write("Last Name: ");
                model.Lastname = Console.ReadLine();
                Console.Write("Adress: ");
                model.Address = Console.ReadLine();
            } while (model.Nit != "" || model.Name != "" || model.Lastname != "" || model.Address != "");
            db.Customers.Add(model);
            db.SaveChanges();
        }
        public void UpdateCustomer()
        {
            var db = new ReciplastkContext();

            Console.WriteLine("");
            Console.Write("Write the ID what you want update: ");
            var customerId = int.Parse(Console.ReadLine());
            var row = db.Customers.Where(x => x.Customerid == customerId).FirstOrDefault();
            Console.Write("Update Name: ");
            row.Name = Console.ReadLine();
            Console.Write("Update Last Name: ");
            row.Lastname = Console.ReadLine();
            db.SaveChanges();
            Console.WriteLine("");
        }
        public void DeleteCustomer()
        {
            var db = new ReciplastkContext();
            Console.WriteLine("");
            Console.Write("Write the ID what you want delete: ");
            var customerId = int.Parse(Console.ReadLine());
            var row = db.Customers.Where(x => x.Customerid == customerId).FirstOrDefault();
            db.Remove(row);
            db.SaveChanges();
            Console.WriteLine("");

        }
    }
}
