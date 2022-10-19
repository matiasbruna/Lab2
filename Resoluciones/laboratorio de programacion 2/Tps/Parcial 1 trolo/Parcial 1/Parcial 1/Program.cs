using System;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {


            int intOpcion = 1;
            int intNumeroLegajo = 0;

            int intLegajoMayorPromedio = int.MinValue;
            int intLegajoMenorPromedio = int.MaxValue;

            float floatPromedio = 0;
            float floatPromedioMayor = float.MinValue;
            float floatPromedioMenor = float.MaxValue;

            int intSumaNota = 0;

            int intPrimerNota = 0;
            int intSegundaNota = 0;
            int intTercerNota = 0;


            int intContadorLegajos = 0;

            float floatSumaPromedios = 0;

            int intCantidadNotas = 3;


            //Console.WriteLine("\nIngrese 1 para cargar primer legajo, 0 para salir");
            //intOpcion = int.Parse(Console.ReadLine());


            while (intOpcion != 0)
            {
                Console.WriteLine("\nIngrese el numero de legajo");
                intNumeroLegajo = int.Parse(Console.ReadLine());


                intContadorLegajos++;


                Console.WriteLine("\nIngrese primer nota");
                intPrimerNota = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese segunda nota");
                intSegundaNota = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese tercer nota");
                intTercerNota = int.Parse(Console.ReadLine());

                intSumaNota = intPrimerNota + intSegundaNota + intTercerNota;
                floatPromedio = intSumaNota / (float)intCantidadNotas;

                floatSumaPromedios += floatPromedio;


                if (floatPromedio > floatPromedioMayor)
                {
                    floatPromedioMayor = floatPromedio;
                    intLegajoMayorPromedio = intNumeroLegajo;

                }

                if (floatPromedio < floatPromedioMenor)
                {
                    floatPromedioMenor = floatPromedio;
                    intLegajoMenorPromedio = intNumeroLegajo;

                }

                if (intContadorLegajos > 5)
                {
                    Console.WriteLine("\nIngrese 1 para cargar otro legajo, 0 para salir");
                    intOpcion = int.Parse(Console.ReadLine());
                }


            }


            Console.WriteLine($"\nEl legajo de Mayor promedio es {intLegajoMayorPromedio}");
            Console.WriteLine($"\nEl mayor promedio es {floatPromedioMayor}");


            Console.WriteLine($"\nEl legajo de Menor promedio es {intLegajoMenorPromedio}");
            Console.WriteLine($"\nEl menor promedio es {floatPromedioMenor}");

            Console.WriteLine($"\nLa cantidad de legajos cargados es {intContadorLegajos}");
            Console.WriteLine($"\nEl promedio del curso es {floatSumaPromedios / intContadorLegajos}");





            Console.WriteLine("\nPrograma finalizado, presione una tecla");
            Console.ReadKey();
        }
    }
}

