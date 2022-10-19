using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_string_ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool encontro = false;
            string[] nombres = { " JuAn", "JOse ", " ANA ", "  maria", "andreS  ", "LuCas " };
            string nombre_ingresado;
            int intentos = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("Intento {0}.\nIngrese un nombre", intentos + 1);
                nombre_ingresado = Console.ReadLine();
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombre_ingresado.Trim().ToUpper().Equals(nombres[i].Trim().ToUpper()))
                    {
                        Console.Clear();
                        Console.Write("Nombre correcto:\nMINUSCULAS: " + nombre_ingresado.ToLower() + "\nMAYUSCULAS: " + nombre_ingresado.ToUpper());
                        encontro = true;
                        intentos = nombres.Length;
                    }
                }
                intentos++;
            } while (intentos < 3 && encontro == false);

            if (encontro == false)
            {
                Console.Clear();
                Console.WriteLine("ha ingresado un nombre correcto 3 veces, el programa se autodestruira... LOL no...");
            }
            Console.ReadKey();
        }
    }
}
