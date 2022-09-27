using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12  //programa de facturacion !
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Factura f = new Factura();

            f.CargarNombre("nacho");


            Console.WriteLine(f.leernombre());

            Console.ReadKey();



        }
    }
}
