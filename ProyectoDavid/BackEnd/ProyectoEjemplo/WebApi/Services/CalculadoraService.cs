namespace WebApi.Services
{
    public class CalculadoraService
    {

        public int sumar(int num1, int num2)
        {
            int Result = num1 + num2;
            return Result;
        }
        public int resta(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        public int mult(int num1,int num2)
        {
            int result = num1 * num2;
            return  result; 
        }
        public double divicion(double num1, double num2)
        {
            double result = num1 / num2;
            return result;
        }

    }
}
