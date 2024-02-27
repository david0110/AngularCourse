using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEjemplo
{
    internal class Juego2
    {
        public string eleccionJugador1 = "";
        public string eleccionJugador2 = "";
        public int contJugador1 = 0;
        public int contJugador2 = 0;
        public void PPT()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Dictionary<string, int> JugadoresPartidas = new Dictionary<string, int>();
            for (int i = 1; contJugador1 < 2 && contJugador2 < 2; i++)
            {
                Console.WriteLine("Jugador 1 \nEscriba Piedra, Papel o Tijera ");
                eleccionJugador1 = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
                Console.WriteLine("Jugador 2 \nEscriba Piedra, Papel o Tijera ");
                eleccionJugador2 = Console.ReadLine().ToLower(); ;

                if (eleccionJugador1 == "papel" && eleccionJugador2 == "piedra" ||
                    eleccionJugador1 == "piedra" && eleccionJugador2 == "tijera" ||
                    eleccionJugador1 == "tijera" && eleccionJugador2 == "papel")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jugador 1 gana la ronda " + i);
                    contJugador1 += 1;
                    JugadoresPartidas["Jugador 1"] = contJugador1;
                    Console.WriteLine("\n");
                }
                else if (eleccionJugador1 == "papel" && eleccionJugador2 == "papel" ||
                    eleccionJugador1 == "piedra" && eleccionJugador2 == "piedra" ||
                    eleccionJugador1 == "tijera" && eleccionJugador2 == "tijera")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Empate en la ronda  " + i);
                    Console.WriteLine("\n");

                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Jugador 2 gana la ronda  " + i);
                    contJugador2 += 1;
                    JugadoresPartidas["Jugador 2"] = contJugador2;
                    Console.WriteLine("\n");
                }
            }
            if (contJugador1 > contJugador2)
            {
                Console.WriteLine("Jugador 1 gana la partida ");
            } else
            {
                Console.WriteLine("Jugador 2 gana la partida ");
            }

            foreach (var item in JugadoresPartidas)
            {
                Console.WriteLine($"El {item.Key} gano {item.Value} veces");
            }
            contJugador1 = 0;
            contJugador2 = 0;

        }
    }
}
