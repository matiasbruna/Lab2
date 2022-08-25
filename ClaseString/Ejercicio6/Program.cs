using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {

           string [,] Usuarios = new string [6,2];   //matriz para guardar los usiarios y las paswords.

            Usuarios[0,0 ] = "Juan";
            Usuarios[1,0 ] = "Jose";
            Usuarios[2,0 ] = "Andres";
            Usuarios[3,0 ] = "Ana";
            Usuarios[4,0 ] = "Silvana";
            Usuarios[5,0 ] = "Romina";
           
            Console.WriteLine(Usuarios[2,0]);

        }

        static void Preguntar(string [,] U)
        {
            string Usuario = "";
        Console.WriteLine("Ingrese un Usuario: ");
        
        Usuario = Console.ReadLine();

        }
    }
}