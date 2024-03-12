using WebApi.DataAccess;

namespace WebApi.Services
{
    public class LoginService
    {
        ReciplastkContext db = new ReciplastkContext();
        public bool VerifyEmployee(String userName, String password)
        {
            var employeeInfo = db.Employees.Where(x => x.Username == userName && x.Password == password).FirstOrDefault();
            if (employeeInfo != null)
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        public bool CreateEmployeed(String Name, String Lastname, String UserName, String Password)
        {
            var model = new Employee();
            model.Roleid = 1;
            model.Name = Name;
            model.Lastname = Lastname;  
            model.Username = UserName;
            model.Password = Password;
            db.Employees.Add(model);
            db.SaveChanges();
            return true;
        }
    }
}