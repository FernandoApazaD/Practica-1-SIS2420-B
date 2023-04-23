using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            do
            {
                Console.Write("Ingresar el numero a convertir:");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero en literal sera: \n\t" + Class1.literal(numero));
            } while (numero>=10000);
            Console.ReadKey();
        }
    }
}
