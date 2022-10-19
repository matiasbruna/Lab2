using System;

namespace Resolucion_Parcial_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool boleano;
            int opcion;
            string parrafo = null;
            char[] delimitadores = new char[] {' ','.',','};
            int contadorPalabrasMenores = 0;
            int contadorPalabrasMayores = 0;
            int contadorPalabrasEnRango = 0;

            do
            {

            
            do
            {
                Console.WriteLine("1-Ingresar parrafo\n2-Mostrar info del parrafo\n0-Salir");
                boleano = int.TryParse(Console.ReadLine(), out opcion);
            } while (opcion != 1 && opcion != 2 && opcion !=0);

            if (opcion == 0)
            {
                System.Environment.Exit(-1);
            }

            if (opcion == 1)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("ingrese un parrafo");
                    parrafo = Console.ReadLine();

                    if (parrafo.Trim() == "")
                    {
                        Console.WriteLine("el parrafo no puede estar vacio, presione una tecla para continuar");
                        Console.ReadKey();
                    }

                    if (parrafo.Length < 30)
                    {
                        Console.WriteLine("el parrafo no puede contener menos de 30 letras, presione una tecla para continuar");
                        Console.ReadKey();                    
                    }
                } while (parrafo.Trim() == "" || parrafo.Length < 30);
                
            }

                if (opcion == 2)
                {
                    if (parrafo == null)
                    {
                        Console.WriteLine("no se ha ingresado ningun parrafo");
                    }
                    else
                    {
                        string[] vectorParrafoSplit = parrafo.Split(delimitadores);
                        Console.WriteLine(vectorParrafoSplit.Length);
                        Console.WriteLine("presione una tecla para continuar");
                        Console.ReadKey();

                        foreach (string item in vectorParrafoSplit)
                        {
                            if (item.Length < 6)
                            {
                                contadorPalabrasMenores++;
                            }

                            if (item.Length > 9)
                            {
                                contadorPalabrasMayores++;
                            }

                            if (item.Length >= 6 && item.Length <= 9)
                            {
                                contadorPalabrasEnRango++;
                            }
                        }

                        Console.WriteLine("menores a 6 caracteres: {0}\nmayores a 9 caracteres: {1}\n entre 6 y 9 caracteres: {2}", contadorPalabrasMenores, contadorPalabrasMayores, contadorPalabrasEnRango);
                        Console.WriteLine("pulse una tecla para continuar");
                        Console.ReadKey();
                        Console.Clear();
                        foreach (string item in vectorParrafoSplit)
                        {
                            Console.WriteLine(item.PadRight(1,';'));
                        }
                    }
                }

                Console.WriteLine("Desea continuar realizando acciones? 1.Si, 2.No");
                opcion = int.Parse(Console.ReadLine());
            } while (opcion == 1);


        }
    }
}
