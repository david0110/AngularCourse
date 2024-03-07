using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DataAccess;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CosutumerInfoController : ControllerBase
    {
        CostumerInfoService customer = new CostumerInfoService();

        [HttpGet("CustomerList")]
        public List<Customer> CustomerList()
        {
            var customeList = customer.ShowAll();
            return customeList;
        }
        [HttpPost("CreateCustomer")]
        public String CreateCustomer(String Nit, String Name, String LastName, String Adress)
        {
            return customer.CreateCustomer(Nit,Name,LastName,Adress);
        }
        [HttpPost("UpdateCustomer")]
        public String UpdateCustomer(int Id,String Name)
        {
            return customer.UpdateCustomer(Id,Name);
        }
        [HttpDelete("DeleteCustomer")]
        public String DeleteCustomer(int IdDelete)
        {
            return customer.DeleteCustomer(IdDelete);
        }

        [HttpGet("Exist")]
       public Customer Exist(int Id)
        {
            return customer.Exist(Id);
        }
    }
}
