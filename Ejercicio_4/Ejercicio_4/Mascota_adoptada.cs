using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Mascota_adoptada : Mascota
    {
        public string Nombre_dueño { get; set; }
        public decimal Pago_mascota { get; set; }
        public DateTime Fecha_adopcion { get; set; }

        public override string Mostrar_Mascota() 
        {
            return $"Nombre: {Nombre_mascota} | Edad: {Edad} | Raza: {Raza} | Sexo: |{Sexo} \nNombre dueño: {Nombre_dueño} | Pago Mascota: {Pago_mascota} | Fecha de Adopcion: {Fecha_adopcion.ToString("dd/mm/yy")}";
        }
    }
}
