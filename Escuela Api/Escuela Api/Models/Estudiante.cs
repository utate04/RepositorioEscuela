using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Models
{
    public class Estudiante
    {
        public int idestudiante { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}
