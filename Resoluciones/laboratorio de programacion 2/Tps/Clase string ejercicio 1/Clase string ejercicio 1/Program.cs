using System;

namespace Clase_string_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, contraseña;

            nombre = ingresocorrecto("Ingrese su nombre");
            apellido = ingresocorrecto("ingrese su apellido");

            Console.Clear();
            Console.WriteLine("ingrese la contraseña");
            contraseña = Console.ReadLine().ToUpper();
            Console.Clear();

            if (contraseña == "DEMO") Console.WriteLine(string.Format("acceso concedido a: {0}, {1}", nombre, apellido));
            else Console.WriteLine("no tiene permisos para acceder");

        }

        static string ingresocorrecto(string mensaje)
        {
            string texto_resultante;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                texto_resultante = Console.ReadLine().ToUpper();
            } while (texto_resultante == "");
            return texto_resultante;
        }
    }
}
