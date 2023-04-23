using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal static class Class1
    {
        public static string literal(int num)
        {
            string[] vec_unidades = { "","cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve","diez" };
            string[] vec = { "once", "doce", "trece", "catorce", "quince", "dieciseis", "diecisiete", "dieciocho", "diecinueve" };
            
            string[] vec_decenas = {"veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa","cien" };
            string[] vec_centenas = { "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };
            
            string res = "";
            if (num <= 10)      return vec_unidades[num+1];
            if (num < 20)       return vec[num - 11];
            if (num < 30)       return "veinti" + vec_unidades[(num % 10) + 1];
            if (num<=100)
            {
                res = vec_decenas[(num / 10) - 2];
                if (num % 10 > 0) res += " y " + vec_unidades[(num % 10) + 1];
                return res;
            }
            if (num < 1000)     return vec_centenas[(num / 100) - 1] + " " + literal(num % 100);                
            if (num < 2000)     return " mil " + literal(num%1000);
            if (num < 10000)    return vec_unidades[(num/1000) + 1] + " mil " + literal(num % 1000);
            else 
                return "\n\tIngresar valores menores a 10000\n";
        }
    }
}
