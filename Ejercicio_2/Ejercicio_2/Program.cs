using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar la cantidad de elementos a mostrar:");
            int n=int.Parse(Console.ReadLine());
            Console.Write("\n\tSerie 1: ");
            Class1.serie1(n);
            Console.Write("\n\tSerie 2: ");
            Class1.serie2(n);
            Console.ReadKey();
        }
    }
}
