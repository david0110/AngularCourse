using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEjemplo
{
    internal class Juego3
    {

        public String[,] Matris = new string[3, 3];
        

        public void IniciarJuego()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("");
            Console.WriteLine("El juego se juega en un tablero de 3x3, donde cada celda puede estar vacía, contener una \"X\" o contener una \"O\".");
            Console.WriteLine("Elija su turno y marque con la letra que le toco");
            Console.WriteLine("");
            Console.WriteLine("  1   2   3 ");
            Console.WriteLine("1   |   |   ");
            Console.WriteLine(" --- --- ---");
            Console.WriteLine("2   |   |   ");
            Console.WriteLine(" --- --- ---");
            Console.WriteLine("3   |   |   ");
            Console.WriteLine("");

        }
        public void MostrarJuego()
        {
            for (int i = 0; i < Matris.GetLength(0); i++)
            {
                for (int j = 0; j < Matris.GetLength(1); j++)
                {
                    Console.Write($"| {Matris[i, j]} |");
                    Console.Write("  ---  ---  ---");
                }
                Console.WriteLine();
            }
        }
        public void PedirDatosUsuario()
        {
            

            for (int i = 0; i < 9; i++)
            {
                var posicionXjugador1 = 0;
                var posicionYjugador1 = 0;
                bool LETTER = true; 
                var cont = 0;
                do
                {
                    if (cont > 0)
                    {
                        Console.WriteLine("Casilla no validad, repite tu posicion");
                    }
                    i++;
                    Console.Write("\n");
                    Console.WriteLine("Jugador 1 = X ");
                    Console.WriteLine("Jugador 1: Escriba el numero de la fila: ");
                    var j1numero1 = int.TryParse(Console.ReadLine(), out posicionXjugador1);
                    posicionXjugador1 -= 1;
                    Console.WriteLine("");
                    Console.WriteLine("Jugador 1: Escriba y el numero de la columna: ");
                    var j1numero2 = int.TryParse(Console.ReadLine(), out posicionYjugador1);
                    posicionYjugador1 -= 1;
                    cont++;
                    ValidacionesUsuarios(LETTER);
                } while (Matris[posicionXjugador1, posicionYjugador1] != null ); // repite mientras esta lleno
                Matris[posicionXjugador1, posicionYjugador1] = "X";
                cont = 0;

                int posicionXjugador2 = 0;
                int posicionYjugador2 = 0;
                do
                {
                    LETTER = false;
                    if (cont > 0)
                    {
                        Console.WriteLine("Casilla no validad, repite tu posicion");
                    }
                    i++;
                    Console.WriteLine("Jugador 2 = O ");
                    Console.WriteLine("Jugador 2: Escriba el numero de la fila: ");
                    var j2numero1 = int.TryParse(Console.ReadLine(), out posicionXjugador2);
                    posicionXjugador2 -= 1;
                    Console.WriteLine("");
                    Console.WriteLine("Jugador 2: Escriba y el numero de la columna: ");
                    var j2numero2 = int.TryParse(Console.ReadLine(), out posicionYjugador2);
                    posicionYjugador2 -= 1;
                    cont++;
                } while (Matris[posicionXjugador2, posicionYjugador2] != null);
                Matris[posicionXjugador2, posicionYjugador2] = "O";
            }
        }
        public bool ValidacionesUsuarios(bool LETTER)
        {
            ////if (Matris[0, 0] == Matris[0, 1] && Matris[0, 1] == Matris[0, 2] && LETTER == true) {
            ////    return true;
            ////}else if (Matris[1, 0] == Matris[1, 1] && Matris[1, 1] == Matris[1] && LETTER == true) {
            ////    return true;
            ////}else if (Matris[2, 0] == Matris[2, 1] && Matris[2, 1] == Matris[2] && LETTER == true) {
            ////    return true;
            ////}else if (Matris[0, 0] == Matris[1, 0] && Matris[1, 0] == Matris[2] && LETTER == true) {
            ////    return true;
            ////}else if (Matris[0, 1] == Matris[1, 1] && Matris[1, 1] == Matris[2] && LETTER == true) {
            ////    return true;
            ////} else if (Matris[0, 2] == Matris[1, 2] && Matris[1, 2] == Matris[2] && LETTER == true) {
            ////    return true;
            ////} else if (Matris[0, 0] == Matris[1, 1] && Matris[1, 1] == Matris[2] && LETTER == true) {
            ////    return true;
            ////} else if (Matris[0, 2] == Matris[1, 1] && Matris[1, 1] == Matris[2, 0] && LETTER == true) {
            ////    return true;
            ////}                             control k c  
            ////else         descomentar      control k u
            ///               organizar       control k d
            ////{
            return false;   
            ////}        
        }
    }    
}   
