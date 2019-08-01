using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Api.Models
{
    public class Calificacion
    {

        public int idcalificacion { get; set; }
        public int puntaje { get; set; }
        public Estudiante estudiante { get; set; }
        public Materia materia { get; set; }
    }
}
