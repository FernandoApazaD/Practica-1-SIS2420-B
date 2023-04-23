using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Mascota_adoptada> listaMascotas = new List<Mascota_adoptada>();
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Benji",
                Edad = 4,
                Raza = "Pastor Aleman",
                Sexo = "Macho",
                Nombre_dueño = "Carlos",
                Pago_mascota = 120,
                Fecha_adopcion = DateTime.Parse("01/11/2018")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Baxter",
                Edad = 7,
                Raza = "Labrador",
                Sexo = "Macho",
                Nombre_dueño = "Pedro",
                Pago_mascota = 110,
                Fecha_adopcion = DateTime.Parse("24/06/2019")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Nessy",
                Edad = 2,
                Raza = "Chihuahua",
                Sexo = "Hembra",
                Nombre_dueño = "Maria",
                Pago_mascota = 150,
                Fecha_adopcion = DateTime.Parse("23/12/2020")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Pipo",
                Edad = 1,
                Raza = "bulldog",
                Sexo = "Macho",
                Nombre_dueño = "Carlos",
                Pago_mascota = 120,
                Fecha_adopcion = DateTime.Parse("15/08/2015")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Nicki",
                Edad = 7,
                Raza = "Chihuahua",
                Sexo = "Hembra",
                Nombre_dueño = "Martin",
                Pago_mascota = 130,
                Fecha_adopcion = DateTime.Parse("12/02/2019")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Dalton",
                Edad = 3,
                Raza = "Labrador",
                Sexo = "Macho",
                Nombre_dueño = "Mario",
                Pago_mascota = 100,
                Fecha_adopcion = DateTime.Parse("06/05/2021")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Toby",
                Edad = 1,
                Raza = "Golden Retriever",
                Sexo = "Macho",
                Nombre_dueño = "Simon",
                Pago_mascota = 90,
                Fecha_adopcion = DateTime.Parse("26/12/2021")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Sassy",
                Edad = 1,
                Raza = "Labrador",
                Sexo = "Hembra",
                Nombre_dueño = "Carla",
                Pago_mascota = 115,
                Fecha_adopcion = DateTime.Parse("17/08/2020")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Fido",
                Edad = 4,
                Raza = "Bulldog",
                Sexo = "Macho",
                Nombre_dueño = "Nelson",
                Pago_mascota = 120,
                Fecha_adopcion = DateTime.Parse("24/05/2018")
            });
            listaMascotas.Add(new Mascota_adoptada()
            {
                Nombre_mascota = "Laika",
                Edad = 9,
                Raza = "Pastor Aleman",
                Sexo = "Hembra",
                Nombre_dueño = "Nanci",
                Pago_mascota = 100,
                Fecha_adopcion = DateTime.Parse("19/03/2021")
            });
            Console.WriteLine("\t----Lista de Mascotas----");
            foreach (var item in listaMascotas)
                Console.WriteLine("\n" + item.Mostrar_Mascota());
            //promedio de edades
            double prom_Edades = Prom_Mascota(listaMascotas);
            Console.WriteLine("\nEl promedio de edades es: {0}" , prom_Edades.ToString("##.##"));
            
            //promedio de pagos
            double promedio_Pagos = Prom_Pago(listaMascotas);
            Console.WriteLine("El promedio de pagos es: {0}", promedio_Pagos.ToString("##.##"));
            
            //Las mascotas que son chihuahua y hembras
            Console.WriteLine("\n\t----Las mascotas que son chihuahua y hembras----");
            Raza_Chihuahua(listaMascotas);

            //Las mascotas menores a 2 años
            Console.WriteLine("\n\t----Las mascotas menores a 2 años----");
            Edad_Mascota(listaMascotas);
            Console.ReadKey();
        }

        private static void Edad_Mascota(List<Mascota_adoptada> listaMascotas)
        {
            var mostrar = from item in listaMascotas
                          where item.Edad < 2
                          select item;
            foreach (var item in mostrar)
                Console.WriteLine(item.Mostrar_Mascota() + "\n");
        }

        private static void Raza_Chihuahua(List<Mascota_adoptada> listaMascotas)
        {
            var mostrar = from item in listaMascotas
                          where item.Raza == "Chihuahua" && item.Sexo == "Hembra"
                          select item;
            foreach (var item in mostrar)
                Console.WriteLine(item.Mostrar_Mascota() + "\n");
        }

        private static double Prom_Pago(List<Mascota_adoptada> listaMascotas)
        {
            return (double)listaMascotas.Average(x => x.Pago_mascota);
        }

        private static double Prom_Mascota(List<Mascota_adoptada> listaMascotas)
        {
            return (double)listaMascotas.Average(x => x.Edad);
        }
    }
}   /*1 Prom_Mascota lambda promedio de edades
      2 Prom_Pago lambda promedio del pago
      3 Raza_Chihuahua linq mostrar las mascotas chihuahua y hembras
      4 Edad:Mascota utilizando linq mascotas menores a 2 años
     */
