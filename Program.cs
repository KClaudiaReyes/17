using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary < int , string> inventario = new Dictionary < int , string>();
            int opcion = 0;

            do
            {
                Console.WriteLine(" ****Menu**** ");
                Console.WriteLine("1. Agregar ");
                Console.WriteLine("2. Eliminar ");
                Console.WriteLine("3. Mostrar ");
                opcion = int.Parse(Console.ReadLine());
                Console.Write(opcion);

                switch(opcion)
                {
                    case 1:  Console.WriteLine("1. Agregar ");
                        Console.WriteLine("ingrese el ID: ");
                        int Id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese producto: ");
                        string nombre = Console.ReadLine();
                        inventario.Add(Id, nombre);
                        
                        break;
                        case 2:   Console.WriteLine("2. Eliminar ");

                        Console.WriteLine(" ingrese el codigo a Eliminar ");
                        int cod = int.Parse(Console.ReadLine());
                        if (inventario.Remove(cod))
                        {
                            Console.WriteLine("PROUCTO ELIMINADO CORRECTAMENTE");
                        }
                        else
                        {
                            Console.WriteLine(" no EXISTE el ID ingresado");
                        }
                        break;
                        case 3: Console.WriteLine("3. Mostrar ");
                        
                        foreach (var item in inventario)
                        {
                            Console.WriteLine(item.Key + item.Value);
                        }
                        break;
                        case 4: Console.WriteLine(" SALIENDO...");
                        break;
                        case 5: default:Console.WriteLine("opcion invalida");
                        break;
                }

            }while (opcion!=0);


        }
    }
}
