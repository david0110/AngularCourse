using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccess;

namespace WebApi.Services
{
    public class CostumerInfoService
    {
        ReciplastkContext db = new ReciplastkContext();

        public Customer Exist(int Id)
        {
            var row = db.Customers.Where(x => x.Customerid == Id).FirstOrDefault();
            return row;    
        }
        public List<Customer> ShowAll()
        {
           var customeList = db.Customers.ToList();
           return customeList;
        }
        public String CreateCustomer(String Nit, String Name, String LastName, String Adress)
        {
            var model = new Customer();
            model.Nit = Nit;
            model.Name = Name;
            model.Lastname = LastName;  
            model.Address = Adress;
            db.Customers.Add(model);
            db.SaveChanges();
            return "Informacion guardada exitosamente";
        }
        public String UpdateCustomer(int Id, String Name)
        {
            var customerId = Exist(Id);
            if (customerId != null)
            {
                customerId.Name = Name;
                db.SaveChanges();
                return "La informacion se actualizo correctamente";
            }
            else
            {
                return "La informacion NO se pudo actualizar";
            }
            
        }
        public String DeleteCustomer(int Id)
        {
            var exist = Exist(Id);
            if (exist != null)
            {
                db.Remove(exist);
                db.SaveChanges();
                return "Informacion se elimino exitosamente";
            }
            else
            {
                return "NO se encontro el Id enviado";
            }

        }
       
    }
}
