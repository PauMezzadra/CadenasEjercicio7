using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadenasEjercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine().ToUpper();
                if (nombre == "")
                {
                    Console.WriteLine("No puede quedar vacío");
                }
                else
                {
                    Console.WriteLine($"Hola {nombre}");
                }
            } while (nombre == "");

            Console.ReadKey();

        }
    }
}
