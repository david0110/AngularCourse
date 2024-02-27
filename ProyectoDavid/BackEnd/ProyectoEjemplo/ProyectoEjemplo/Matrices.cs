using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEjemplo
{
    public class Matrices
    {
        // Estructuras de datos...
        // Array
        // Lista
        // [1,4,95,66]
        // ["Pedro","david"]
        // [true,false, true]
        // [
        //  [1,2,3],
        //  [3],
        //  [-1,-4]
        //]
        string[] denomincaciones = new string[6] { "5000", "10000", "20000", "50000","100000","500"};
        public void Prueba()
        {
            int[] contadoresDenominaciones = new int[denomincaciones.Length];
            for (int i = 0; i < denomincaciones.Length; i++)
            {
                contadoresDenominaciones[i]++;
            }

            int[][] numeros = new int[3][]; // Array de arrays int
            numeros[0] = new int[3];

            numeros[0][0] = 1;
            numeros[0][1] = 2;
            numeros[0][2] = 3;

            numeros[1] = new int[1];
            numeros[1][0] = 3;
            //numeros[0][1] = 1; // error

            numeros[2] = new int[2];
            numeros[2][0] = -1;
            numeros[2][1] = -3;

            for (int indiceFila = 0; indiceFila < numeros.Length; indiceFila++)
            {
                for (int indiceColumna = 0; indiceColumna < numeros[indiceFila].Length; indiceColumna++)
                {
                    Console.WriteLine($"[{indiceFila}][{indiceColumna}] = {numeros[indiceFila][indiceColumna]}");
                }
            }

            // Matriz 
            // numeros [
            //  2,4,8,10
            //  1,3,5,7,9
            //  -1,-2,-3,-4
            //] // 2 Dim

            int[,] numerosMatriz = new int[3, 4]; // new DataType[numRows, numColumns]

            numerosMatriz[0, 0] = 2;
            numerosMatriz[0, 1] = 4;
            numerosMatriz[0, 2] = 8;
            numerosMatriz[0, 3] = 10;
            numerosMatriz[1, 0] = 1;
            numerosMatriz[1, 1] = 3;
            numerosMatriz[1, 2] = 5;
            numerosMatriz[1, 3] = 7;
            numerosMatriz[2, 0] = -1;
            numerosMatriz[2, 1] = -2;
            numerosMatriz[2, 2] = -3;
            numerosMatriz[2, 3] = -4;

            for (int indiceFila = 0; indiceFila < numerosMatriz.GetLength(0); indiceFila++)
            {
                for (int indiceColumna = 0; indiceColumna < numerosMatriz.GetLength(1); indiceColumna++)
                {
                    Console.WriteLine($"[{indiceFila}][{indiceColumna}] = {numerosMatriz[indiceFila, indiceColumna]}");
                }
            }

            // Dictionary: It is organized based on key instead of indexes
            /// cantidadAmigos = 
            /// {
            /// "casa": 1,
            /// "trabajo": 3,
            /// "barrio": 12
            /// }
            ///
            /// bd = 
            /// {
            /// "1152212727": "Pedro",
            /// "1017238424": "Maria",
            /// "1018230810": "David"
            /// }
            /// 
            /// mayoresEdad = {
            ///     true: 17,
            ///     false: 22
            /// }
            /// 
            /// casas = 
            /// {
            /// "cra 72 b": ["Pedro","Andrea"],
            /// "Manizales": ["Ale","Weimar","David"],
            /// "1018230810": "David"
            /// }
            /// 
            /// 


            Dictionary<string,int> dicAmigos = new Dictionary<string,int>(); // Dictionary<keyType, valueType> varName = new  Dictionary<keyType, valueType>();
            // IF the key does not exists, the dictionary creates a new entry
            dicAmigos["casa"] = 1;
            dicAmigos["trabajo"] = 2;
            dicAmigos["barrio"] = 1;

            // IF the key exists, the dictionary updates the existing entry

            dicAmigos["casa"] = 6;

            Dictionary<string, string> bd = new Dictionary<string, string>(); // Dictionary<keyType, valueType> varName = new  Dictionary<keyType, valueType>();
            bd["1017238242"] = "maria";
           
            Dictionary<bool, int> edades = new Dictionary<bool, int>(); // Dictionary<keyType, valueType> varName = new  Dictionary<keyType, valueType>();
            edades[true] = 1;
            edades[false] = 7;

            // How to iterate over the dictionaries.
            foreach (var item in dicAmigos)
            {
                Console.WriteLine($"The key {item.Key} and the value; {item.Value}");
            }
            //Diference between a normal algorithm vs using data structures.
            //De 15 personasm, Contar cuantas personas hay de cada edad. desde los 1 a los 6 años
            var cont1 = 0;
            var cont2 = 0;
            var cont3 = 0;
            var cont4 = 0;
            var cont5 = 0;
            var cont6 = 0;
            var edad = 0;
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona " + i);
                 edad = Convert.ToUInt16( Console.ReadLine());
                if(edad == 1)
                {
                    cont1++;
                }
                else if(edad == 2)
                {
                    cont2++;
                }
                else if (edad == 3)
                {
                    cont3++;
                }
                else if (edad == 4)
                {
                    cont4++;
                }
                else if (edad == 5)
                {
                    cont5++;
                }
                else if (edad == 6)
                {
                    cont6++;
                }
            }
            Console.WriteLine($"Hay {cont1} de 1 años");
            Console.WriteLine($"Hay {cont2} de 2 años");
            Console.WriteLine($"Hay {cont3} de 3 años");
            Console.WriteLine($"Hay {cont4} de 4 años");
            Console.WriteLine($"Hay {cont5} de 5 años");
            Console.WriteLine($"Hay {cont6} de 6 años");


            Dictionary<int, int> edades2 = new Dictionary<int, int>();
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona " + i);
                edad = Convert.ToUInt16(Console.ReadLine());
                if(edad> 5) {
                    Console.WriteLine("La edad solo puede ser de 0 a 6");
                }
                edades2[edad]++;
            }

            foreach (var item in edades2)
            {
                Console.WriteLine($"Hay {item.Value} {item.Key} de edad");
            }


        }
    }
}
