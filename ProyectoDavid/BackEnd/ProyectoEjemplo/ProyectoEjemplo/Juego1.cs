using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEjemplo
{
    public class Juego1
    {
        public int randomNum = new Random().Next(0, 100);
        public int UserNum;
        public int i;
        public void ExplicacionRecoleccion()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n");
            Console.WriteLine("El numero ganador estsara en modo aleatorio entre el 0 y el 100 ");
            Console.WriteLine("\n");
            Console.WriteLine("Escribir un numero para adivinar el numero ganador: ");
        }
        public void FrioCaliente()
        {
            for (i = 0; i < 10; i++)
            {
                UserNum = Convert.ToInt16(Console.ReadLine());
                if (UserNum == randomNum)
                {
                    Console.WriteLine("¡¡GANASTE!!");
                    break;
                }
                else if (UserNum > (randomNum + 10))
                {
                    Console.WriteLine("¡¡Frio!! Escriba un numero mas bajo ");

                }
                else if (UserNum < (randomNum - 10))
                {

                    Console.WriteLine("¡¡Frio!! Escriba un numero mas alto ");

                }
                else if (UserNum > (randomNum + 3) && UserNum <= (randomNum + 10))
                {
                    Console.WriteLine("¡¡Tibio!! Escriba un numero mas bajo ");

                }
                else if (UserNum < (randomNum - 3) && UserNum >= (randomNum - 10))
                {
                    Console.WriteLine("¡¡Tibio!! Escriba un numero mas alto ");

                }
                else if (UserNum >= (randomNum + 1) && UserNum <= (randomNum + 3))
                {
                    Console.WriteLine("¡¡Caliente!! Escriba un numero mas bajo ");

                }
                else if (UserNum <= (randomNum - 1) && UserNum >= (randomNum - 3))
                {
                    Console.WriteLine("¡¡Caliente!! Escriba un numero mas alto ");
                }
            }
            if (i == 10)
            {
                Console.WriteLine("¡¡PERDISTE!!");
            }
        }
    }
}
