using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace ClaseChar
{
    class Program
    {
        static void Main(string[] args)
        {

            char Salida = '0';

          
                char caracter1 = '3';
                char caracter2 = '3';

                Console.Write("Ingrese el Primer Caracter: ");
                caracter1 = char.Parse(Console.ReadLine());

                Console.Write("Ingrese el Segundo Caracter: ");
                caracter2 = char.Parse(Console.ReadLine());


                Console.WriteLine("Los dos caracteres son: " + caracter1.Equals(caracter2));

                int resultado = caracter1.CompareTo(caracter2);
                if (resultado > 0)
                {
                    Console.WriteLine("El Caracter 2 es mayor");

                }
                else
                {
                    Console.WriteLine("El Caracter 2 es Menor");
                }
                Console.WriteLine("Ingrese N para salir.. sino repite.");


                Console.WriteLine(char.GetUnicodeCategory(caracter1));
                Console.WriteLine(char.GetUnicodeCategory(caracter2));

                Console.ReadKey();


              
           



        }
    }
}
