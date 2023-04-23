using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota
    {
        public string Nombre_mascota { get; set; }
        public int Edad { get; set; }
        public string Raza { get; set; }
        public string Sexo { get; set; }

        public virtual string Mostrar_Mascota()
        {
            return $"Nombre: {Nombre_mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: {Sexo}";
        }
    }
}
