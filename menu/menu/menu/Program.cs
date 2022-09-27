using System;
using System.ComponentModel.Design;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int Opcion = 0;

            Opcion = Menu();

            Console.Clear();



            Console.WriteLine(Opcion);


        }
        static int Menu()
        {
            bool ingresoCorrecto;
            int seleccion;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Agregar");
                Console.WriteLine("2-Modificar");
                Console.WriteLine("3-Eliminar");
                Console.WriteLine("4-Listar elementos");
                Console.WriteLine("5-Reiniciar los valores");
                Console.WriteLine("6-Salir");
                ingresoCorrecto = int.TryParse(Console.ReadLine(), out seleccion);
            } while (ingresoCorrecto != true || seleccion > 6 || seleccion < 1);
            return seleccion;


        }
    }
}