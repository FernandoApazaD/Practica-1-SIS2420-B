using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota_perdida : Mascota
    {
        public string Motivo { get; set; }
        public DateTime Fecha_perdida { get; set; }

        public override string Mostrar_Mascota()
        {
            return $"Nombre: {Nombre_mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: {Sexo} \n Motivo: {Motivo} | Fecha Perdida: {Fecha_perdida.ToString("dd/mm/yy")}";
        }
    }
}
