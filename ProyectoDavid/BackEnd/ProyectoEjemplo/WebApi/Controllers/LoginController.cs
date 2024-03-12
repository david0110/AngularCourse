using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        LoginService loginInfo = new LoginService();

        [HttpGet("VerifyEmployee")]
        public bool VerifyEmployee(String UserName, String Password)
        {
            return loginInfo.VerifyEmployee(UserName, Password);
        }
        [HttpPost("CreateEmployeed")]
        public bool CreateEmployeed(String Name, String Lastname, String UserName, String Password)
        {
            return loginInfo.CreateEmployeed(Name, Lastname, UserName,Password);
        }
    }   
}
