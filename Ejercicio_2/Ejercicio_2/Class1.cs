using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal static class Class1
    {
        public static void serie1(int n) 
        {
            int elemento = 1;
            for (int i = 1; i <= n; i++) 
            {
                elemento*= i;
                Console.Write(elemento + "  ");
            }
        }
        public static void serie2(int n) 
        {
            for(int i = 1; i <= n;i++)
                Console.Write(Math.Pow(2,i) + "  ");
        }
    }
}
