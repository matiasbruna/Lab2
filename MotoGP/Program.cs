
using System;

namespace MotoGP
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           Console.Clear();


           double [] Piloto = CargarDatos();

            //Console.Clear();

           // TiempoRapidoLento(Piloto);




        }

        static double [] CargarDatos ()
        {
            int vueltas  = 0;
            Console.Write("MotoGp....Ingrese la Cantidad de Vueltas: ");
            vueltas = int.Parse(Console.ReadLine());
            
            double [] tiempoVueltas= new double[vueltas];
        
            Console.Clear();

            for (int i = 0; i < tiempoVueltas.Length; i++)
            {
                Console.Write($"Tiempo de la vuelta numero {i+1}: ");
                tiempoVueltas[i] = double.Parse(Console.ReadLine());
                Console.Write("\n");    
            }
            
            return tiempoVueltas;
        }
      /*   static void TiempoRapidoLento (double[] P)
        {

           double MejorTiempo = P[0];
           double MenorTiempo = P[0];

           for (int i = 0; i < P.Length; i++)
           {
               if (P[i] >= MejorTiempo[i]) {
                   MejorTiempo = P[i];
               }

               if (P[i] <= MenorTiempo[i]){
                   MenorTiempo = P[i]; 
               }
           }     

           Console.WriteLine($"El Mejor tiempo es: {MejorTiempo}.");
            Console.WriteLine($"El menor tiempo es: {MenorTiempo}.");

        } */


    }
}