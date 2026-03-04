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

                        break;
                        case 2:
                        break;
                        case 3:
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
