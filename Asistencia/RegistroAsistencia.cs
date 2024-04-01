using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistencia
{
    internal class RegistroAsistencia
    {
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }

        public bool EstadoAsistencia { get; private set; }

        public RegistroAsistencia(DateTime fecha, string nombre)
        {

            Fecha = fecha;
            Nombre = nombre;
            EstadoAsistencia = false;

        }
        public void MarcarAsistencia()
        {

            EstadoAsistencia = true;

        }

        public string GenerarReporte()
        {
            return $"Nombre: {Nombre}, Fecha: {Fecha}, Asistencia: {(EstadoAsistencia ? "Asistió" : "Ausente")}";
        }


    }


}


    

