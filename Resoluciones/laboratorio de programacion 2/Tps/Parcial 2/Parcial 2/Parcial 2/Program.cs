using System;
using System.Collections;

namespace Parcial_2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList lista_empresas = new SortedList();
            int eleccion = 0;

            do
            {
               eleccion = menu();
                switch (eleccion)
                {
                    case 1:
                        añadir(lista_empresas);
                        break;

                    case 2:
                        mostrar(lista_empresas);
                        break;

                    case 3:
                        buscar_nombre(lista_empresas);
                        break;

                    case 4:
                        buscar_cuit(lista_empresas);
                        break;

                    case 5:
                        eliminar_empresa(lista_empresas);
                        break;

                    case 6:
                        limpiar_lista(lista_empresas);
                        break;


                }
            } while (eleccion !=8);

            Console.ReadKey();
        }

        static int menu()
        {
            int opcion;
            bool ingresocorrecto = false;
            do
            {
                Console.Clear();
                Console.WriteLine("1-Agregar una empresa");
                Console.WriteLine("2-Listar empresas");
                Console.WriteLine("3-Buscar una empresa (Por nombre)");
                Console.WriteLine("4-Buscar una empresa (por CUIT)");
                Console.WriteLine("5-Eliminar una empresa de la lista");
                Console.WriteLine("6-Borrar la lista completa");
                Console.WriteLine("7-Cargar lista Demo");
                Console.WriteLine("8-salir");

                ingresocorrecto = int.TryParse(Console.ReadLine(), out opcion);
            } while (ingresocorrecto == false ||opcion > 8 || opcion < 1);
            return opcion;
        }

        static void añadir(SortedList Lista_empresas)
        {
            int cuit;
            string nombre, digitos;
            bool ingresocorrecto = false;

            do
            {
                Console.WriteLine("ingrese el CUIT/CUIL de la empresa:");
                
                ingresocorrecto = int.TryParse(Console.ReadLine(), out cuit);

                if (Lista_empresas.ContainsKey(cuit))
                {
                    Console.WriteLine("El cuit ingresado ya existe en la lista, por favor ingrese otro:");
                    ingresocorrecto = false;
                }

            } while (ingresocorrecto == false);


            do
            {
                Console.WriteLine("ingrese la razon social de la empresa");
                nombre = Console.ReadLine();
            } while (nombre == " ");

            Lista_empresas.Add(cuit, nombre);
            
        }

        static void mostrar(SortedList lista_empresas)
        {
            for (int i = 0; i <lista_empresas.Count; i++)
            {
                Console.WriteLine("Codigo: {0} -  CUIT/CUIL: {1} - Razon Social: {2}",i+1, lista_empresas.GetKey(i), lista_empresas.GetByIndex(i));
            }
            Console.ReadLine();
        }

        static void buscar_nombre(SortedList lista_empresas)
        {
            string texto, buscar;

            Console.WriteLine("Ingrese el texto inicial de alguna empresa");
            texto = Console.ReadLine();

            for (int i = 0; i < lista_empresas.Count; i++)
            {

                if (lista_empresas.GetByIndex(i).ToString().StartsWith(texto))
                {
                    Console.WriteLine("Codigo: {0} -  CUIT/CUIL: {1} - Razon Social: {2}", i + 1, lista_empresas.GetKey(i), lista_empresas.GetByIndex(i));
                }
                
            }
            Console.ReadLine();

        }

        static void buscar_cuit(SortedList lista_empresas)
        {
            int cuit;
            bool ingresocorrecto = false;
            do
            {
                Console.WriteLine("ingrese el CUIT/CUIL de la empresa que desea buscar:");

                ingresocorrecto = int.TryParse(Console.ReadLine(), out cuit);

            } while (ingresocorrecto == false);

            if (lista_empresas.ContainsKey(cuit))
            {
                Console.WriteLine("Codigo: {0} -  CUIT/CUIL: {1} - Razon Social: {2}", lista_empresas.IndexOfKey(cuit), cuit, lista_empresas[cuit]);
            }
            Console.ReadLine();
        }

        static void eliminar_empresa(SortedList lista_empresas)
        {
            int opcion, cuit, indice;
            Console.WriteLine("1- eliminar por CUIT/CUIL \n 2- eliminar por codigo");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("ingrese el CUIT/CUIL de la empresa a eliminar:");
                    cuit = int.Parse(Console.ReadLine());
                    lista_empresas.Remove(cuit);
                break;

                case 2:
                    Console.WriteLine("ingrese el codigo de la empresa a eliminar:");
                    indice = int.Parse(Console.ReadLine());
                    lista_empresas.RemoveAt(indice);
                break;
            }
            Console.ReadLine();
        }

        static void limpiar_lista(SortedList lista_empresas)
        {
            int opcion;
            Console.WriteLine("esta seguro de que desea limpiar la lista? 1-si 2-no");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                lista_empresas.Clear();
            }
            Console.ReadLine();
        }

    }
}
