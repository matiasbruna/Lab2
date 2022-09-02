using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9  //Ejercicio resuelto por la profe! 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { " JuAn", "JOse ", " ANA ", "  maria", "andreS  ", "LuCas " };

            bool encontro = false;
            int indice, intentos = 0;
            string nombreIngresado = "";

            do
            {

                Console.Write("intento nro: {0}\nIngrese nombre: ", intentos + 1);
                nombreIngresado = Console.ReadLine();

                // desde aqui comienza buscqueda en vector
                indice = -1;
                for (int ind = 0; ind < nombres.Length; ind++)
                {
                    if (nombreIngresado.Trim().ToLower().Equals(nombres[ind].Trim().ToLower()))
                    {
                        Console.Write("Nombre correcto:\nMINUSCULAS: " + nombreIngresado.ToLower() + "\nMAYUSCULAS: " + nombreIngresado.ToUpper());
                        Console.Read();

                        encontro = true;
                        ind = nombres.Length;
                    }
                }

                intentos++;

            } while (encontro == false && intentos < 3);


            if (!encontro) Console.Write("Nombres incorrectos en 3 intentos.");
            Console.Read();



        }
    }
}
