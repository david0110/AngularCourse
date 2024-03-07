using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
// Servicio de prueba que se llame calculadora, 2 metodos, suma y resta, invocar 2 metodos en el servicio
namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebaDavidController : ControllerBase
    {
        CalculadoraService calculadora = new CalculadoraService();

        [HttpPost("Sumar")]
        public int Sumar(int num1, int num2)
        {
            int resultSuma = calculadora.sumar(num1,num2);
            return resultSuma;
        }
        [HttpPost("Restar")]
        public int Restar(int numero1, int numero2)
        {
            int resultResta = calculadora.resta(numero1, numero2);
            return resultResta;   
        }
        [HttpPost("Multiplicar")]
        public int Multiplicar(int num1, int num2)
        {
            int resultadoMult = calculadora.mult(num1, num2);
            return resultadoMult;
        }
        [HttpPost("Dividir")]
        public double Dividir(double num1, double num2)
        {
            double resultadoDiv = calculadora.divicion(num1,num2);
            return resultadoDiv;
        }

    }
}
