using System;

namespace Clase_string_ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, apellido, mensaje;
            int dni;

            nombre = ingreso("ingrese su nombre");
            apellido = ingreso("ingrese su apellido");
            do
            {
                Console.Clear();
                Console.WriteLine("ingrese su DNI");
            } while (int.TryParse(Console.ReadLine(), out dni)==false);

            Console.Clear();
            mensaje = string.Concat("Nombre: ", nombre, "\nApellido: ", apellido, "\nDNI: ", dni);
            Console.WriteLine(mensaje);
        }

        static string ingreso (string mensaje)
        {
            string ingreso;
            do
            {
                Console.Clear();
                Console.WriteLine(mensaje);
                ingreso = Console.ReadLine();
            } while (ingreso == "");

            return ingreso;
        }
    }
}
