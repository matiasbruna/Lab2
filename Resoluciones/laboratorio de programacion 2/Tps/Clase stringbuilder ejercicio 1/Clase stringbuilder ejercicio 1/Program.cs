using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_stringbuilder_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mensaje = { "logicamente", "ahora", "lo", "urgente", "es", "esperar" };
            StringBuilder mensaje_armado = new StringBuilder();
            for(int i = 0; i < mensaje.Length; i++)
            {
                mensaje_armado.AppendFormat("{0} ", mensaje[i]);
                Console.WriteLine(mensaje_armado);
            }
            Console.Read();
        }
    }
}
