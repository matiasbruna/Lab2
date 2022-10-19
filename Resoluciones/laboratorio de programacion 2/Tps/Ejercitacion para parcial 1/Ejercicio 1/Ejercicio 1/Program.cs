using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char char1, char2;
            int numero1 = 0, numero2 = 0;

            char1 = carga("ingrese un caracter");
            char2 = carga("ingrese otro caracter");

            if (char.GetNumericValue(char1) > char.GetNumericValue(char2))
            {
                Console.WriteLine("El caracter {0} es mayor que el caracter {1}", char1, char2);
            }
            else
            {
                Console.WriteLine("El caracter {0} es mayor que el caracter {1}", char2, char1);
            }

            if(char.IsDigit(char1) || char.IsDigit(char2))
            {
                numero1 = char1;
                numero2 = char2;

                if ((numero1 % 2) == 0 && char.IsDigit(char1))
                {
                    Console.WriteLine("El caracter {0} es un numero par", char1);
                }
                if ((numero2 % 2) == 0 && char.IsDigit(char2))
                {
                    Console.WriteLine("El caracter {0} es un numero par", char2);
                }
            }
            else
            {
                Console.WriteLine("Ningun digito ingresado es un numero par");
            }

            Console.WriteLine("El caracter {0} es del tipo: {1}", char1, char.GetUnicodeCategory(char1));
            Console.WriteLine("El caracter {0} es del tipo: {1}", char2, char.GetUnicodeCategory(char2));

            Console.Read();
        }

        static char carga (string mensaje)
        {
            char ingreso;
            bool ingreso_no_vacio;
            do
            {
                Console.WriteLine(mensaje);
                ingreso_no_vacio = char.TryParse(Console.ReadLine(), out ingreso);
                Console.Clear();
            } while (!ingreso_no_vacio);
            return ingreso;
        }
    }
}
