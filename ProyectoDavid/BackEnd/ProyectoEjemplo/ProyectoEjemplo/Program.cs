// See https://aka.ms/new-console-template for more information
using ProyectoEjemplo;
var juego1 = new Juego1();
var juego2 = new Juego2();
var juego3 = new Juego3();



var jugar = "y";
var eleccion = 0;

Console.WriteLine("Juego 1 \nConsiste en escribir un numero aleatorio para \npoder saber si el numero ganador esta mas arriba \no mas abajo del numero que escogiste.");
Console.WriteLine("\n");
Console.WriteLine("Juego 2 \nPartisiparan dos jugadores donde cada uno tendra \nque escoger entre Pierda, Papel y Tijera y se \nmostrara en pnatalla el ganadoer de la ronada y \nal final de la partida.");
Console.WriteLine("\n");
Console.WriteLine("Juego 3 \nPartisiparan dos jugadores donde cada uno tendra \nun turno y debera marcar la letra que le toco en una casilla.");
Console.WriteLine("\n");
while (jugar=="y")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Escribe 1 para jugar 'Adivina el numero'. \nEscribe el nuemro 2 para jugar Piedra, Papel y Tijera. \nEscribe 3 parea jugar Tricky.");
    eleccion = Convert.ToInt16(Console.ReadLine());
    if (eleccion == 1)
    {
        juego1.ExplicacionRecoleccion();
        juego1.FrioCaliente();
    }
    else if (eleccion == 2)
    {
        juego2.PPT();
    }
    else if (eleccion == 3)
    {
        juego3.IniciarJuego();
        juego3.MostrarJuego();
        juego3.PedirDatosUsuario();
    } else
    {
        Console.WriteLine("El numero de juego que ha ingresado es incorrecto");
    }
    Console.WriteLine("¡¡Hola!! ¿Quieres volver a jugar? (yes/no) = y/n");
    jugar = Convert.ToString(Console.ReadLine().ToLower());
}







