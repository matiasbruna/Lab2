using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_stringbuiilder_ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mensaje = { "Lógicamente ", "ahora ", "lo ", "urgente ", "es ", "esperar" };
            StringBuilder mensaje_armado = new StringBuilder();

            for (int i = 0; i < mensaje.Length; i++)
            {
                mensaje_armado.Insert(mensaje_armado.Length, mensaje[i]);
                Console.WriteLine(mensaje_armado);
            }
            Console.Read();
        }
    }
}
