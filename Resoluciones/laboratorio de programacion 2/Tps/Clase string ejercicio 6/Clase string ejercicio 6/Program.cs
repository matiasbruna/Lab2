using System;

namespace Clase_string_ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encontro = false;
            int indice = -1;
            string[] nombres = { "Juan", "Jose", "Andres", "Ana", "Silvana", "Romina" };
            string clavenueva, nombreIngresado = "";

            Console.Write("Ingrese nombre: ");
            nombreIngresado = Console.ReadLine();
            do
            {
                indice++;
                if (nombres[indice] == nombreIngresado)
                {
                    Console.Write("Ingrese una nueva clave de seguridad: ");
                    clavenueva = Console.ReadLine();
                    string caracteres = "-.";
                    string numeros = "0123456789";

                    clavenueva = clavenueva.Trim();
                    clavenueva = clavenueva.TrimStart(caracteres.ToCharArray());
                    clavenueva = clavenueva.TrimEnd(numeros.ToCharArray());
                    Console.Write("Clave de seguridad: " + clavenueva);

                    encontro = true;
                    indice = nombres.Length;
                }
            } while (nombres.Length - 1 > indice);

            if (!encontro) Console.Write("Nombre incorrecto.");
            Console.Read();
        }
    }
}
