using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //que le den a este ejercicio no me sale

            int[] numeros = new int[3];
            bool ingreso_es_vacio,ingreso_es_igual = false;
            int numero, resultado;

            for (int i = 0; i < 3; i++)
            {
                do
                {
                    Console.WriteLine("ingrese el {0} numero", i+1);
                    ingreso_es_vacio = int.TryParse(Console.ReadLine(), out numero);
                } while (!ingreso_es_vacio && !numeros.Contains(numero));
                numeros[i] = numero;
            }

            resultado = numeros[0] + numeros[1] + numeros[2];

            Console.Write("La suma de los numero ingresados es: " + resultado);
            Console.Read();
        }
    }
}
